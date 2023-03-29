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
    public partial class History : UserControl
    {
        private DHistory d;
        public List<string> inputs;
        public int k = -1;
        public string name;
        public History(DHistory sender)
        {
            InitializeComponent();
            Form1 form = new Form1();
            d = sender;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }
        public void func(List<string> param)
        {
            inputs = param;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Show();
        }

        private void History_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            for (int i = 0; i < inputs.Count; i++)
            {
                //listBox3.Items.Add(result[i]);
                listBox1.Items.Add(inputs[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                name = listBox1.SelectedItem.ToString(); // получаем имя из текстового поля
                d(name);
            }
        }
    }
}
