using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class Resultado : Form
    {
        public string idGame { get; set; }
        public int idjogador { get; set; }

        public Resultado()
        {
            InitializeComponent();
            GameService.AplicarHeader(this, lblVersion, lblGrupo);
        }

        public void Carregar()
        {
            try
            {
                var players = GameService.GetAllPlayers(idGame);

                players.Sort((a, b) =>
                {
                    int scoreA = 0, scoreB = 0;
                    if (a.Length >= 3) int.TryParse(a[2], out scoreA);
                    if (b.Length >= 3) int.TryParse(b[2], out scoreB);
                    return scoreB.CompareTo(scoreA);
                });

                lstRanking.Items.Clear();
                string[] medals = { "1°", "2°", "3°", "4°" };
                string winnerName = "";

                for (int i = 0; i < players.Count; i++)
                {
                    var p = players[i];
                    string name = p.Length >= 2 ? p[1] : p[0];
                    string score = p.Length >= 3 ? p[2] : "?";
                    string medal = i < medals.Length ? medals[i] : (i + 1) + "°";
                    lstRanking.Items.Add(medal + "  " + name + "  —  " + score + " pts");
                    if (i == 0) winnerName = name;
                }

                if (!string.IsNullOrEmpty(winnerName))
                    lblVencedor.Text = "Vencedor: " + winnerName;

                string myName = GameService.GetUsernameById(idGame, idjogador.ToString()) ?? idjogador.ToString();
                lblDetalhes.Text = "Pontuação de " + myName + ":";

                CarregarDetalhesPontuacao();
            }
            catch (Exception ex)
            {
                lblVencedor.Text = "Erro: " + ex.Message;
            }
        }

        private void CarregarDetalhesPontuacao()
        {
            try
            {
                string raw = Jogo.ListarPontuacao(idjogador);
                if (string.IsNullOrEmpty(raw))
                {
                    txtDetalhes.Text = "(Sem detalhes disponíveis)";
                    return;
                }

                var sb = new StringBuilder();
                string[] lines = GameService.ParseResponse(raw);
                int total = 0;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        string code = parts[0].Trim();
                        string valor = parts[1].Trim();

                        string cercadoName = GameService.GetCercadoName(code);
                        string label = cercadoName != null
                            ? cercadoName + " (" + code + ")"
                            : code;

                        int pts = 0;
                        int.TryParse(valor, out pts);
                        total += pts;

                        sb.AppendLine(label + ":  " + pts + " pts");
                    }
                    else
                    {
                        sb.AppendLine(line.Trim());
                    }
                }

                sb.AppendLine();
                sb.AppendLine("─────────────────────");
                sb.AppendLine("Total:  " + total + " pts");

                txtDetalhes.Text = sb.ToString();
            }
            catch
            {
                txtDetalhes.Text = "(Erro ao buscar detalhes)";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
