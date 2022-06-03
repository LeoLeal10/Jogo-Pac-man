using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2B2_Jogo
{
    public partial class frMinigames : Form
    {

        public frMinigames()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frMinigames_Load(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;

            Bitmap bmp = new Bitmap(button1.Width, button1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
                using (LinearGradientBrush br = new LinearGradientBrush(
                                                    r,
                                                    Color.Red,
                                                    Color.DarkRed,
                                                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(br, r);
                }
            }
            button1.BackgroundImage = bmp;
        }
    }
}
