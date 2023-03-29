using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupProject_106
{
    public partial class Const : UserControl
    {
        public BindingList<ConstantValues> constants;
        private bool ok = false;
        private ToDic c;
        public Const(BindingList<ConstantValues> constants1, ToDic sender)
        {
            InitializeComponent();
            c = sender;
            constants = constants1;

            dataGridView1.DataSource = constants1;
            dataGridView1.DataError += dataGridView1_DataError;
        }

        private void Const_Load(object sender, EventArgs e)
        {
            
            StyleDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error");
        }
        public void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ForeColor = Color.Green;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.HotPink;
            //DataGridViewdataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVerticalte;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (constants != null)
            {
                c(constants);
            }
        }
    }
}
/*
 for (int i = 0; i < constants.Count; i++)
            {
                if (constants[i].Name.Length == 1)
                {
                    char c = char.Parse(constants[i].Name);
                    //int m = System.Convert.ToInt32(c);
                    //MessageBox.Show("" + m+"");

                    if (c != 'x' && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        /*if (i < newc.Count - 2 && newc[i] == "c" && newc[i + 1] == "o" && newc[i + 2] == "s")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]); newc.Remove(newc[i + 2]);
                        }
                        if (i < newc.Count - 2 && newc[i] == "s" && newc[i + 1] == "i" && newc[i + 2] == "n")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]); newc.Remove(newc[i + 2]);
                        }
                        if (i < newc.Count - 2 && newc[i] == "c" && newc[i + 1] == "t" && newc[i + 2] == "g")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]); newc.Remove(newc[i + 2]);
                        }
                        if (i < newc.Count - 2 && newc[i] == "l" && newc[i + 1] == "o" && newc[i + 2] == "g")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]); newc.Remove(newc[i + 2]);
                        }
                        if (i < newc.Count - 1 && newc[i] == "l" && newc[i + 1] == "n")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]);
                        }
                        if (i < newc.Count - 1 && newc[i] == "t" && newc[i + 1] == "g")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]);
                        }
                        ok = true;
                        //constants.Add(new() { Name = newc[i], Value = 0.0 });
                    }
                    /*else if (constants[i].Name.Length == 2)
                    {

                        if (i < constants[i].Name.Length - 1 && constants[i].Name == "l" && constants[i + 1] == "n")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]);
                        }
                        if (i < newc.Count - 1 && newc[i] == "t" && newc[i + 1] == "g")
                        {
                            newc.Remove(newc[i]); newc.Remove(newc[i + 1]);
                        }

                        newc.Remove(newc[i]);
                    }
            if (ok == true)
            {
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
                for (int i = 0; i < constants.Count; i++)
                {
                    constants.Add(new() { Name = constants[i].Name, Value = 0.0 });
                    //_constants.Add(new() { Name = newc[i], Value = 0.0 });
                }
 */