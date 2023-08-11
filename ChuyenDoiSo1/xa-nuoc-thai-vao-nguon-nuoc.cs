namespace xa_nuoc_thai_vao_nguon_nuoc
{
    public partial class xanuocthai_VNN : Form
    {
        public xanuocthai_VNN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel bottomMarginPanel = new Panel();
            bottomMarginPanel.Dock = DockStyle.Bottom;
            bottomMarginPanel.Height = 20; // Chiều cao của khoảng trống
            this.Controls.Add(bottomMarginPanel);
        }
    }
}