using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace N2B2_Jogo
{
    public partial class frTelaInicial : Form
    {

        public frTelaInicial()
        {
            InitializeComponent();         
            InformacoesCompartilhadas.musicaPacMan.PlayLooping();           
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if(InformacoesCompartilhadas.dificuldade == 1)
            {
                MessageBox.Show("MARIQUINHAS NÃO JOGAM", "MARIQUINHA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(InformacoesCompartilhadas.dificuldade == 0)
            {
                MessageBox.Show("Selecione uma dificuldade no menu de opções", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frNome nome = new frNome();
            nome.ShowDialog();
            if (InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.musicaPacMan.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.musicaPacMan.PlayLooping();
        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {
            frRecordes recordes = new frRecordes();
            recordes.ShowDialog();
        }

        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            frOpçoes opcoes = new frOpçoes();
            opcoes.ShowDialog();
        }


        private void btnMinigame_Click(object sender, EventArgs e)
        {
            frMenuMinigames minigames = new frMenuMinigames();
            minigames.ShowDialog();
            if(InformacoesCompartilhadas.musicaAtivada)
                InformacoesCompartilhadas.musicaPacMan.PlayLooping();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ??", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void brnSobre_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.ShowDialog();
        }
    }
}
