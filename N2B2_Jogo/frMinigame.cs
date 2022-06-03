using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_Jogo
{
    public partial class frMinigame : Form
    {
        Stopwatch cronometro = new Stopwatch();
        public frMinigame()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Image imagem = Image.FromFile("minigame1_Fundo.png");

            BackgroundImage = imagem;
            btnJogar.Visible = false;
            Pomo.Visible = true;
            timer1.Start();
            cronometro.Restart();
            timerCronometro.Start();

        }

        private void Pomo_Click(object sender, EventArgs e)
        {

        }

        private void frMinigame_Load(object sender, EventArgs e)
        {
            if(InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.pegueopombo.PlayLooping();
        }

        private void Pomo_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Você Ganhou!", "PARABÉNS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            timerCronometro.Stop();
            btnJogar.Visible = true;
            Pomo.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            Pomo.Left = gerador.Next(0, Width - Pomo.Width);
            Pomo.Top = gerador.Next(0, Height - Pomo.Height);
            lblCronometro.Text = Math.Truncate(cronometro.Elapsed.TotalSeconds).ToString()+"S";
        }

        private void lblCronometro_Click(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            frMinigame.ActiveForm.Dispose();
            InformacoesCompartilhadas.musica.PlayLooping();
        }

        private void frMinigame_FormClosing(object sender, FormClosingEventArgs e)
        {
            InformacoesCompartilhadas.pegueopombo.Stop();
        }
    }
}
