using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupProject_106
{
    public partial class Menu : UserControl
    {
        private MyDelegate d;

        public Menu(MyDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Operation_click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            Button button = (Button)sender;
            string exp = button.Text;
            d(exp);
            //form.ShowDialog();
            //form.textBoxIntegral.Text += expression.ToString();
            //MessageBox.Show(""+expression+"");
        }
        /*public string GetUserControlText() { 
            return expression; 
        }*/
        /*public string Data
        {
            get
            {
                return expression;
            }
        }*/
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            d("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d("-1");
        }
    }
}
