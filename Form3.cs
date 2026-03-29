using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos {


    public partial class Form3 : Form {

        public string idGame { get; set; }
        public int idjogador { get; set; }
        public string idsenha { get; set; }

        public string idPlayerDiceSelected { get; set; }
        public string diceSide { get; set; }
        public string getUsernameById(string idJogo, string idPlayer)
        {


            string returnedList = Jogo.ListarJogadores(int.Parse(idJogo));
 

            returnedList = returnedList.Replace("\r", "");

            returnedList = returnedList.Substring(0, returnedList.Length - 1);

            string[] playerGames = returnedList.Split('\n');

            //string[] playerInfos = returned.Split(',');
            foreach (var player in playerGames)
            {
                string[] playerInfos = player.Split(',');
                if (playerInfos[0] == idPlayer) return playerInfos[1];
            }
            return null;

        }

        public string getDiceSide(string diceSideSorted)
        {
            string DiceSide = Jogo.ListarFacesDado();
            DiceSide = DiceSide.Replace("\r", "");

            DiceSide = DiceSide.Substring(0, DiceSide.Length - 1);

            string[] diceSides = DiceSide.Split('\n');
            foreach (var diceSide in diceSides)
            {
                string[] diceSidesInfos = diceSide.Split(',');
                if (diceSidesInfos[0] == diceSideSorted) return diceSidesInfos[1];
            }
            return null;

        }


        
        public void AtualizarTela() {
            string atualGame = Jogo.VerificarPartida(int.Parse(idGame));
            atualGame = atualGame.Substring(0, atualGame.Length - 2);
            string[] atualGameInfo = atualGame.Split(',');


            
            string playerName = getUsernameById(this.idGame, Convert.ToString(atualGameInfo[3]));
            lblPlayerDiceData.Text = playerName;
            string diceSideName = getDiceSide(atualGameInfo[4]);
            lblDiceData.Text = diceSideName;
            lblTurno.Text = atualGameInfo[1];

            lblActualPlayer.Text = getUsernameById(this.idGame, Convert.ToString(this.idjogador));
            lblPlayerId.Text = Convert.ToString(this.idjogador);
            lblpasswordId.Text = Convert.ToString(this.idsenha);



        }

        public Form3() {
            InitializeComponent();


            
        }

        private string getDinossauroCodeByName(string nameDinossauro) {
            string dinossaurosList = Jogo.ListarDinossauros(true);
            dinossaurosList = dinossaurosList.Replace("\r", "");
            dinossaurosList = dinossaurosList.Substring(0, dinossaurosList.Length - 1);
            string[] dinossauros = dinossaurosList.Split('\n');
            foreach (var dinossauro in dinossauros) {
                string[] dinossauroInfos = dinossauro.Split(',');
                if (dinossauroInfos[1] == nameDinossauro) return dinossauroInfos[0];
            }
            return null;
        }

        private string getCercadoCodeByName(string nameCercado) {
            string cercadosList = Jogo.ListarCercados();
            cercadosList = cercadosList.Replace("\r", "");
            cercadosList = cercadosList.Substring(0, cercadosList.Length - 1);
            string[] cercados = cercadosList.Split('\n');
            foreach (var cercado in cercados) {
                string[] cercadoInfos = cercado.Split(',');
                if (cercadoInfos[1] == nameCercado) return cercadoInfos[0];
            }
            return null;
        }

        private string getDinossauroName(string idDinossauro) {
            string dinossaurosList = Jogo.ListarDinossauros(true);
            dinossaurosList = dinossaurosList.Replace("\r", "");
            dinossaurosList = dinossaurosList.Substring(0, dinossaurosList.Length - 1);
            string[] dinossauros = dinossaurosList.Split('\n');
            foreach (var dinossauro in dinossauros) {
                string[] dinossauroInfos = dinossauro.Split(',');
                if (dinossauroInfos[0] == idDinossauro) return dinossauroInfos[1];
            }
            return null;
        }

        private string getCercadoName(string idCercado) {
            string cercadosList = Jogo.ListarCercados();
            cercadosList = cercadosList.Replace("\r", "");
            cercadosList = cercadosList.Substring(0, cercadosList.Length - 1);
            string[] cercados = cercadosList.Split('\n');
            foreach (var cercado in cercados) {
                string[] cercadoInfos = cercado.Split(',');
                if (cercadoInfos[0] == idCercado) return cercadoInfos[1];
            }
            return null;
        }

        private void btnExibeMao_Click(object sender, EventArgs e) {
            lstBoxExibeMao.Items.Clear();
            string returned = Jogo.ExibirMao(this.idjogador, this.idsenha);

            returned = returned.Replace("\r", "");

            string[] dinossauros = returned.Split('\n');




            for (int i = 1; i < dinossauros.Length - 1; i++) {
                string[] dinossaurosInfo = dinossauros[i].Split(',');
                string dinossauroName = getDinossauroName(dinossaurosInfo[0]);

                string dinossauroInfo = dinossauroName + "," + "Qnt: " + dinossaurosInfo[1];   

                lstBoxExibeMao.Items.Add(dinossauroInfo);
            }

        }

        private void btnUpdateScreen_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void btnExibeCercados_Click(object sender, EventArgs e) {

            lstBoxCercados.Items.Clear();
            string returned = Jogo.ListarCercados();

            returned = returned.Replace("\r", "");

            returned = returned.Substring(0, returned.Length - 1);

            string[] cercados = returned.Split('\n');

            foreach (var cercado in cercados) {
                string[] CercadosInfos = cercado.Split(',');
                lstBoxCercados.Items.Add(CercadosInfos[1]);
            }
            return;
        }

        private void btnLancaJogada_Click(object sender, EventArgs e) {
            string dinossauroJoga = txtBoxDinossauros.Text;
            string cercadoJoga = txtBoxCercado.Text;

            cercadoJoga = getCercadoCodeByName(cercadoJoga);
            dinossauroJoga = getDinossauroCodeByName(dinossauroJoga);

            string atualGame = Jogo.VerificarPartida(int.Parse(idGame));
            atualGame = atualGame.Substring(0, atualGame.Length - 2);
            string[] atualGameInfo = atualGame.Split(',');
            string onwerDice = atualGameInfo[3];

            if (!(onwerDice == Convert.ToString(idjogador)))
            {
                bool isValidPlay = this.isValidPlay(dinossauroJoga, cercadoJoga, this.diceSide);

                if (!isValidPlay)
                {
                    MessageBox.Show("Jogada inválida! O dinossauro selecionado não pode ser jogado nesse cercado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

           


            string gameReturn = Jogo.Jogar(idjogador,idsenha,dinossauroJoga,cercadoJoga);



            lblResulta.Text = gameReturn;
            if (gameReturn.StartsWith("ERRO")) {
                MessageBox.Show(gameReturn, "Erro ao realizar a jogada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        public static class CercadosDadoValido { 
            public static readonly Dictionary<string, List<string>> Mapa = new Dictionary<string, List<string>>()
            {
                {"FI", new List<string>(){"FL", "AL", "VZ", "TI" }},
                {"MT", new List<string>(){"FL", "AL", "VZ", "TI" }},
                {"RS", new List<string>(){"FL", "WC", "VZ", "TI" }},
                {"CD", new List<string>(){"PR", "WC", "VZ", "TI" }},
                {"PA", new List<string>(){"PR", "AL", "VZ", "TI" }},
                {"IS", new List<string>(){"PR", "WC", "VZ", "TI" }}
            };
        }

        private bool isValidPlay(string dinossauroCode, string cercadoCode, string diceSideCode)
        {

           if(!CercadosDadoValido.Mapa.ContainsKey(cercadoCode))
            {
                return false;
            }
            return CercadosDadoValido.Mapa[cercadoCode].Contains(diceSideCode);
        }

        private void lstBoxCercados_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cercadoJoga = lstBoxCercados.SelectedItem.ToString();
            txtBoxCercado.Text = cercadoJoga;
        }

        private void lstBoxExibeMao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dinossauroJoga = lstBoxExibeMao.SelectedItem.ToString();

            string[] dinossauroJogaInfo = dinossauroJoga.Split(',');
            txtBoxDinossauros.Text = dinossauroJogaInfo[0];
        }

        private void btnShowTabuleiro_Click(object sender, EventArgs e)
        {
            Tabuleiro tabuleiroForm = new Tabuleiro();
            tabuleiroForm.idjogador = this.idjogador;
            tabuleiroForm.idsenha = this.idsenha;
            tabuleiroForm.AtualizarTela();

            tabuleiroForm.Show();
        }
    }
}
