using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;


namespace AppChoThueXe
{

    public partial class ChucNangDonDatXe : UserControl
    {

        private DatabaseHelper _databaseHelper = new DatabaseHelper();
        private int _carID;
        private bool isFormLoaded = false;
        private bool isDataFromListView = false;
        public ChucNangDonDatXe()
        {
            InitializeComponent();
            LoadDataAndGenerateButtons();
        }



        public DataTable GetCarList()
        {
            string query = "SELECT ID_XE, TENXE FROM XE";
            return _databaseHelper.GetDataFromDatabase(query);
        }


        // Cập nhật ComboBox khi chọn xe
        private void UpdateComboBoxWithSelectedCar(int selectedCarID)
        {
            string selectedCarName = GetCarNameByID(selectedCarID);

            // Tìm kiếm xe trong ComboBox theo tên đã chọn
            foreach (var item in cbbXeDaChon.Items)
            {
                if (((DataRowView)item)["TENXE"].ToString() == selectedCarName)
                {
                    cbbXeDaChon.SelectedItem = item;  // Cập nhật selectedItem trong ComboBox
                    break;
                }
            }

            // Hiển thị thông báo chọn xe
            MessageBox.Show($"Đã chọn xe: {selectedCarName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetCarNameByID(int carID)
        {
            string query = "SELECT TENXE FROM XE WHERE ID_XE = " + carID;

            DataTable result = _databaseHelper.GetDataFromDatabase(query);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["TENXE"].ToString();
            }
            else
            {
                return string.Empty;  // Trả về chuỗi rỗng nếu không tìm thấy xe
            }
        }
        private void LoadCarListToComboBox()
        {
            DataTable carTable = GetCarList();

            if (carTable.Rows.Count > 0)
            {
                cbbXeDaChon.DataSource = carTable; // Gán nguồn dữ liệu
                cbbXeDaChon.DisplayMember = "TENXE"; // Hiển thị tên xe trong ComboBox
                cbbXeDaChon.ValueMember = "ID_XE"; // Lấy giá trị là ID của xe
            }
            else
            {
                MessageBox.Show("Không có xe nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadKhachHangLenComboBox()
        {
            // Clear existing items in ComboBox
            cbbTenKhachHang.Items.Clear();

            try
            {
                // Mở kết nối cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    connection.Open();

                    // Truy vấn tên khách hàng và ID
                    string query = "SELECT ID_KHACHHANG, TENKHACHHANG FROM KHACHHANG";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Duyệt qua từng dòng kết quả
                            while (reader.Read())
                            {
                                // Lấy ID và tên khách hàng
                                int idKhachHang = reader.GetInt32(0);
                                string tenKhachHang = reader.GetString(1);

                                // Thêm vào ComboBox (hiển thị tên, lưu ID)
                                cbbTenKhachHang.Items.Add(new KeyValuePair<int, string>(idKhachHang, tenKhachHang));
                            }
                        }
                    }

                    // Thiết lập thuộc tính hiển thị và giá trị
                    cbbTenKhachHang.DisplayMember = "Value"; // Hiển thị tên khách hàng
                    cbbTenKhachHang.ValueMember = "Key";    // Lưu trữ ID khách hàng
                    if (cbbTenKhachHang.Items.Count > 0)
                    {
                        cbbTenKhachHang.SelectedIndex = 0; // Chọn mục đầu tiên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChucNangDonDatXe_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            LoadDuLieuVaoListView();
            LoadCarListToComboBox();
            LoadKhachHangLenComboBox();
            isFormLoaded = true;
        }

        private void lstvQuanLyDonDatXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            isDataFromListView = true;
            if (lstvQuanLyDonDatXe.SelectedItems.Count > 0)
            {
                ListViewItem selecteditem = lstvQuanLyDonDatXe.SelectedItems[0];

                cbbTenKhachHang.Text = selecteditem.SubItems[1].Text;  // Tên khách hàng
                cbbXeDaChon.Text = selecteditem.SubItems[2].Text;      // Tên xe
                datetimeNgayThue.Value = DateTime.Parse(selecteditem.SubItems[3].Text); // Ngày thuê
                datetimeNgayTraXe.Value = DateTime.Parse(selecteditem.SubItems[4].Text); // Ngày trả xe
                numericUpGiamGia.Value = decimal.Parse(selecteditem.SubItems[5].Text);  // Giảm giá
                txtTongTien.Text = selecteditem.SubItems[6].Text + "VND";
            }
            isDataFromListView = false;
        }

        private void LoadDuLieuVaoListView()
        {
            string query = "SELECT DATXE.MADATXE, DATXE.ID_KHACHHANG, KHACHHANG.TENKHACHHANG, DATXE.ID_XE, DATXE.NGAYTHUE, DATXE.NGAYTRAXE, DATXE.GIAMGIA, DATXE.TONGTIEN, DATXE.TRANGTHAI, DATXE.NGAYTAODON, (SELECT XE.TENXE FROM XE WHERE DATXE.ID_XE = XE.ID_XE) AS TENXE FROM DATXE LEFT JOIN KHACHHANG ON DATXE.ID_KHACHHANG = KHACHHANG.ID_KHACHHANG";  // Câu truy vấn SQL
            DataTable data = _databaseHelper.GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["MADATXE"].ToString());
                item.SubItems.Add(row["TENKHACHHANG"].ToString());
                item.SubItems.Add(row["TENXE"].ToString()); // Hiển thị tên hãng xe từ bảng HANGXE
                item.SubItems.Add(Convert.ToDateTime(row["NGAYTHUE"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(Convert.ToDateTime(row["NGAYTRAXE"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["GIAMGIA"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                string trangThai = row["TRANGTHAI"].ToString();
                string trangThaiHienThi = "";

                // Kiểm tra trạng thái và gán giá trị hiển thị tương ứng
                switch (trangThai)
                {
                    case "CHODUYET":
                        trangThaiHienThi = "CHỜ DUYỆT";
                        break;
                    case "DADUYET":
                        trangThaiHienThi = "ĐÃ DUYỆT";
                        break;
                    case "HUY":
                        trangThaiHienThi = "HUỶ";
                        break;
                    case "HOANTHANH":
                        trangThaiHienThi = "HOÀN THÀNH";
                        break;
                    default:
                        trangThaiHienThi = "KHÔNG XÁC ĐỊNH";
                        break;
                }
                item.SubItems.Add(trangThaiHienThi);
                item.SubItems.Add(row["NGAYTAODON"].ToString());
                lstvQuanLyDonDatXe.Items.Add(item);
            }
            lstvQuanLyDonDatXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyDonDatXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void LoadDataAndGenerateButtons()
        {
            // 1. Sử dụng DatabaseHelper để lấy dữ liệu xe
            DatabaseHelper dbHelper = new DatabaseHelper();
            string query = "SELECT ID_XE,TENXE,SO_LUONG,TRANGTHAIXE FROM XE"; // Thay query nếu cần
            DataTable carTable = dbHelper.GetDataFromDatabase(query);

            // 3. Tạo nút động từ dữ liệu
            foreach (DataRow row in carTable.Rows)
            {
                int carID = (int)row["ID_XE"];
                string carName = row["TENXE"].ToString();
                int availableCount = (int)row["SO_LUONG"];
                string carStatus = row["TRANGTHAIXE"].ToString();

                Button btn = new Button
                {
                    Text = carName,
                    Width = 150,
                    Height = 50,
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.FromArgb(0, 67, 133),
                    ForeColor = Color.FromArgb(157, 247, 229),
                    Margin = new Padding(10)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Tag = carID;



                if (carStatus == "COSAN" && availableCount > 0)
                {
                    btn.Text += $" (Còn {availableCount} chiếc)";
                    btn.Enabled = true; // Cho phép đặt xe
                    btn.BackColor = Color.FromArgb(36, 79, 113); // xe có sẵn
                    btn.ForeColor = Color.FromArgb(250, 248, 191);
                }
                else if (carStatus == "DATHUE" && availableCount > 0)
                {
                    btn.Text += $" (Còn {availableCount} chiếc)";
                    btn.Enabled = true; // Cho phép đặt xe, nhưng sẽ hiển thị rằng xe đang cho thuê
                    btn.BackColor = Color.FromArgb(153, 0, 18); // xe đang cho thuê
                    btn.ForeColor = Color.FromArgb(255, 255, 255);
                }
                else if (carStatus == "BAOTRI")
                {
                    btn.Text += " (Bảo trì)";
                    btn.Enabled = false; // Không cho phép đặt xe
                    btn.BackColor = Color.White; // Màu nút xám cho xe bảo trì
                }
                else
                {
                    btn.Text += $" (Còn 0 chiếc)";
                    btn.Enabled = false; // Nếu không có xe, không cho phép đặt
                    btn.BackColor = Color.Silver; // Màu nút đỏ nếu không có xe
                }


                // Xử lý sự kiện khi nhấn vào nút
                btn.Click += (s, e) =>
                {
                    Button clickedButton = (Button)s;
                    int selectedCarID = (int)clickedButton.Tag;
                    ThongTinXe_DatDon details = new ThongTinXe_DatDon(selectedCarID);
                    details.CarSelected += UpdateComboBoxWithSelectedCar;
                    details.ShowDialog();
                };


                // Thêm nút vào FlowLayoutPanel
                lstdanhsachxe.Controls.Add(btn);
            }
        }


        private void btnLoadLaiXe_Click(object sender, EventArgs e)
        {
            lstdanhsachxe.Controls.Clear();
            cbbXeDaChon.DataSource = null;
            // Thêm các mục vào Items theo cách thủ công (nếu cần)
            cbbXeDaChon.Items.Clear();
            LoadDataAndGenerateButtons();
            LoadCarListToComboBox();
            lstvQuanLyDonDatXe.Items.Clear();
            LoadDuLieuVaoListView();
            cbbTenKhachHang.Items.Clear();
            LoadKhachHangLenComboBox();
        }

        private void btnDoiXe_Click(object sender, EventArgs e)
        {
            string selectedCarName = cbbXeDaChon.Text;

            if (string.IsNullOrEmpty(selectedCarName))
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sanitizedCarName = selectedCarName.Replace("'", "''"); // Sanitize input bằng cách thay thế dấu nháy đơn
            string query = $"SELECT ID_XE FROM XE WHERE TENXE = N'{sanitizedCarName}'";

            // 3. Thực hiện truy vấn
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable result = dbHelper.GetDataFromDatabase(query);

            if (result.Rows.Count > 0)
            {
                int selectedCarID = Convert.ToInt32(result.Rows[0]["ID_XE"]);

                // 4. Thông báo đổi xe thành công
                MessageBox.Show($"Bạn đã đổi xe thành công: {selectedCarName} (ID: {selectedCarID})",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật carID hoặc logic khác
                _carID = selectedCarID;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID của xe này trong cơ sở dữ liệu.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.Show();
        }

        private decimal CalculateTotalPrice(DateTime ngayThue, DateTime ngayTraXe, decimal giamgia)
        {
            int selectedCarID = (int)((DataRowView)cbbXeDaChon.SelectedItem)["ID_XE"];

            // Lấy giá xe từ cơ sở dữ liệu
            decimal carPrice = 0;
            string query = "SELECT GIATHUETHEONGAY FROM XE WHERE ID_XE = " + selectedCarID;

            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        carPrice = Convert.ToDecimal(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá thuê xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }

            // Tính số ngày thuê
            int soNgayThue = (ngayTraXe - ngayThue).Days;

            // Tính tổng tiền trước khi giảm giá
            decimal tongTienTruocGiam = carPrice * soNgayThue;

            // Tính tổng tiền sau giảm giá
            decimal tongTien = tongTienTruocGiam - (tongTienTruocGiam * giamgia / 100);

            if (tongTien < 0)
            {
                tongTien = 0;
            }

            return tongTien;
        }

        private void CalculateAndUpdateTotalPrice()
        {
            if (cbbXeDaChon.SelectedItem == null || cbbTenKhachHang.SelectedItem == null)
                return;

            DateTime ngayThue = datetimeNgayThue.Value;
            DateTime ngayTraXe = datetimeNgayTraXe.Value;
            decimal giamgia = numericUpGiamGia.Value;

            // Kiểm tra ngày trả xe lớn hơn ngày thuê
            if (ngayTraXe <= ngayThue)
            {
                MessageBox.Show("Ngày trả xe phải lớn hơn ngày thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedCarID = (int)((DataRowView)cbbXeDaChon.SelectedItem)["ID_XE"];

            // Kiểm tra tình trạng xe và số lượng xe
            string query = "SELECT TRANGTHAIXE, SO_LUONG FROM XE WHERE ID_XE = " + selectedCarID;
            decimal tongTien = 0;

            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string carStatus = reader.IsDBNull(0) ? null : reader.GetString(0);
                            int availableCount = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                            // Kiểm tra tình trạng xe
                            if (carStatus == "BAOTRI" || availableCount == 0)
                            {
                                MessageBox.Show("Xe này đang bảo trì hoặc hết xe, không thể tính tổng tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtTongTien.Text = "0"; // Đặt tổng tiền = 0
                                return;
                            }
                        }
                    }
                }
            }

            // Tính tổng tiền
            tongTien = CalculateTotalPrice(ngayThue, ngayTraXe, giamgia);

            // Cập nhật tổng tiền vào TextBox
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = tongTien.ToString("C", culture);  // Định dạng tiền tệ
        }

        private void btnDatXe_Click(object sender, EventArgs e)
        {
            // Lấy ID của xe đã chọn từ ComboBox
            if (cbbXeDaChon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbTenKhachHang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCarID = (int)((DataRowView)cbbXeDaChon.SelectedItem)["ID_XE"]; // Lấy ID xe từ ComboBox

            string carStatus = "";
            int availableCount = 0;

            // Truy vấn cơ sở dữ liệu để lấy trạng thái xe và số lượng
            string query = $"SELECT TRANGTHAIXE, SO_LUONG FROM XE WHERE ID_XE = {selectedCarID}";

            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                try
                {
                    connection.Open();

                    // Lấy trạng thái và số lượng xe bằng cách thực hiện truy vấn
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object resultStatus = cmd.ExecuteScalar(); // Trả về kết quả đầu tiên (TRANGTHAIXE)
                        if (resultStatus != null)
                        {
                            carStatus = resultStatus.ToString();
                        }

                        // Truy vấn tiếp để lấy số lượng xe
                        query = $"SELECT SO_LUONG FROM XE WHERE ID_XE = {selectedCarID}";
                        using (SqlCommand cmdAvailable = new SqlCommand(query, connection))
                        {
                            object resultCount = cmdAvailable.ExecuteScalar();
                            availableCount = resultCount != null ? Convert.ToInt32(resultCount) : 0;
                        }
                    }

                    // Kiểm tra trạng thái xe và số lượng
                    if (carStatus == "BAOTRI")
                    {
                        MessageBox.Show("Xe đang bảo trì, không thể đặt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (availableCount == 0)
                    {
                        MessageBox.Show("Hết xe, không thể đặt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (carStatus == "COSAN" || (carStatus == "DATHUE" && availableCount > 0))
                    {
                        string selectedCarName = cbbXeDaChon.Text;  // Tên xe đã chọn
                        int makhachhang = ((KeyValuePair<int, string>)cbbTenKhachHang.SelectedItem).Key;  // ID khách hàng
                        string tenkhachhang = ((KeyValuePair<int, string>)cbbTenKhachHang.SelectedItem).Value;  // Tên khách hàng
                        DateTime ngaythue = datetimeNgayThue.Value.Date;
                        DateTime ngaytraxe = datetimeNgayTraXe.Value.Date;
                        decimal giamgia = numericUpGiamGia.Value;
                        decimal tongtien = CalculateTotalPrice(ngaythue, ngaytraxe, giamgia);
                        CultureInfo culture = new CultureInfo("vi-VN");
                        txtTongTien.Text = tongtien.ToString("C", culture);
                        DateTime ngayTaoDon = DateTime.Today.Date;

                        // Tạo thông báo xác nhận đặt xe
                        string message = $"Bạn có muốn đặt xe: {selectedCarName}\n" +
                                         $"Từ ngày: {ngaythue:dd/MM/yyyy} tới ngày: {ngaytraxe:dd/MM/yyyy}\n" +
                                         $"Giảm giá: {giamgia:C} VNĐ\n" +
                                         $"Thành tiền: {tongtien.ToString("C", culture)}";
                        DialogResult result = MessageBox.Show(message, "Xác nhận đặt xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string insertQuery = $@"
                    INSERT INTO DATXE (ID_KHACHHANG, ID_XE, NGAYTHUE, NGAYTRAXE, GIAMGIA, TONGTIEN, TRANGTHAI, NGAYTAODON) 
                    VALUES ({makhachhang}, {selectedCarID}, '{ngaythue:yyyy-MM-dd}', '{ngaytraxe:yyyy-MM-dd}', {giamgia}, {tongtien}, 'CHODUYET', '{ngayTaoDon}')";

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                            {
                                int rowsAffected = insertCmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    // Cập nhật trạng thái xe thành 'DATHUE' sau khi đặt xe thành công
                                    string updateCarStatusQuery = $"UPDATE XE SET TRANGTHAIXE = 'DATHUE' WHERE ID_XE = {selectedCarID}";
                                    using (SqlCommand updateStatusCmd = new SqlCommand(updateCarStatusQuery, connection))
                                    {
                                        updateStatusCmd.ExecuteNonQuery();
                                    }

                                    // Cập nhật số lượng xe trong bảng XE
                                    string updateQuery = $"UPDATE XE SET SO_LUONG = SO_LUONG - 1 WHERE ID_XE = {selectedCarID}";
                                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCmd.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Đặt xe thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lstvQuanLyDonDatXe.Items.Clear();
                                    LoadDuLieuVaoListView();
                                }
                                else
                                {
                                    MessageBox.Show("Có lỗi xảy ra khi đặt xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // Người dùng chọn "No"
                            MessageBox.Show("Đặt xe đã bị hủy.", "Hủy đặt xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show($"Lỗi khi kiểm tra xe: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cbbXeDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded && !isDataFromListView)
            {
                // Chỉ tính tổng tiền nếu giá trị hợp lệ
                if (datetimeNgayTraXe.Value > datetimeNgayThue.Value)
                {
                    CalculateAndUpdateTotalPrice();
                }
            }
        }

        private void cbbTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded && !isDataFromListView)
            {
                // Chỉ tính tổng tiền nếu giá trị hợp lệ
                if (datetimeNgayTraXe.Value > datetimeNgayThue.Value)
                {
                    CalculateAndUpdateTotalPrice();
                }
            }
        }

        private void datetimeNgayThue_ValueChanged(object sender, EventArgs e)
        {
            if (isFormLoaded && !isDataFromListView)
            {
                // Chỉ tính tổng tiền nếu giá trị hợp lệ
                if (datetimeNgayTraXe.Value > datetimeNgayThue.Value)
                {
                    CalculateAndUpdateTotalPrice();
                }
            }
        }

        private void datetimeNgayTraXe_ValueChanged(object sender, EventArgs e)
        {
            if (isFormLoaded && !isDataFromListView)
            {
                // Chỉ tính tổng tiền nếu giá trị hợp lệ
                if (datetimeNgayTraXe.Value > datetimeNgayThue.Value)
                {
                    CalculateAndUpdateTotalPrice();
                }
            }
        }

        private void numericUpGiamGia_ValueChanged(object sender, EventArgs e)
        {
            if (isFormLoaded && !isDataFromListView)
            {
                // Chỉ tính tổng tiền nếu giá trị hợp lệ
                if (datetimeNgayTraXe.Value > datetimeNgayThue.Value)
                {
                    CalculateAndUpdateTotalPrice();
                }
            }
        }




        private void btnHuyXe_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đơn hàng nào được chọn không
            if (lstvQuanLyDonDatXe.SelectedItems.Count > 0)
            {
                var selectedItem = lstvQuanLyDonDatXe.SelectedItems[0];
                string trangThai = selectedItem.SubItems[7].Text; // Giả sử SubItems[7] là trạng thái đơn hàng

                // Kiểm tra trạng thái của đơn hàng
                if (trangThai == "CHỜ DUYỆT")
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn huỷ xe không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy thông tin cần thiết từ ListViewItem
                        string maDatXe = selectedItem.Text; // Mã đặt xe (Text của ListViewItem)
                        int maXe;

                        // Kiểm tra giá trị của ID_XE có hợp lệ không
                        if (!int.TryParse(selectedItem.SubItems[0].Text, out maXe))
                        {
                            MessageBox.Show("ID xe không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Thay đổi trạng thái đơn hàng trong giao diện
                        selectedItem.SubItems[7].Text = "HUY"; // Cập nhật trạng thái thành "Hủy"

                        // Kết nối với cơ sở dữ liệu
                        using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                        {
                            try
                            {
                                connection.Open();

                                // Cập nhật trạng thái đơn hàng trong cơ sở dữ liệu
                                string updateQuery = $"UPDATE DATXE SET TRANGTHAI = 'HUY' WHERE MADATXE = {maDatXe}";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                                {
                                    updateCmd.ExecuteNonQuery();
                                }

                                // Hoàn lại số lượng xe
                                string updateCarQuantityQuery = $"UPDATE XE SET SO_LUONG = SO_LUONG + 1 WHERE ID_XE = {maXe}";
                                using (SqlCommand updateCarQuantityCmd = new SqlCommand(updateCarQuantityQuery, connection))
                                {
                                    updateCarQuantityCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Đơn hàng đã bị hủy và xe đã được hoàn lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lstvQuanLyDonDatXe.Items.Clear();
                                LoadDuLieuVaoListView();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi huỷ đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đơn hàng không thể huỷ khi không ở trạng thái 'Chờ Duyệt'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        // Phương thức lấy mã đơn hàng từ giao diện (ví dụ từ DataGridView)
        private string GetSelectedMaDatXe()
        {
            if (lstvQuanLyDonDatXe.SelectedItems.Count > 0)
            {
                return lstvQuanLyDonDatXe.SelectedItems[0].SubItems[0].Text;
            }
            return null;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Giả sử mã đơn hàng được chọn từ giao diện
            string maDatXe = GetSelectedMaDatXe(); // Lấy mã đơn từ giao diện
            if (string.IsNullOrEmpty(maDatXe))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"SELECT * 
                      FROM DATXE 
                      JOIN KHACHHANG ON DATXE.ID_KHACHHANG = KHACHHANG.ID_KHACHHANG 
                      JOIN XE ON DATXE.ID_XE = XE.ID_XE 
                      WHERE DATXE.MADATXE = '{maDatXe}'";

            try
            {
                using (SqlConnection conn = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string tenkhachhang = reader["TENKHACHHANG"].ToString();
                        string tenXe = reader["TENXE"].ToString();
                        string ngayBatDau = Convert.ToDateTime(reader["NGAYTHUE"]).ToShortDateString();
                        string ngayKetThuc = Convert.ToDateTime(reader["NGAYTRAXE"]).ToShortDateString();
                        decimal soTien = Convert.ToDecimal(reader["TONGTIEN"]);
                        string trangThai = reader["TRANGTHAI"].ToString();
                        // Kiểm tra trạng thái đơn hàng
                        if (trangThai != "CHODUYET")
                        {
                            MessageBox.Show("Đơn hàng này không thể thanh toán vì không ở trạng thái 'CHỜ DUYỆT'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Hiển thị xác nhận
                        DialogResult result = MessageBox.Show(
                            $"Bạn có muốn thanh toán đơn hàng?\n\n" +
                            $"Mã đơn: {maDatXe}\n" +
                            $"Tên xe: {tenXe}\n" +
                            $"Thời gian thuê: {ngayBatDau} - {ngayKetThuc}\n" +
                            $"Số tiền: {soTien:C}",
                            "Xác nhận thanh toán",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            // Cập nhật trạng thái đơn hàng
                            reader.Close(); // Đóng reader trước khi thực hiện lệnh khác
                            DateTime ngayThanhToan = DateTime.Now.Date; // Lấy thời gian thanh toán hiện tại
                            string updateQuery = $"UPDATE DATXE SET TRANGTHAI = 'DADUYET', NGAYTHANHTOAN = '{ngayThanhToan}' WHERE MADATXE = '{maDatXe}'";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thanh toán thành công! Trạng thái đơn hàng đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra khi cập nhật trạng thái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDuLieuBang_Click(object sender, EventArgs e)
        {
            // Cảnh báo dữ liệu nguy hiểm
            DialogResult warningResult = MessageBox.Show(
                "Đây là dữ liệu nguy hiểm. Hành động này sẽ xóa toàn bộ dữ liệu trong bảng Thanh toán và Đặt xe. Bạn có muốn tiếp tục?",
                "Cảnh báo khẩn cấp!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (warningResult == DialogResult.No)
                return;

            // Hỏi người dùng có muốn lưu dữ liệu ra file Excel trước khi xóa không
            DialogResult saveResult = MessageBox.Show(
                "Bạn có muốn lưu dữ liệu ra file Excel trước khi xóa không?",
                "Lưu dữ liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (saveResult == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Chọn thư mục để lưu file Excel",
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"DuLieuDatXe_ThanhToan_{DateTime.Now:yyyyMMdd_HHmmss}"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string savePath = Path.GetDirectoryName(saveFileDialog.FileName);
                        string fileDatXe = Path.Combine(savePath, $"BangDatXe_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");
                        string fileThanhToan = Path.Combine(savePath, $"BangThanhToan_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

                        // Lưu dữ liệu bảng Đặt xe
                        DataTable datXeTable = GetDataTable("SELECT * FROM DATXE");
                        ExportDataToExcel(datXeTable, fileDatXe); // Sử dụng hàm ExportDataToExcel

                        // Lưu dữ liệu bảng Thanh toán
                        DataTable thanhToanTable = GetDataTable("SELECT * FROM THANHTOAN");
                        ExportDataToExcel(thanhToanTable, fileThanhToan); // Sử dụng hàm ExportDataToExcel

                        MessageBox.Show($"Dữ liệu đã được lưu tại:\n- {fileDatXe}\n- {fileThanhToan}", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy lưu dữ liệu. Thao tác xóa sẽ tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Hỏi xác nhận xóa lần cuối
            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ dữ liệu trong bảng Thanh toán và Đặt xe không? Hành động này không thể hoàn tác.",
                "Xác nhận xóa dữ liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
                return;

            // Xóa dữ liệu
            try
            {
                using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Xóa dữ liệu trong bảng THANHTOAN
                        string deleteThanhToanQuery = "DELETE FROM THANHTOAN";
                        using (SqlCommand cmd = new SqlCommand(deleteThanhToanQuery, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa dữ liệu trong bảng DATXE
                        string deleteDatXeQuery = "DELETE FROM DATXE";
                        using (SqlCommand cmd = new SqlCommand(deleteDatXeQuery, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // reset ID dữ liệu trong bảng DATXE
                        string resetDatXeQuery = "DBCC CHECKIDENT ('DATXE', RESEED, 0)";
                        using (SqlCommand cmd = new SqlCommand(resetDatXeQuery, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // reset ID dữ liệu trong bảng DATXE
                        string resetTrangThaiQuery = "UPDATE XE SET TRANGTHAIXE = 'COSAN'";
                        using (SqlCommand cmd = new SqlCommand(resetTrangThaiQuery, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm lấy dữ liệu từ cơ sở dữ liệu
        private DataTable GetDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // Hàm xuất dữ liệu ra file Excel
        public void ExportDataToExcel(DataTable dataTable, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                // Tạo một worksheet cho dữ liệu
                var worksheet = package.Workbook.Worksheets.Add("Dữ liệu");

                // Thêm tiêu đề cột
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Thêm dữ liệu vào các ô
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                    }
                }

                // Lưu file Excel
                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }


    }
}