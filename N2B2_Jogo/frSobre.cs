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
    public partial class frSobre : Form
    {
        int contador = 0;
        public frSobre()
        {
            InitializeComponent();
        }

        private void btnVerNomes_Click(object sender, EventArgs e)
        {
            timer1.Start();
            llNathan.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador != 200)
            {
                contador += 5;
                llNathan.Top = contador;
            }


        }
    }
}
