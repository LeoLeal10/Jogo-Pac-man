namespace N2B2_Jogo
{
    partial class frNome
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira uma sigla com 3 letras para o recorde";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(310, 105);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 26);
            this.txtNome.TabIndex = 1;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.Yellow;
            this.btnProximo.Location = new System.Drawing.Point(651, 169);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(112, 35);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "->";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.ForeColor = System.Drawing.Color.Yellow;
            this.btnVolta.Location = new System.Drawing.Point(13, 174);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(112, 35);
            this.btnVolta.TabIndex = 3;
            this.btnVolta.Text = "<-";
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // frNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 223);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insira seu Nome";
            this.Load += new System.EventHandler(this.frNome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVolta;
    }
}