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
    public partial class DA_Huyen : Form
    {
        public DA_Huyen()
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ban_dang_ki a = new Ban_dang_ki();
            ShowDialog(a);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BCK_Huyen a = new BCK_Huyen();
            ShowDialog(a);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KH_Huyen a = new KH_Huyen();
            ShowDialog(a);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HSTra_BKHBVMT a = new HSTra_BKHBVMT();
            ShowDialog(a);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HSTra_DABVMT a = new HSTra_DABVMT();
            ShowDialog(a);
        }
    }
}
