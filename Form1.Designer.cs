namespace Mesozoicos {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnListGame = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionLabel = new System.Windows.Forms.Label();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.txtNameGame = new System.Windows.Forms.TextBox();
            this.lblCreateGameName = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.textResultGame = new System.Windows.Forms.TextBox();
            this.txtBoxPlayerInfo = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtEntrarID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrarSenha = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblListaDeJogos = new System.Windows.Forms.Label();
            this.lblStatusCriacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListGame
            // 
            this.btnListGame.Location = new System.Drawing.Point(12, 322);
            this.btnListGame.Name = "btnListGame";
            this.btnListGame.Size = new System.Drawing.Size(91, 50);
            this.btnListGame.TabIndex = 0;
            this.btnListGame.Text = "Listar Jogos";
            this.btnListGame.UseVisualStyleBackColor = true;
            this.btnListGame.Click += new System.EventHandler(this.btnListGame_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(712, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblVersionLabel
            // 
            this.lblVersionLabel.AutoSize = true;
            this.lblVersionLabel.Location = new System.Drawing.Point(671, 9);
            this.lblVersionLabel.Name = "lblVersionLabel";
            this.lblVersionLabel.Size = new System.Drawing.Size(43, 13);
            this.lblVersionLabel.TabIndex = 2;
            this.lblVersionLabel.Text = "Versão:";
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(12, 52);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(192, 264);
            this.listBoxGames.TabIndex = 4;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.Location = new System.Drawing.Point(671, 31);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(63, 13);
            this.lblNameGroup.TabIndex = 5;
            this.lblNameGroup.Text = "Mesozóicos";
            // 
            // txtNameGame
            // 
            this.txtNameGame.Location = new System.Drawing.Point(323, 79);
            this.txtNameGame.Name = "txtNameGame";
            this.txtNameGame.Size = new System.Drawing.Size(100, 20);
            this.txtNameGame.TabIndex = 6;
            // 
            // lblCreateGameName
            // 
            this.lblCreateGameName.AutoSize = true;
            this.lblCreateGameName.Location = new System.Drawing.Point(320, 63);
            this.lblCreateGameName.Name = "lblCreateGameName";
            this.lblCreateGameName.Size = new System.Drawing.Size(86, 13);
            this.lblCreateGameName.TabIndex = 7;
            this.lblCreateGameName.Text = "Nome da Partida";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(323, 228);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(92, 50);
            this.btnCreateGame.TabIndex = 8;
            this.btnCreateGame.Text = "Criar Partida";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(323, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(323, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(320, 166);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(82, 13);
            this.lblGroupName.TabIndex = 11;
            this.lblGroupName.Text = "Nome do Grupo";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(323, 182);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(100, 20);
            this.txtGroupName.TabIndex = 12;
            this.txtGroupName.Text = "Mesozóicos";
            // 
            // textResultGame
            // 
            this.textResultGame.Location = new System.Drawing.Point(223, 57);
            this.textResultGame.Multiline = true;
            this.textResultGame.Name = "textResultGame";
            this.textResultGame.ReadOnly = true;
            this.textResultGame.Size = new System.Drawing.Size(94, 264);
            this.textResultGame.TabIndex = 13;
            // 
            // txtBoxPlayerInfo
            // 
            this.txtBoxPlayerInfo.Location = new System.Drawing.Point(660, 79);
            this.txtBoxPlayerInfo.Multiline = true;
            this.txtBoxPlayerInfo.Name = "txtBoxPlayerInfo";
            this.txtBoxPlayerInfo.ReadOnly = true;
            this.txtBoxPlayerInfo.Size = new System.Drawing.Size(128, 194);
            this.txtBoxPlayerInfo.TabIndex = 21;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(473, 228);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(92, 50);
            this.btnEntrarPartida.TabIndex = 14;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtEntrarID
            // 
            this.txtEntrarID.Location = new System.Drawing.Point(473, 79);
            this.txtEntrarID.Name = "txtEntrarID";
            this.txtEntrarID.Size = new System.Drawing.Size(100, 20);
            this.txtEntrarID.TabIndex = 15;
            this.txtEntrarID.TextChanged += new System.EventHandler(this.txtEntrarID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID da Partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Senha:";
            // 
            // txtEntrarSenha
            // 
            this.txtEntrarSenha.Location = new System.Drawing.Point(473, 132);
            this.txtEntrarSenha.Name = "txtEntrarSenha";
            this.txtEntrarSenha.Size = new System.Drawing.Size(100, 20);
            this.txtEntrarSenha.TabIndex = 18;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(473, 166);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNomeUsuario.TabIndex = 19;
            this.lblNomeUsuario.Text = "Usuario:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(473, 182);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJogador.TabIndex = 20;
            // 
            // lblListaDeJogos
            // 
            this.lblListaDeJogos.AutoSize = true;
            this.lblListaDeJogos.Location = new System.Drawing.Point(12, 31);
            this.lblListaDeJogos.Name = "lblListaDeJogos";
            this.lblListaDeJogos.Size = new System.Drawing.Size(77, 13);
            this.lblListaDeJogos.TabIndex = 22;
            this.lblListaDeJogos.Text = "Lista De Jogos";
            // 
            // lblStatusCriacao
            // 
            this.lblStatusCriacao.AutoSize = true;
            this.lblStatusCriacao.Location = new System.Drawing.Point(220, 36);
            this.lblStatusCriacao.Name = "lblStatusCriacao";
            this.lblStatusCriacao.Size = new System.Drawing.Size(91, 13);
            this.lblStatusCriacao.TabIndex = 23;
            this.lblStatusCriacao.Text = "Status de Criação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusCriacao);
            this.Controls.Add(this.lblListaDeJogos);
            this.Controls.Add(this.txtBoxPlayerInfo);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.txtEntrarSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntrarID);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.textResultGame);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lblCreateGameName);
            this.Controls.Add(this.txtNameGame);
            this.Controls.Add(this.lblNameGroup);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.lblVersionLabel);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnListGame);
            this.Name = "Form1";
            this.Text = "3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListGame;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionLabel;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Label lblNameGroup;
        private System.Windows.Forms.TextBox txtNameGame;
        private System.Windows.Forms.Label lblCreateGameName;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox textResultGame;
        private System.Windows.Forms.TextBox txtBoxPlayerInfo;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtEntrarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrarSenha;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblListaDeJogos;
        private System.Windows.Forms.Label lblStatusCriacao;
    }
}

