namespace Mesozoicos
{
    partial class Resultado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lstRanking = new System.Windows.Forms.ListBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblVersion
            //
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(560, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            //
            // lblGrupo
            //
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Location = new System.Drawing.Point(560, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Text = "Mesozóicos";
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblTitulo.Size = new System.Drawing.Size(680, 50);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Text = "JOGO ENCERRADO!";
            this.lblTitulo.Name = "lblTitulo";
            //
            // lblVencedor
            //
            this.lblVencedor.AutoSize = false;
            this.lblVencedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblVencedor.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblVencedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVencedor.Location = new System.Drawing.Point(0, 62);
            this.lblVencedor.Size = new System.Drawing.Size(680, 32);
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVencedor.Text = "Vencedor: ...";
            this.lblVencedor.Name = "lblVencedor";
            //
            // lblRanking
            //
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRanking.ForeColor = System.Drawing.Color.White;
            this.lblRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblRanking.Location = new System.Drawing.Point(20, 105);
            this.lblRanking.Text = "Classificação Final:";
            this.lblRanking.Name = "lblRanking";
            //
            // lstRanking
            //
            this.lstRanking.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.lstRanking.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstRanking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstRanking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRanking.Location = new System.Drawing.Point(20, 128);
            this.lstRanking.Size = new System.Drawing.Size(290, 370);
            this.lstRanking.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstRanking.Name = "lstRanking";
            //
            // lblDetalhes
            //
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalhes.ForeColor = System.Drawing.Color.White;
            this.lblDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalhes.Location = new System.Drawing.Point(330, 105);
            this.lblDetalhes.Text = "Sua pontuação (detalhes):";
            this.lblDetalhes.Name = "lblDetalhes";
            //
            // txtDetalhes
            //
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.txtDetalhes.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtDetalhes.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalhes.Location = new System.Drawing.Point(330, 128);
            this.txtDetalhes.Size = new System.Drawing.Size(330, 370);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalhes.ReadOnly = true;
            this.txtDetalhes.Name = "txtDetalhes";
            //
            // btnFechar
            //
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(240, 516);
            this.btnFechar.Size = new System.Drawing.Size(200, 45);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            //
            // Resultado
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.ForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 578);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Resultado";
            this.Text = "DRAFTOSAURUS - Resultado Final";
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lstRanking);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.btnFechar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.ListBox lstRanking;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Button btnFechar;
    }
}
