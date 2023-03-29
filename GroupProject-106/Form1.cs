using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GroupProject_106
{
    public delegate void MyDelegate(string data); //меню
    public delegate void DHistory(string his);
    //public delegate void DConst(BindingList<string, double> constant);

    public partial class Form1 : Form
    {
        public BindingList<ConstantValues> constants = new BindingList<ConstantValues>();

        public string result;
        public string time;

        List<string> inputs = new List<string>();

        public BindingList<ConstantValues> empty = new BindingList<ConstantValues>();
        public Form1()
        {
            InitializeComponent();

            button5.BackColor = Color.White;
            button5.ForeColor = Color.Green;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.BorderColor = Color.HotPink;
            Menu menu = new Menu(new MyDelegate(func));
            addUserControl(menu);
        }
        /*public void co(BindingList<string, double> param)
        {
            constants = param;
        }*/
        public void func(string param)
        {
            if (param == "") { textBoxMin.Text = ""; textBoxMax.Text = ""; textBoxIntegral.Text = ""; }
            else if (param == "-1")
            {
                string[] arr = textBoxIntegral.Lines.ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i].Remove(arr.Length + 1, 1);
                }
                textBoxIntegral.Lines = arr;
            }
            else textBoxIntegral.Text += param;
        }
        public void his(string param)
        {
            textBoxIntegral.Text = param;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel10.Controls.Clear();
            panel10.Controls.Add(userControl);
            userControl.BringToFront();
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

        public bool proverki_vvoda(string text, string min, string max)
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
                "Два знака операции не могут стоять рядом друг с другом!",
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
            /*
            bool correctDigits = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (i != text.Length - 1 && Char.IsDigit(text[i]) && text[i + 1].ToString() == "x")
                {
                    correctDigits = false;
                    correct = false;
                    break;
                }
                if (i != 0 && Char.IsDigit(text[i]) && text[i - 1].ToString() == "x")
                {
                    correctDigits = false;
                    correct = false;
                    break;
                }
                if (i != 0 && Char.IsDigit(text[i]) && (Char.IsLetter(text[i - 1]) || text[i - 1].ToString() == ")" || text[i - 1].ToString() == "("))
                {
                    correctDigits = false;
                    correct = false;
                    break;
                }
                if (i != text.Length - 1 && Char.IsDigit(text[i]) && (Char.IsLetter(text[i + 1]) || text[i + 1].ToString() == ")" || text[i + 1].ToString() == "("))
                {
                    correctDigits = false;
                    correct = false;
                    break;
                }
            }
            if (!correctDigits)
            {

                MessageBox.Show(
                    "Неправильно введены знаки оперций",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            */

            bool correctBreakets = true;
            bool ch = true;
            //проверка на кореектность ввода функций и переменных


            //проверка на скобки
            foreach (string s in listConstantFunctions)
            {
                string[] intermediateCheck = checkToSign.Split("@");
                foreach (string s2 in intermediateCheck)
                {
                    //(s2[s2.IndexOf(s) - 1].ToString() != "(" || s2[s2.IndexOf(s) + s.Length].ToString() != "(")
                    if (s2.IndexOf(s) != 0 && s2.IndexOf(s) != -1 && s2[s2.IndexOf(s) - 1].ToString() != "(")
                    {
                        correctBreakets = false;
                        correct = false;
                        break;
                    }
                    if (s2.IndexOf(s) != -1 && s2[s2.IndexOf(s) + s.Length].ToString() != "(")
                    {
                        correctBreakets = false;
                        correct = false;
                        break;
                    }
                }
            }
            if (!correctBreakets)
            {

                MessageBox.Show(
                    "Неправильно введены скобки!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            }
            if (listConstantSign.Contains(text[0].ToString()))
            {
                MessageBox.Show(
                    "Выражение не может начинаться с операции!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                correct = false;
            }
            else if (listConstantSign.Contains(text[text.Length - 1].ToString()))
            {
                MessageBox.Show(
                    "Выражение не может заканчиваться знаком операции!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                correct = false;
            }
            return correct;
        }
        private bool proverki_const(string text)
        {
            text += "+0";
            bool flag = true;
            string newconst = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((char)text[i] != 'x' &&
                    (((char)text[i] >= 'a' && (char)text[i] <= 'z')
                    || ((char)text[i] >= 'A' && (char)text[i] <= 'Z')))
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if ((char)text[j] != '+' && (char)text[j] != '-'
                            && (char)text[j] != '*' && (char)text[j] != '/' && (char)text[j] != '^')
                        {
                            newconst += (text[j]);
                        }
                        else { constants.Add(new() { Name = newconst, Value = 0.0 }); i += newconst.Length; newconst = ""; break; }
                    }
                }
            }
            if (constants != null)
            {
                for (int i = 0; i < constants.Count; i++)
                {
                    if (i < constants.Count && constants[i].Name.Length > 3)
                    {
                        if ((constants[i].Name[0] == 's' && constants[i].Name[1] == 'i' && constants[i].Name[2] == 'n') ||
                             (constants[i].Name[0] == 'c' && constants[i].Name[1] == 'o' && constants[i].Name[2] == 's') ||
                             (constants[i].Name[0] == 'c' && constants[i].Name[1] == 't' && constants[i].Name[2] == 'g') ||
                             (constants[i].Name[0] == 'l' && constants[i].Name[1] == 'o' && constants[i].Name[2] == 'g'))
                        { constants.RemoveAt(i); }
                    }
                    if (i < constants.Count && (constants[i].Name.Length > 2))
                    {
                        if ((constants[i].Name[0] == 't' && constants[i].Name[1] == 'g') ||
                            (constants[i].Name[0] == 'l' && constants[i].Name[1] == 'n'))
                        { constants.RemoveAt(i); }
                    }
                }
                if (constants.Count > 1)
                {
                    for (int i = 0; i < constants.Count; i++)
                    {
                        for (int j = constants.Count - 1; j >= 0; j--)
                        {
                            if (constants[i].Name == constants[j].Name && i != j) constants.Remove(constants[j]);
                        }
                    }
                }
            }
            else flag = false;
            return flag;
        }

        private void textBoxIntegral_TextChanged(object sender, EventArgs e)
        {
            //button1.Visible = false;
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            //button1.Visible = false;
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            //button1.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void неНажиматьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form4();
            myForm.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Green;
            button6.FlatAppearance.BorderColor = Color.White;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Green;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.BorderColor = Color.HotPink;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Green;
            button7.FlatAppearance.BorderColor = Color.White;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Green;
            button8.FlatAppearance.BorderColor = Color.White;
            panel10.Visible = true;
            Menu menu = new Menu(new MyDelegate(func));
            addUserControl(menu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Green;
            button5.FlatAppearance.BorderColor = Color.White;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Green;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatAppearance.BorderColor = Color.HotPink;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Green;
            button6.FlatAppearance.BorderColor = Color.White;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Green;
            button8.FlatAppearance.BorderColor = Color.White;
            Result res = new Result(result, time, textBoxIntegral.Text, textBoxMin.Text, textBoxMax.Text);
            addUserControl(res);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Green;
            button5.FlatAppearance.BorderColor = Color.White;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Green;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatAppearance.BorderColor = Color.HotPink;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Green;
            button7.FlatAppearance.BorderColor = Color.White;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Green;
            button8.FlatAppearance.BorderColor = Color.White;
            Const constant = new Const(constants, new ToDic(c));
            addUserControl(constant);

        }
        public void c(BindingList<ConstantValues> c) { }
        private void ResButton_Click(object sender, EventArgs e)
        {
            History History = new History(new DHistory(his));

            /*if(proverki_const(textBoxIntegral.Text)) 
            {
                Const constform = new Const(constants, new ToDic(c));
                addUserControl(constform);
            }*/
            if (proverki_vvoda(textBoxIntegral.Text, textBoxMin.Text, textBoxMax.Text) && proverki_const(textBoxIntegral.Text))
            {
                Const constform = new Const(constants, new ToDic(c));
                double min = Convert.ToDouble(textBoxMin.Text);
                double max = Convert.ToDouble(textBoxMax.Text);
                Quadrature x = new Quadrature(textBoxIntegral.Text);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Quadrature integr = new Quadrature(textBoxIntegral.Text);
                result = integr.romberg(min, max, 0.01, 1, 4).ToString();
                sw.Stop();
                time = sw.ElapsedMilliseconds.ToString();
                Result res = new Result(result, time, textBoxIntegral.Text, textBoxMin.Text, textBoxMax.Text);

                button5.BackColor = Color.White;
                button5.ForeColor = Color.Green;
                button5.FlatAppearance.BorderColor = Color.White;
                button7.BackColor = Color.White;
                button7.ForeColor = Color.Green;
                button7.FlatAppearance.BorderSize = 3;
                button7.FlatAppearance.BorderColor = Color.HotPink;
                button6.BackColor = Color.White;
                button6.ForeColor = Color.Green;
                button6.FlatAppearance.BorderColor = Color.White;
                button8.BackColor = Color.White;
                button8.ForeColor = Color.Green;
                button8.FlatAppearance.BorderColor = Color.White;
                addUserControl(res);
                //constants.Clear();
            }

            inputs.Add(textBoxIntegral.Text);
            History.inputs = inputs;
        }

        private void textBoxIntegral_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Green;
            button5.FlatAppearance.BorderColor = Color.White;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Green;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatAppearance.BorderColor = Color.HotPink;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Green;
            button7.FlatAppearance.BorderColor = Color.White;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Green;
            button6.FlatAppearance.BorderColor = Color.White;
            History History = new History(new DHistory(his));
            History.inputs = inputs;
            //d(inputs);
            addUserControl(History);

            //History.Dispose();

        }

        private void неНажиматьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}