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
            this.SuspendLayout();
            // 
            // txtBoxMaoJogador
            // 
            this.txtBoxMaoJogador.Location = new System.Drawing.Point(12, 12);
            this.txtBoxMaoJogador.Multiline = true;
            this.txtBoxMaoJogador.Name = "txtBoxMaoJogador";
            this.txtBoxMaoJogador.Size = new System.Drawing.Size(183, 337);
            this.txtBoxMaoJogador.TabIndex = 0;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibeMao);
            this.Controls.Add(this.txtBoxMaoJogador);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMaoJogador;
        private System.Windows.Forms.Button btnExibeMao;
    }
}