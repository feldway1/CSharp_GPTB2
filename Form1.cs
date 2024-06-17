using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_GPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tcka_Scroll(object sender, EventArgs e)
        {
            txta.Text = tcka.Value.ToString();
        }

        private void tckb_Scroll(object sender, EventArgs e)
        {
            txtb.Text = tckb.Value.ToString();
        }

        private void tckc_Scroll(object sender, EventArgs e)
        {
            txtc.Text = tckc.Value.ToString();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta, x1, x2;
            if (a == 0)
                if (b == 0)
                {
                    if (c != 0)
                    {
                        lblkq.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        lblkq.Text = "Phương trình vô số nghiệm";
                    }

                }
                else
                {
                    x1 = x2 = -c / b;
                    lblkq.Text = "Phương trình có nghiệm x =" + x1;
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblkq.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    lblkq.Text = "Phương trình có nghiệm x1 = x2 = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblkq.Text = "Phương trình có 2 nghiệm phân biệt:" + "\nx1 = " + x1 + "\nx2 = " + x2;
                }

            }

        }
    }
}

