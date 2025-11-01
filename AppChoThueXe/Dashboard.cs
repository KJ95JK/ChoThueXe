using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppChoThueXe
{
    public partial class Dashboard : Form
    {
        private string userRole;
        private string username;
        public Dashboard(string role, string username)
        {
            InitializeComponent();
            userRole = role;
            this.username = username;
        }
        private void DisplayUserName()
        {
            lbXinChaoUsername.Text = "Xin chào: " + username + ", chúc bạn một ngày vui vẻ!";
        }
        // Phương thức để tùy chỉnh giao diện theo quyền
        private void CustomizeDashboard()
        {
            if (userRole == "QUANTRI")
            {
                // Hiển thị tất cả các chức năng cho quản trị viên
                btnThongKe.Visible = true;
                btnNguoiDung.Visible = true;
            }
            else if (userRole == "NHANVIEN")
            {
                // Ẩn chức năng thống kê và quản lý người dùng cho nhân viên
                btnThongKe.Visible = false;
                btnNguoiDung.Visible = false;
            }
            else
            {
                MessageBox.Show("Quyền người dùng không hợp lệ.");
            }
        }

        private void ChangeIconColor(FontAwesome.Sharp.IconButton clickedButton)
        {
            // Đặt lại màu icon mặc định cho tất cả nút
            btnTrangChu.IconColor = Color.FromArgb(157, 247, 229);
            btnTrangChu.ForeColor = Color.FromArgb(157, 247, 229);
            btnTrangChu.BackColor = Color.FromArgb(0, 67, 133);
            btnQuanLyXe.IconColor = Color.FromArgb(157, 247, 229);
            btnQuanLyXe.ForeColor = Color.FromArgb(157, 247, 229);
            btnQuanLyXe.BackColor = Color.FromArgb(0, 67, 133);
            btnDonDatXe.IconColor = Color.FromArgb(157, 247, 229);
            btnDonDatXe.ForeColor = Color.FromArgb(157, 247, 229);
            btnDonDatXe.BackColor = Color.FromArgb(0, 67, 133);
            btnThanhToan.IconColor = Color.FromArgb(157, 247, 229);
            btnThanhToan.ForeColor = Color.FromArgb(157, 247, 229);
            btnThanhToan.BackColor = Color.FromArgb(0, 67, 133);
            btnNguoiDung.IconColor = Color.FromArgb(157, 247, 229);
            btnNguoiDung.ForeColor = Color.FromArgb(157, 247, 229);
            btnNguoiDung.BackColor = Color.FromArgb(0, 67, 133);
            btnThongKe.IconColor = Color.FromArgb(157, 247, 229);
            btnThongKe.ForeColor = Color.FromArgb(157, 247, 229);
            btnThongKe.BackColor = Color.FromArgb(0, 67, 133);

            // Thay đổi màu icon cho nút được nhấn
            clickedButton.BackColor = Color.FromArgb(157, 247, 229);
            clickedButton.ForeColor = Color.FromArgb(0, 67, 133);
            clickedButton.IconColor = Color.FromArgb(0, 67, 133);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ChangeIconColor(btnTrangChu);
            PageChucNangTrangChu.Visible = true;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            CustomizeDashboard();
            DisplayUserName();
            this.FormClosing += Dashboard_FormClosing;
        }

        private void btnQuanLyXe_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnQuanLyXe);
            PageChucNangTrangChu.Visible = false;
            PageChucNangQuanLyXe.Visible = true;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            DisplayUserName();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnTrangChu);
            PageChucNangTrangChu.Visible = true;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            DisplayUserName();
        }

        private void btnDonDatXe_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnDonDatXe);
            PageChucNangTrangChu.Visible = false;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = true;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            DisplayUserName();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnNguoiDung); 
            PageChucNangTrangChu.Visible = false;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = true;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            DisplayUserName();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnThongKe);
            PageChucNangTrangChu.Visible = false;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = false;
            //PageChucNangThongKe.Visible = false;
            MessageBox.Show("Comming Soon", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PageChucNangTrangChu.Visible = true;
            ChangeIconColor(btnTrangChu);
            DisplayUserName();
        }

        // Bắt sự kiện khi form Dashboard đóng
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();
            this.Hide();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắc muốn đăng xuất?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ChangeIconColor(btnThanhToan);
            PageChucNangTrangChu.Visible = false;
            PageChucNangQuanLyXe.Visible = false;
            PageChucNangDonDatXe.Visible = false;
            PageChucNangNguoiDung.Visible = false;
            PageChucNangThanhToan.Visible = true;
            //PageChucNangThongKe.Visible = false;
            DisplayUserName();
        }
    }
}
