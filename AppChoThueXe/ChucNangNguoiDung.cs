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
    public partial class ChucNangNguoiDung : UserControl
    {

        public ChucNangNguoiDung()
        {
            InitializeComponent();
        }
        private DatabaseHelper _databaseHelper = new DatabaseHelper();
        private void LoadDuLieuVaoListView()
        {
            string query = "SELECT * FROM NGUOIDUNG";  // Câu truy vấn SQL
            DataTable data = _databaseHelper.GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID_NGUOIDUNG"].ToString());
                item.SubItems.Add(row["USERNAME"].ToString());
                string quyen = row["QUYEN"].ToString();
                string matKhau = row["MATKHAU"].ToString();
                // Nếu quyền là "QUANTRI", hiển thị mật khẩu thật, nếu không, hiển thị dấu "*"
                if (quyen == "QUANTRI")
                {
                    item.SubItems.Add(matKhau); // Hiển thị mật khẩu thật cho người quản trị
                }
                else
                {
                    item.SubItems.Add(new string('*', matKhau.Length)); // Hiển thị dấu "*" cho mật khẩu của người dùng khác
                }
                item.SubItems.Add(row["QUYEN"].ToString());

                lstvQuanLyNguoiDung.Items.Add(item);
            }
            lstvQuanLyNguoiDung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyNguoiDung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void LoadUserRolesToComboBox()
        {
            // Câu truy vấn SQL để lấy quyền người dùng
            string query = "SELECT DISTINCT QUYEN FROM NGUOIDUNG WHERE QUYEN IN ('QUANTRI', 'NHANVIEN')";

            // Khởi tạo ComboBox (giả sử bạn có một ComboBox tên là cbbQuyen)
            cbbQuyen.Items.Clear();  // Xóa các mục trong ComboBox trước khi thêm mới

            try
            {
                using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Duyệt qua các quyền người dùng và thêm vào ComboBox
                    while (reader.Read())
                    {
                        string quyen = reader["QUYEN"].ToString();
                        string quyenHienThi = "";

                        // Ánh xạ các giá trị không dấu sang tiếng Việt
                        switch (quyen)
                        {
                            case "QUANTRI":
                                quyenHienThi = "Quản trị";
                                break;
                            case "NHANVIEN":
                                quyenHienThi = "Nhân viên";
                                break;
                            default:
                                quyenHienThi = quyen; // Giữ nguyên nếu không có ánh xạ
                                break;
                        }

                        // Thêm quyền vào ComboBox
                        cbbQuyen.Items.Add(quyenHienThi);
                    }

                    // Đặt giá trị mặc định cho ComboBox nếu cần
                    if (cbbQuyen.Items.Count > 0)
                    {
                        cbbQuyen.SelectedIndex = 0; // Chọn mục đầu tiên trong ComboBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ChucNangNguoiDung_Load(object sender, EventArgs e)
        {
            btnSuaNguoiDung.Enabled = false;
            btnXoaNguoiDung.Enabled = false;
            LoadUserRolesToComboBox();
            LoadDuLieuVaoListView();
            lstvQuanLyNguoiDung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstvQuanLyNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvQuanLyNguoiDung.SelectedItems.Count > 0)
            {
                btnSuaNguoiDung.Enabled = true;
                btnXoaNguoiDung.Enabled = true;
                ListViewItem selecteditem = lstvQuanLyNguoiDung.SelectedItems[0];
                txtUsername.Text = selecteditem.SubItems[1].Text;
                txtMatKhau.Text = selecteditem.SubItems[2].Text;
                // Lấy quyền người dùng từ ListView (giả sử quyền là SubItem thứ 3)
                string quyen = selecteditem.SubItems[3].Text;

                // Cập nhật ComboBox với quyền của người dùng
                switch (quyen)
                {
                    case "QUANTRI":
                        cbbQuyen.SelectedItem = "Quản trị";  // Hiển thị quyền Quản trị
                        break;
                    case "NHANVIEN":
                        cbbQuyen.SelectedItem = "Nhân viên";  // Hiển thị quyền Nhân viên
                        break;
                    default:
                        cbbQuyen.SelectedItem = quyen; // Nếu có quyền khác, giữ nguyên
                        break;
                }
            }
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtMatKhau.Text;
            string role = cbbQuyen.SelectedItem.ToString();

            // Chuyển đổi giá trị hiển thị trong ComboBox thành giá trị gốc phù hợp với cơ sở dữ liệu
            string roleValue = "";
            switch (role)
            {
                case "Quản trị":
                    roleValue = "QUANTRI";
                    break;
                case "Nhân viên":
                    roleValue = "NHANVIEN";
                    break;
                default:
                    MessageBox.Show("Giá trị quyền không hợp lệ.");
                    return;
            }

            // Kiểm tra nếu có thông tin thiếu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(roleValue))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM NGUOIDUNG WHERE USERNAME = @username";
            string insertQuery = "INSERT INTO NGUOIDUNG (USERNAME, MATKHAU, QUYEN) VALUES (@username, @password, @role)";
            string updateQuery = "UPDATE NGUOIDUNG SET MATKHAU = @password, QUYEN = @role WHERE USERNAME = @username";

            try
            {
                using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                {
                    conn.Open();

                    // Kiểm tra xem tên người dùng đã tồn tại hay chưa
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int count = (int)checkCmd.ExecuteScalar(); // Lấy số lượng người dùng có tên giống

                    if (count > 0)
                    {
                        // Nếu người dùng đã tồn tại, thực hiện cập nhật
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.Parameters.AddWithValue("@password", password);
                        updateCmd.Parameters.AddWithValue("@role", roleValue);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật người dùng thành công!");
                    }
                    else
                    {
                        // Nếu người dùng chưa tồn tại, thực hiện thêm mới
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@role", roleValue);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm người dùng thành công!");
                    }
                    lstvQuanLyNguoiDung.Items.Clear();
                    // Sau khi thêm hoặc cập nhật, cập nhật lại ListView
                    LoadDuLieuVaoListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý người dùng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có người dùng được chọn trong ListView
            if (lstvQuanLyNguoiDung.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvQuanLyNguoiDung.SelectedItems[0];
                string username = selectedItem.SubItems[1].Text; // Lấy username từ ListView

                // Xác nhận việc xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng " + username + "?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM NGUOIDUNG WHERE USERNAME = @username"; // Câu truy vấn xoá

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                        {
                            conn.Open();

                            SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                            cmd.Parameters.AddWithValue("@username", username); // Thêm parameter username

                            // Thực thi câu truy vấn
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xoá người dùng thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy người dùng để xoá.");
                            }
                            lstvQuanLyNguoiDung.Items.Clear();
                            // Sau khi xoá, cập nhật lại ListView
                            LoadDuLieuVaoListView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xoá người dùng: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để xoá.");
            }
        }

        private void btnSuaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có người dùng được chọn trong ListView
            if (lstvQuanLyNguoiDung.SelectedItems.Count > 0)
            {
                btnSuaNguoiDung.Enabled = true;
                ListViewItem selectedItem = lstvQuanLyNguoiDung.SelectedItems[0];
                string oldUsername = selectedItem.SubItems[1].Text; // Lấy username cũ từ ListView
                string oldPassword = selectedItem.SubItems[2].Text; // Lấy mật khẩu cũ
                string oldRole = selectedItem.SubItems[3].Text; // Lấy quyền cũ

                // Lấy giá trị mới từ các TextBox và ComboBox
                string newUsername = txtUsername.Text;
                string newPassword = txtMatKhau.Text;
                string newRole = cbbQuyen.SelectedItem.ToString();

                // Chuyển đổi quyền có dấu sang quyền không dấu để lưu vào cơ sở dữ liệu
                string newRoleCode = ConvertRoleToCode(newRole);

                // Kiểm tra quyền có hợp lệ không
                List<string> validRoles = new List<string> { "QUANTRI", "NHANVIEN" }; // Danh sách quyền hợp lệ
                if (!validRoles.Contains(newRoleCode))
                {
                    MessageBox.Show("Quyền không hợp lệ! Chỉ có thể chọn 'Quản trị' hoặc 'Nhân viên'.");
                    return; // Dừng xử lý nếu quyền không hợp lệ
                }

                // Kiểm tra sự thay đổi và cập nhật từng trường
                bool isChanged = false;
                string updateQuery = "UPDATE NGUOIDUNG SET ";

                // Kiểm tra thay đổi cho tên người dùng
                if (newUsername != oldUsername)
                {
                    updateQuery += $"USERNAME = '{newUsername}', ";
                    isChanged = true;
                }

                // Kiểm tra thay đổi cho mật khẩu
                if (newPassword != oldPassword)
                {
                    updateQuery += $"MATKHAU = '{newPassword}', ";
                    isChanged = true;
                }

                // Kiểm tra thay đổi cho quyền
                if (newRoleCode != oldRole)
                {
                    updateQuery += $"QUYEN = '{newRoleCode}' ";
                    isChanged = true;
                }

                // Nếu có sự thay đổi, tiếp tục với cập nhật, nếu không thì thông báo không thay đổi
                if (isChanged)
                {
                    // Loại bỏ dấu phẩy cuối cùng nếu có
                    if (updateQuery.EndsWith(", "))
                    {
                        updateQuery = updateQuery.Substring(0, updateQuery.Length - 2);
                    }

                    updateQuery += $" WHERE ID_NGUOIDUNG = {selectedItem.SubItems[0].Text}"; // Thêm điều kiện WHERE để cập nhật đúng người dùng

                    try
                    {
                        // Cập nhật thông tin vào cơ sở dữ liệu
                        using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                        {
                            SqlCommand cmd = new SqlCommand(updateQuery, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        // Thông báo và cập nhật lại ListView
                        MessageBox.Show("Thông tin người dùng đã được cập nhật.");
                        lstvQuanLyNguoiDung.Items.Clear();
                        LoadDuLieuVaoListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để sửa.");
            }
        }

        private string ConvertRoleToCode(string role)
        {
            switch (role)
            {
                case "Quản trị":
                    return "QUANTRI";
                case "Nhân viên":
                    return "NHANVIEN";
                default:
                    return ""; // Trả về chuỗi rỗng nếu không có quyền hợp lệ
            }
        }
    }
}
