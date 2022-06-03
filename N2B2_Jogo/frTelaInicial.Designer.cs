namespace N2B2_Jogo
{
    partial class frTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTelaInicial));
            this.brnSobre = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnMinigame = new System.Windows.Forms.Button();
            this.BtnOpcoes = new System.Windows.Forms.Button();
            this.btnRecordes = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // brnSobre
            // 
            this.brnSobre.BackColor = System.Drawing.Color.Yellow;
            this.brnSobre.Image = ((System.Drawing.Image)(resources.GetObject("brnSobre.Image")));
            this.brnSobre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brnSobre.Location = new System.Drawing.Point(695, 591);
            this.brnSobre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnSobre.Name = "brnSobre";
            this.brnSobre.Size = new System.Drawing.Size(168, 89);
            this.brnSobre.TabIndex = 12;
            this.brnSobre.Text = "Sobre";
            this.brnSobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brnSobre.UseVisualStyleBackColor = false;
            this.brnSobre.Click += new System.EventHandler(this.brnSobre_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Yellow;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(1083, 584);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(105, 96);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Sair";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnMinigame
            // 
            this.btnMinigame.BackColor = System.Drawing.Color.Yellow;
            this.btnMinigame.Image = ((System.Drawing.Image)(resources.GetObject("btnMinigame.Image")));
            this.btnMinigame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinigame.Location = new System.Drawing.Point(12, 584);
            this.btnMinigame.Name = "btnMinigame";
            this.btnMinigame.Size = new System.Drawing.Size(105, 96);
            this.btnMinigame.TabIndex = 4;
            this.btnMinigame.Text = "Minigames";
            this.btnMinigame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinigame.UseVisualStyleBackColor = false;
            this.btnMinigame.Click += new System.EventHandler(this.btnMinigame_Click);
            // 
            // BtnOpcoes
            // 
            this.BtnOpcoes.BackColor = System.Drawing.Color.Yellow;
            this.BtnOpcoes.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpcoes.Image")));
            this.BtnOpcoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOpcoes.Location = new System.Drawing.Point(519, 591);
            this.BtnOpcoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOpcoes.Name = "BtnOpcoes";
            this.BtnOpcoes.Size = new System.Drawing.Size(168, 89);
            this.BtnOpcoes.TabIndex = 2;
            this.BtnOpcoes.Text = "Opções";
            this.BtnOpcoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOpcoes.UseVisualStyleBackColor = false;
            this.BtnOpcoes.Click += new System.EventHandler(this.BtnOpcoes_Click);
            // 
            // btnRecordes
            // 
            this.btnRecordes.BackColor = System.Drawing.Color.Yellow;
            this.btnRecordes.Image = ((System.Drawing.Image)(resources.GetObject("btnRecordes.Image")));
            this.btnRecordes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecordes.Location = new System.Drawing.Point(343, 591);
            this.btnRecordes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecordes.Name = "btnRecordes";
            this.btnRecordes.Size = new System.Drawing.Size(168, 89);
            this.btnRecordes.TabIndex = 1;
            this.btnRecordes.Text = "Recordes";
            this.btnRecordes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecordes.UseVisualStyleBackColor = false;
            this.btnRecordes.Click += new System.EventHandler(this.btnRecordes_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Yellow;
            this.btnJogar.Image = ((System.Drawing.Image)(resources.GetObject("btnJogar.Image")));
            this.btnJogar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJogar.Location = new System.Drawing.Point(167, 591);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(168, 89);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.TabStop = false;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(408, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(369, 99);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Yellow;
            this.btnAjuda.Image = global::N2B2_Jogo.Properties.Resources.ajuda;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAjuda.Location = new System.Drawing.Point(871, 591);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(168, 89);
            this.btnAjuda.TabIndex = 14;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // frTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.brnSobre);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnMinigame);
            this.Controls.Add(this.BtnOpcoes);
            this.Controls.Add(this.btnRecordes);
            this.Controls.Add(this.btnJogar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pac Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnRecordes;
        private System.Windows.Forms.Button BtnOpcoes;
        private System.Windows.Forms.Button btnMinigame;
        private System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button brnSobre;
        private System.Windows.Forms.PictureBox pbLogo;
        internal System.Windows.Forms.Button btnAjuda;
    }
}

