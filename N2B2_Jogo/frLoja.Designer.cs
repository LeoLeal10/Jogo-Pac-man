namespace N2B2_Jogo
{
    partial class frLoja
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
            this.llDinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprarVida = new System.Windows.Forms.Button();
            this.btnDanoAumenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llDinheiro
            // 
            this.llDinheiro.AutoSize = true;
            this.llDinheiro.Location = new System.Drawing.Point(12, 649);
            this.llDinheiro.Name = "llDinheiro";
            this.llDinheiro.Size = new System.Drawing.Size(0, 20);
            this.llDinheiro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(203, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "+50 de vida";
            // 
            // btnComprarVida
            // 
            this.btnComprarVida.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnComprarVida.Location = new System.Drawing.Point(299, 111);
            this.btnComprarVida.Name = "btnComprarVida";
            this.btnComprarVida.Size = new System.Drawing.Size(75, 35);
            this.btnComprarVida.TabIndex = 3;
            this.btnComprarVida.Text = "30$";
            this.btnComprarVida.UseVisualStyleBackColor = true;
            this.btnComprarVida.Click += new System.EventHandler(this.btnComprarVida_Click);
            // 
            // btnDanoAumenta
            // 
            this.btnDanoAumenta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDanoAumenta.Location = new System.Drawing.Point(299, 172);
            this.btnDanoAumenta.Name = "btnDanoAumenta";
            this.btnDanoAumenta.Size = new System.Drawing.Size(75, 39);
            this.btnDanoAumenta.TabIndex = 4;
            this.btnDanoAumenta.Text = "20$";
            this.btnDanoAumenta.UseVisualStyleBackColor = true;
            this.btnDanoAumenta.Click += new System.EventHandler(this.btnDanoAumenta_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(191, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "+dano de atk";
            // 
            // frLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDanoAumenta);
            this.Controls.Add(this.btnComprarVida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llDinheiro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frLoja";
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.frLoja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprarVida;
        private System.Windows.Forms.Button btnDanoAumenta;
        private System.Windows.Forms.Label label2;
    }
}