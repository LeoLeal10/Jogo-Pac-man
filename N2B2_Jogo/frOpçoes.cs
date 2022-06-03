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
    public partial class frOpçoes : Form
    {
        public frOpçoes()
        {
            InitializeComponent();
        }

        private void frOpçoes_Load(object sender, EventArgs e)
        {
            cbDificuldade.SelectedIndex = InformacoesCompartilhadas.indexSelecionado;
            if (InformacoesCompartilhadas.musicaAtivada)
                ckbMusica.Checked = true;
            else
                ckbMusica.Checked = false;
        }

        private void ckbMusica_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMusica.Checked)
            {
                InformacoesCompartilhadas.musicaAtivada = true;
                InformacoesCompartilhadas.musicaPacMan.PlayLooping();
            }
            else
            {
                InformacoesCompartilhadas.musicaAtivada = false;
                InformacoesCompartilhadas.musicaPacMan.Stop();
            }
        }


        private void cbDificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDificuldade.SelectedIndex == 0)
            {
                InformacoesCompartilhadas.dificuldade = 1;
                MessageBox.Show("IIIIHHH MEDROSO", "TA EM CHOK??", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InformacoesCompartilhadas.indexSelecionado = 0;
            }
            else if(cbDificuldade.SelectedIndex == 1)
            {
                InformacoesCompartilhadas.dificuldade = 2;
                InformacoesCompartilhadas.indexSelecionado = 1;
            }
            else if(cbDificuldade.SelectedIndex == 2)
            {
                InformacoesCompartilhadas.dificuldade = 3;
                InformacoesCompartilhadas.indexSelecionado = 2;
            }
            else if(cbDificuldade.SelectedIndex == 3)
            {
                InformacoesCompartilhadas.dificuldade = 4;
                MessageBox.Show("MODO BRABO ATIVADO", "BRABO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InformacoesCompartilhadas.indexSelecionado = 3;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frOpçoes.ActiveForm.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
