using System.Diagnostics;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double lower;
            double hight;
            if (Double.TryParse(textBoxMin.Text, out lower) && (Double.TryParse(textBoxMax.Text, out hight)))
            {
                Quadrature integr = new Quadrature(textBoxIntegral.Text);
                var sw = new Stopwatch();
                sw.Start();
                string result = integr.romberg(lower, hight, 0.01, 1, 4).ToString();
                
                sw.Stop();
                if (result == "NaN")
                {
                    MessageBox.Show(
                    "Пределы интегрирования указаны не верно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    textBoxResult.Text = result;
                    textBoxTime.Text = sw.ElapsedMilliseconds.ToString() + " ms";
                }
            }
            else
            {
                MessageBox.Show(
                    "Пределы интегрирования указаны не верно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public string returnFunc()
        {
            return textBoxIntegral.Text;
        }

        private void textBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += '+';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += '-';
        }

        private void buttonUmnoj_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += '*';
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += '/';
        }

        private void buttonStepen_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += '^';
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "sqrt(";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "cos(";
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "sin(";
        }

        private void buttonTg_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "tg(";
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "ctg(";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "log(";
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "ln(";
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "Pi";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            textBoxIntegral.Text += "E";
        }
    }
}