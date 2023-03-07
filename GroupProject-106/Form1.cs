using PolishNotation;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //PostfixNotationExpression c = new PostfixNotationExpression();
            //string text = textBox1.Text;
            //string result = "";
            foreach (var a in c.ConvertToPostfixNotation(text))
            {
                result += a;
                result += " ";
            }
            textBox2.Text = result;
            //textBox3.Text = c.result(text).ToString();
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PostfixNotationExpression c = new PostfixNotationExpression();
            string text = textBox3.Text;
            string result = "";
            foreach (var a in c.ConvertToPostfixNotation(text))
            {
                result += a;
                result += " ";
            }
            //textBox5.Text = result;
            textBox5.Text = c.result(text).ToString();
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            PostfixNotationExpression c = new PostfixNotationExpression();
            string text = textBox3.Text;
            string result = "";
            foreach (var a in c.ConvertToPostfixNotation(text))
            {
                result += a;
                result += " ";
            }
            //textBox5.Text = result;
            textBox5.Text = c.result(text).ToString();
        }
    }
}