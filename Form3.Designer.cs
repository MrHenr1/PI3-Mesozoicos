namespace Mesozoicos {
    partial class Form3 {
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
            this.btnExibeMao = new System.Windows.Forms.Button();
            this.lblPlayerDice = new System.Windows.Forms.Label();
            this.lblPlayerDiceData = new System.Windows.Forms.Label();
            this.lblDiceData = new System.Windows.Forms.Label();
            this.lblDice = new System.Windows.Forms.Label();
            this.btnUpdateScreen = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxExibeMao = new System.Windows.Forms.ListBox();
            this.lstBoxCercados = new System.Windows.Forms.ListBox();
            this.btnExibeCercados = new System.Windows.Forms.Button();
            this.btnLancaJogada = new System.Windows.Forms.Button();
            this.txtBoxDinossauros = new System.Windows.Forms.TextBox();
            this.txtBoxCercado = new System.Windows.Forms.TextBox();
            this.lblDinossauro = new System.Windows.Forms.Label();
            this.lblCercado = new System.Windows.Forms.Label();
            this.lblResulta = new System.Windows.Forms.Label();
            this.lblpasswordId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblActualPlayer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowTabuleiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibeMao
            // 
            this.btnExibeMao.Location = new System.Drawing.Point(294, 14);
            this.btnExibeMao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExibeMao.Name = "btnExibeMao";
            this.btnExibeMao.Size = new System.Drawing.Size(160, 46);
            this.btnExibeMao.TabIndex = 1;
            this.btnExibeMao.Text = "Exibir Mão";
            this.btnExibeMao.UseVisualStyleBackColor = true;
            this.btnExibeMao.Click += new System.EventHandler(this.btnExibeMao_Click);
            // 
            // lblPlayerDice
            // 
            this.lblPlayerDice.AutoSize = true;
            this.lblPlayerDice.Location = new System.Drawing.Point(873, 14);
            this.lblPlayerDice.Name = "lblPlayerDice";
            this.lblPlayerDice.Size = new System.Drawing.Size(141, 20);
            this.lblPlayerDice.TabIndex = 2;
            this.lblPlayerDice.Text = "Jogador com dado";
            // 
            // lblPlayerDiceData
            // 
            this.lblPlayerDiceData.AutoSize = true;
            this.lblPlayerDiceData.Location = new System.Drawing.Point(1020, 14);
            this.lblPlayerDiceData.Name = "lblPlayerDiceData";
            this.lblPlayerDiceData.Size = new System.Drawing.Size(151, 20);
            this.lblPlayerDiceData.TabIndex = 3;
            this.lblPlayerDiceData.Text = "{Jogador com dado}";
            // 
            // lblDiceData
            // 
            this.lblDiceData.AutoSize = true;
            this.lblDiceData.Location = new System.Drawing.Point(1020, 51);
            this.lblDiceData.Name = "lblDiceData";
            this.lblDiceData.Size = new System.Drawing.Size(55, 20);
            this.lblDiceData.TabIndex = 5;
            this.lblDiceData.Text = "{dado}";
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Location = new System.Drawing.Point(873, 51);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(48, 20);
            this.lblDice.TabIndex = 4;
            this.lblDice.Text = "Dado";
            // 
            // btnUpdateScreen
            // 
            this.btnUpdateScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateScreen.Location = new System.Drawing.Point(1046, 632);
            this.btnUpdateScreen.Name = "btnUpdateScreen";
            this.btnUpdateScreen.Size = new System.Drawing.Size(129, 48);
            this.btnUpdateScreen.TabIndex = 6;
            this.btnUpdateScreen.Text = "Atualizar tela";
            this.btnUpdateScreen.UseVisualStyleBackColor = false;
            this.btnUpdateScreen.Click += new System.EventHandler(this.btnUpdateScreen_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(1020, 89);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(56, 20);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "{turno}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turno";
            // 
            // lstBoxExibeMao
            // 
            this.lstBoxExibeMao.FormattingEnabled = true;
            this.lstBoxExibeMao.ItemHeight = 20;
            this.lstBoxExibeMao.Location = new System.Drawing.Point(13, 14);
            this.lstBoxExibeMao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxExibeMao.Name = "lstBoxExibeMao";
            this.lstBoxExibeMao.Size = new System.Drawing.Size(273, 224);
            this.lstBoxExibeMao.TabIndex = 9;
            this.lstBoxExibeMao.SelectedIndexChanged += new System.EventHandler(this.lstBoxExibeMao_SelectedIndexChanged);
            // 
            // lstBoxCercados
            // 
            this.lstBoxCercados.FormattingEnabled = true;
            this.lstBoxCercados.ItemHeight = 20;
            this.lstBoxCercados.Location = new System.Drawing.Point(13, 248);
            this.lstBoxCercados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxCercados.Name = "lstBoxCercados";
            this.lstBoxCercados.Size = new System.Drawing.Size(273, 224);
            this.lstBoxCercados.TabIndex = 10;
            this.lstBoxCercados.SelectedIndexChanged += new System.EventHandler(this.lstBoxCercados_SelectedIndexChanged);
            // 
            // btnExibeCercados
            // 
            this.btnExibeCercados.Location = new System.Drawing.Point(294, 248);
            this.btnExibeCercados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExibeCercados.Name = "btnExibeCercados";
            this.btnExibeCercados.Size = new System.Drawing.Size(160, 46);
            this.btnExibeCercados.TabIndex = 11;
            this.btnExibeCercados.Text = "Exibir Cercados";
            this.btnExibeCercados.UseVisualStyleBackColor = true;
            this.btnExibeCercados.Click += new System.EventHandler(this.btnExibeCercados_Click);
            // 
            // btnLancaJogada
            // 
            this.btnLancaJogada.Location = new System.Drawing.Point(598, 257);
            this.btnLancaJogada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLancaJogada.Name = "btnLancaJogada";
            this.btnLancaJogada.Size = new System.Drawing.Size(160, 46);
            this.btnLancaJogada.TabIndex = 12;
            this.btnLancaJogada.Text = "Lançar Jogada";
            this.btnLancaJogada.UseVisualStyleBackColor = true;
            this.btnLancaJogada.Click += new System.EventHandler(this.btnLancaJogada_Click);
            // 
            // txtBoxDinossauros
            // 
            this.txtBoxDinossauros.Location = new System.Drawing.Point(508, 200);
            this.txtBoxDinossauros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDinossauros.Name = "txtBoxDinossauros";
            this.txtBoxDinossauros.ReadOnly = true;
            this.txtBoxDinossauros.Size = new System.Drawing.Size(148, 26);
            this.txtBoxDinossauros.TabIndex = 13;
            // 
            // txtBoxCercado
            // 
            this.txtBoxCercado.Location = new System.Drawing.Point(684, 200);
            this.txtBoxCercado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCercado.Name = "txtBoxCercado";
            this.txtBoxCercado.ReadOnly = true;
            this.txtBoxCercado.Size = new System.Drawing.Size(148, 26);
            this.txtBoxCercado.TabIndex = 14;
            // 
            // lblDinossauro
            // 
            this.lblDinossauro.AutoSize = true;
            this.lblDinossauro.Location = new System.Drawing.Point(504, 175);
            this.lblDinossauro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDinossauro.Name = "lblDinossauro";
            this.lblDinossauro.Size = new System.Drawing.Size(90, 20);
            this.lblDinossauro.TabIndex = 15;
            this.lblDinossauro.Text = "Dinossauro";
            // 
            // lblCercado
            // 
            this.lblCercado.AutoSize = true;
            this.lblCercado.Location = new System.Drawing.Point(680, 175);
            this.lblCercado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCercado.Name = "lblCercado";
            this.lblCercado.Size = new System.Drawing.Size(69, 20);
            this.lblCercado.TabIndex = 16;
            this.lblCercado.Text = "Cercado";
            // 
            // lblResulta
            // 
            this.lblResulta.AutoSize = true;
            this.lblResulta.Location = new System.Drawing.Point(956, 355);
            this.lblResulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResulta.Name = "lblResulta";
            this.lblResulta.Size = new System.Drawing.Size(51, 20);
            this.lblResulta.TabIndex = 17;
            this.lblResulta.Text = "label1";
            // 
            // lblpasswordId
            // 
            this.lblpasswordId.AutoSize = true;
            this.lblpasswordId.Location = new System.Drawing.Point(159, 583);
            this.lblpasswordId.Name = "lblpasswordId";
            this.lblpasswordId.Size = new System.Drawing.Size(152, 30);
            this.lblpasswordId.TabIndex = 23;
            this.lblpasswordId.Text = "{passwordId}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID Senha";
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Location = new System.Drawing.Point(159, 545);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(113, 30);
            this.lblPlayerId.TabIndex = 21;
            this.lblPlayerId.Text = "{playerId}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Jogador";
            // 
            // lblActualPlayer
            // 
            this.lblActualPlayer.AutoSize = true;
            this.lblActualPlayer.Location = new System.Drawing.Point(159, 508);
            this.lblActualPlayer.Name = "lblActualPlayer";
            this.lblActualPlayer.Size = new System.Drawing.Size(171, 30);
            this.lblActualPlayer.TabIndex = 19;
            this.lblActualPlayer.Text = "{JogadorAtual}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Jogador atual: ";
            // 
            // btnShowTabuleiro
            // 
            this.btnShowTabuleiro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnShowTabuleiro.Location = new System.Drawing.Point(913, 632);
            this.btnShowTabuleiro.Name = "btnShowTabuleiro";
            this.btnShowTabuleiro.Size = new System.Drawing.Size(127, 48);
            this.btnShowTabuleiro.TabIndex = 24;
            this.btnShowTabuleiro.Text = "Exibir Tabueiro";
            this.btnShowTabuleiro.UseVisualStyleBackColor = false;
            this.btnShowTabuleiro.Click += new System.EventHandler(this.btnShowTabuleiro_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnShowTabuleiro);
            this.Controls.Add(this.lblpasswordId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblActualPlayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblResulta);
            this.Controls.Add(this.lblCercado);
            this.Controls.Add(this.lblDinossauro);
            this.Controls.Add(this.txtBoxCercado);
            this.Controls.Add(this.txtBoxDinossauros);
            this.Controls.Add(this.btnLancaJogada);
            this.Controls.Add(this.btnExibeCercados);
            this.Controls.Add(this.lstBoxCercados);
            this.Controls.Add(this.lstBoxExibeMao);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateScreen);
            this.Controls.Add(this.lblDiceData);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.lblPlayerDiceData);
            this.Controls.Add(this.lblPlayerDice);
            this.Controls.Add(this.btnExibeMao);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExibeMao;
        private System.Windows.Forms.Label lblPlayerDice;
        private System.Windows.Forms.Label lblPlayerDiceData;
        private System.Windows.Forms.Label lblDiceData;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Button btnUpdateScreen;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxExibeMao;
        private System.Windows.Forms.ListBox lstBoxCercados;
        private System.Windows.Forms.Button btnExibeCercados;
        private System.Windows.Forms.Button btnLancaJogada;
        private System.Windows.Forms.TextBox txtBoxDinossauros;
        private System.Windows.Forms.TextBox txtBoxCercado;
        private System.Windows.Forms.Label lblDinossauro;
        private System.Windows.Forms.Label lblCercado;
        private System.Windows.Forms.Label lblResulta;
        private System.Windows.Forms.Label lblpasswordId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblActualPlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowTabuleiro;
    }
}