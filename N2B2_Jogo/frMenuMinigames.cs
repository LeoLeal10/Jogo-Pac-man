using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_Jogo
{
    public partial class frMenuMinigames : Form
    {
        public frMenuMinigames()
        {
            InitializeComponent();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            frMenuMinigames.ActiveForm.Dispose();
    
        }


        private void pictureJogo1_Click_1(object sender, EventArgs e)
        {
            frMinigame minigame = new frMinigame();
            minigame.ShowDialog();
        }

        private void pictureJogo2_Click(object sender, EventArgs e)
        {
            FrMinigame2 minigame2 = new FrMinigame2();
            minigame2.ShowDialog();
        }

        private void pictureJogo1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureJogo1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureJogo3_Click(object sender, EventArgs e)
        {
            frMinigame3 minigame3 = new frMinigame3();
            if(InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.musica.PlayLooping();
            minigame3.ShowDialog();
            InformacoesCompartilhadas.musica.Stop();
        }
        
    }
}
