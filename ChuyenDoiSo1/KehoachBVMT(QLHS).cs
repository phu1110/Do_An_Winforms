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
    public partial class KehoachBVMT_QLHS_ : Form
    {
        public KehoachBVMT_QLHS_()
        {
            InitializeComponent();
        }

        private void linkCamket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ban_cam_ket_BVMT_QLHS_ a = new Ban_cam_ket_BVMT_QLHS_();
            a.ShowDialog();
        }

        private void linkDangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ban_dang_ky_dat_TCMT_QLHS_ a = new Ban_dang_ky_dat_TCMT_QLHS_();
            a.ShowDialog();

        }

        private void linkDean_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            De_an_BVMT a = new De_an_BVMT();
            a.ShowDialog();
        }
    }
}
