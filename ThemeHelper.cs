using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Mesozoicos
{
    public static class ThemeHelper
    {
        // Cores principais do tema Draftosaurus
        public static readonly Color BackgroundDark = Color.FromArgb(27, 67, 50);       // Verde escuro
        public static readonly Color BackgroundMedium = Color.FromArgb(45, 106, 79);    // Verde medio
        public static readonly Color BackgroundLight = Color.FromArgb(82, 145, 115);    // Verde claro
        public static readonly Color PanelBackground = Color.FromArgb(250, 237, 205);   // Bege claro
        public static readonly Color PanelBorder = Color.FromArgb(139, 90, 43);         // Marrom
        public static readonly Color ButtonPrimary = Color.FromArgb(230, 126, 34);      // Laranja
        public static readonly Color ButtonPrimaryHover = Color.FromArgb(211, 84, 0);   // Laranja escuro
        public static readonly Color ButtonSecondary = Color.FromArgb(142, 68, 173);    // Roxo
        public static readonly Color ButtonDanger = Color.FromArgb(192, 57, 43);        // Vermelho
        public static readonly Color TextLight = Color.FromArgb(255, 255, 255);         // Branco
        public static readonly Color TextDark = Color.FromArgb(60, 35, 10);             // Marrom escuro
        public static readonly Color TextGold = Color.FromArgb(241, 196, 15);           // Dourado
        public static readonly Color AccentGreen = Color.FromArgb(39, 174, 96);         // Verde destaque
        public static readonly Color HudBackground = Color.FromArgb(40, 40, 40, 200);   // Preto semi-transparente

        // Fontes
        public static readonly Font TitleFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static readonly Font LabelFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font LabelBoldFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font SmallFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font HudFont = new Font("Segoe UI", 12F, FontStyle.Bold);

        public static void ApplyFormTheme(Form form)
        {
            form.BackColor = BackgroundDark;
            form.ForeColor = TextLight;
            form.Font = LabelFont;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void StyleGroupBox(GroupBox gb)
        {
            gb.BackColor = PanelBackground;
            gb.ForeColor = TextDark;
            gb.Font = SubtitleFont;
            gb.FlatStyle = FlatStyle.Flat;
        }

        public static void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = TextLight;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = ButtonFont;
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = TextDark;
            txt.Font = LabelFont;
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void StyleListBox(ListBox lb)
        {
            lb.BackColor = Color.White;
            lb.ForeColor = TextDark;
            lb.Font = LabelFont;
            lb.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void StyleLabel(Label lbl, Font font = null)
        {
            lbl.Font = font ?? LabelFont;
            lbl.ForeColor = TextDark;
        }

        public static void StyleDarkLabel(Label lbl, Font font = null)
        {
            lbl.Font = font ?? LabelFont;
            lbl.ForeColor = TextLight;
            lbl.BackColor = Color.Transparent;
        }

        public static Panel CreateHeaderPanel(string title, int width)
        {
            var panel = new Panel();
            panel.BackColor = BackgroundMedium;
            panel.Dock = DockStyle.Top;
            panel.Height = 60;
            panel.Width = width;

            var lbl = new Label();
            lbl.Text = title;
            lbl.Font = TitleFont;
            lbl.ForeColor = TextGold;
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Dock = DockStyle.Fill;
            panel.Controls.Add(lbl);

            return panel;
        }

        public static void DrawDinoMarker(Graphics g, Color color, int x, int y, int size)
        {
            using (var brush = new SolidBrush(color))
            using (var pen = new Pen(Color.FromArgb(60, 35, 10), 2))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(brush, x - size / 2, y - size / 2, size, size);
                g.DrawEllipse(pen, x - size / 2, y - size / 2, size, size);
            }
        }
    }
}
