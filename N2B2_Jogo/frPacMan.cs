using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_Jogo
{
    public partial class frPacMan : Form
    {
        #region Carregamento inicial e declaração de variáveis
        public frPacMan()
        {
            InitializeComponent();
        }
        bool comecou;
        Random rnd = new Random();
        int pontuacao = 0;
        int sentidoPacMan = 1;
        int sentidoFantasma1 = 1;
        int sentidoFantasma2 = 2;
        int sentidoFantasma3 = 3;
        int sentidoFantasma4 = 4;
        int sentidoFantasma5 = 3;
        int sentidoFantasma6 = 3;
        int sentidoFantasma7 = 4;
        int sentidoFantasma8 = 3;
        int passoFantasma = 2;
        bool easterEgg = false;
        /// <summary>
        /// Método de carregamento do form, nesse método, dependendo da dificuldade, os fantasmas são trazidos para o jogo
        /// inicia o loop com o som da mordida do pacman
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frPacMan_Load(object sender, EventArgs e)
        {
            if (InformacoesCompartilhadas.dificuldade == 3)
            {
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
            }
            if (InformacoesCompartilhadas.dificuldade == 4)
            {
                
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
                pbFantasma7.Left = 309;
                pbFantasma7.Top = 313;
                pbFantasma8.Left = 152;
                pbFantasma8.Top = 313;
            }
            comecou = false;
            InformacoesCompartilhadas.inicioPacMan.Play();
            pontuacao = 0;
        }
        #endregion
        #region Movimento do PacMan
        /// <summary>
        /// Checa, quando o usuário aperta uma tecla, qual direção ele pretende ir
        /// ou se ligou o EasterEgg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frPacMan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P && e.Alt && e.Shift)
            {
                if (!easterEgg)
                {
                    easterEgg = true;
                    MessageBox.Show("E4ST3R 3GG 4T1V4D0!!!");
                }
                else
                {
                    easterEgg = false;
                    MessageBox.Show("desativado");
                }
            }
            if (!comecou)
            {
                timerPacMan.Start();
                timerFantasma1.Start();
                timerFantasma2.Start();
                timerFantasma3.Start();
                timerFantasma4.Start();
                timerFantasma5.Start();
                timerFantasma6.Start();
                timerFantasma7.Start();
                timerFantasma8.Start();
                InformacoesCompartilhadas.mordidaPacMan.PlayLooping();
                comecou = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sentidoPacMan = 1;
                pbPacMan.Image = Image.FromFile("pacman_gif.gif");
            }
            if (e.KeyCode == Keys.Left)
            {
                sentidoPacMan = 2;
                pbPacMan.Image = Image.FromFile("pacmanleft_gif.gif");
            }
            if (e.KeyCode == Keys.Up)
            {
                sentidoPacMan = 3;
                pbPacMan.Image = Image.FromFile("pacmanup_gif.gif");
            }
            if (e.KeyCode == Keys.Down)
            {
                sentidoPacMan = 4;
                pbPacMan.Image = Image.FromFile("pacmandown_gif.gif");
            }
        }
        /// <summary>
        /// método tick do timer do PacMan, esse método faz todo o movimento do PacMan conforme o tempo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPacMan_Tick(object sender, EventArgs e)
        {
            switch (sentidoPacMan)
            {
                case 1:
                    if (ChecagemPassoPacMan(pbPacMan, sentidoPacMan, passoFantasma))
                        pbPacMan.Left += passoFantasma;
                    TeleporteDireita(pbPacMan);
                    Pontos(pbPacMan);
                    break;

                case 2:
                    if (ChecagemPassoPacMan(pbPacMan, sentidoPacMan, passoFantasma))
                        pbPacMan.Left -= passoFantasma;
                    TeleporteEsquerda(pbPacMan);
                    Pontos(pbPacMan);
                    break;

                case 3:
                    if (ChecagemPassoPacMan(pbPacMan, sentidoPacMan, passoFantasma))
                        pbPacMan.Top -= passoFantasma;
                    Pontos(pbPacMan);
                    break;

                case 4:
                    if (ChecagemPassoPacMan(pbPacMan, sentidoPacMan, passoFantasma))
                        pbPacMan.Top += passoFantasma;
                    Pontos(pbPacMan);
                    break;
            }
        }
        #endregion
        #region Controle dos fantasmas
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma1_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma1)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma1, passoFantasma))
                    {
                        sentidoFantasma1 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma1.Left += passoFantasma;
                    TeleporteDireita(pbFantasma1);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma1, passoFantasma))
                    {
                        sentidoFantasma1 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma1.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma1);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma1, passoFantasma))
                    {
                        sentidoFantasma1 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma1.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma1, passoFantasma))
                    {
                        sentidoFantasma1 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma1.Top += passoFantasma;
                    break;
            }

        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma2_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma2)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma2, passoFantasma))
                    {
                        sentidoFantasma2 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma2.Left += passoFantasma;
                    TeleporteDireita(pbFantasma2);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma2, passoFantasma))
                    {
                        sentidoFantasma2 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma2.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma2);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma2, passoFantasma))
                    {
                        sentidoFantasma2 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma2.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma2, passoFantasma))
                    {
                        sentidoFantasma2 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma2.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma3_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma3)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma3, passoFantasma))
                    {
                        sentidoFantasma3 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma3.Left += passoFantasma;
                    TeleporteDireita(pbFantasma3);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma3, passoFantasma))
                    {
                        sentidoFantasma3 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma3.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma3);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma3, passoFantasma))
                    {
                        sentidoFantasma3 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma3.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma3, passoFantasma))
                    {
                        sentidoFantasma3 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma3.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma4_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma4)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma4, passoFantasma))
                    {
                        sentidoFantasma4 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma4.Left += passoFantasma;
                    TeleporteDireita(pbFantasma4);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma4, passoFantasma))
                    {
                        sentidoFantasma4 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma4.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma4);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma4, passoFantasma))
                    {
                        sentidoFantasma4 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma4.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma4, passoFantasma))
                    {
                        sentidoFantasma4 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma4.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma5_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma5)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma5, passoFantasma))
                    {
                        sentidoFantasma5 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma5.Left += passoFantasma;
                    TeleporteDireita(pbFantasma5);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma5, passoFantasma))
                    {
                        sentidoFantasma5 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma5.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma5);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma5, passoFantasma))
                    {
                        sentidoFantasma5 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma5.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma5, passoFantasma))
                    {
                        sentidoFantasma5 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma5.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma6_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma6)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma6, passoFantasma))
                    {
                        sentidoFantasma6 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma6.Left += passoFantasma;
                    TeleporteDireita(pbFantasma6);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma6, passoFantasma))
                    {
                        sentidoFantasma6 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma6.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma6);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma6, passoFantasma))
                    {
                        sentidoFantasma6 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma6.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma6, passoFantasma))
                    {
                        sentidoFantasma6 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma6.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma7_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma7)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma7, passoFantasma))
                    {
                        sentidoFantasma7 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma7.Left += passoFantasma;
                    TeleporteDireita(pbFantasma7);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma7, passoFantasma))
                    {
                        sentidoFantasma7 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma7.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma7);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma7, passoFantasma))
                    {
                        sentidoFantasma7 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma7.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma7, passoFantasma))
                    {
                        sentidoFantasma7 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma7.Top += passoFantasma;
                    break;
            }
        }
        /// <summary>
        /// Método Tick do timer que controla o fantasma numero 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFantasma8_Tick(object sender, EventArgs e)
        {
            switch (sentidoFantasma8)
            {
                case 1:
                    if (!PodeAndarDireita(pbFantasma8, passoFantasma))
                    {
                        sentidoFantasma8 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma8.Left += passoFantasma;
                    TeleporteDireita(pbFantasma8);
                    break;

                case 2:
                    if (!PodeAndarEsquerda(pbFantasma8, passoFantasma))
                    {
                        sentidoFantasma8 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma8.Left -= passoFantasma;
                    TeleporteEsquerda(pbFantasma8);
                    break;

                case 3:
                    if (!PodeAndarCima(pbFantasma8, passoFantasma))
                    {
                        sentidoFantasma8 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma8.Top -= passoFantasma;
                    break;

                case 4:
                    if (!PodeAndarBaixo(pbFantasma8, passoFantasma))
                    {
                        sentidoFantasma8 = rnd.Next(1, 5);
                        break;
                    }
                    pbFantasma8.Top += passoFantasma;
                    break;
            }
        }
        #endregion
        #region Condições de movimento
        /// <summary>
        /// Checa se não chocou com um fantasma enquanto anda para a esquerda.
        /// </summary>
        /// <returns>um booleano dizendo se chocou ou não.</returns>
        private bool ColidiuEsquerda(PictureBox pbPacMan)
        {
            PictureBox[] fantasmas = { pbFantasma1, pbFantasma2, pbFantasma3, pbFantasma4, pbFantasma5, pbFantasma6, pbFantasma7, pbFantasma8 };
            foreach (PictureBox pbFantasma in fantasmas)
            {
                if (pbPacMan.Left + pbPacMan.Width - 1 >= pbFantasma.Left && pbPacMan.Left - 1 <= pbFantasma.Left + pbFantasma.Width
                     && pbPacMan.Top <= pbFantasma.Top + pbFantasma.Height && pbPacMan.Top + pbPacMan.Height >= pbFantasma.Top)
                {
                    if (!easterEgg)
                    {
                        pbPacMan.Image = Image.FromFile("pacmandying_gif.gif");
                        Perdeu();
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Checa se não chocou com um fantasma enquanto anda para a direita.
        /// </summary>
        /// <returns>um booleano dizendo se chocou ou não.</returns>
        private bool ColidiuDireita(PictureBox pbPacMan)
        {
            PictureBox[] fantasmas = { pbFantasma1, pbFantasma2, pbFantasma3, pbFantasma4, pbFantasma5, pbFantasma6, pbFantasma7, pbFantasma8 };
            foreach (PictureBox pbFantasma in fantasmas)
            {
                if (pbPacMan.Left + pbPacMan.Width + 1 >= pbFantasma.Left && pbPacMan.Left + 1 <= pbFantasma.Left + pbFantasma.Width
                    && pbPacMan.Top <= pbFantasma.Top + pbFantasma.Height && pbPacMan.Top + pbPacMan.Height >= pbFantasma.Top)
                {
                    if (!easterEgg)
                    {
                        pbPacMan.Image = Image.FromFile("pacmandying_gif.gif");
                        Perdeu();
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Checa se não chocou com um fantasma enquanto anda para cima.
        /// </summary>
        /// <returns>um booleano dizendo se chocou ou não.</returns>
        private bool ColidiuCima(PictureBox pbPacMan)
        {
            PictureBox[] fantasmas = { pbFantasma1, pbFantasma2, pbFantasma3, pbFantasma4, pbFantasma5, pbFantasma6, pbFantasma7, pbFantasma8 };
            foreach (PictureBox pbFantasma in fantasmas)
            {
                if (pbPacMan.Top - 1 <= pbFantasma.Top + pbFantasma.Height && pbPacMan.Top + pbPacMan.Height >= pbFantasma.Top
                    && pbPacMan.Left + pbPacMan.Width >= pbFantasma.Left && pbPacMan.Left <= pbFantasma.Left + pbFantasma.Width)
                {
                    if (!easterEgg)
                    {
                        pbPacMan.Image = Image.FromFile("pacmandying_gif.gif");
                        Perdeu();
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Checa se não chocou com um fantasma enquanto anda para baixo.
        /// </summary>
        /// <returns>um booleano dizendo se chocou ou não.</returns>
        private bool ColidiuBaixo(PictureBox pbPacMan)
        {
            PictureBox[] fantasmas = { pbFantasma1, pbFantasma2, pbFantasma3, pbFantasma4, pbFantasma5, pbFantasma6, pbFantasma7, pbFantasma8 };
            foreach (PictureBox pbFantasma in fantasmas)
            {
                if (pbPacMan.Top <= pbFantasma.Top + pbFantasma.Height && pbPacMan.Top + 1 + pbPacMan.Height >= pbFantasma.Top
                    && pbPacMan.Left + pbPacMan.Width >= pbFantasma.Left && pbPacMan.Left <= pbFantasma.Left + pbFantasma.Width)
                {
                    if (!easterEgg)
                    {
                        pbPacMan.Image = Image.FromFile("pacmandying_gif.gif");
                        Perdeu();
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Checa se ele não bateu na parede quando anda para a esquerda.
        /// </summary>
        /// <param name="pbPacMan">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <param name="passo">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <returns>booleano dizendo se pode ou não continuar andando</returns>
        private bool PodeAndarEsquerda(PictureBox pbPacMan, int passo)
        {
            PictureBox[] paredes = {pbParede1, pbParede2, pbParede3, pbParede4, pbParede5, pbParede6, pbParede7, pbParede8, pbParede9, pbParede10,
                                    pbParede11, pbParede12, pbParede13, pbParede14, pbParede15, pbParede16, pbParede17, pbParede18, pbParede19, pbParede20,
                                    pbParede21, pbParede22, pbParede23, pbParede24, pbParede25, pbParede26, pbParede27, pbParede28, pbParede29, pbParede30,
                                    pbParede31, pbParede32, pbParede33, pbParede34, pbParede35, pbParede36, pbParede37, pbParede38, pbParede39, pbParede40,
                                    pbParede41, pbParede42, pbParede43, pbParede44, pbParede45, pbParede46, pbParede47, pbParede48, pbParede49, pbParede50};

            foreach (PictureBox pbParede in paredes)
            {
                if (pbPacMan.Left + pbPacMan.Width - passo >= pbParede.Left && pbPacMan.Left - passo <= pbParede.Left + pbParede.Width
                     && pbPacMan.Top <= pbParede.Top + pbParede.Height && pbPacMan.Top + pbPacMan.Height >= pbParede.Top)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Checa se ele não bateu na parede quando anda para a direita.
        /// </summary>
        /// <param name="pbPacMan">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <param name="passo">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <returns>booleano dizendo se pode ou não continuar andando</returns>
        private bool PodeAndarDireita(PictureBox pbPacMan, int passo)
        {
            PictureBox[] paredes = {pbParede1, pbParede2, pbParede3, pbParede4, pbParede5, pbParede6, pbParede7, pbParede8, pbParede9, pbParede10,
                                    pbParede11, pbParede12, pbParede13, pbParede14, pbParede15, pbParede16, pbParede17, pbParede18, pbParede19, pbParede20,
                                    pbParede21, pbParede22, pbParede23, pbParede24, pbParede25, pbParede26, pbParede27, pbParede28, pbParede29, pbParede30,
                                    pbParede31, pbParede32, pbParede33, pbParede34, pbParede35, pbParede36, pbParede37, pbParede38, pbParede39, pbParede40,
                                    pbParede41, pbParede42, pbParede43, pbParede44, pbParede45, pbParede46, pbParede47, pbParede48, pbParede49, pbParede50};

            foreach (PictureBox pbParede in paredes)
            {
                if (pbPacMan.Left + pbPacMan.Width + passo >= pbParede.Left && pbPacMan.Left + 1 <= pbParede.Left + pbParede.Width
                    && pbPacMan.Top <= pbParede.Top + pbParede.Height && pbPacMan.Top + pbPacMan.Height >= pbParede.Top)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Checa se ele não bateu na parede quando anda para cima.
        /// </summary>
        /// <param name="pbPacMan">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <param name="passo">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <returns>booleano dizendo se pode ou não continuar andando</returns>
        private bool PodeAndarCima(PictureBox pbPacMan, int passo)
        {
            PictureBox[] paredes = {pbParede1, pbParede2, pbParede3, pbParede4, pbParede5, pbParede6, pbParede7, pbParede8, pbParede9, pbParede10,
                                    pbParede11, pbParede12, pbParede13, pbParede14, pbParede15, pbParede16, pbParede17, pbParede18, pbParede19, pbParede20,
                                    pbParede21, pbParede22, pbParede23, pbParede24, pbParede25, pbParede26, pbParede27, pbParede28, pbParede29, pbParede30,
                                    pbParede31, pbParede32, pbParede33, pbParede34, pbParede35, pbParede36, pbParede37, pbParede38, pbParede39, pbParede40,
                                    pbParede41, pbParede42, pbParede43, pbParede44, pbParede45, pbParede46, pbParede47, pbParede48, pbParede49, pbParede50};

            foreach (PictureBox pbParede in paredes)
            {
                if (pbPacMan.Top - passo <= pbParede.Top + pbParede.Height && pbPacMan.Top + pbPacMan.Height >= pbParede.Top
                    && pbPacMan.Left + pbPacMan.Width >= pbParede.Left && pbPacMan.Left <= pbParede.Left + pbParede.Width)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Checa se ele não bateu na parede quando anda para baixo.
        /// </summary>
        /// <param name="pbPacMan">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <param name="passo">
        /// objeto para a checagem ex: pacman ou fantasmas
        /// </param>
        /// <returns>booleano dizendo se pode ou não continuar andando</returns>
        private bool PodeAndarBaixo(PictureBox pbPacMan, int passo)
        {
            PictureBox[] paredes = {pbParede1, pbParede2, pbParede3, pbParede4, pbParede5, pbParede6, pbParede7, pbParede8, pbParede9, pbParede10,
                                    pbParede11, pbParede12, pbParede13, pbParede14, pbParede15, pbParede16, pbParede17, pbParede18, pbParede19, pbParede20,
                                    pbParede21, pbParede22, pbParede23, pbParede24, pbParede25, pbParede26, pbParede27, pbParede28, pbParede29, pbParede30,
                                    pbParede31, pbParede32, pbParede33, pbParede34, pbParede35, pbParede36, pbParede37, pbParede38, pbParede39, pbParede40,
                                    pbParede41, pbParede42, pbParede43, pbParede44, pbParede45, pbParede46, pbParede47, pbParede48, pbParede49, pbParede50};

            foreach (PictureBox pbParede in paredes)
            {
                if (pbPacMan.Top <= pbParede.Top + pbParede.Height && pbPacMan.Top + passo + pbPacMan.Height >= pbParede.Top
                    && pbPacMan.Left + pbPacMan.Width >= pbParede.Left && pbPacMan.Left <= pbParede.Left + pbParede.Width)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Vê se ele vai entrar na passagem da esquerda que leva para o lado direito
        /// </summary>
        /// <param name="pbPacMan"></param>
        /// <returns>booleano dizendo se entrou na passagem ou não</returns>
        private bool TeleporteEsquerda(PictureBox pbPacMan)
        {
            if (pbPacMan.Left + pbPacMan.Width < 0)
            {
                pbPacMan.Left = Width + pbPacMan.Width;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Vê se ele vai entrar na passagem da direita que leva para o lado esquerdo
        /// </summary>
        /// <param name="pbPacMan"></param>
        /// <returns>booleano dizendo se entrou na passagem ou não</returns>
        private bool TeleporteDireita(PictureBox pbPacMan)
        {
            if (pbPacMan.Left > Width)
            {
                pbPacMan.Left = 0 - pbPacMan.Width;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Esse método checa se o PacMan pode andar naquela direção, ou seja, se tem parede ou fantasma encostando nele.
        /// </summary>
        /// <param name="pbPacMan">PictureBox do PacMan</param>
        /// <param name="sentido">int sentido em que o PacMan está se movendo</param>
        /// <param name="passoFantasma">int com o numero de pixels que o PacMan avança por tick</param>
        /// <returns>booleano que diz se pode ou não andar</returns>
        private bool ChecagemPassoPacMan(PictureBox pbPacMan, int sentido, int passoFantasma)
        {
            switch (sentido)
            {
                case 1:
                    if (!PodeAndarDireita(pbPacMan, passoFantasma))
                    {
                        ColidiuDireita(pbPacMan);
                        return false;
                    }
                    ColidiuDireita(pbPacMan);
                    return true;
                case 2:
                    if (!PodeAndarEsquerda(pbPacMan, passoFantasma))
                    {
                        ColidiuEsquerda(pbPacMan);
                        return false;
                    }
                    ColidiuEsquerda(pbPacMan);
                    return true;
                case 3:
                    if (!PodeAndarCima(pbPacMan, passoFantasma))
                    {
                        ColidiuCima(pbPacMan);
                        return false;
                    }
                    ColidiuCima(pbPacMan);
                    return true;
                case 4:
                    if (!PodeAndarBaixo(pbPacMan, passoFantasma))
                    {
                        ColidiuBaixo(pbPacMan);
                        return false;
                    }
                    ColidiuBaixo(pbPacMan);
                    return true;
            }
            return false;
        }
        #endregion
        #region Pontuação
        /// <summary>
        /// Método que checa se o PacMan comeu algum ponto, se ele tiver comido todos os pontos ele chama o método Venceu.
        /// </summary>
        /// <param name="pbPacMan">PictureBox do PacMan</param>
        private void Pontos(PictureBox pbPacMan)
        {
            PictureBox[] pontos = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                                   pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                                   pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
                                   pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
                                   pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,
                                   pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60,
                                   pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70,
                                   pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80,
                                   pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86,  pictureBox87, pictureBox88, pictureBox89, pictureBox90,
                                   pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100,
                                   pictureBox101, pictureBox102, pictureBox103, pictureBox104, pictureBox105,  pictureBox106, pictureBox107, pictureBox108, pictureBox109,
                                   pictureBox110, pictureBox111, pictureBox112, pictureBox113,};

            foreach (PictureBox ponto in pontos)
            {
                if (pbPacMan.Left + pbPacMan.Width >= ponto.Left && pbPacMan.Left <= ponto.Left + ponto.Width &&
                   pbPacMan.Top + pbPacMan.Height >= ponto.Top && pbPacMan.Top <= ponto.Top + ponto.Height)
                {
                    pontuacao += 1;
                    ponto.Left += 10000;
                    if (pontuacao == 113)
                        Venceu();
                }
            }
        }
        #endregion
        #region Métodos de fim de jogo
        /// <summary>
        /// Metodo chamado quando o pacman encosta em um fantasma,
        /// para tudo e salva o recorde.
        /// </summary>
        private void Perdeu()
        {
            timerFantasma1.Stop();
            timerFantasma2.Stop();
            timerFantasma3.Stop();
            timerFantasma4.Stop();
            timerFantasma5.Stop();
            timerFantasma6.Stop();
            timerFantasma7.Stop();
            timerFantasma8.Stop();
            timerPacMan.Stop();
            InformacoesCompartilhadas.pontuacao += pontuacao;
            InformacoesCompartilhadas.mortePacMan.Play();
            SalvarRecorde();
            InformacoesCompartilhadas.pontuacao = 0;
            MessageBox.Show("Você perdeu!");
            frPacMan.ActiveForm.Dispose();
        }
        /// <summary>
        /// Método que pega a pontuação e o nome e salva no arquivo texto "recordes.txt" em ordem crescente
        /// </summary>
        private void SalvarRecorde()
        {
            if (!File.Exists("recordes.txt"))
            {
                File.Create("recordes.txt");
            }
            string[] linhasComNull = new string[10];
            string[] linhas = File.ReadAllLines("recordes.txt");
            linhasComNull = LinhasEmCrescente(linhasComNull, linhas);
            File.WriteAllLines("recordes.txt", linhasComNull);
        }
        /// <summary>
        /// Coloca as linhas em ordem crescente
        /// </summary>
        /// <param name="linhasComNull">vetor com 10 posições nulas</param>
        /// <param name="linhas">vetor das linhas</param>
        /// <returns>vetor preenchido de forma crescente</returns>
        private string[] LinhasEmCrescente(string[] linhasComNull, string[] linhas)
        {
            for (int i = 0; i < linhasComNull.Length; i++)
            {
                if (linhas.Length == 0)
                    break;
                if (i == linhas.Length - 1)
                    break;
                linhasComNull[i] = linhas[i];
            }
            for (int i = 0; i < 10; i++)
            {
                if (string.IsNullOrEmpty(linhasComNull[i]))
                {
                    if (i == 0)
                    {
                        linhasComNull[i] = InformacoesCompartilhadas.nome + "|" + InformacoesCompartilhadas.pontuacao + Environment.NewLine;
                        break;
                    }
                    else
                    {
                        linhasComNull[i - 1] += Environment.NewLine + InformacoesCompartilhadas.nome + "|" + InformacoesCompartilhadas.pontuacao;
                        break;
                    }
                }
                string[] dados = linhasComNull[i].Split('|');
                if (InformacoesCompartilhadas.pontuacao > double.Parse(dados[1]))
                {
                    if (i == 0)
                    {
                        linhasComNull[i + 1] = linhasComNull[i];
                        linhasComNull[i] = InformacoesCompartilhadas.nome + "|" + InformacoesCompartilhadas.pontuacao;
                        break;
                    }
                    if (i == 9)
                    {
                        linhasComNull[i] = InformacoesCompartilhadas.nome + "|" + InformacoesCompartilhadas.pontuacao;
                        break;
                    }
                    linhasComNull[i - 1] += Environment.NewLine + InformacoesCompartilhadas.nome + "|" + InformacoesCompartilhadas.pontuacao;
                    break;
                }
            }
            return linhasComNull;
        }
        /// <summary>
        /// Metodo chamado quando o usuário vence o nível, esse método para todos os timers e aumenta a dificuldade da proxima fase.
        /// </summary>
        private void Venceu()
        {
            timerFantasma1.Stop();
            timerFantasma2.Stop();
            timerFantasma3.Stop();
            timerFantasma4.Stop();
            timerFantasma5.Stop();
            timerFantasma6.Stop();
            timerFantasma7.Stop();
            timerFantasma8.Stop();
            timerPacMan.Stop();
            MessageBox.Show("Você venceu!!");
            if (passoFantasma < 6)
                passoFantasma += 1;
            if (InformacoesCompartilhadas.dificuldade == 3)
            {
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
            }
            if (InformacoesCompartilhadas.dificuldade == 4)
            {
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
                pbFantasma7.Left = 309;
                pbFantasma7.Top = 313;
                pbFantasma8.Left = 152;
                pbFantasma8.Top = 313;
            }
            InformacoesCompartilhadas.mordidaPacMan.Stop();
            InformacoesCompartilhadas.pontuacao += pontuacao;
            MessageBox.Show("Você venceu!!");
            comecou = false;
            Reiniciar();
        }
        /// <summary>
        /// Método para reiniciar a fase, coloca todos os fantasmas e pontos em posição inicial e zera a pontuação
        /// </summary>
        private void Reiniciar()
        {
            PictureBox[] pontos = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                                   pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                                   pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
                                   pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
                                   pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,
                                   pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60,
                                   pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70,
                                   pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80,
                                   pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86,  pictureBox87, pictureBox88, pictureBox89, pictureBox90,
                                   pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100,
                                   pictureBox101, pictureBox102, pictureBox103, pictureBox104, pictureBox105,  pictureBox106, pictureBox107, pictureBox108, pictureBox109,
                                   pictureBox110, pictureBox111, pictureBox112, pictureBox113,};
            foreach (PictureBox ponto in pontos)
            {
                ponto.Left -= 10000;
            }
            timerFantasma1.Stop();
            timerFantasma2.Stop();
            timerFantasma3.Stop();
            timerFantasma4.Stop();
            timerFantasma5.Stop();
            timerPacMan.Stop();
            pbPacMan.Left = 230;
            pbPacMan.Top = 454;
            pbFantasma1.Left = 184;
            pbFantasma1.Top = 248;
            pbFantasma2.Left = 215;
            pbFantasma2.Top = 248;
            pbFantasma3.Left = 246;
            pbFantasma3.Top = 248;
            pbFantasma4.Left = 277;
            pbFantasma4.Top = 248;
            if (InformacoesCompartilhadas.dificuldade == 3)
            {
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
            }
            if (InformacoesCompartilhadas.dificuldade == 4)
            {
                pbFantasma5.Left = 309;
                pbFantasma5.Top = 278;
                pbFantasma6.Left = 152;
                pbFantasma6.Top = 278;
                pbFantasma7.Left = 309;
                pbFantasma7.Top = 313;
                pbFantasma8.Left = 152;
                pbFantasma8.Top = 313;
            }
            pontuacao = 0;
            comecou = false;
        }
        #endregion
        #region Fechando a tela
        /// <summary>
        /// Método acionado quando o formulário do PacMan está sendo fechado.
        /// esse método desliga todos os timers e para a música.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frPacMan_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerFantasma1.Stop();
            timerFantasma2.Stop();
            timerFantasma3.Stop();
            timerFantasma4.Stop();
            timerFantasma5.Stop();
            timerFantasma6.Stop();
            timerFantasma7.Stop();
            timerFantasma8.Stop();
            timerPacMan.Stop();
            InformacoesCompartilhadas.mordidaPacMan.Stop();
        }
        /// <summary>
        /// Método acionado quando o formulário do PacMan é fechado.
        /// desliga a música.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frPacMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            InformacoesCompartilhadas.mordidaPacMan.Stop();
        }
        #endregion
    }
}
