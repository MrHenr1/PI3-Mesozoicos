using System;
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



        }

        public Form3() {
            InitializeComponent();
        }
        
        private void btnExibeMao_Click(object sender, EventArgs e) {
            string returned = Jogo.ExibirMao(this.idjogador, this.idsenha);

            returned = returned.Replace("\r", "");

            string[] dinossauros = returned.Split('\n');


            string playerName = getUsernameById(this.idGame, Convert.ToString(this.idjogador));
            lblPlayerDiceData.Text = playerName;

            for (int i = 0; i < dinossauros.Length; i++) {
                lstBoxExibeMao.Items.Add(dinossauros[i]);
            }

        }

        private void btnUpdateScreen_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void btnExibeCercados_Click(object sender, EventArgs e) {
            string returned = Jogo.ListarCercados();

            returned = returned.Replace("\r", "");

            string[] cercados = returned.Split('\n');

            foreach (var cercado in cercados) {
                string[] CercadosInfos = cercado.Split(',');
                lstBoxCercados.Items.Add(CercadosInfos[0]);
            }
            return;
        }

        private void btnLancaJogada_Click(object sender, EventArgs e) {
            string dinossauroJoga = txtBoxDinossauros.Text;
            string cercadoJoga = txtBoxCercado.Text;
            string gameReturn = Jogo.Jogar(idjogador,idsenha,dinossauroJoga,cercadoJoga);
            lblResulta.Text = gameReturn;
            if (gameReturn.StartsWith("ERRO")) {
                MessageBox.Show(gameReturn, "Erro ao realizar a jogada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
