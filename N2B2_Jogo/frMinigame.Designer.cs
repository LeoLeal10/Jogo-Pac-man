namespace N2B2_Jogo
{
    partial class frMinigame
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pomo = new System.Windows.Forms.PictureBox();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.btnVolta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pomo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Yellow;
            this.btnJogar.Image = global::N2B2_Jogo.Properties.Resources.icones_jogar;
            this.btnJogar.Location = new System.Drawing.Point(560, 506);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(164, 77);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pomo
            // 
            this.Pomo.BackColor = System.Drawing.Color.Transparent;
            this.Pomo.Image = global::N2B2_Jogo.Properties.Resources.pomo2_0;
            this.Pomo.Location = new System.Drawing.Point(601, 386);
            this.Pomo.Name = "Pomo";
            this.Pomo.Size = new System.Drawing.Size(81, 77);
            this.Pomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pomo.TabIndex = 3;
            this.Pomo.TabStop = false;
            this.Pomo.Visible = false;
            this.Pomo.Click += new System.EventHandler(this.Pomo_Click_1);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(626, 386);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(0, 25);
            this.lblCronometro.TabIndex = 4;
            this.lblCronometro.Click += new System.EventHandler(this.lblCronometro_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolta.Image = global::N2B2_Jogo.Properties.Resources.icones_saida;
            this.btnVolta.Location = new System.Drawing.Point(12, 507);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(84, 87);
            this.btnVolta.TabIndex = 11;
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // frMinigame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::N2B2_Jogo.Properties.Resources.minigame1_FundoComeco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 614);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.Pomo);
            this.Controls.Add(this.btnJogar);
            this.DoubleBuffered = true;
            this.Name = "frMinigame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pegue o Pomo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMinigame_FormClosing);
            this.Load += new System.EventHandler(this.frMinigame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pomo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Pomo;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer timerCronometro;
        private System.Windows.Forms.Button btnVolta;
    }
}