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

namespace AppChoThueXe
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        private DatabaseHelper _databaseHelper = new DatabaseHelper();
        private void LoadDuLieuVaoListView()
        {
            string query = "SELECT KHACHHANG.ID_KHACHHANG, KHACHHANG.TENKHACHHANG, KHACHHANG.CCCD, KHACHHANG.NGAYSINH, KHACHHANG.SODIENTHOAI, KHACHHANG.EMAIL, KHACHHANG.GIOITINH FROM KHACHHANG";  // Câu truy vấn SQL
            DataTable data = _databaseHelper.GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID_KHACHHANG"].ToString());
                item.SubItems.Add(row["TENKHACHHANG"].ToString());
                item.SubItems.Add(row["CCCD"].ToString()); // Hiển thị tên hãng xe từ bảng HANGXE
                item.SubItems.Add(row["NGAYSINH"].ToString());
                item.SubItems.Add(row["SODIENTHOAI"].ToString());
                item.SubItems.Add(row["EMAIL"].ToString());
                item.SubItems.Add(row["GIOITINH"].ToString());
                lstvQuanLyKhachHang.Items.Add(item);
            }
            lstvQuanLyKhachHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyKhachHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstvQuanLyDonDatXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvQuanLyKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem selecteditem = lstvQuanLyKhachHang.SelectedItems[0];

                txtTenKhachHang.Text = selecteditem.SubItems[1].Text;
                txtCCCD.Text = selecteditem.SubItems[2].Text;
                DateTime selectedDate;
                if (DateTime.TryParse(selecteditem.SubItems[3].Text, out selectedDate))
                {
                    dateTimeNgaySinh.Value = selectedDate;
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                }
                txtSoDienThoai.Text = selecteditem.SubItems[4].Text;
                txtEmail.Text = selecteditem.SubItems[5].Text;

                if (selecteditem.SubItems[6].Text == "NAM")
                {
                    radNam.Checked = true;
                }
                else if (selecteditem.SubItems[6].Text == "NỮ")
                {
                    radNu.Checked = true;
                }
                else
                {
                    // Nếu giá trị không phải "NAM" hoặc "NU", có thể thiết lập trạng thái mặc định
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
            }
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieuVaoListView();
        }

        public bool KhachHangDaTonTaiChua(string cccd)
        {
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
            {
                string query = "SELECT COUNT(1) FROM KHACHHANG WHERE CCCD = @CCCD";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CCCD", cccd);

                connection.Open();
                exists = (int)cmd.ExecuteScalar() > 0;
                connection.Close();
            }
            return exists;
        }

        public void CapNhatThongTinKhachHang(string cccd, string tenKhachHang = null, DateTime? ngaySinh = null, string soDienThoai = null, string email = null, string gioiTinh = null)
        {
            using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
            {
                connection.Open();

                // Tạo câu lệnh SQL để cập nhật thông tin khách hàng
                string query = "UPDATE KHACHHANG SET " +
                               "TENKHACHHANG = ISNULL(@TENKHACHHANG, TENKHACHHANG), " +
                               "NGAYSINH = ISNULL(@NGAYSINH, NGAYSINH), " +
                               "SODIENTHOAI = ISNULL(@SODIENTHOAI, SODIENTHOAI), " +
                               "EMAIL = ISNULL(@EMAIL, EMAIL), " +
                               "GIOITINH = ISNULL(@GIOITINH, GIOITINH) " +
                               "WHERE CCCD = @CCCD";

                SqlCommand cmd = new SqlCommand(query, connection);

                // Gán giá trị tham số (sử dụng NULL nếu không cần cập nhật trường nào)
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                cmd.Parameters.AddWithValue("@TENKHACHHANG", (object)tenKhachHang ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NGAYSINH", (object)ngaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SODIENTHOAI", (object)soDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EMAIL", (object)email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@GIOITINH", (object)gioiTinh ?? DBNull.Value);

                // Thực thi lệnh
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Thông tin khách hàng đã được cập nhật thành công.");
                }
                else
                {
                    Console.WriteLine("Không có thay đổi nào được thực hiện.");
                }
            }
        }



        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" || txtCCCD.Text == "" || txtSoDienThoai.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenkhachhang = txtTenKhachHang.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string ngaySinh = dateTimeNgaySinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = string.Empty;
            if (radNam.Checked)
            {
                gioiTinh = "NAM";
            }
            else
            {
                gioiTinh = "NỮ";
            }
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            // Kiểm tra xem khách hàng đã tồn tại chưa dựa trên CCCD
            if (KhachHangDaTonTaiChua(cccd))
            {
                // Nếu khách hàng đã tồn tại, thực hiện các hành động cần thiết (ví dụ, thông báo hoặc cập nhật)
                CapNhatThongTinKhachHang(cccd);
                MessageBox.Show($"Khách hàng với CCCD '{cccd}' đã tồn tại. Thông tin đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu chưa tồn tại, thêm mới
                string query = "INSERT INTO KHACHHANG (TENKHACHHANG, CCCD, NGAYSINH, SODIENTHOAI, EMAIL, GIOITINH) " +
                               "VALUES (@TENKHACHHANG, @CCCD, @NGAYSINH, @SODIENTHOAI, @EMAIL, @GIOITINH)";

                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Gán giá trị cho các tham số
                    cmd.Parameters.AddWithValue("@TENKHACHHANG", txtTenKhachHang.Text.Trim());
                    cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
                    cmd.Parameters.AddWithValue("@NGAYSINH", dateTimeNgaySinh.Value); // DateTimePicker
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", txtSoDienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMAIL", string.IsNullOrEmpty(txtEmail.Text.Trim()) ? (object)DBNull.Value : txtEmail.Text.Trim()); // Email có thể null
                    cmd.Parameters.AddWithValue("@GIOITINH", radNam.Checked ? "NAM" : "NỮ"); // RadioButton

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            lstvQuanLyKhachHang.Items.Clear();
            LoadDuLieuVaoListView();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (lstvQuanLyKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvQuanLyKhachHang.SelectedItems[0];
                string idKhachHang = selectedItem.SubItems[0].Text; // ID_KHACHHANG là cột đầu tiên
                string tenKhachHang = txtTenKhachHang.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                DateTime ngaySinh = dateTimeNgaySinh.Value; // Ngày sinh từ DateTimePicker
                string soDienThoai = txtSoDienThoai.Text.Trim();
                string email = txtEmail.Text.Trim();
                string gioiTinh = radNam.Checked ? "NAM" : "NỮ"; // Giới tính từ RadioButton

                string query = "UPDATE KHACHHANG SET TENKHACHHANG = @TENKHACHHANG, CCCD = @CCCD, NGAYSINH = @NGAYSINH, " +
                               "SODIENTHOAI = @SODIENTHOAI, EMAIL = @EMAIL, GIOITINH = @GIOITINH " +
                               "WHERE ID_KHACHHANG = @ID_KHACHHANG";

                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID_KHACHHANG", idKhachHang); // ID_KHACHHANG không thay đổi
                    cmd.Parameters.AddWithValue("@TENKHACHHANG", tenKhachHang);
                    cmd.Parameters.AddWithValue("@CCCD", cccd);
                    cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", soDienThoai);
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@GIOITINH", gioiTinh);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lstvQuanLyKhachHang.Items.Clear();
                // Sau khi sửa, tải lại dữ liệu vào ListView
                LoadDuLieuVaoListView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            // Lấy ID_KHACHHANG từ ListView (cột đầu tiên)
            if (lstvQuanLyKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idKhachHang = lstvQuanLyKhachHang.SelectedItems[0].SubItems[0].Text; // Giả sử cột ID_KHACHHANG là cột đầu tiên

            // Chuỗi kết nối từ DatabaseHelper
            string connectionString = _databaseHelper._connectionString;

            // Tạo câu truy vấn
            string queryCheck = $"SELECT COUNT(*) FROM DATXE WHERE ID_KHACHHANG = '{idKhachHang}'";
            string queryDelete = $"DELETE FROM KHACHHANG WHERE ID_KHACHHANG = '{idKhachHang}'";
            string queryResetIdentity = "DBCC CHECKIDENT ('KHACHHANG', RESEED)";  // Reset Identity

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem khách hàng có tồn tại trong bảng DATXE
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, connection))
                    {
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Không thể xóa khách hàng này vì đang có đơn đặt xe liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Xóa khách hàng
                    using (SqlCommand cmdDelete = new SqlCommand(queryDelete, connection))
                    {
                        int rowsAffected = cmdDelete.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Reset giá trị Identity sau khi xóa
                            using (SqlCommand cmdResetIdentity = new SqlCommand(queryResetIdentity, connection))
                            {
                                cmdResetIdentity.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Xóa khách hàng khỏi ListView
                            lstvQuanLyKhachHang.Items.Remove(lstvQuanLyKhachHang.SelectedItems[0]);
                            lstvQuanLyKhachHang.Items.Clear();
                            LoadDuLieuVaoListView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
