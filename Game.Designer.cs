namespace Mesozoicos
{
    partial class Game
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
            this.panelHud = new System.Windows.Forms.Panel();
            this.lblPlayerLabel = new System.Windows.Forms.Label();
            this.lblPlayerVal = new System.Windows.Forms.Label();
            this.lblTurnoLabel = new System.Windows.Forms.Label();
            this.lblTurnoVal = new System.Windows.Forms.Label();
            this.lblDadoLabel = new System.Windows.Forms.Label();
            this.lblDadoVal = new System.Windows.Forms.Label();
            this.lblJogadorDadoLabel = new System.Windows.Forms.Label();
            this.lblJogadorDadoVal = new System.Windows.Forms.Label();
            this.grpMao = new System.Windows.Forms.GroupBox();
            this.lstMao = new System.Windows.Forms.ListBox();
            this.grpCercados = new System.Windows.Forms.GroupBox();
            this.lstCercados = new System.Windows.Forms.ListBox();
            this.grpJogada = new System.Windows.Forms.GroupBox();
            this.lblDinossauro = new System.Windows.Forms.Label();
            this.txtDinossauro = new System.Windows.Forms.TextBox();
            this.lblCercado = new System.Windows.Forms.Label();
            this.txtCercado = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.grpTurnoStatus = new System.Windows.Forms.GroupBox();
            this.lstTurnoStatus = new System.Windows.Forms.ListBox();
            this.grpHistorico = new System.Windows.Forms.GroupBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnTabuleiro = new System.Windows.Forms.Button();
            this.panelHud.SuspendLayout();
            this.grpMao.SuspendLayout();
            this.grpCercados.SuspendLayout();
            this.grpJogada.SuspendLayout();
            this.grpTurnoStatus.SuspendLayout();
            this.grpHistorico.SuspendLayout();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.Text = "DRAFTOSAURUS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblVersion
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(1040, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 15);
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // lblGrupo
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Location = new System.Drawing.Point(1040, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(70, 15);
            this.lblGrupo.Text = "Mesozóicos";
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // panelHud
            this.panelHud.BackColor = System.Drawing.Color.FromArgb(30, 50, 35);
            this.panelHud.Controls.Add(this.lblPlayerLabel);
            this.panelHud.Controls.Add(this.lblPlayerVal);
            this.panelHud.Controls.Add(this.lblTurnoLabel);
            this.panelHud.Controls.Add(this.lblTurnoVal);
            this.panelHud.Controls.Add(this.lblDadoLabel);
            this.panelHud.Controls.Add(this.lblDadoVal);
            this.panelHud.Controls.Add(this.lblJogadorDadoLabel);
            this.panelHud.Controls.Add(this.lblJogadorDadoVal);
            this.panelHud.Location = new System.Drawing.Point(12, 55);
            this.panelHud.Name = "panelHud";
            this.panelHud.Size = new System.Drawing.Size(1090, 70);
            // lblPlayerLabel
            this.lblPlayerLabel.AutoSize = true;
            this.lblPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.lblPlayerLabel.Location = new System.Drawing.Point(10, 10);
            this.lblPlayerLabel.Name = "lblPlayerLabel";
            this.lblPlayerLabel.Text = "Jogador:";
            // lblPlayerVal
            this.lblPlayerVal.AutoSize = true;
            this.lblPlayerVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerVal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblPlayerVal.Location = new System.Drawing.Point(10, 38);
            this.lblPlayerVal.Name = "lblPlayerVal";
            this.lblPlayerVal.Text = "---";
            // lblTurnoLabel
            this.lblTurnoLabel.AutoSize = true;
            this.lblTurnoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTurnoLabel.ForeColor = System.Drawing.Color.White;
            this.lblTurnoLabel.Location = new System.Drawing.Point(250, 10);
            this.lblTurnoLabel.Name = "lblTurnoLabel";
            this.lblTurnoLabel.Text = "Turno:";
            // lblTurnoVal
            this.lblTurnoVal.AutoSize = true;
            this.lblTurnoVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurnoVal.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblTurnoVal.Location = new System.Drawing.Point(250, 38);
            this.lblTurnoVal.Name = "lblTurnoVal";
            this.lblTurnoVal.Text = "---";
            // lblDadoLabel
            this.lblDadoLabel.AutoSize = true;
            this.lblDadoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDadoLabel.ForeColor = System.Drawing.Color.White;
            this.lblDadoLabel.Location = new System.Drawing.Point(480, 10);
            this.lblDadoLabel.Name = "lblDadoLabel";
            this.lblDadoLabel.Text = "Face do Dado:";
            // lblDadoVal
            this.lblDadoVal.AutoSize = true;
            this.lblDadoVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDadoVal.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblDadoVal.Location = new System.Drawing.Point(480, 38);
            this.lblDadoVal.Name = "lblDadoVal";
            this.lblDadoVal.Text = "---";
            // lblJogadorDadoLabel
            this.lblJogadorDadoLabel.AutoSize = true;
            this.lblJogadorDadoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJogadorDadoLabel.ForeColor = System.Drawing.Color.White;
            this.lblJogadorDadoLabel.Location = new System.Drawing.Point(780, 10);
            this.lblJogadorDadoLabel.Name = "lblJogadorDadoLabel";
            this.lblJogadorDadoLabel.Text = "Jogador com Dado:";
            // lblJogadorDadoVal
            this.lblJogadorDadoVal.AutoSize = true;
            this.lblJogadorDadoVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJogadorDadoVal.ForeColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.lblJogadorDadoVal.Location = new System.Drawing.Point(780, 38);
            this.lblJogadorDadoVal.Name = "lblJogadorDadoVal";
            this.lblJogadorDadoVal.Text = "---";
            // grpMao
            this.grpMao.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpMao.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpMao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpMao.Controls.Add(this.lstMao);
            this.grpMao.Location = new System.Drawing.Point(12, 135);
            this.grpMao.Name = "grpMao";
            this.grpMao.Size = new System.Drawing.Size(250, 260);
            this.grpMao.TabIndex = 0;
            this.grpMao.TabStop = false;
            this.grpMao.Text = "Minha Mão";
            // lstMao
            this.lstMao.BackColor = System.Drawing.Color.White;
            this.lstMao.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstMao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstMao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMao.FormattingEnabled = true;
            this.lstMao.ItemHeight = 18;
            this.lstMao.Location = new System.Drawing.Point(10, 30);
            this.lstMao.Name = "lstMao";
            this.lstMao.Size = new System.Drawing.Size(230, 220);
            this.lstMao.TabIndex = 0;
            this.lstMao.SelectedIndexChanged += new System.EventHandler(this.lstMao_SelectedIndexChanged);
            // grpCercados
            this.grpCercados.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpCercados.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpCercados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpCercados.Controls.Add(this.lstCercados);
            this.grpCercados.Location = new System.Drawing.Point(275, 135);
            this.grpCercados.Name = "grpCercados";
            this.grpCercados.Size = new System.Drawing.Size(250, 260);
            this.grpCercados.TabIndex = 1;
            this.grpCercados.TabStop = false;
            this.grpCercados.Text = "Cercados";
            // lstCercados
            this.lstCercados.BackColor = System.Drawing.Color.White;
            this.lstCercados.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstCercados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCercados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCercados.FormattingEnabled = true;
            this.lstCercados.ItemHeight = 18;
            this.lstCercados.Location = new System.Drawing.Point(10, 30);
            this.lstCercados.Name = "lstCercados";
            this.lstCercados.Size = new System.Drawing.Size(230, 220);
            this.lstCercados.TabIndex = 0;
            this.lstCercados.SelectedIndexChanged += new System.EventHandler(this.lstCercados_SelectedIndexChanged);
            // grpJogada
            this.grpJogada.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpJogada.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpJogada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpJogada.Controls.Add(this.lblDinossauro);
            this.grpJogada.Controls.Add(this.txtDinossauro);
            this.grpJogada.Controls.Add(this.lblCercado);
            this.grpJogada.Controls.Add(this.txtCercado);
            this.grpJogada.Controls.Add(this.btnJogar);
            this.grpJogada.Location = new System.Drawing.Point(540, 135);
            this.grpJogada.Name = "grpJogada";
            this.grpJogada.Size = new System.Drawing.Size(260, 260);
            this.grpJogada.TabIndex = 2;
            this.grpJogada.TabStop = false;
            this.grpJogada.Text = "Fazer Jogada";
            // lblDinossauro
            this.lblDinossauro.AutoSize = true;
            this.lblDinossauro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDinossauro.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblDinossauro.Location = new System.Drawing.Point(10, 35);
            this.lblDinossauro.Name = "lblDinossauro";
            this.lblDinossauro.Text = "Dinossauro:";
            // txtDinossauro
            this.txtDinossauro.BackColor = System.Drawing.Color.White;
            this.txtDinossauro.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtDinossauro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDinossauro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDinossauro.Location = new System.Drawing.Point(12, 58);
            this.txtDinossauro.Name = "txtDinossauro";
            this.txtDinossauro.ReadOnly = true;
            this.txtDinossauro.Size = new System.Drawing.Size(236, 26);
            this.txtDinossauro.TabIndex = 0;
            // lblCercado
            this.lblCercado.AutoSize = true;
            this.lblCercado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCercado.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblCercado.Location = new System.Drawing.Point(10, 95);
            this.lblCercado.Name = "lblCercado";
            this.lblCercado.Text = "Cercado:";
            // txtCercado
            this.txtCercado.BackColor = System.Drawing.Color.White;
            this.txtCercado.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtCercado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCercado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCercado.Location = new System.Drawing.Point(12, 118);
            this.txtCercado.Name = "txtCercado";
            this.txtCercado.ReadOnly = true;
            this.txtCercado.Size = new System.Drawing.Size(236, 26);
            this.txtCercado.TabIndex = 1;
            // btnJogar
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Location = new System.Drawing.Point(12, 170);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(236, 50);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR!";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // grpTurnoStatus
            this.grpTurnoStatus.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpTurnoStatus.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpTurnoStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpTurnoStatus.Controls.Add(this.lstTurnoStatus);
            this.grpTurnoStatus.Location = new System.Drawing.Point(815, 135);
            this.grpTurnoStatus.Name = "grpTurnoStatus";
            this.grpTurnoStatus.Size = new System.Drawing.Size(290, 150);
            this.grpTurnoStatus.TabIndex = 3;
            this.grpTurnoStatus.TabStop = false;
            this.grpTurnoStatus.Text = "Status do Turno";
            // lstTurnoStatus
            this.lstTurnoStatus.BackColor = System.Drawing.Color.White;
            this.lstTurnoStatus.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lstTurnoStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstTurnoStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTurnoStatus.FormattingEnabled = true;
            this.lstTurnoStatus.ItemHeight = 18;
            this.lstTurnoStatus.Location = new System.Drawing.Point(10, 30);
            this.lstTurnoStatus.Name = "lstTurnoStatus";
            this.lstTurnoStatus.Size = new System.Drawing.Size(270, 110);
            this.lstTurnoStatus.TabIndex = 0;
            // grpHistorico
            this.grpHistorico.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpHistorico.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpHistorico.Controls.Add(this.txtHistorico);
            this.grpHistorico.Location = new System.Drawing.Point(12, 405);
            this.grpHistorico.Name = "grpHistorico";
            this.grpHistorico.Size = new System.Drawing.Size(790, 180);
            this.grpHistorico.TabIndex = 4;
            this.grpHistorico.TabStop = false;
            this.grpHistorico.Text = "Histórico";
            // txtHistorico
            this.txtHistorico.BackColor = System.Drawing.Color.White;
            this.txtHistorico.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtHistorico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistorico.Location = new System.Drawing.Point(10, 30);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(770, 140);
            this.txtHistorico.TabIndex = 0;
            // btnAtualizar
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(815, 540);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 42);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar Tela";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // btnTabuleiro
            this.btnTabuleiro.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnTabuleiro.ForeColor = System.Drawing.Color.White;
            this.btnTabuleiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabuleiro.FlatAppearance.BorderSize = 0;
            this.btnTabuleiro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabuleiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabuleiro.Location = new System.Drawing.Point(965, 540);
            this.btnTabuleiro.Name = "btnTabuleiro";
            this.btnTabuleiro.Size = new System.Drawing.Size(140, 42);
            this.btnTabuleiro.TabIndex = 6;
            this.btnTabuleiro.Text = "Ver Tabuleiro";
            this.btnTabuleiro.UseVisualStyleBackColor = false;
            this.btnTabuleiro.Click += new System.EventHandler(this.btnTabuleiro_Click);
            // Game
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.ForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.panelHud);
            this.Controls.Add(this.grpMao);
            this.Controls.Add(this.grpCercados);
            this.Controls.Add(this.grpJogada);
            this.Controls.Add(this.grpTurnoStatus);
            this.Controls.Add(this.grpHistorico);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnTabuleiro);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Game";
            this.Text = "DRAFTOSAURUS - Jogo";
            this.panelHud.ResumeLayout(false);
            this.panelHud.PerformLayout();
            this.grpMao.ResumeLayout(false);
            this.grpCercados.ResumeLayout(false);
            this.grpJogada.ResumeLayout(false);
            this.grpJogada.PerformLayout();
            this.grpTurnoStatus.ResumeLayout(false);
            this.grpHistorico.ResumeLayout(false);
            this.grpHistorico.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Panel panelHud;
        private System.Windows.Forms.Label lblPlayerLabel;
        private System.Windows.Forms.Label lblPlayerVal;
        private System.Windows.Forms.Label lblTurnoLabel;
        private System.Windows.Forms.Label lblTurnoVal;
        private System.Windows.Forms.Label lblDadoLabel;
        private System.Windows.Forms.Label lblDadoVal;
        private System.Windows.Forms.Label lblJogadorDadoLabel;
        private System.Windows.Forms.Label lblJogadorDadoVal;
        private System.Windows.Forms.GroupBox grpMao;
        private System.Windows.Forms.ListBox lstMao;
        private System.Windows.Forms.GroupBox grpCercados;
        private System.Windows.Forms.ListBox lstCercados;
        private System.Windows.Forms.GroupBox grpJogada;
        private System.Windows.Forms.Label lblDinossauro;
        private System.Windows.Forms.TextBox txtDinossauro;
        private System.Windows.Forms.Label lblCercado;
        private System.Windows.Forms.TextBox txtCercado;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.GroupBox grpTurnoStatus;
        private System.Windows.Forms.ListBox lstTurnoStatus;
        private System.Windows.Forms.GroupBox grpHistorico;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnTabuleiro;
    }
}
