using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject_106
{
    public partial class Result : UserControl
    {
        public string Res;
        public string Time;
        public string Integral, Min, Max;
        /*public string exp = "1/3";
        public int left = 0, right = 30, height = 30;*/
        public Result(string Res, string Time, string integral, string min, string max)
        {
            InitializeComponent();
            label2.Text = integral + "=" + Res;
            label6.Text = min;
            label7.Text = max;
            textBoxTime.Text = Time;
            Integral = integral;
            Min = min;
            Max = max;
        }
        /*public void Adopt()
        {
            var form1 = new Form1();
            Res = form1.result;
            Time = form1.time;
        }*/
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form3(Integral, Min, Max);
            myForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
