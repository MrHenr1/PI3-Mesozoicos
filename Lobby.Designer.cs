namespace Mesozoicos
{
    partial class Lobby
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGroupTag = new System.Windows.Forms.Label();
            this.grpListGames = new System.Windows.Forms.GroupBox();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.btnListGame = new System.Windows.Forms.Button();
            this.grpCreateGame = new System.Windows.Forms.GroupBox();
            this.lblCreateGameName = new System.Windows.Forms.Label();
            this.txtNameGame = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.grpJoinGame = new System.Windows.Forms.GroupBox();
            this.lblEntrarID = new System.Windows.Forms.Label();
            this.txtEntrarID = new System.Windows.Forms.TextBox();
            this.lblEntrarSenha = new System.Windows.Forms.Label();
            this.txtEntrarSenha = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.grpListGames.SuspendLayout();
            this.grpCreateGame.SuspendLayout();
            this.grpJoinGame.SuspendLayout();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(560, 45);
            this.lblTitle.Text = "DRAFTOSAURUS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblVersion
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(810, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 17);
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // lblGroupTag
            this.lblGroupTag.AutoSize = true;
            this.lblGroupTag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGroupTag.ForeColor = System.Drawing.Color.White;
            this.lblGroupTag.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupTag.Location = new System.Drawing.Point(810, 28);
            this.lblGroupTag.Name = "lblGroupTag";
            this.lblGroupTag.Size = new System.Drawing.Size(70, 17);
            this.lblGroupTag.Text = "Mesozóicos";
            this.lblGroupTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // grpListGames
            this.grpListGames.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpListGames.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpListGames.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.grpListGames.Controls.Add(this.listBoxGames);
            this.grpListGames.Controls.Add(this.btnListGame);
            this.grpListGames.Location = new System.Drawing.Point(15, 60);
            this.grpListGames.Name = "grpListGames";
            this.grpListGames.Size = new System.Drawing.Size(270, 440);
            this.grpListGames.TabIndex = 0;
            this.grpListGames.TabStop = false;
            this.grpListGames.Text = "Partidas Disponíveis";
            // listBoxGames
            this.listBoxGames.BackColor = System.Drawing.Color.White;
            this.listBoxGames.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.listBoxGames.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(12, 35);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(246, 340);
            this.listBoxGames.TabIndex = 0;
            // btnListGame
            this.btnListGame.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnListGame.ForeColor = System.Drawing.Color.White;
            this.btnListGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListGame.FlatAppearance.BorderSize = 0;
            this.btnListGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListGame.Location = new System.Drawing.Point(12, 385);
            this.btnListGame.Name = "btnListGame";
            this.btnListGame.Size = new System.Drawing.Size(246, 42);
            this.btnListGame.TabIndex = 1;
            this.btnListGame.Text = "Atualizar Lista";
            this.btnListGame.UseVisualStyleBackColor = false;
            this.btnListGame.Click += new System.EventHandler(this.btnListGame_Click);
            // grpCreateGame
            this.grpCreateGame.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpCreateGame.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpCreateGame.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.grpCreateGame.Controls.Add(this.lblCreateGameName);
            this.grpCreateGame.Controls.Add(this.txtNameGame);
            this.grpCreateGame.Controls.Add(this.lblPassword);
            this.grpCreateGame.Controls.Add(this.txtPassword);
            this.grpCreateGame.Controls.Add(this.lblGroupName);
            this.grpCreateGame.Controls.Add(this.txtGroupName);
            this.grpCreateGame.Controls.Add(this.btnCreateGame);
            this.grpCreateGame.Location = new System.Drawing.Point(300, 60);
            this.grpCreateGame.Name = "grpCreateGame";
            this.grpCreateGame.Size = new System.Drawing.Size(260, 440);
            this.grpCreateGame.TabIndex = 1;
            this.grpCreateGame.TabStop = false;
            this.grpCreateGame.Text = "Criar Partida";
            // lblCreateGameName
            this.lblCreateGameName.AutoSize = true;
            this.lblCreateGameName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreateGameName.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblCreateGameName.Location = new System.Drawing.Point(12, 40);
            this.lblCreateGameName.Name = "lblCreateGameName";
            this.lblCreateGameName.Size = new System.Drawing.Size(100, 17);
            this.lblCreateGameName.Text = "Nome da Partida:";
            // txtNameGame
            this.txtNameGame.BackColor = System.Drawing.Color.White;
            this.txtNameGame.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtNameGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNameGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameGame.Location = new System.Drawing.Point(15, 62);
            this.txtNameGame.Name = "txtNameGame";
            this.txtNameGame.Size = new System.Drawing.Size(230, 26);
            this.txtNameGame.TabIndex = 0;
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblPassword.Location = new System.Drawing.Point(12, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 17);
            this.lblPassword.Text = "Senha:";
            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(15, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 26);
            this.txtPassword.TabIndex = 1;
            // lblGroupName
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGroupName.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblGroupName.Location = new System.Drawing.Point(12, 160);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(90, 17);
            this.lblGroupName.Text = "Nome do Grupo:";
            // txtGroupName
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtGroupName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Location = new System.Drawing.Point(15, 182);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(230, 26);
            this.txtGroupName.TabIndex = 2;
            this.txtGroupName.Text = "Mesozóicos";
            // btnCreateGame
            this.btnCreateGame.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnCreateGame.ForeColor = System.Drawing.Color.White;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGame.FlatAppearance.BorderSize = 0;
            this.btnCreateGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGame.Location = new System.Drawing.Point(15, 385);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(230, 42);
            this.btnCreateGame.TabIndex = 3;
            this.btnCreateGame.Text = "Criar Partida";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // grpJoinGame
            this.grpJoinGame.BackColor = System.Drawing.Color.FromArgb(250, 237, 205);
            this.grpJoinGame.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.grpJoinGame.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.grpJoinGame.Controls.Add(this.lblEntrarID);
            this.grpJoinGame.Controls.Add(this.txtEntrarID);
            this.grpJoinGame.Controls.Add(this.lblEntrarSenha);
            this.grpJoinGame.Controls.Add(this.txtEntrarSenha);
            this.grpJoinGame.Controls.Add(this.lblNomeUsuario);
            this.grpJoinGame.Controls.Add(this.txtNomeJogador);
            this.grpJoinGame.Controls.Add(this.btnEntrarPartida);
            this.grpJoinGame.Location = new System.Drawing.Point(575, 60);
            this.grpJoinGame.Name = "grpJoinGame";
            this.grpJoinGame.Size = new System.Drawing.Size(310, 440);
            this.grpJoinGame.TabIndex = 2;
            this.grpJoinGame.TabStop = false;
            this.grpJoinGame.Text = "Entrar na Partida";
            // lblEntrarID
            this.lblEntrarID.AutoSize = true;
            this.lblEntrarID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEntrarID.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblEntrarID.Location = new System.Drawing.Point(12, 40);
            this.lblEntrarID.Name = "lblEntrarID";
            this.lblEntrarID.Size = new System.Drawing.Size(80, 17);
            this.lblEntrarID.Text = "ID da Partida:";
            // txtEntrarID
            this.txtEntrarID.BackColor = System.Drawing.Color.White;
            this.txtEntrarID.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtEntrarID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEntrarID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrarID.Location = new System.Drawing.Point(15, 62);
            this.txtEntrarID.Name = "txtEntrarID";
            this.txtEntrarID.Size = new System.Drawing.Size(280, 26);
            this.txtEntrarID.TabIndex = 0;
            // lblEntrarSenha
            this.lblEntrarSenha.AutoSize = true;
            this.lblEntrarSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEntrarSenha.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblEntrarSenha.Location = new System.Drawing.Point(12, 100);
            this.lblEntrarSenha.Name = "lblEntrarSenha";
            this.lblEntrarSenha.Size = new System.Drawing.Size(50, 17);
            this.lblEntrarSenha.Text = "Senha:";
            // txtEntrarSenha
            this.txtEntrarSenha.BackColor = System.Drawing.Color.White;
            this.txtEntrarSenha.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtEntrarSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEntrarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrarSenha.Location = new System.Drawing.Point(15, 122);
            this.txtEntrarSenha.Name = "txtEntrarSenha";
            this.txtEntrarSenha.Size = new System.Drawing.Size(280, 26);
            this.txtEntrarSenha.TabIndex = 1;
            // lblNomeUsuario
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.lblNomeUsuario.Location = new System.Drawing.Point(12, 160);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(100, 17);
            this.lblNomeUsuario.Text = "Seu Nome:";
            // txtNomeJogador
            this.txtNomeJogador.BackColor = System.Drawing.Color.White;
            this.txtNomeJogador.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10);
            this.txtNomeJogador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeJogador.Location = new System.Drawing.Point(15, 182);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(280, 26);
            this.txtNomeJogador.TabIndex = 2;
            // btnEntrarPartida
            this.btnEntrarPartida.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.Location = new System.Drawing.Point(15, 385);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(280, 42);
            this.btnEntrarPartida.TabIndex = 3;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // Lobby
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.ForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGroupTag);
            this.Controls.Add(this.grpListGames);
            this.Controls.Add(this.grpCreateGame);
            this.Controls.Add(this.grpJoinGame);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Lobby";
            this.Text = "DRAFTOSAURUS - Lobby";
            this.grpListGames.ResumeLayout(false);
            this.grpCreateGame.ResumeLayout(false);
            this.grpCreateGame.PerformLayout();
            this.grpJoinGame.ResumeLayout(false);
            this.grpJoinGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGroupTag;
        private System.Windows.Forms.GroupBox grpListGames;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button btnListGame;
        private System.Windows.Forms.GroupBox grpCreateGame;
        private System.Windows.Forms.Label lblCreateGameName;
        private System.Windows.Forms.TextBox txtNameGame;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.GroupBox grpJoinGame;
        private System.Windows.Forms.Label lblEntrarID;
        private System.Windows.Forms.TextBox txtEntrarID;
        private System.Windows.Forms.Label lblEntrarSenha;
        private System.Windows.Forms.TextBox txtEntrarSenha;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
    }
}
