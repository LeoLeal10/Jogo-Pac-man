using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_Jogo
{
    public partial class frMinigame3 : Form
    {
        
        int nivel = 10;
        public frMinigame3()
        {
            InitializeComponent();

            this.Cursor = new Cursor("blade.cur");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            InformacoesCompartilhadas.hit.Play();
            Random rndcor = new Random();
            
            BackColor = Color.FromArgb(rndcor.Next(0, 255), rndcor.Next(0, 255), rndcor.Next(0, 255));
            pbVida.PerformStep();
            pbVida.Increment(-InformacoesCompartilhadas.danoAdicional);
            
            if (pbVida.Value == 0)
            {
                label4.Text = pbVida.Value.ToString();
                timerJogo.Stop();
                MessageBox.Show("Ganhou");
                InformacoesCompartilhadas.kill.Play();
                BackColor = Color.White;
                btnIniciar.Visible = true;
                InformacoesCompartilhadas.dinheiro += 10;
                nivel += 10;
                pbVida.Value = 100;
                pbVidaJogador.Value = pbVidaJogador.Maximum;
                pbBoss.Enabled = false;
                label1.Text = "Nível: " + (nivel / 10).ToString();
                label2.Text = pbVidaJogador.Maximum.ToString();
                label3.Text = pbVidaJogador.Value.ToString();
                llDinheiro.Text = $"Dinheiro: {InformacoesCompartilhadas.dinheiro}$";
                
            }
            label4.Text = pbVida.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pbVidaJogador.Increment(-(rnd.Next(5, nivel)));
            if(pbVidaJogador.Value == 0)
            {
                timerJogo.Stop();
                MessageBox.Show("Você perdeu!!");
                InformacoesCompartilhadas.dinheiro = 0;
                InformacoesCompartilhadas.vidaMaxima = 100;
                frMinigame3.ActiveForm.Dispose();
                InformacoesCompartilhadas.musica.PlayLooping();

            }
            label2.Text = pbVidaJogador.Maximum.ToString();
            label3.Text = pbVidaJogador.Value.ToString();
        }

        private void frJogo_Load(object sender, EventArgs e)
        {
            pbBoss.Enabled = false;
            InformacoesCompartilhadas.vidaMaxima = 100;
            if(InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.musica.PlayLooping();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            pbVidaJogador.Maximum = InformacoesCompartilhadas.vidaMaxima;
            pbVidaJogador.Value = pbVidaJogador.Maximum;
            timerJogo.Start();
            pbBoss.Enabled = true;
            label1.Text = $"Nível: {nivel / 10}";
            llDinheiro.Text = $"Dinheiro: {InformacoesCompartilhadas.dinheiro}$";
            btnIniciar.Visible = false;                 
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            frLoja loja = new frLoja();
            loja.ShowDialog();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InformacoesCompartilhadas.vidaMaxima = 999999999;
            MessageBox.Show("E4S73R 3GG 4T1V4D0!!", "3RR0", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frMinigame3_FormClosed(object sender, FormClosedEventArgs e)
        {
            InformacoesCompartilhadas.musica.Stop();
        }

        private void frMinigame3_FormClosing(object sender, FormClosingEventArgs e)
        {
            InformacoesCompartilhadas.musica.Stop();
        }
    }
}
