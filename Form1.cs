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

namespace Mesozoicos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnListGame_Click(object sender, EventArgs e) {
           string retuned = Jogo.ListarPartidas("T");
            retuned = retuned.Replace("\r", "");

            retuned = retuned.Substring(0, retuned.Length - 1);

            string[] games = retuned.Split('\n');

            for (int i = 0; i < games.Length; i++) {
                listBoxGames.Items.Add(games[i]);
            }
        }

        private void lblVersion_Click(object sender, EventArgs e) {
            
        }

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnCreateGame_Click(object sender, EventArgs e) {
            string nomePartida = txtNameGame.Text;
            string senha = txtPassword.Text;
            string nomeGrupo = txtGroupName.Text;

            
            string idPartida = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);
            if (idPartida == "ERRO: Partida já existente") {
                MessageBox.Show("Essa Partida já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idPartida == "ERRO:Nome da partida está vazio") {
                MessageBox.Show("Dados inválidos! Insira dados corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                textResultGame.Text = "NONE: " + nomePartida + " SENHA: " + senha + " GRUPO: " + nomeGrupo + " ID PARTIDA: " + idPartida;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            int entrarID = Convert.ToInt32(txtEntrarID.Text);
            string entrarSenha = txtEntrarSenha.Text;
            string entrarUsuario = txtNomeJogador.Text;
            string playerInfo = Jogo.Entrar(entrarID, entrarUsuario, entrarSenha);

           
            string[] playerInfos = playerInfo.Split(',');
            if (playerInfo == "ERRO: Partida não está aberta") {
                MessageBox.Show("Essa Partida não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                txtBoxPlayerInfo.Text = "ID:" + playerInfos[0] + "\n" + "Senha:" + playerInfos[1];
                
                Form2 form2 = new Form2();
                form2.idjogador = int.Parse(playerInfos[0]);
                form2.idsenha = playerInfos[1];
                form2.idpartida = Convert.ToString(entrarID);
                form2.Atualizartela();
                form2.Show();
            }
        }

        private void txtEntrarID_TextChanged(object sender, EventArgs e) {

        }
    }
}
