using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChuyenDoiSo1
{
    public partial class LuatBVMT : Form
    {
        public LuatBVMT()
        {
            InitializeComponent();
        }

        private void LuatBVMT_Load(object sender, EventArgs e)
        {

        }

        private void linkTNMT_QLMT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://thuvienphapluat.vn/van-ban/Tai-nguyen-Moi-truong/Thong-tu-02-2022-TT-BTNMT-huong-dan-Luat-Bao-ve-moi-truong-500694.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QLMT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://thuvienphapluat.vn/van-ban/Tai-nguyen-Moi-truong/Ke-hoach-5402-KH-UBND-2022-tang-cuong-cong-tac-lanh-dao-bao-ve-moi-truong-Lam-Dong-525899.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkTNMT_QLTNKS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "http://vanban.monre.gov.vn/Admin/Uploads/VanBan/Lu%E1%BA%ADt%20Kho%C3%A1ng%20s%E1%BA%A3n%202010.DOCS";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QLTNKS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://thuvienphapluat.vn/van-ban/Tai-nguyen-Moi-truong/Chi-thi-09-CT-UBND-2021-tang-cuong-cong-tac-quan-ly-hoat-dong-khoang-san-tinh-Lam-Dong-486308.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkTNMT_QLTND_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "http://vanban.monre.gov.vn/Admin/Uploads/VanBan/Lu%E1%BA%ADt%20%C4%90%E1%BA%A5t%20%C4%91ai%20n%C4%83m%202013.doc";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QLTND_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://lamdong.gov.vn/sites/stnmt/vbqppl/SitePages/Home.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkTNMT_QLTNN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "http://vanban.monre.gov.vn/Admin/Uploads/VanBan/Lu%E1%BA%ADt%20t%C3%A0i%20nguy%C3%AAn%20n%C6%B0%E1%BB%9Bc%202012.doc";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QLTNN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://lamdong.gov.vn/sites/stnmt/vbqppl/tainguyennuoc/SitePages/Home.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkTNMT_QLTNR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://lamdong.gov.vn/sites/stnmt/vbqppl/SitePages/Home.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QLTNR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://lamdong.gov.vn/sites/stnmt/vbqppl/SitePages/Home.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkTNMT_QCTCHH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://thuvienphapluat.vn/van-ban/Tai-nguyen-Moi-truong/Thong-tu-01-2023-TT-BTNMT-Quy-chuan-ky-thuat-chat-luong-moi-truong-xung-quanh-559212.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkUBND_QCTCHH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Địa chỉ URL bạn muốn mở
            string url = "https://thuvienphapluat.vn/van-ban/Bo-may-hanh-chinh/Quyet-dinh-47-2022-QD-UBND-tieu-chuan-danh-gia-chinh-quyen-dia-phuong-o-xa-phuong-Lam-Dong-534175.aspx";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
