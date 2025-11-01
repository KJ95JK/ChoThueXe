using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppChoThueXe
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private DatabaseHelper _databaseHelper = new DatabaseHelper();



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;  // Giả sử bạn đã mã hóa mật khẩu trong cơ sở dữ liệu, sử dụng MD5 hoặc SHA256

            // Câu truy vấn để lấy quyền người dùng
            string query = "SELECT QUYEN FROM NGUOIDUNG WHERE USERNAME = @username AND MATKHAU = @password";

            try
            {
                using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);  // Mật khẩu đã được mã hóa
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string quyen = reader["QUYEN"].ToString();

                        MessageBox.Show("Bạn Đã Đăng Nhập Với Quyền: " + quyen, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở form Dashboard và chuyển quyền
                        Dashboard db = new Dashboard(quyen, username); // Truyền quyền vào Dashboard
                        db.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                // Nếu checkbox được chọn, hiển thị mật khẩu
                txtMatKhau.PasswordChar = '\0';  // Mật khẩu sẽ không bị ẩn, hiển thị rõ
            }
            else
            {
                // Nếu checkbox không được chọn, ẩn mật khẩu
                txtMatKhau.PasswordChar = '*';  // Mật khẩu sẽ bị ẩn bằng dấu *
            }
        }
    }
}
