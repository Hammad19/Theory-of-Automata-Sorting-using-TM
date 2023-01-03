using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertion_sort_using_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lwTM.View = View.Details;
            lwTM.GridLines = true;
            lwTM.FullRowSelect = true;

        }


        private void txtInputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {

            InsertionSort Ins = new InsertionSort();
            string s = txtInputs.Text;
            if (s.Last() == ' ')
            {
                s = s.Remove(s.Length - 1, 1);
            }
            Ins.array = Array.ConvertAll(s.Split(' '), int.Parse);
            var t = Ins.Sorting();
            foreach (string[] l in t.Item2)
            {
                ListViewItem n = new ListViewItem(l);
                lwTM.Items.Add(n);
            }
            txtOutputs.Text = t.Item1;
        }
    }
}
