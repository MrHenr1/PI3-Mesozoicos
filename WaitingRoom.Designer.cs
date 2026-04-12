namespace Mesozoicos
{
    partial class WaitingRoom
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.grpPlayerInfo = new System.Windows.Forms.GroupBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblIdJogadorVal = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaVal = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblIdPartidaVal = new System.Windows.Forms.Label();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.grpPlayerInfo.SuspendLayout();
            this.grpPlayers.SuspendLayout();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.Text = "SALA DE ESPERA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblVersion
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(470, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 15);
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // lblGrupo
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Location = new System.Drawing.Point(470, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(70, 15);
            this.lblGrupo.Text = "Mesozóicos";
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // grpPlayerInfo
            this.grpPlayerInfo.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpPlayerInfo.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpPlayerInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.grpPlayerInfo.Controls.Add(this.lblIdJogador);
            this.grpPlayerInfo.Controls.Add(this.lblIdJogadorVal);
            this.grpPlayerInfo.Controls.Add(this.lblSenha);
            this.grpPlayerInfo.Controls.Add(this.lblSenhaVal);
            this.grpPlayerInfo.Controls.Add(this.lblIdPartida);
            this.grpPlayerInfo.Controls.Add(this.lblIdPartidaVal);
            this.grpPlayerInfo.Location = new System.Drawing.Point(15, 60);
            this.grpPlayerInfo.Name = "grpPlayerInfo";
            this.grpPlayerInfo.Size = new System.Drawing.Size(350, 140);
            this.grpPlayerInfo.TabIndex = 0;
            this.grpPlayerInfo.TabStop = false;
            this.grpPlayerInfo.Text = "Suas Informações";
            // lblIdJogador
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdJogador.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblIdJogador.Location = new System.Drawing.Point(12, 35);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(90, 19);
            this.lblIdJogador.Text = "ID Jogador:";
            // lblIdJogadorVal
            this.lblIdJogadorVal.AutoSize = true;
            this.lblIdJogadorVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdJogadorVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblIdJogadorVal.Location = new System.Drawing.Point(160, 35);
            this.lblIdJogadorVal.Name = "lblIdJogadorVal";
            this.lblIdJogadorVal.Size = new System.Drawing.Size(30, 19);
            this.lblIdJogadorVal.Text = "---";
            // lblSenha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblSenha.Location = new System.Drawing.Point(12, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(110, 19);
            this.lblSenha.Text = "Senha Jogador:";
            // lblSenhaVal
            this.lblSenhaVal.AutoSize = true;
            this.lblSenhaVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSenhaVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblSenhaVal.Location = new System.Drawing.Point(160, 65);
            this.lblSenhaVal.Name = "lblSenhaVal";
            this.lblSenhaVal.Size = new System.Drawing.Size(30, 19);
            this.lblSenhaVal.Text = "---";
            // lblIdPartida
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdPartida.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblIdPartida.Location = new System.Drawing.Point(12, 95);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(80, 19);
            this.lblIdPartida.Text = "ID Partida:";
            // lblIdPartidaVal
            this.lblIdPartidaVal.AutoSize = true;
            this.lblIdPartidaVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdPartidaVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblIdPartidaVal.Location = new System.Drawing.Point(160, 95);
            this.lblIdPartidaVal.Name = "lblIdPartidaVal";
            this.lblIdPartidaVal.Size = new System.Drawing.Size(30, 19);
            this.lblIdPartidaVal.Text = "---";
            // grpPlayers
            this.grpPlayers.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpPlayers.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpPlayers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.grpPlayers.Controls.Add(this.lstJogadores);
            this.grpPlayers.Controls.Add(this.btnListarJogadores);
            this.grpPlayers.Controls.Add(this.btnIniciarPartida);
            this.grpPlayers.Location = new System.Drawing.Point(15, 210);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(550, 300);
            this.grpPlayers.TabIndex = 1;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Jogadores na Partida";
            // lstJogadores
            this.lstJogadores.BackColor = System.Drawing.Color.White;
            this.lstJogadores.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstJogadores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstJogadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 18;
            this.lstJogadores.Location = new System.Drawing.Point(12, 35);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(526, 202);
            this.lstJogadores.TabIndex = 0;
            // btnListarJogadores
            this.btnListarJogadores.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnListarJogadores.ForeColor = System.Drawing.Color.White;
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.FlatAppearance.BorderSize = 0;
            this.btnListarJogadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.Location = new System.Drawing.Point(12, 245);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(255, 42);
            this.btnListarJogadores.TabIndex = 1;
            this.btnListarJogadores.Text = "Atualizar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // btnIniciarPartida
            this.btnIniciarPartida.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.FlatAppearance.BorderSize = 0;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.Location = new System.Drawing.Point(283, 245);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(255, 42);
            this.btnIniciarPartida.TabIndex = 2;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // lblStatus
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(380, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 19);
            this.lblStatus.Text = "";
            // WaitingRoom
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.ForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 530);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.grpPlayerInfo);
            this.Controls.Add(this.grpPlayers);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "WaitingRoom";
            this.Text = "DRAFTOSAURUS - Sala de Espera";
            this.grpPlayerInfo.ResumeLayout(false);
            this.grpPlayerInfo.PerformLayout();
            this.grpPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.GroupBox grpPlayerInfo;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblIdJogadorVal;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenhaVal;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblIdPartidaVal;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblStatus;
    }
}
