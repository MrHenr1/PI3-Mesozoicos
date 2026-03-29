using System;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos {
    public partial class Form2 : Form {

        public int idjogador { get; set; }
        public string idsenha { get; set; }
        public string idpartida { get; set; }

        public Form2() {
            InitializeComponent();
            txtIDListar.Text = idpartida;
        }

        public void Atualizartela() {
            lblidjogador.Text = Convert.ToString(idjogador);
            lblidsenha.Text = Convert.ToString(idsenha);
            lblidpartida.Text = Convert.ToString(idpartida);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e) {
            // int idpartida = int.Parse(txtIDListar.Text);
            string returned = Jogo.ListarJogadores(int.Parse(this.idpartida));
            txtBoxJogadores.Text = returned;

            
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e) {
            string gameReturn = Jogo.Iniciar(this.idjogador, this.idsenha);

            //if(lblPartidaStatus.Text.StartsWith("ERRO"))
            //{

            //}


            if (gameReturn.StartsWith("ERRO") )
            {
                MessageBox.Show(gameReturn, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] gamesInfos = gameReturn.Split(',');
            Form3 form3 = new Form3();
            form3.idjogador = this.idjogador;
            form3.idsenha = this.idsenha;
            form3.idPlayerDiceSelected = gamesInfos[0];
            form3.diceSide = gamesInfos[1];
            form3.idGame = this.idpartida;

            form3.Show();
        }
                              
        private void btnExibeMao_Click(object sender, EventArgs e) {
            string returned = Jogo.ExibirMao(this.idjogador, this.idsenha);
            txtBoxMaoJogador.Text = returned;
        }
    }
}
