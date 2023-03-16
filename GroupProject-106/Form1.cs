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
            if (proverki_vvoda(textBoxIntegral.Text, textBoxMin.Text, textBoxMax.Text))
            {
                double min = Convert.ToDouble(textBoxMin.Text);
                double max = Convert.ToDouble(textBoxMax.Text);
                Quadrature x = new Quadrature(textBoxIntegral.Text);
                Stopwatch sw = Stopwatch.StartNew();
                textBoxResult.Text = x.romberg(min, max, 0.01, 1).ToString();
                sw.Stop();
                textBoxTime.Text = sw.ElapsedMilliseconds.ToString();
                button1.Visible = true;
            }
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
            textBoxMin.Text = "";
            textBoxMax.Text = "";
            button1.Visible = false;
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
        MessageBoxIcon.Information);
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
            MessageBoxIcon.Information);
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
            MessageBoxIcon.Information);
            }
        }

        private void анекдотПроИнтегралToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Встречает мужик своего преподавателя по ВУЗу лет через восемь после окончания, " +
            "разговорились, вспомнили время былое. " +
            "Профессор спрашивает:\r\n— Вот я вам читал три года высшую математику, скажи, в жизни тебе " +
            "мои знания когда-нибудь пригодились?\r\nСтудент, подумав:\r\n— А ведь был " +
            "один случай.\r\n— Очень интересно, расскажите, я его буду на лекциях " +
            "рассказывать, что высшая математика не такая абстрактная наука и в жизни бывает нужна.\r\n— Шел я как-то по " +
            "улице, и мне шляпу ветром в лужу сдуло. Так я взял кусок проволоки, загнул его в форме интеграла и " +
            "достал шляпу!",
            "Анекдот про интеграл",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form3(textBoxIntegral.Text, textBoxMin.Text, textBoxMax.Text);
            myForm.Show();
        }

        public static bool proverki_vvoda(string text, string min, string max)
        {
            bool correct = true;
            // проверки пределов
            double lower = 0, hight = 0;
            if (Double.TryParse(min, out lower) && (Double.TryParse(max, out hight)))
            {
                if (lower > hight)
                {
                    MessageBox.Show(
                    "Пределы интегрирования указаны неверно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    correct = false;
                }
            }
            else
            {
                MessageBox.Show(
                    "Пределы интегрирования указаны неверно!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                correct = false;
            }

            // проверка на корректность ввода знаков оперции
            List<string> listConstantSign = new List<string>() { "*", "-", "+", "^" };
            List<string> listConstantFunctions = new List<string>() { "arcsin", "arccos", "arctg", "arcctg", "sqrt", "cos", "sin", "tg", "ctg", "ln", "log" };
            string checkToSign = text;
            for (int i = 0; i < listConstantSign.Count; i++)
            {
                checkToSign = checkToSign.Replace(listConstantSign[i], "@");
            }
            if (checkToSign.Contains("@@"))
            {
                MessageBox.Show(
                "Вы пропустили знак операции между выражениями!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                correct = false;
            }

            //проверка на скобки
            brackets br = new brackets(text);
            var resId = br.CorrectBrackets();
            if (resId != -1)
            {
                MessageBox.Show(
                        "Скобки расставлены - криво!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                correct = false;
            }

            //проверка на кореектность ввода функций и переменных
            foreach (string s in listConstantFunctions)
            {
                string[] intermediateCheck = checkToSign.Split("@");
                foreach (string s2 in intermediateCheck)
                {
                    if (s2.IndexOf(s) != 0 && s2.IndexOf(s) != -1 && s2[s2.IndexOf(s) - 1].ToString() != "(")
                    {
                        MessageBox.Show(
                        "Вы пропустили знак операции между выражениями!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        correct = false;
                        continue;
                    }
                }
            }
            return correct;
        }

        private void textBoxIntegral_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void неНажиматьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form4();
            myForm.Show();
        }
    }
}