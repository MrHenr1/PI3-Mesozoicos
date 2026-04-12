namespace Mesozoicos
{
    partial class Tabuleiro
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose esta no Tabuleiro.cs (limpa imagens tambem)

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblJogadorAtual = new System.Windows.Forms.Label();
            this.cmbOponentes = new System.Windows.Forms.ComboBox();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblVersion
            //
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(580, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 15);
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //
            // lblGrupo
            //
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Location = new System.Drawing.Point(580, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(70, 15);
            this.lblGrupo.Text = "Mesozóicos";
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //
            // lblJogadorAtual
            //
            this.lblJogadorAtual.AutoSize = true;
            this.lblJogadorAtual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJogadorAtual.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblJogadorAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorAtual.Location = new System.Drawing.Point(12, 9);
            this.lblJogadorAtual.Name = "lblJogadorAtual";
            this.lblJogadorAtual.Size = new System.Drawing.Size(150, 25);
            this.lblJogadorAtual.Text = "Meu Tabuleiro";
            //
            // cmbOponentes
            //
            this.cmbOponentes.BackColor = System.Drawing.Color.White;
            this.cmbOponentes.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.cmbOponentes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOponentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOponentes.FormattingEnabled = true;
            this.cmbOponentes.Location = new System.Drawing.Point(12, 42);
            this.cmbOponentes.Name = "cmbOponentes";
            this.cmbOponentes.Size = new System.Drawing.Size(280, 26);
            this.cmbOponentes.TabIndex = 0;
            this.cmbOponentes.SelectedIndexChanged += new System.EventHandler(this.cmbOponentes_SelectedIndexChanged);
            //
            // panelBoard
            //
            this.panelBoard.BackColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.panelBoard.Location = new System.Drawing.Point(12, 75);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(560, 560);
            this.panelBoard.TabIndex = 1;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            //
            // lstBoardData
            //
            this.lstBoardData = new System.Windows.Forms.ListBox();
            this.lstBoardData.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.lstBoardData.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstBoardData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBoardData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBoardData.FormattingEnabled = true;
            this.lstBoardData.ItemHeight = 18;
            this.lstBoardData.Location = new System.Drawing.Point(580, 75);
            this.lstBoardData.Name = "lstBoardData";
            this.lstBoardData.Size = new System.Drawing.Size(280, 560);
            this.lstBoardData.TabIndex = 3;
            //
            // btnAtualizar
            //
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 645);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(200, 40);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar Tabuleiro";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            //
            // lblInfo
            //
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(230, 653);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 19);
            this.lblInfo.Text = "";
            //
            // Tabuleiro
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.ForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblJogadorAtual);
            this.Controls.Add(this.cmbOponentes);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.lstBoardData);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Tabuleiro";
            this.Text = "DRAFTOSAURUS - Tabuleiro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblJogadorAtual;
        private System.Windows.Forms.ComboBox cmbOponentes;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstBoardData;
    }
}
