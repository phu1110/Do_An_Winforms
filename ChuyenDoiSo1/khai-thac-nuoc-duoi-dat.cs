namespace khai_thac_nuoc_duoi_dat
{
    public partial class khaithac_dat : Form
    {
        public khaithac_dat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
