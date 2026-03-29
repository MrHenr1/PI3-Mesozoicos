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
            this.SuspendLayout();
            // 
            // btnExibeMao
            // 
            this.btnExibeMao.Location = new System.Drawing.Point(12, 355);
            this.btnExibeMao.Name = "btnExibeMao";
            this.btnExibeMao.Size = new System.Drawing.Size(107, 30);
            this.btnExibeMao.TabIndex = 1;
            this.btnExibeMao.Text = "Exibir Mão";
            this.btnExibeMao.UseVisualStyleBackColor = true;
            this.btnExibeMao.Click += new System.EventHandler(this.btnExibeMao_Click);
            // 
            // lblPlayerDice
            // 
            this.lblPlayerDice.AutoSize = true;
            this.lblPlayerDice.Location = new System.Drawing.Point(582, 9);
            this.lblPlayerDice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerDice.Name = "lblPlayerDice";
            this.lblPlayerDice.Size = new System.Drawing.Size(95, 13);
            this.lblPlayerDice.TabIndex = 2;
            this.lblPlayerDice.Text = "Jogador com dado";
            // 
            // lblPlayerDiceData
            // 
            this.lblPlayerDiceData.AutoSize = true;
            this.lblPlayerDiceData.Location = new System.Drawing.Point(680, 9);
            this.lblPlayerDiceData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerDiceData.Name = "lblPlayerDiceData";
            this.lblPlayerDiceData.Size = new System.Drawing.Size(103, 13);
            this.lblPlayerDiceData.TabIndex = 3;
            this.lblPlayerDiceData.Text = "{Jogador com dado}";
            // 
            // lblDiceData
            // 
            this.lblDiceData.AutoSize = true;
            this.lblDiceData.Location = new System.Drawing.Point(680, 33);
            this.lblDiceData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiceData.Name = "lblDiceData";
            this.lblDiceData.Size = new System.Drawing.Size(39, 13);
            this.lblDiceData.TabIndex = 5;
            this.lblDiceData.Text = "{dado}";
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Location = new System.Drawing.Point(582, 33);
            this.lblDice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(33, 13);
            this.lblDice.TabIndex = 4;
            this.lblDice.Text = "Dado";
            // 
            // btnUpdateScreen
            // 
            this.btnUpdateScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateScreen.Location = new System.Drawing.Point(697, 411);
            this.btnUpdateScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateScreen.Name = "btnUpdateScreen";
            this.btnUpdateScreen.Size = new System.Drawing.Size(86, 31);
            this.btnUpdateScreen.TabIndex = 6;
            this.btnUpdateScreen.Text = "Atualizar tela";
            this.btnUpdateScreen.UseVisualStyleBackColor = false;
            this.btnUpdateScreen.Click += new System.EventHandler(this.btnUpdateScreen_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(680, 58);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(39, 13);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "{turno}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turno";
            // 
            // lstBoxExibeMao
            // 
            this.lstBoxExibeMao.FormattingEnabled = true;
            this.lstBoxExibeMao.Location = new System.Drawing.Point(12, 12);
            this.lstBoxExibeMao.Name = "lstBoxExibeMao";
            this.lstBoxExibeMao.Size = new System.Drawing.Size(112, 329);
            this.lstBoxExibeMao.TabIndex = 9;
            // 
            // lstBoxCercados
            // 
            this.lstBoxCercados.FormattingEnabled = true;
            this.lstBoxCercados.Location = new System.Drawing.Point(130, 12);
            this.lstBoxCercados.Name = "lstBoxCercados";
            this.lstBoxCercados.Size = new System.Drawing.Size(182, 329);
            this.lstBoxCercados.TabIndex = 10;
            // 
            // btnExibeCercados
            // 
            this.btnExibeCercados.Location = new System.Drawing.Point(158, 355);
            this.btnExibeCercados.Name = "btnExibeCercados";
            this.btnExibeCercados.Size = new System.Drawing.Size(107, 30);
            this.btnExibeCercados.TabIndex = 11;
            this.btnExibeCercados.Text = "Exibir Cercados";
            this.btnExibeCercados.UseVisualStyleBackColor = true;
            this.btnExibeCercados.Click += new System.EventHandler(this.btnExibeCercados_Click);
            // 
            // btnLancaJogada
            // 
            this.btnLancaJogada.Location = new System.Drawing.Point(399, 167);
            this.btnLancaJogada.Name = "btnLancaJogada";
            this.btnLancaJogada.Size = new System.Drawing.Size(107, 30);
            this.btnLancaJogada.TabIndex = 12;
            this.btnLancaJogada.Text = "Lançar Jogada";
            this.btnLancaJogada.UseVisualStyleBackColor = true;
            this.btnLancaJogada.Click += new System.EventHandler(this.btnLancaJogada_Click);
            // 
            // txtBoxDinossauros
            // 
            this.txtBoxDinossauros.Location = new System.Drawing.Point(339, 130);
            this.txtBoxDinossauros.Name = "txtBoxDinossauros";
            this.txtBoxDinossauros.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDinossauros.TabIndex = 13;
            // 
            // txtBoxCercado
            // 
            this.txtBoxCercado.Location = new System.Drawing.Point(456, 130);
            this.txtBoxCercado.Name = "txtBoxCercado";
            this.txtBoxCercado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCercado.TabIndex = 14;
            // 
            // lblDinossauro
            // 
            this.lblDinossauro.AutoSize = true;
            this.lblDinossauro.Location = new System.Drawing.Point(336, 114);
            this.lblDinossauro.Name = "lblDinossauro";
            this.lblDinossauro.Size = new System.Drawing.Size(60, 13);
            this.lblDinossauro.TabIndex = 15;
            this.lblDinossauro.Text = "Dinossauro";
            // 
            // lblCercado
            // 
            this.lblCercado.AutoSize = true;
            this.lblCercado.Location = new System.Drawing.Point(453, 114);
            this.lblCercado.Name = "lblCercado";
            this.lblCercado.Size = new System.Drawing.Size(47, 13);
            this.lblCercado.TabIndex = 16;
            this.lblCercado.Text = "Cercado";
            // 
            // lblResulta
            // 
            this.lblResulta.AutoSize = true;
            this.lblResulta.Location = new System.Drawing.Point(637, 231);
            this.lblResulta.Name = "lblResulta";
            this.lblResulta.Size = new System.Drawing.Size(35, 13);
            this.lblResulta.TabIndex = 17;
            this.lblResulta.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}