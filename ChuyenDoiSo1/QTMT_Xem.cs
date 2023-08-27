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
    public partial class QTMT_Xem : Form
    {
        public QTMT_Xem()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            f(e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            f(e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                textBox.AppendText(Environment.NewLine);
                e.Handled = true; // Ngăn việc kích hoạt sự kiện mặc định của phím Enter
            }
        }
    }
}
