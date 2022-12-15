using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Windows
{
    public partial class Calculadora_windows : Form
    {
        double acumula = 0;
        string operacao = "";
        public Calculadora_windows()
        {
            InitializeComponent();
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            display.Text = "9";
        }

        private void lblSomar_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }
        }
        private void lblDiminuir_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }
        private void lblMult_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
        }
        private void lblDividir_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
        }
        private void lblVirgula_Click(object sender, EventArgs e)
        {
            display.Text += ",";
        }

        private void lblCalcular_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void lblZerar_Click(object sender, EventArgs e)
        {
            acumula = 0;
            display.Text = "";
        }
    }
}
