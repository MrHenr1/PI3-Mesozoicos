using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public partial class Tabuleiro : Form
    {
        public int idjogador { get; set; }
        public string idsenha { get; set; }
        public string idGame { get; set; }

        private Image boardImage;
        private List<string[]> boardData = new List<string[]>();

        // Cache das imagens dos dinos (cor -> imagem) - case insensitive
        private Dictionary<string, Image> dinoImages = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        // Zonas dos cercados: posicao em % da imagem (x, y, largura, altura).
        // Ajuste os valores abaixo para alinhar as caixinhas com as zonas do tabuleiro.
        // Dica: x=0.0 = borda esquerda, x=1.0 = borda direita; mesmo raciocinio para y.
        private static readonly Dictionary<string, RectangleF> cercadoZones = new Dictionary<string, RectangleF>(StringComparer.OrdinalIgnoreCase)
        {
            //                          x%     y%     w%     h%
            {"FI", new RectangleF(0.02f, 0.02f, 0.38f, 0.30f)},  // Floresta Igualdade
            {"RS", new RectangleF(0.78f, 0.02f, 0.20f, 0.15f)},  // Rei da Selva
            {"MT", new RectangleF(0.02f, 0.34f, 0.28f, 0.22f)},  // Mata Tripla
            {"RI", new RectangleF(0.35f, 0.34f, 0.30f, 0.22f)},  // Rio
            {"CD", new RectangleF(0.55f, 0.18f, 0.40f, 0.32f)},  // Campina Diferença
            {"PA", new RectangleF(0.02f, 0.58f, 0.38f, 0.30f)},  // Pradaria Amor
            {"IS", new RectangleF(0.65f, 0.65f, 0.25f, 0.20f)},  // Ilha Solitária
        };

        public Tabuleiro()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadBoardImage();
            LoadDinoImages();
            GameService.AplicarHeader(this, lblVersion, lblGrupo);
        }

        private void LoadBoardImage()
        {
            string[] paths = new string[]
            {
                Path.Combine(Application.StartupPath, "Images", "Tabuleiro.jpg"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Tabuleiro.jpg"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "Tabuleiro.jpg"),
            };

            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    boardImage = Image.FromFile(path);
                    return;
                }
            }
        }

        private void LoadDinoImages()
        {
            // Nomes dos arquivos por cor
            string[] cores = { "Amarelo", "Azul", "Laranja", "Roxo", "Verde", "Vermelho" };

            foreach (string cor in cores)
            {
                string[] paths = new string[]
                {
                    Path.Combine(Application.StartupPath, "Images", "dinos", cor + ".png"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "dinos", cor + ".png"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "dinos", cor + ".png"),
                };

                foreach (string path in paths)
                {
                    if (File.Exists(path))
                    {
                        dinoImages[cor] = Image.FromFile(path);
                        break;
                    }
                }
            }
        }

        // Busca imagem: dinoCode -> ListarDinossauros -> cor -> arquivo
        private Image GetDinoImage(string dinoCode)
        {
            try
            {
                var allDinos = GameService.GetAllDinossauros();
                foreach (var dino in allDinos)
                {
                    if (string.Equals(dino[0].Trim(), dinoCode.Trim(), StringComparison.OrdinalIgnoreCase) && dino.Length >= 3)
                    {
                        string cor = dino[2].Trim();
                        if (dinoImages.ContainsKey(cor))
                            return dinoImages[cor];
                    }
                }
            }
            catch { }
            return null;
        }


        public void AtualizarTela()
        {
            CarregarMeuTabuleiro();
            CarregarOponentes();
        }

        private void CarregarMeuTabuleiro()
        {
            boardData.Clear();
            try
            {
                boardData = GameService.GetBoardState(this.idjogador, this.idsenha);
                lblInfo.Text = "Meu tabuleiro - " + boardData.Count + " posições";
                lblJogadorAtual.Text = "Meu Tabuleiro";
                lblJogadorAtual.ForeColor = Color.FromArgb(39, 174, 96);
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Erro: " + ex.Message;
            }
            AtualizarListaTextual();
            panelBoard.Invalidate();
        }

        private void CarregarOponentes()
        {
            cmbOponentes.Items.Clear();
            cmbOponentes.Items.Add("-- Meu Tabuleiro --");
            cmbOponentes.SelectedIndex = 0;

            if (string.IsNullOrEmpty(idGame)) return;

            try
            {
                var players = GameService.GetAllPlayers(idGame);
                foreach (var player in players)
                {
                    int playerId = int.Parse(player[0]);
                    if (playerId != this.idjogador)
                        cmbOponentes.Items.Add(player[1] + " (ID:" + player[0] + ")");
                }
            }
            catch { }
        }

        private void cmbOponentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOponentes.SelectedIndex == 0)
            {
                CarregarMeuTabuleiro();
                return;
            }

            string selected = cmbOponentes.SelectedItem.ToString();
            int idStart = selected.IndexOf("(ID:") + 4;
            int idEnd = selected.IndexOf(")");
            if (idStart < 4 || idEnd < 0) return;

            string opponentIdStr = selected.Substring(idStart, idEnd - idStart);
            int opponentId;
            if (!int.TryParse(opponentIdStr, out opponentId)) return;

            boardData.Clear();
            try
            {
                boardData = GameService.GetBoardStateOponente(opponentId);
                string opponentName = selected.Substring(0, selected.IndexOf(" (ID:"));
                lblInfo.Text = "Tabuleiro de " + opponentName + " - " + boardData.Count + " posições";
                lblJogadorAtual.Text = opponentName;
                lblJogadorAtual.ForeColor = Color.FromArgb(230, 126, 34);
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Erro: " + ex.Message;
            }
            AtualizarListaTextual();
            panelBoard.Invalidate();
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            int panelW = panelBoard.Width;
            int panelH = panelBoard.Height;

            if (boardImage != null)
            {
                float scale = Math.Min((float)panelW / boardImage.Width, (float)panelH / boardImage.Height);
                int imgW = (int)(boardImage.Width * scale);
                int imgH = (int)(boardImage.Height * scale);
                int imgX = (panelW - imgW) / 2;
                int imgY = (panelH - imgH) / 2;

                g.DrawImage(boardImage, imgX, imgY, imgW, imgH);
                DrawZoneOverlays(g, imgX, imgY, imgW, imgH);
                DrawDinosaurs(g, imgX, imgY, imgW, imgH);
            }
            else
            {
                g.Clear(Color.FromArgb(80, 120, 60));
            }

            // Lista textual eh atualizada em CarregarMeuTabuleiro/cmbOponentes
        }

        private void DrawZoneOverlays(Graphics g, int imgX, int imgY, int imgW, int imgH)
        {
            foreach (var kvp in cercadoZones)
            {
                var zone = kvp.Value;
                int zX = imgX + (int)(zone.X * imgW);
                int zY = imgY + (int)(zone.Y * imgH);
                int zW = (int)(zone.Width * imgW);
                int zH = (int)(zone.Height * imgH);

                using (var fill = new SolidBrush(Color.FromArgb(50, 255, 255, 255)))
                    g.FillRectangle(fill, zX, zY, zW, zH);

                using (var border = new Pen(Color.FromArgb(160, 255, 255, 255), 1.5f))
                {
                    border.DashStyle = DashStyle.Dash;
                    g.DrawRectangle(border, zX, zY, zW, zH);
                }

                using (var font = new Font("Segoe UI", 7f, FontStyle.Bold))
                using (var labelBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255)))
                    g.DrawString(kvp.Key, font, labelBrush, zX + 3, zY + 2);
            }
        }

        private void DrawDinosaurs(Graphics g, int imgX, int imgY, int imgW, int imgH)
        {
            // Agrupar boardData por cercado
            var groups = new Dictionary<string, List<string[]>>(StringComparer.OrdinalIgnoreCase);
            foreach (var entry in boardData)
            {
                string code = entry[0];
                if (!groups.ContainsKey(code))
                    groups[code] = new List<string[]>();
                groups[code].Add(entry);
            }

            int dinoSize = Math.Max(30, imgW / 14);

            foreach (var group in groups)
            {
                RectangleF zone;
                if (cercadoZones.ContainsKey(group.Key))
                    zone = cercadoZones[group.Key];
                else
                    continue;

                // Converte zona de % pra pixels
                int zoneX = imgX + (int)(zone.X * imgW);
                int zoneY = imgY + (int)(zone.Y * imgH);
                int zoneW = (int)(zone.Width * imgW);
                int zoneH = (int)(zone.Height * imgH);

                // Grid: quantos cabem por linha na largura da zona
                int spacing = dinoSize + 4;
                int maxCols = Math.Max(1, (zoneW - 8) / spacing);

                int dinoIndex = 0;
                foreach (var entry in group.Value)
                {
                    int qty = 1;
                    if (entry.Length >= 5) int.TryParse(entry[4], out qty);
                    Image dinoImg = GetDinoImage(entry[2]);

                    for (int i = 0; i < qty; i++)
                    {
                        int col = dinoIndex % maxCols;
                        int row = dinoIndex / maxCols;
                        int drawX = zoneX + 4 + col * spacing;
                        int drawY = zoneY + 14 + row * spacing; // 14px para o label do codigo

                        if (dinoImg != null)
                        {
                            g.DrawImage(dinoImg, drawX, drawY, dinoSize, dinoSize);
                        }
                        else
                        {
                            Color dinoColor = GetDinoColorFallback(entry[2]);
                            using (var brush = new SolidBrush(dinoColor))
                            using (var pen = new Pen(Color.FromArgb(40, 20, 5), 2))
                            {
                                g.FillEllipse(brush, drawX, drawY, dinoSize, dinoSize);
                                g.DrawEllipse(pen, drawX, drawY, dinoSize, dinoSize);
                            }
                        }
                        dinoIndex++;
                    }
                }
            }
        }

        private void AtualizarListaTextual()
        {
            lstBoardData.Items.Clear();

            if (boardData.Count == 0)
            {
                lstBoardData.Items.Add("(Tabuleiro vazio)");
                return;
            }

            foreach (var entry in boardData)
            {
                // entry: [cercadoCode, cercadoName, dinoCode, dinoName, qty]
                string cercadoCode = entry[0];
                string cercado = entry[1];
                string dinoCode = entry[2];
                string dino = entry[3];
                string qty = entry.Length >= 5 ? entry[4] : "?";

                bool posFound = cercadoZones.ContainsKey(cercadoCode);
                string posTag = posFound ? "" : " [?pos]";

                lstBoardData.Items.Add("[" + cercadoCode + "] " + cercado + " - " + dino + " x" + qty + posTag);
            }
        }

        private Color GetDinoColorFallback(string dinoCode)
        {
            try
            {
                var allDinos = GameService.GetAllDinossauros();
                foreach (var dino in allDinos)
                {
                    if (dino[0] == dinoCode && dino.Length >= 3)
                        return GameService.GetDinoColor(dino[2]);
                }
            }
            catch { }
            return Color.Gray;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cmbOponentes.SelectedIndex == 0)
                CarregarMeuTabuleiro();
            else
                cmbOponentes_SelectedIndexChanged(sender, e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (boardImage != null) boardImage.Dispose();
                foreach (var img in dinoImages.Values)
                    if (img != null) img.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
