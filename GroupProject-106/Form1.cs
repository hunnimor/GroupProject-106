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
            foreach (var a in c.ConvertToPostfixNotation(text)){
                result += a;
                result += " ";
            }
            textBox2.Text = result;
            textBox3.Text = c.result(text).ToString();
        }
    }
}