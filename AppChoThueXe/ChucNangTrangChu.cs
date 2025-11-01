using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChoThueXe
{
    public partial class ChucNangTrangChu : UserControl
    {
        public ChucNangTrangChu()
        {
            InitializeComponent();
        }

        private void btnHuongDanSuDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKiemTraCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên Bản Hiện Tại Của Bạn Đang Là Phiên Bản Mới Nhất: H1.0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
