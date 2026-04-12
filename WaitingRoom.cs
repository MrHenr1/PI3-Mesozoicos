using System;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class WaitingRoom : Form
    {
        public int idjogador { get; set; }
        public string idsenha { get; set; }
        public string idpartida { get; set; }

        private Timer pollTimer;
        private bool gameOpened = false;

        public WaitingRoom()
        {
            InitializeComponent();
            GameService.AplicarHeader(this, lblVersion, lblGrupo);

            pollTimer = new Timer();
            pollTimer.Interval = 3000; // verifica a cada 3 segundos
            pollTimer.Tick += PollTimer_Tick;
        }

        public void Atualizartela()
        {
            lblIdJogadorVal.Text = Convert.ToString(idjogador);
            lblSenhaVal.Text = Convert.ToString(idsenha);
            lblIdPartidaVal.Text = Convert.ToString(idpartida);

            pollTimer.Start();
            lblStatus.Text = "Aguardando inicio...";
        }

        private void PollTimer_Tick(object sender, EventArgs e)
        {
            // Se ja abriu o Game pra esse jogador, nao faz nada
            if (gameOpened) return;

            try
            {
                string[] gameInfo = GameService.GetGameStatus(this.idpartida);
                if (gameInfo == null || gameInfo.Length < 5) return;

                string status = gameInfo[0].Trim();

                if (status == "J" || status == "Jogando")
                {
                    // Para o timer ANTES de abrir pra garantir que nao dispara de novo
                    pollTimer.Stop();
                    gameOpened = true;

                    lblStatus.Text = "Partida iniciada!";
                    lblStatus.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);

                    AbrirTelaJogo(gameInfo[3], gameInfo[4]);
                }
            }
            catch { }
        }

        private void AbrirTelaJogo(string idPlayerDice, string diceFace)
        {
            Game game = new Game();
            game.idjogador = this.idjogador;
            game.idsenha = this.idsenha;
            game.idPlayerDiceSelected = idPlayerDice;
            game.diceSide = diceFace;
            game.idGame = this.idpartida;
            game.AtualizarTela();
            game.Show();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();
            try
            {
                var players = GameService.GetAllPlayers(this.idpartida);
                foreach (var player in players)
                {
                    string display = "ID: " + player[0] + "  |  " + player[1];
                    if (player.Length >= 3)
                        display += "  |  Pontos: " + player[2];
                    lstJogadores.Items.Add(display);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar jogadores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (gameOpened) return; // protecao extra

            string gameReturn = Jogo.Iniciar(this.idjogador, this.idsenha);

            if (gameReturn.StartsWith("ERRO"))
            {
                MessageBox.Show(gameReturn, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Para o timer e marca como aberto ANTES de criar o form
            pollTimer.Stop();
            gameOpened = true;

            string[] gamesInfos = gameReturn.Split(',');
            AbrirTelaJogo(gamesInfos[0], gamesInfos[1]);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pollTimer.Stop();
            pollTimer.Dispose();
            base.OnFormClosed(e);
        }
    }
}
