using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace AppChoThueXe
{
    public partial class ThemHangXe : Form
    {
        public delegate void HangXeAddedEventHandler();
        public event HangXeAddedEventHandler HangXeAdded;
        public ThemHangXe()
        {
            InitializeComponent();
        }
        // KẾT NỐI TỚI CƠ SỞ DỮ LIỆU
        private DatabaseHelper _databaseHelper = new DatabaseHelper();

        public DataTable GetDataFromDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public async Task<List<string>> GetCountriesFromAPIAsync()
        {
            string apiUrl = "https://restcountries.com/v3.1/all";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var countries = JsonConvert.DeserializeObject<List<dynamic>>(json);
                    List<string> countryNames = countries.Select(c => (string)c["name"]["common"]).ToList();
                    return countryNames;
                }
                else
                {
                    throw new Exception("Không thể tải danh sách quốc gia từ API.");
                }
            }
        }

        private void ThemHangXe_Load(object sender, EventArgs e)
        {

            List<string> countries = new List<string>
            {
                "Chọn Hãng Xe","Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua và Barbuda",
                "Argentina", "Armenia", "Australia", "Áo", "Azerbaijan", "Bahamas", "Bahrain",
                "Bangladesh", "Barbados", "Belarus", "Bỉ", "Belize", "Benin", "Bhutan", "Bolivia",
                "Bosnia và Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso",
                "Burundi", "Cape Verde", "Campuchia", "Cameroon", "Canada", "Cộng hòa Trung Phi",
                "Chad", "Chile", "Trung Quốc", "Colombia", "Comoros", "Cộng hòa Congo", "Costa Rica",
                "Croatia", "Cuba", "Síp", "Cộng hòa Séc", "Đan Mạch", "Djibouti", "Dominica",
                "Cộng hòa Dominica", "Ecuador", "Ai Cập", "El Salvador", "Guinea Xích đạo", "Eritrea",
                "Estonia", "Eswatini", "Ethiopia", "Fiji", "Phần Lan", "Pháp", "Gabon", "Gambia",
                "Gruzia", "Đức", "Ghana", "Hy Lạp", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau",
                "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "Ấn Độ", "Indonesia", "Iran", "Iraq",
                "Ireland", "Israel", "Ý", "Jamaica", "Nhật Bản", "Jordan", "Kazakhstan", "Kenya", "Kiribati",
                "Triều Tiên", "Hàn Quốc", "Kuwait", "Kyrgyzstan", "Lào", "Latvia", "Liban", "Lesotho",
                "Liberia", "Libya", "Liechtenstein", "Litva", "Luxembourg", "Madagascar", "Malawi",
                "Malaysia", "Maldives", "Mali", "Malta", "Quần đảo Marshall", "Mauritania", "Mauritius",
                "Mexico", "Micronesia", "Moldova", "Monaco", "Mông Cổ", "Montenegro", "Maroc", "Mozambique",
                "Myanmar", "Namibia", "Nauru", "Nepal", "Hà Lan", "New Zealand", "Nicaragua", "Niger",
                "Nigeria", "Bắc Macedonia", "Na Uy", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea",
                "Paraguay", "Peru", "Philippines", "Ba Lan", "Bồ Đào Nha", "Qatar", "Romania", "Nga", "Rwanda","Việt Nam", "Mỹ"
            };
            

            foreach (string country in countries)
            {
                cbbQuocGia.Items.Add(country);
            }
            cbbQuocGia.SelectedIndex = 0;
            LoadDuLieuVaoListViewHangXe();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThemTenHangXe()
        {
            // Kiểm tra hãng xe đã tồn tại
            string checkQuery = "SELECT COUNT(*) FROM HANGXE WHERE TENHANGXE = @TENHANGXE";
            string insertQuery = "INSERT INTO HANGXE (TENHANGXE, QUOCGIA, WEBSITE) VALUES (@TENHANGXE, @QUOCGIA, @WEBSITE)";

            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@TENHANGXE", txtTenHangXe.Text.Trim());

                connection.Open();

                int count = (int)checkCmd.ExecuteScalar(); // Kiểm tra số lượng kết quả
                if (count > 0)
                {
                    MessageBox.Show("Hãng xe này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu không tồn tại, tiến hành thêm mới
                SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@TENHANGXE", txtTenHangXe.Text.Trim());
                insertCmd.Parameters.AddWithValue("@QUOCGIA", cbbQuocGia.SelectedItem.ToString());
                insertCmd.Parameters.AddWithValue("@WEBSITE", txtWebsite.Text.Trim());

                insertCmd.ExecuteNonQuery(); // Thực thi câu lệnh INSERT
                MessageBox.Show("Thêm hãng xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật ListView sau khi thêm
            lstvQuanLyHangXe.Items.Clear();
            LoadDuLieuVaoListViewHangXe();

            // Gọi sự kiện khi thêm hãng xe thành công
            HangXeAdded?.Invoke(); // Gọi sự kiện nếu có
        }


        private void btnThemHangXe_Click(object sender, EventArgs e)
        {
            ThemTenHangXe();
        }

        private void LoadDuLieuVaoListViewHangXe()
        {
            string query = "SELECT ID_HANGXE, TENHANGXE, QUOCGIA,WEBSITE FROM HANGXE";  // Câu truy vấn SQL
            DataTable data = GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID_HANGXE"].ToString());
                item.SubItems.Add(row["TENHANGXE"].ToString());
                item.SubItems.Add(row["QUOCGIA"].ToString());
                item.SubItems.Add(row["WEBSITE"].ToString()); // Hiển thị tên hãng xe từ bảng HANGXE
                lstvQuanLyHangXe.Items.Add(item);
            }
            
            lstvQuanLyHangXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyHangXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstvQuanLyHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvQuanLyHangXe.SelectedItems.Count > 0)
            {
                ListViewItem selecteditem = lstvQuanLyHangXe.SelectedItems[0];

                txtTenHangXe.Text = selecteditem.SubItems[1].Text;
                cbbQuocGia.SelectedItem = selecteditem.SubItems[2].Text;
                txtWebsite.Text = selecteditem.SubItems[3].Text;
            }
        }

        private void btnXoaHangXe_Click(object sender, EventArgs e)
        {
            if (lstvQuanLyHangXe.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn
                ListViewItem selectedItem = lstvQuanLyHangXe.SelectedItems[0];
                int idHangXe = int.Parse(selectedItem.Text); // ID_HANGXE là cột đầu tiên
                string tenHangXe = selectedItem.SubItems[1].Text;

                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    connection.Open();

                    // Kiểm tra xem hãng xe có xe nào liên quan không
                    string checkCarsQuery = "SELECT COUNT(*) FROM XE WHERE ID_HANGXE = @ID_HANGXE";
                    SqlCommand checkCarsCmd = new SqlCommand(checkCarsQuery, connection);
                    checkCarsCmd.Parameters.AddWithValue("@ID_HANGXE", idHangXe);
                    int countCars = (int)checkCarsCmd.ExecuteScalar();

                    if (countCars > 0)
                    {
                        // Nếu còn xe liên quan, thông báo không thể xóa
                        MessageBox.Show($"Hãng xe {tenHangXe} vẫn còn xe liên quan. Vui lòng xóa các xe trước khi xóa hãng xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Hiển thị thông báo xác nhận trước khi xóa
                    DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa hãng xe {tenHangXe}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        // Tắt ràng buộc FOREIGN KEY tạm thời
                        SqlCommand disableFK = new SqlCommand("ALTER TABLE XE NOCHECK CONSTRAINT FK_XE_HANGXE", connection);
                        disableFK.ExecuteNonQuery();

                        // Xóa hãng xe khỏi bảng HANGXE
                        string deleteHangXeQuery = "DELETE FROM HANGXE WHERE ID_HANGXE = @ID_HANGXE";
                        SqlCommand deleteHangXeCmd = new SqlCommand(deleteHangXeQuery, connection);
                        deleteHangXeCmd.Parameters.AddWithValue("@ID_HANGXE", idHangXe);
                        deleteHangXeCmd.ExecuteNonQuery();

                        // Bật lại ràng buộc FOREIGN KEY
                        SqlCommand enableFK = new SqlCommand("ALTER TABLE XE CHECK CONSTRAINT FK_XE_HANGXE", connection);
                        enableFK.ExecuteNonQuery();

                        connection.Close();

                        // Xóa hãng xe khỏi ListView
                        lstvQuanLyHangXe.Items.Remove(selectedItem);

                        MessageBox.Show($"Hãng xe {tenHangXe} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hãng xe để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenHangXe.Clear();
            txtWebsite.Clear();
            cbbQuocGia.SelectedIndex = 0;
        }
    }
}
