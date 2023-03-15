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
                List<string> listConstantSign = new List<string>() { "*", "-", "+", "^"};
                List<string> listConstantFunctions = new List<string>() { "arcsin", "arccos", "arctg", "arcctg", "sqrt", "cos", "sin", "tg", "ctg", "ln", "log"};
                string checkToSign = textBoxIntegral.Text;
                // проверка на корректность ввода знаков оперции
                for(int i = 0; i < listConstantSign.Count; i++)
                {
                    checkToSign = checkToSign.Replace(listConstantSign[i], "@");
                }
                if (checkToSign.Contains("@@"))
                {
                    MessageBox.Show(
                    "Знаки операций введены не верно",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                //проверка на скобки
                brackets br = new brackets(Text);
                var resId = br.CorrectBrackets();

                //проверка на кореектность ввода функций и переменных
                foreach (string s in listConstantFunctions)
                {
                    string[] intermediateCheck = checkToSign.Split("@");
                    foreach (string s2 in intermediateCheck)
                    {
                        if (s2.IndexOf(s) != 0 && s2.IndexOf(s) != -1 && s2[s2.IndexOf(s) - 1].ToString() != "(")
                        {
                            MessageBox.Show(
                            "Знаки операции введены не верно",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
                }
                //конец проверок


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
    }
}