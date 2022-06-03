using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static N2B2_Jogo.InformacoesCompartilhadas;

namespace N2B2_Jogo
{
    public partial class frNome : Form
    {
        public frNome()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira uma sigla", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtNome.Text.Length != 3)
            {
                MessageBox.Show("O Maximo de letras é 3", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nome = txtNome.Text;
            frNome.ActiveForm.Dispose();
            frPacMan jogo = new frPacMan();
            jogo.ShowDialog();
        }

        private void frNome_Load(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            frNome.ActiveForm.Dispose();
        }
    }
}
