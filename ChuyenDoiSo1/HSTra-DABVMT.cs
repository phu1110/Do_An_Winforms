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
    public partial class HSTra_DABVMT : Form
    {
        public HSTra_DABVMT()
        {
            InitializeComponent();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Tạm thời lưu lại chiều cao ban đầu của TextBox (nếu cần)
            int initialHeight = textBox.Height;

            // Tính toán chiều cao mới dựa trên nội dung
            int newHeight = TextRenderer.MeasureText(textBox.Text, textBox.Font, new Size(textBox.Width, int.MaxValue), TextFormatFlags.WordBreak).Height;

            // Thiết lập chiều cao mới cho TextBox
            textBox.Height = newHeight;

            // Đảm bảo chiều cao không nhỏ hơn chiều cao ban đầu (nếu cần)
            if (textBox.Height < initialHeight)
            {
                textBox.Height = initialHeight;
            }
        }
    }
}
