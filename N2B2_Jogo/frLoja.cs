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
    public partial class frLoja : Form
    {
        public frLoja()
        {
            InitializeComponent();
        }

        private void frLoja_Load(object sender, EventArgs e)
        {
            llDinheiro.Text = $"Dinheiro: {InformacoesCompartilhadas.dinheiro.ToString()}$";
        }

        private void btnComprarVida_Click(object sender, EventArgs e)
        {
            if (InformacoesCompartilhadas.dinheiro >= 30)
            {
                InformacoesCompartilhadas.vidaMaxima += 50;
                InformacoesCompartilhadas.dinheiro -= 30;
                llDinheiro.Text = $"Dinheiro: {InformacoesCompartilhadas.dinheiro}$";
                return;
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro o suficiente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
   

        private void btnDanoAumenta_Click_1(object sender, EventArgs e)
        {
            if (InformacoesCompartilhadas.dinheiro >= 20)
            {
                InformacoesCompartilhadas.danoAdicional = InformacoesCompartilhadas.danoAdicional + 3;
                InformacoesCompartilhadas.dinheiro -= 20;
                llDinheiro.Text = $"Dinheiro: {InformacoesCompartilhadas.dinheiro}$";
                return;
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro o suficiente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
