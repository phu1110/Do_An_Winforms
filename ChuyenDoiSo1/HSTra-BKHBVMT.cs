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
    public partial class HSTra_BKHBVMT : Form
    {
        public HSTra_BKHBVMT()
        {
            InitializeComponent();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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
