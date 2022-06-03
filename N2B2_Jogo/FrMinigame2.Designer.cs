namespace N2B2_Jogo
{
    partial class FrMinigame2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMinigame2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.pbBOT = new System.Windows.Forms.PictureBox();
            this.pbJogador = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faça sua escolha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "VS";
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Black;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJogar.Location = new System.Drawing.Point(147, 444);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(100, 54);
            this.btnJogar.TabIndex = 9;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click_1);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.Black;
            this.btnVolta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolta.Location = new System.Drawing.Point(345, 472);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(59, 38);
            this.btnVolta.TabIndex = 10;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // pbBOT
            // 
            this.pbBOT.Location = new System.Drawing.Point(253, 272);
            this.pbBOT.Name = "pbBOT";
            this.pbBOT.Size = new System.Drawing.Size(100, 100);
            this.pbBOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBOT.TabIndex = 8;
            this.pbBOT.TabStop = false;
            // 
            // pbJogador
            // 
            this.pbJogador.Location = new System.Drawing.Point(43, 272);
            this.pbJogador.Name = "pbJogador";
            this.pbJogador.Size = new System.Drawing.Size(100, 100);
            this.pbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJogador.TabIndex = 5;
            this.pbJogador.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(253, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(147, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(41, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrMinigame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(416, 522);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pbBOT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrMinigame2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.pbBOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBOT;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnVolta;
    }
}