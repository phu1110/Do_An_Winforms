using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDoiSo1
{
    public partial class Ban_dang_ky_dat_TCMT_QLHS_ : Form
    {
        public Ban_dang_ky_dat_TCMT_QLHS_()
        {
            InitializeComponent();
        }
        private void Ban_dang_ky_dat_TCMT_QLHS__Load(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
        private void linkCamket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }
    }
}
