using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class Game : Form
    {
        public string idGame { get; set; }
        public int idjogador { get; set; }
        public string idsenha { get; set; }
        public string idPlayerDiceSelected { get; set; }
        public string diceSide { get; set; }
        public bool isBot { get; set; }

        private Timer pollTimer;
        private Random rng = new Random();

        public Game()
        {
            InitializeComponent();
            GameService.AplicarHeader(this, lblVersion, lblGrupo);

            CarregarCercados();

            pollTimer = new Timer();
            pollTimer.Interval = 3000;
            pollTimer.Tick += PollTimer_Tick;
        }

        private void CarregarCercados()
        {
            lstCercados.Items.Clear();
            try
            {
                var cercados = GameService.GetAllCercados();
                foreach (var cercado in cercados)
                {
                    string display = cercado[1];
                    if (cercado.Length >= 3)
                        display += " - " + cercado[2];
                    lstCercados.Items.Add(display);
                }
            }
            catch { }
        }

        public void AtualizarTela()
        {
            try
            {
                string[] gameInfo = GameService.GetGameStatus(idGame);
                if (gameInfo == null || gameInfo.Length < 5) return;

                string playerName = GameService.GetUsernameById(this.idGame, gameInfo[3]);
                lblJogadorDadoVal.Text = playerName ?? gameInfo[3];

                string diceSideName = GameService.GetDiceSideName(gameInfo[4]);
                lblDadoVal.Text = diceSideName ?? gameInfo[4];

                lblTurnoVal.Text = gameInfo[1];

                string myName = GameService.GetUsernameById(this.idGame, Convert.ToString(this.idjogador));
                lblPlayerVal.Text = (myName ?? Convert.ToString(this.idjogador)) + (isBot ? " [BOT]" : "");

                this.diceSide = gameInfo[4];

                AtualizarMao();
                AtualizarStatusTurno();
                AtualizarHistorico();

                pollTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarMao()
        {
            lstMao.Items.Clear();
            try
            {
                var mao = GameService.GetPlayerHand(this.idjogador, this.idsenha);
                foreach (var dino in mao)
                    lstMao.Items.Add(dino[1] + "  x" + dino[2]);
            }
            catch { }
        }

        private void AtualizarStatusTurno()
        {
            try
            {
                string turnInfo = GameService.GetTurnInfoRaw(int.Parse(idGame));
                if (string.IsNullOrEmpty(turnInfo)) return;

                string[] lines = GameService.ParseResponse(turnInfo);
                lstTurnoStatus.Items.Clear();

                if (lines.Length > 0)
                {
                    string[] header = lines[0].Split(',');
                    if (header.Length >= 1)
                        lstTurnoStatus.Items.Add("Status: " + header[0]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;
                    string[] jogada = lines[i].Split(',');
                    string pName = jogada.Length >= 1
                        ? GameService.GetUsernameById(idGame, jogada[0]) ?? jogada[0]
                        : lines[i];
                    lstTurnoStatus.Items.Add("  " + pName + " - jogou");
                }
            }
            catch { }
        }

        private void AtualizarHistorico()
        {
            try
            {
                string historico = GameService.GetHistory(int.Parse(idGame));
                if (string.IsNullOrEmpty(historico)) return;
                txtHistorico.Text = historico;
                txtHistorico.SelectionStart = txtHistorico.Text.Length;
                txtHistorico.ScrollToCaret();
            }
            catch { }
        }

        private void PollTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatusTurno();

                string[] gameInfo = GameService.GetGameStatus(idGame);
                if (gameInfo == null || gameInfo.Length < 5) return;

                if (gameInfo[0].Trim() == "E")
                {
                    pollTimer.Stop();
                    MostrarResultado();
                    return;
                }

                if (lblTurnoVal.Text != gameInfo[1])
                    AtualizarTela();

                if (isBot && gameInfo[0].Trim() == "J" && GameService.VerificarVez(idGame, idjogador))
                    ExecutarJogadaBot();
            }
            catch { }
        }

        private void MostrarResultado()
        {
            var resultado = new Resultado();
            resultado.idGame = this.idGame;
            resultado.idjogador = this.idjogador;
            resultado.Carregar();
            resultado.ShowDialog();
        }

        private void ExecutarJogadaBot()
        {
            try
            {
                var mao = GameService.GetPlayerHand(this.idjogador, this.idsenha);
                if (mao.Count == 0) return;

                string[] gameInfo = GameService.GetGameStatus(idGame);
                if (gameInfo == null || gameInfo.Length < 5) return;

                bool isOwnerDice = gameInfo[3] == Convert.ToString(idjogador);
                int turno = 1;
                int.TryParse(gameInfo[1], out turno);

                var allDinos = GameService.GetAllDinossauros();
                var myBoard = GameService.GetBoardState(idjogador, idsenha);

                List<string[]> opponentBoard = new List<string[]>();
                foreach (var p in GameService.GetAllPlayers(idGame))
                {
                    int pid;
                    if (int.TryParse(p[0], out pid) && pid != idjogador)
                    {
                        opponentBoard = GameService.BuildBoardFromTurns(int.Parse(idGame), pid);
                        break;
                    }
                }

                var myValidEnclosures = GameService.GetCercadosValidosParaDado(this.diceSide, isOwnerDice);
                var opponentValidEnclosures = GameService.GetCercadosValidosParaDado(this.diceSide, !isOwnerDice);

                if (this.diceSide == "VZ")
                {
                    myValidEnclosures.RemoveAll(c => c != "RI" && BotScoring.GetEnclosureCount(c, myBoard) > 0);
                    opponentValidEnclosures.RemoveAll(c => c != "RI" && BotScoring.GetEnclosureCount(c, opponentBoard) > 0);
                }
                else if (this.diceSide == "TI")
                {
                    myValidEnclosures.RemoveAll(c => BotScoring.EnclosureHasTRex(c, myBoard, allDinos));
                    opponentValidEnclosures.RemoveAll(c => BotScoring.EnclosureHasTRex(c, opponentBoard, allDinos));
                }

                if (!myValidEnclosures.Contains("RI")) myValidEnclosures.Add("RI");
                if (!opponentValidEnclosures.Contains("RI")) opponentValidEnclosures.Add("RI");

                string[] jogada = BotStrategy.EscolherJogada(
                    mao, myBoard, opponentBoard,
                    myValidEnclosures, opponentValidEnclosures,
                    allDinos, turno);

                string dinoCode = jogada != null ? jogada[0] : mao[rng.Next(mao.Count)][0];
                string cercadoCode = jogada != null ? jogada[1] : myValidEnclosures[rng.Next(myValidEnclosures.Count)];

                string gameReturn = Jogo.Jogar(idjogador, idsenha, dinoCode, cercadoCode);
                if (!gameReturn.StartsWith("ERRO"))
                    AtualizarTela();
            }
            catch { }
        }

        private void lstMao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMao.SelectedItem == null) return;
            string selected = lstMao.SelectedItem.ToString();
            txtDinossauro.Text = selected.Split(new string[] { "  x" }, StringSplitOptions.None)[0].Trim();
        }

        private void lstCercados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCercados.SelectedItem == null) return;
            txtCercado.Text = lstCercados.SelectedItem.ToString().Split('-')[0].Trim();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string dinossauroNome = txtDinossauro.Text.Trim();
            string cercadoNome = txtCercado.Text.Trim();

            if (string.IsNullOrEmpty(dinossauroNome) || string.IsNullOrEmpty(cercadoNome))
            {
                MessageBox.Show("Selecione um dinossauro e um cercado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cercadoCode = GameService.GetCercadoCode(cercadoNome);
            string dinoCode = GameService.GetDinossauroCode(dinossauroNome);

            if (cercadoCode == null || dinoCode == null)
            {
                MessageBox.Show("Dinossauro ou cercado inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] gameInfo = GameService.GetGameStatus(idGame);
            if (gameInfo != null && gameInfo.Length >= 4)
            {
                string ownerDice = gameInfo[3];
                if (ownerDice != Convert.ToString(idjogador))
                {
                    if (!GameService.IsValidPlay(cercadoCode, this.diceSide))
                    {
                        MessageBox.Show("Jogada inválida! O dado não permite colocar nesse cercado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            string gameReturn = Jogo.Jogar(idjogador, idsenha, dinoCode, cercadoCode);

            if (gameReturn.StartsWith("ERRO"))
            {
                MessageBox.Show(gameReturn, "Erro ao realizar a jogada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Jogada realizada! Próximo turno: " + gameReturn, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarTela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            Tabuleiro tabuleiroForm = new Tabuleiro();
            tabuleiroForm.idjogador = this.idjogador;
            tabuleiroForm.idsenha = this.idsenha;
            tabuleiroForm.idGame = this.idGame;
            tabuleiroForm.AtualizarTela();
            tabuleiroForm.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pollTimer.Stop();
            pollTimer.Dispose();
            base.OnFormClosed(e);
        }
    }
}
