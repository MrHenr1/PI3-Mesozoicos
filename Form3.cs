using System;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }
        public int idjogador { get; set; }
        public string idsenha { get; set; }

        private void btnExibeMao_Click(object sender, EventArgs e) {
            string returned = Jogo.ExibirMao(this.idjogador, this.idsenha);
            txtBoxMaoJogador.Text = returned;
        }
    }
}
