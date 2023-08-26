using danh_gia_tac_dong_moi_truong;
using khai_thac_nuoc_duoi_dat;
using System.Security.RightsManagement;
using System.Windows.Media.Media3D;
using xa_nuoc_thai_vao_nguon_nuoc;

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

        private void nhậpDữLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           HSTra_BKHBVMT hst = new HSTra_BKHBVMT();
            hst.ShowDialog();
            HSTra_DABVMT hstda = new HSTra_DABVMT();
            hstda.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hp = new HelpForm();
            hp.ShowDialog();
        }

        private void bảnĐăngKýĐạtTCMTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ban_dang_ki a = new Ban_dang_ki();
            a.ShowDialog();
        }

        private void quảnLýTàiNguyênĐấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khaithac_dat kt_dat = new khaithac_dat();
            kt_dat.ShowDialog();
        }

        private void đánhGiáTácĐộngMôiTrườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhgia_TDMT dg = new danhgia_TDMT();
            dg.ShowDialog();
        }

        private void xảNướcThảVàoNguồnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xanuocthai_VNN  xnt = new xanuocthai_VNN();
            xnt.ShowDialog();
        }

        private void kếHoạchBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HSTra_BKHBVMT HST = new HSTra_BKHBVMT();
            HST.ShowDialog();
        }

        private void đềÁnBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HSTra_DABVMT HST = new HSTra_DABVMT();
            HST.ShowDialog();
        }

        private void bảnĐăngKýĐạtTCMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ban_dang_ky_dat_TCMT_QLHS_ a = new Ban_dang_ky_dat_TCMT_QLHS_();
            a.ShowDialog();
        }

        private void camKếtBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ban_cam_ket_BVMT_QLHS_ a = new Ban_cam_ket_BVMT_QLHS_();
            a.ShowDialog();
        }

        private void kếHoạchBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH_Huyen a = new KH_Huyen();
            a.ShowDialog();
        }

        private void đềÁnBVMTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            De_an_BVMT a = new De_an_BVMT();
            a.ShowDialog();
        }

        private void khaiThácNướcDướiĐấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khaithac_dat a = new khaithac_dat();
            a.ShowDialog();
        }

        private void camKếtBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCK_Huyen a = new BCK_Huyen();
            a.ShowDialog();
        }

        private void kếHoạchBVMTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KehoachBVMT_QLHS_ a = new KehoachBVMT_QLHS_();
            a.ShowDialog();
        }

        private void đềÁnBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DA_Huyen a = new DA_Huyen();
            a.ShowDialog();
        }

        private void thốngKêToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ThongKe TT = new ThongKe();
            TT.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoimatkhauForm_ a = new DoimatkhauForm_();
            a.ShowDialog();
        }

        private void đổiGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoigiaodienForm a = new DoigiaodienForm();
            a.ShowDialog();
        }

        private void vănBảnLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuatBVMT a = new LuatBVMT();
            a.ShowDialog();
        }
    }
}