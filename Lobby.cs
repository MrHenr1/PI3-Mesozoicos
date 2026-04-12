using System;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            GameService.AplicarHeader(this, lblVersion, lblGroupTag);
            txtGroupName.Text = "Mesozóicos";
        }

        private void btnListGame_Click(object sender, EventArgs e)
        {
            listBoxGames.Items.Clear();
            try
            {
                string[] games = GameService.ParseResponse(Jogo.ListarPartidas("T"));
                foreach (string game in games)
                {
                    if (!string.IsNullOrWhiteSpace(game))
                        listBoxGames.Items.Add(game);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar partidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNameGame.Text;
            string senha = txtPassword.Text;
            string nomeGrupo = txtGroupName.Text;

            string idPartida = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);

            if (idPartida.StartsWith("ERRO"))
            {
                MessageBox.Show(idPartida, "Erro ao criar partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Partida criada com sucesso!\n\n" +
                    "Nome: " + nomePartida + "\n" +
                    "ID: " + idPartida,
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int entrarID;
            if (!int.TryParse(txtEntrarID.Text, out entrarID))
            {
                MessageBox.Show("ID da partida deve ser um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string entrarSenha = txtEntrarSenha.Text;
            string entrarUsuario = txtNomeJogador.Text;
            string playerInfo = Jogo.Entrar(entrarID, entrarUsuario, entrarSenha);

            if (playerInfo.StartsWith("ERRO"))
            {
                MessageBox.Show(playerInfo, "Erro ao entrar na partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] playerInfos = playerInfo.Split(',');

            WaitingRoom waitingRoom = new WaitingRoom();
            waitingRoom.idjogador = int.Parse(playerInfos[0]);
            waitingRoom.idsenha = playerInfos[1];
            waitingRoom.idpartida = Convert.ToString(entrarID);
            waitingRoom.Atualizartela();
            waitingRoom.Show();
        }
    }
}
