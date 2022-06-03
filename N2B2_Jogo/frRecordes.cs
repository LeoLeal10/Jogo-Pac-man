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
    public partial class frRecordes : Form
    {
        public frRecordes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frRecordes.ActiveForm.Dispose();
        }

        private void frRecordes_Load(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("recordes.txt");
            if(linhas.Length == 0)
            {
                MessageBox.Show("Não tem recordes no sistema.");
                return;
            }
            for(int i = 0; i < 10; i++)
            {
                if (i >= linhas.Length)
                    break;
                if (string.IsNullOrEmpty(linhas[i]))
                    break;
                string[] dados = linhas[i].Split('|');
                lbRecordes.Items.Add($"{dados[0].ToUpper()} --- {dados[1]} Pontos");
            }
        }

        private void lbRecordes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
