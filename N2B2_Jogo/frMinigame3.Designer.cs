namespace N2B2_Jogo
{
    partial class frMinigame3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.pbVidaJogador = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.llDinheiro = new System.Windows.Forms.Label();
            this.pbEasterEgg = new System.Windows.Forms.PictureBox();
            this.pbBoss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasterEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVida
            // 
            this.pbVida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbVida.Location = new System.Drawing.Point(557, 561);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(376, 23);
            this.pbVida.Step = -10;
            this.pbVida.TabIndex = 1;
            this.pbVida.Value = 100;
            // 
            // timerJogo
            // 
            this.timerJogo.Interval = 200;
            this.timerJogo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbVidaJogador
            // 
            this.pbVidaJogador.Location = new System.Drawing.Point(24, 506);
            this.pbVidaJogador.Name = "pbVidaJogador";
            this.pbVidaJogador.Size = new System.Drawing.Size(376, 23);
            this.pbVidaJogador.Step = -10;
            this.pbVidaJogador.TabIndex = 2;
            this.pbVidaJogador.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(352, 369);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 68);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Começar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.Location = new System.Drawing.Point(24, 369);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(75, 68);
            this.btnLoja.TabIndex = 8;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // llDinheiro
            // 
            this.llDinheiro.AutoSize = true;
            this.llDinheiro.Location = new System.Drawing.Point(24, 350);
            this.llDinheiro.Name = "llDinheiro";
            this.llDinheiro.Size = new System.Drawing.Size(0, 13);
            this.llDinheiro.TabIndex = 9;
            // 
            // pbEasterEgg
            // 
            this.pbEasterEgg.Location = new System.Drawing.Point(27, 562);
            this.pbEasterEgg.Name = "pbEasterEgg";
            this.pbEasterEgg.Size = new System.Drawing.Size(72, 50);
            this.pbEasterEgg.TabIndex = 10;
            this.pbEasterEgg.TabStop = false;
            this.pbEasterEgg.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbBoss
            // 
            this.pbBoss.Image = global::N2B2_Jogo.Properties.Resources.Captura_de_tela_2020_11_04_124826;
            this.pbBoss.InitialImage = global::N2B2_Jogo.Properties.Resources.Captura_de_tela_2020_11_04_124826;
            this.pbBoss.Location = new System.Drawing.Point(433, 34);
            this.pbBoss.Name = "pbBoss";
            this.pbBoss.Size = new System.Drawing.Size(598, 521);
            this.pbBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBoss.TabIndex = 0;
            this.pbBoss.TabStop = false;
            this.pbBoss.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frMinigame3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 624);
            this.Controls.Add(this.pbEasterEgg);
            this.Controls.Add(this.llDinheiro);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbVidaJogador);
            this.Controls.Add(this.pbVida);
            this.Controls.Add(this.pbBoss);
            this.DoubleBuffered = true;
            this.Name = "frMinigame3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Clicar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMinigame3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMinigame3_FormClosed);
            this.Load += new System.EventHandler(this.frJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEasterEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBoss;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.ProgressBar pbVidaJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Label llDinheiro;
        private System.Windows.Forms.PictureBox pbEasterEgg;
    }
}