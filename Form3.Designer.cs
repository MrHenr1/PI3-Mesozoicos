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
            this.txtBoxMaoJogador = new System.Windows.Forms.TextBox();
            this.btnExibeMao = new System.Windows.Forms.Button();
            this.lblPlayerDice = new System.Windows.Forms.Label();
            this.lblPlayerDiceData = new System.Windows.Forms.Label();
            this.lblDiceData = new System.Windows.Forms.Label();
            this.lblDice = new System.Windows.Forms.Label();
            this.btnUpdateScreen = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxMaoJogador
            // 
            this.txtBoxMaoJogador.Location = new System.Drawing.Point(18, 18);
            this.txtBoxMaoJogador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxMaoJogador.Multiline = true;
            this.txtBoxMaoJogador.Name = "txtBoxMaoJogador";
            this.txtBoxMaoJogador.Size = new System.Drawing.Size(272, 516);
            this.txtBoxMaoJogador.TabIndex = 0;
            // 
            // btnExibeMao
            // 
            this.btnExibeMao.Location = new System.Drawing.Point(18, 546);
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
            this.lblPlayerDice.Location = new System.Drawing.Point(309, 18);
            this.lblPlayerDice.Name = "lblPlayerDice";
            this.lblPlayerDice.Size = new System.Drawing.Size(141, 20);
            this.lblPlayerDice.TabIndex = 2;
            this.lblPlayerDice.Text = "Jogador com dado";
            // 
            // lblPlayerDiceData
            // 
            this.lblPlayerDiceData.AutoSize = true;
            this.lblPlayerDiceData.Location = new System.Drawing.Point(456, 18);
            this.lblPlayerDiceData.Name = "lblPlayerDiceData";
            this.lblPlayerDiceData.Size = new System.Drawing.Size(151, 20);
            this.lblPlayerDiceData.TabIndex = 3;
            this.lblPlayerDiceData.Text = "{Jogador com dado}";
            // 
            // lblDiceData
            // 
            this.lblDiceData.AutoSize = true;
            this.lblDiceData.Location = new System.Drawing.Point(456, 55);
            this.lblDiceData.Name = "lblDiceData";
            this.lblDiceData.Size = new System.Drawing.Size(83, 30);
            this.lblDiceData.TabIndex = 5;
            this.lblDiceData.Text = "{dado}";
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Location = new System.Drawing.Point(309, 55);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(72, 30);
            this.lblDice.TabIndex = 4;
            this.lblDice.Text = "Dado";
            // 
            // btnUpdateScreen
            // 
            this.btnUpdateScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateScreen.Location = new System.Drawing.Point(1046, 633);
            this.btnUpdateScreen.Name = "btnUpdateScreen";
            this.btnUpdateScreen.Size = new System.Drawing.Size(129, 47);
            this.btnUpdateScreen.TabIndex = 6;
            this.btnUpdateScreen.Text = "Atualizar tela";
            this.btnUpdateScreen.UseVisualStyleBackColor = false;
            this.btnUpdateScreen.Click += new System.EventHandler(this.btnUpdateScreen_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(456, 94);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(84, 30);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "{turno}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turno";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateScreen);
            this.Controls.Add(this.lblDiceData);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.lblPlayerDiceData);
            this.Controls.Add(this.lblPlayerDice);
            this.Controls.Add(this.btnExibeMao);
            this.Controls.Add(this.txtBoxMaoJogador);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMaoJogador;
        private System.Windows.Forms.Button btnExibeMao;
        private System.Windows.Forms.Label lblPlayerDice;
        private System.Windows.Forms.Label lblPlayerDiceData;
        private System.Windows.Forms.Label lblDiceData;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Button btnUpdateScreen;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label label2;
    }
}