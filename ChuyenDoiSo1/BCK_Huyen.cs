using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDoiSo1
{
    public partial class BCK_Huyen : Form
    {
        public BCK_Huyen()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox.Multiline)
                {
                    int selectionStart = textBox.SelectionStart;
                    textBox.Text = textBox.Text.Insert(selectionStart, Environment.NewLine);
                    textBox.SelectionStart = selectionStart + Environment.NewLine.Length;
                    e.Handled = true;
                }
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox.Multiline)
                {
                    int selectionStart = textBox.SelectionStart;
                    textBox.Text = textBox.Text.Insert(selectionStart, Environment.NewLine);
                    textBox.SelectionStart = selectionStart + Environment.NewLine.Length;
                    e.Handled = true;
                }
            }
        }
    }
}
