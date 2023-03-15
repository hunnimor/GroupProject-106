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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Pibimpap_Studios была основана две недели назад, для выполнения командного проекта по ООП. \n\n" +
            "Наша компания cовсем новая, но ее штат растет с невероятной скоростью и насчитывает на данный момент 6 человек.\n\n" +
            "Pibimpap_Studios cпециализируется на разработке математического ПО и телеграм ботах.\n\n" +
            "При возникновение каких-либо проблем/ошибок можете связаться с нами:\n" +
            "tg: @le10uch\n" +
            "mail: mirzagitv03@gmail.com",
            "О нас",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void оКалькулятореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                "Калькулятор Интегралов позволяет вычислять определенные интегралы и рисовать графики " +
                "— совершенно бесплатно!\n\n" +
                "Наш Калькулятор позволяет проверить решение Вашего определенного интеграла, Интерактивные " +
                "графики помогут представить и лучше понять функции интегралов.\n\n" +
                "Чтобы узнать больше о том как пользоваться Калькулятором Интегралов, загляните в раздел \"Справка\"",
                "О калькуляторе",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                "Введите функцию, которую вы хотите проинтегрировать в Калькулятор Интегралов. " +
                "Не вводите \"f(x) = \" часть и дифференциал \"dx\"! Затем расставьте пределы интегрирования.\n" +
                "После того как Вы закончили вводить вашу функцию, нажмите \"=\" и Калькулятор Интегралов выдаст результат.",
                "Справка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}