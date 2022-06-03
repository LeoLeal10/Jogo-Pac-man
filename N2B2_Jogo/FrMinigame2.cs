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
    public partial class FrMinigame2 : Form
    {
        public FrMinigame2()
        {
            InitializeComponent();
        }
        public string resultadoRodada(int player, int cpu)
        {
            switch (player)
            {
                case 0:
                    if (cpu == 4) return "Você perdeu.";
                    else if (cpu == 5) return "Você ganhou";
                    return "Empatou";

                case 1:
                    if (cpu == 5) return "Você perdeu.";
                    else if (cpu == 3) return "Você ganhou";
                    return "Empatou";

                case 2:
                    if (cpu == 3) return "Você perdeu.";
                    else if (cpu == 4) return "Você ganhou";
                    return "Empatou";                    
            }
            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pbJogador.ImageLocation = "0.png";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            pbJogador.ImageLocation = "2.png";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pbJogador.ImageLocation = "1.png";
        }
        private void btnJogar_Click_1(object sender, EventArgs e)
        {
            if (pbJogador.ImageLocation == null)
            {
                MessageBox.Show("Esolha uma das opções antes de jogar.", "Erro ao jogar", MessageBoxButtons.OK);
                return;
            }
            else
            {
                int escolhaJG = int.Parse(pbJogador.ImageLocation.Substring(0, 1));
                Random random = new Random();
                int escolhaBOT = random.Next(3, 6);
                pbBOT.ImageLocation = escolhaBOT + ".png";

                MessageBox.Show(resultadoRodada(escolhaJG, escolhaBOT));
            }
        }
        private void btnVolta_Click(object sender, EventArgs e)
        {
            FrMinigame2.ActiveForm.Dispose();
        }
    }
}
