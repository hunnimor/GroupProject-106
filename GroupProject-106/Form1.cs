using PolishNotation;

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
            PostfixNotationExpression c = new PostfixNotationExpression();
            string text = textBox1.Text;

            string result = "";
            for (int i = 0; i < c.ConvertToPostfixNotation(text).Length; i++)
            {
                result += c.ConvertToPostfixNotation(text)[i];
                result += " ";
            }
            textBox2.Text = result;
        }
    }
}