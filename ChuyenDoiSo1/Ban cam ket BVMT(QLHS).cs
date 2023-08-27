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
    public partial class Ban_cam_ket_BVMT_QLHS_ : Form
    {
        public Ban_cam_ket_BVMT_QLHS_()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkKehoach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KehoachBVMT_QLHS_ a = new KehoachBVMT_QLHS_();
            a.ShowDialog();
        }

        private void linkDean_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            De_an_BVMT a = new De_an_BVMT();
            a.ShowDialog();
        }

        private void linkDangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ban_dang_ky_dat_TCMT_QLHS_ a = new Ban_dang_ky_dat_TCMT_QLHS_();
            a.ShowDialog();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int lineHeight = TextRenderer.MeasureText("A", textBox.Font).Height; // Chiều cao của mỗi dòng văn bản
            int lineCount = textBox.GetLineFromCharIndex(textBox.TextLength) + 1; // Số dòng văn bản

            // Thiết lập chiều cao mới cho TextBox
            textBox.Height = lineCount * lineHeight + textBox.Padding.Vertical;
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
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
