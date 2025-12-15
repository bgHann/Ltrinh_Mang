using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1._2
{
    public partial class frmUCLN : Form
    {
        public frmUCLN()
        {
            InitializeComponent();
        }
        int ucln(int a, int b)
        {
            while (b != 0)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
			}
            return a;
		}

		private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)txtA.Value;
            int b = (int)txtB.Value;
            int kq = ucln(a, b);
            lbkq.Text = kq.ToString();



		}

        private void frmUCLN_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtA_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
