using System.Security.RightsManagement;

namespace ChuyenDoiSo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private class renderer : ToolStripProfessionalRenderer
        {
            public renderer() : base(new cols()) { }
        }

        private class cols : ProfessionalColorTable
        {
            public override Color MenuItemSelected { get { return Color.MidnightBlue; } }
            public override Color MenuItemSelectedGradientBegin { get { return Color.Black; } }
            public override Color MenuItemSelectedGradientEnd { get { return Color.White; } }
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bảnĐăngKýĐạtTCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ban_dang_ki a = new Ban_dang_ki();
            a.ShowDialog();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }
    }
}