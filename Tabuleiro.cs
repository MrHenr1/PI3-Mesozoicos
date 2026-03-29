using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class Tabuleiro : Form
    {
        public int idjogador { get; set; }
        public string idsenha { get; set; }

        private string getDinossauroName(string idDinossauro)
        {
            string dinossaurosList = Jogo.ListarDinossauros(true);
            dinossaurosList = dinossaurosList.Replace("\r", "");
            dinossaurosList = dinossaurosList.Substring(0, dinossaurosList.Length - 1);
            string[] dinossauros = dinossaurosList.Split('\n');
            foreach (var dinossauro in dinossauros)
            {
                string[] dinossauroInfos = dinossauro.Split(',');
                if (dinossauroInfos[0] == idDinossauro) return dinossauroInfos[1];
            }
            return null;
        }

        private string getCercadoName(string idCercado)
        {
            string cercadosList = Jogo.ListarCercados();
            cercadosList = cercadosList.Replace("\r", "");
            cercadosList = cercadosList.Substring(0, cercadosList.Length - 1);
            string[] cercados = cercadosList.Split('\n');
            foreach (var cercado in cercados)
            {
                string[] cercadoInfos = cercado.Split(',');
                if (cercadoInfos[0] == idCercado) return cercadoInfos[1];
            }
            return null;
        }
        public Tabuleiro()
        {
            InitializeComponent();
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }


        public void AtualizarTela()
        {
            string tabuleiro = Jogo.ExibirTabuleiro(this.idjogador, this.idsenha);

            tabuleiro = tabuleiro.Replace("\r", "");
            tabuleiro = tabuleiro.Substring(0, tabuleiro.Length - 1);
            string[] tabuleiroLines = tabuleiro.Split('\n');

            foreach(string line in tabuleiroLines)
            {
                string[] play = line.Split(',');
                string dinossauroName = getDinossauroName(play[1]);
                string cercadoName = getCercadoName(play[0]);

                string lineInfo = cercadoName + "," + dinossauroName + "," + "Qnt: " + play[2];

                lstTabuleiro.Items.Add(lineInfo);
            }

            
        }
    }
}
