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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int counter = 0;
        int len = 0;
        string text;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = text.Substring(0, counter);
            counter++;
            if (counter > len)
            {
                timer1.Stop();
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"8263-pornhub-intro-sound.wav");
            player.Play();*/
            text = label1.Text;
            len = text.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }
    }
}
