namespace Mesozoicos {
    partial class Form2 {
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
            this.txtBoxJogadores = new System.Windows.Forms.TextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lblPartidaListar = new System.Windows.Forms.Label();
            this.txtIDListar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidjogador = new System.Windows.Forms.Label();
            this.lblidsenha = new System.Windows.Forms.Label();
            this.lblidpartida = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.Label();
            this.txtIDPartida = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnExibeMao = new System.Windows.Forms.Button();
            this.txtBoxMaoJogador = new System.Windows.Forms.TextBox();
            this.lblPartidaStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxJogadores
            // 
            this.txtBoxJogadores.Location = new System.Drawing.Point(12, 52);
            this.txtBoxJogadores.Multiline = true;
            this.txtBoxJogadores.Name = "txtBoxJogadores";
            this.txtBoxJogadores.Size = new System.Drawing.Size(129, 264);
            this.txtBoxJogadores.TabIndex = 0;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(12, 332);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(114, 37);
            this.btnListarJogadores.TabIndex = 1;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblPartidaListar
            // 
            this.lblPartidaListar.AutoSize = true;
            this.lblPartidaListar.Location = new System.Drawing.Point(12, 7);
            this.lblPartidaListar.Name = "lblPartidaListar";
            this.lblPartidaListar.Size = new System.Drawing.Size(69, 13);
            this.lblPartidaListar.TabIndex = 23;
            this.lblPartidaListar.Text = "ID da Partida";
            this.lblPartidaListar.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIDListar
            // 
            this.txtIDListar.Location = new System.Drawing.Point(12, 23);
            this.txtIDListar.Name = "txtIDListar";
            this.txtIDListar.Size = new System.Drawing.Size(100, 20);
            this.txtIDListar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Jogador";
            // 
            // lblidjogador
            // 
            this.lblidjogador.AutoSize = true;
            this.lblidjogador.Location = new System.Drawing.Point(273, 7);
            this.lblidjogador.Name = "lblidjogador";
            this.lblidjogador.Size = new System.Drawing.Size(58, 13);
            this.lblidjogador.TabIndex = 25;
            this.lblidjogador.Text = "{idjogador}";
            // 
            // lblidsenha
            // 
            this.lblidsenha.AutoSize = true;
            this.lblidsenha.Location = new System.Drawing.Point(273, 30);
            this.lblidsenha.Name = "lblidsenha";
            this.lblidsenha.Size = new System.Drawing.Size(52, 13);
            this.lblidsenha.TabIndex = 26;
            this.lblidsenha.Text = "{idsenha}";
            // 
            // lblidpartida
            // 
            this.lblidpartida.AutoSize = true;
            this.lblidpartida.Location = new System.Drawing.Point(273, 52);
            this.lblidpartida.Name = "lblidpartida";
            this.lblidpartida.Size = new System.Drawing.Size(55, 13);
            this.lblidpartida.TabIndex = 27;
            this.lblidpartida.Text = "{idpartida}";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.AutoSize = true;
            this.txtSenhaJogador.Location = new System.Drawing.Point(198, 30);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(76, 13);
            this.txtSenhaJogador.TabIndex = 28;
            this.txtSenhaJogador.Text = "SenhaJogador";
            // 
            // txtIDPartida
            // 
            this.txtIDPartida.AutoSize = true;
            this.txtIDPartida.Location = new System.Drawing.Point(198, 52);
            this.txtIDPartida.Name = "txtIDPartida";
            this.txtIDPartida.Size = new System.Drawing.Size(54, 13);
            this.txtIDPartida.TabIndex = 29;
            this.txtIDPartida.Text = "ID Partida";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(138, 332);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(114, 37);
            this.btnIniciarPartida.TabIndex = 30;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnExibeMao
            // 
            this.btnExibeMao.Location = new System.Drawing.Point(428, 355);
            this.btnExibeMao.Name = "btnExibeMao";
            this.btnExibeMao.Size = new System.Drawing.Size(107, 30);
            this.btnExibeMao.TabIndex = 32;
            this.btnExibeMao.Text = "Exibir Mão";
            this.btnExibeMao.UseVisualStyleBackColor = true;
            this.btnExibeMao.Click += new System.EventHandler(this.btnExibeMao_Click);
            // 
            // txtBoxMaoJogador
            // 
            this.txtBoxMaoJogador.Location = new System.Drawing.Point(428, 12);
            this.txtBoxMaoJogador.Multiline = true;
            this.txtBoxMaoJogador.Name = "txtBoxMaoJogador";
            this.txtBoxMaoJogador.Size = new System.Drawing.Size(183, 337);
            this.txtBoxMaoJogador.TabIndex = 31;
            // 
            // lblPartidaStatus
            // 
            this.lblPartidaStatus.AutoSize = true;
            this.lblPartidaStatus.Location = new System.Drawing.Point(164, 308);
            this.lblPartidaStatus.Name = "lblPartidaStatus";
            this.lblPartidaStatus.Size = new System.Drawing.Size(35, 13);
            this.lblPartidaStatus.TabIndex = 33;
            this.lblPartidaStatus.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPartidaStatus);
            this.Controls.Add(this.btnExibeMao);
            this.Controls.Add(this.txtBoxMaoJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtIDPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblidpartida);
            this.Controls.Add(this.lblidsenha);
            this.Controls.Add(this.lblidjogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartidaListar);
            this.Controls.Add(this.txtIDListar);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txtBoxJogadores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label lblPartidaListar;
        private System.Windows.Forms.TextBox txtIDListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidjogador;
        private System.Windows.Forms.Label lblidsenha;
        private System.Windows.Forms.Label lblidpartida;
        private System.Windows.Forms.Label txtSenhaJogador;
        private System.Windows.Forms.Label txtIDPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnExibeMao;
        private System.Windows.Forms.TextBox txtBoxMaoJogador;
        private System.Windows.Forms.Label lblPartidaStatus;
    }
}