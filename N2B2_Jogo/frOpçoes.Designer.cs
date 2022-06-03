namespace N2B2_Jogo
{
    partial class frOpçoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frOpçoes));
            this.label3 = new System.Windows.Forms.Label();
            this.ckbMusica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(81, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dificuldade";
            // 
            // ckbMusica
            // 
            this.ckbMusica.AutoSize = true;
            this.ckbMusica.Checked = true;
            this.ckbMusica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbMusica.Location = new System.Drawing.Point(313, 42);
            this.ckbMusica.Name = "ckbMusica";
            this.ckbMusica.Size = new System.Drawing.Size(15, 14);
            this.ckbMusica.TabIndex = 12;
            this.ckbMusica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbMusica.UseVisualStyleBackColor = true;
            this.ckbMusica.CheckedChanged += new System.EventHandler(this.ckbMusica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(110, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Música";
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "Mariquinha",
            "Fácil",
            "Normal",
            "Brabo"});
            this.cbDificuldade.Location = new System.Drawing.Point(207, 70);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(121, 21);
            this.cbDificuldade.TabIndex = 14;
            this.cbDificuldade.SelectedIndexChanged += new System.EventHandler(this.cbDificuldade_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.ForeColor = System.Drawing.Color.Yellow;
            this.btnVoltar.Location = new System.Drawing.Point(22, 267);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 68);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "<---";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frOpçoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(445, 347);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbMusica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "frOpçoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.frOpçoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}