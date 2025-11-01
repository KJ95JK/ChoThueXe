using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace AppChoThueXe
{
    public partial class ChucNangQuanLyXe : UserControl
    {
        private DatabaseHelper _databaseHelper = new DatabaseHelper();
        // KẾT NỐI TỚI CƠ SỞ DỮ LIỆU
        public ChucNangQuanLyXe()
        {
            InitializeComponent();
        }

        // TẢI NĂM VÀO COMBOBOX
        private void TaiNamSanXuat()
        {
            int currentyear = DateTime.Now.Year;
            for(int year = 1970; year <= currentyear; year++)
            {
                cbbNamSanXuat.Items.Add(year.ToString());
            }
            cbbNamSanXuat.SelectedItem = currentyear.ToString();
        }
        // TẢI TRẠNG THÁI XE VÀO COMBOBOX
        private void TaiTrangThaiXe()
        {
            cbbTrangThaiXe.Items.Add("CÓ SẴN");
            cbbTrangThaiXe.Items.Add("ĐÃ THUÊ");
            cbbTrangThaiXe.Items.Add("BẢO TRÌ");
            cbbTrangThaiXe.SelectedIndex = 0;
        }

        // TẢI HÃNG XE VÀO COMBOBOX
        private void TaiHangXe()
        {
            string query = "SELECT ID_HANGXE, TENHANGXE FROM HANGXE";
            DataTable data = _databaseHelper.GetDataFromDatabase(query);
            cbbHangXe.Items.Clear();
            cbbHangXe.Items.Add("Chọn Hãng Xe");
            foreach(DataRow row in data.Rows)
            {
                string idhangxe = row["ID_HANGXE"].ToString();
                string tenhangxe = row["TENHANGXE"].ToString();
                cbbHangXe.Items.Add(new KeyValuePair<string, string>(idhangxe,tenhangxe));
            }
            cbbHangXe.SelectedIndex = 0;
        }

        // Khi hãng xe được thêm thành công, gọi lại TaiHangXe
        private void FormThemHangXe_HangXeAdded()
        {
            TaiHangXe(); // Gọi lại phương thức để load dữ liệu vào ComboBox
        }

        // Khi mở form ThemHangXe từ form QuanLyXe
        private void OpenThemHangXeForm()
        {
            ThemHangXe formThemHangXe = new ThemHangXe();
            formThemHangXe.HangXeAdded += FormThemHangXe_HangXeAdded; // Đăng ký sự kiện
            formThemHangXe.ShowDialog(); // Hiển thị form
        }

       


        // KIỂM TRA MÃ XE
        private bool XeDaTonTaiChua(string tenXe, string namSanXuat, string mauXe, string soChoNgoi)
        {
            string query = "SELECT COUNT(*) FROM XE WHERE TENXE = @TENXE AND NAMSANXUAT = @NAMSANXUAT AND MAUXE = @MAUXE AND SOCHONGOI = @SOCHONGOI";
            using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TENXE", tenXe);
                cmd.Parameters.AddWithValue("@NAMSANXUAT", namSanXuat);
                cmd.Parameters.AddWithValue("@MAUXE", mauXe);
                cmd.Parameters.AddWithValue("@SOCHONGOI", soChoNgoi);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Nếu tồn tại, biến đếm lớn hơn 0 (đồng nghĩa với việc có tồn tại xe)
            }
        }

        private void CapNhatSoLuongXe(string tenXe, string namSanXuat, string mauXe, string soChoNgoi)
        {
            string query = "UPDATE XE SET SO_LUONG = SO_LUONG + @SO_LUONG, GIATHUETHEONGAY = @GIATHUETHEONGAY, TRANGTHAIXE = @TRANGTHAIXE WHERE TENXE = @TENXE AND NAMSANXUAT = @NAMSANXUAT AND MAUXE = @MAUXE AND SOCHONGOI = @SOCHONGOI";
            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TENXE", tenXe);
                cmd.Parameters.AddWithValue("@NAMSANXUAT", namSanXuat);
                cmd.Parameters.AddWithValue("@MAUXE", mauXe);
                cmd.Parameters.AddWithValue("@SOCHONGOI", soChoNgoi);
                cmd.Parameters.AddWithValue("@SO_LUONG", numericUpDownSoLuong.Value);  // Cộng thêm số lượng
                cmd.Parameters.AddWithValue("@GIATHUETHEONGAY", txtGiaThueTheoNgay.Text.Trim());
                cmd.Parameters.AddWithValue("@TRANGTHAIXE", cbbTrangThaiXe.SelectedItem.ToString() == "CÓ SẴN" ? "COSAN" : cbbTrangThaiXe.SelectedItem.ToString() == "ĐÃ THUÊ" ? "DATHUE" : "BAOTRI");

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }



        private void LoadDuLieuVaoListView()
        {
            lstvQuanLyXe.Items.Clear();
            string query = "SELECT ID_XE, TENXE, ID_HANGXE, MAUXE, NAMSANXUAT, SOCHONGOI, GIATHUETHEONGAY,TRANGTHAIXE, SO_LUONG, (SELECT HANGXE.TENHANGXE FROM HANGXE WHERE HANGXE.ID_HANGXE = XE.ID_HANGXE) AS TENHANG FROM XE";  // Câu truy vấn SQL
            DataTable data = _databaseHelper.GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID_XE"].ToString());
                item.SubItems.Add(row["TENXE"].ToString());
                item.SubItems.Add(row["TENHANG"].ToString()); // Hiển thị tên hãng xe từ bảng HANGXE
                item.SubItems.Add(row["MAUXE"].ToString());
                item.SubItems.Add(row["NAMSANXUAT"].ToString());
                item.SubItems.Add(row["SOCHONGOI"].ToString());
                item.SubItems.Add(row["GIATHUETHEONGAY"].ToString());
                item.SubItems.Add(row["SO_LUONG"].ToString());
                string trangThai = row["TRANGTHAIXE"].ToString();
                string trangThaiHienThi = "";

                // Kiểm tra trạng thái và gán giá trị hiển thị tương ứng
                switch (trangThai)
                {
                    case "COSAN":
                        trangThaiHienThi = "CÓ SẴN";
                        break;
                    case "DATHUE":
                        trangThaiHienThi = "ĐÃ THUÊ";
                        break;
                    case "BAOTRI":
                        trangThaiHienThi = "BẢO TRÌ";
                        break;
                    default:
                        trangThaiHienThi = "KHÔNG XÁC ĐỊNH";
                        break;
                }
                item.SubItems.Add(trangThaiHienThi);
                lstvQuanLyXe.Items.Add(item);
            }
            lstvQuanLyXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ChucNangQuanLyXe_Load(object sender, EventArgs e)
        {  
            btnSuaXe.Enabled = false;
            btnXoaXe.Enabled = false;
            LoadDuLieuVaoListView();
            TaiNamSanXuat();
            TaiTrangThaiXe();
            TaiHangXe();  // Tải danh sách hãng xe vào ComboBox
            DatLaiMacDinh();
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (cbbHangXe.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn hãng xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenXe.Text == "" || txtSoChoNgoi.Text == "" || txtMauXe.Text == "" || txtGiaThueTheoNgay.Text == "")
            {
                MessageBox.Show("Không được bỏ trống, vui lòng nhập dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenXe = txtTenXe.Text.Trim();
            string namSanXuat = cbbNamSanXuat.SelectedItem.ToString();
            string mauXe = txtMauXe.Text.Trim();
            string soChoNgoi = txtSoChoNgoi.Text.Trim();

            // Kiểm tra xem xe đã tồn tại hay chưa
            if (XeDaTonTaiChua(tenXe, namSanXuat, mauXe, soChoNgoi))
            {
                // Nếu xe đã tồn tại, cộng thêm số lượng xe
                CapNhatSoLuongXe(tenXe, namSanXuat, mauXe, soChoNgoi);
                MessageBox.Show($"Cập nhật số lượng cho xe '{tenXe}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu chưa tồn tại, thêm mới
                // LẤY HÃNG XE
                KeyValuePair<string, string> selectedHangXe = (KeyValuePair<string, string>)cbbHangXe.SelectedItem;
                string idHangXe = selectedHangXe.Key; // Lấy ID_HANGXE từ ComboBox
                string query = "INSERT INTO XE(TENXE, ID_HANGXE, MAUXE, NAMSANXUAT, SOCHONGOI, GIATHUETHEONGAY, TRANGTHAIXE, SO_LUONG) VALUES (@TENXE, @ID_HANGXE, @MAUXE, @NAMSANXUAT, @SOCHONGOI, @GIATHUETHEONGAY, @TRANGTHAIXE, @SO_LUONG)";
                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TENXE", tenXe);
                    cmd.Parameters.AddWithValue("@ID_HANGXE", idHangXe);
                    cmd.Parameters.AddWithValue("@MAUXE", mauXe);
                    cmd.Parameters.AddWithValue("@NAMSANXUAT", namSanXuat);
                    cmd.Parameters.AddWithValue("@SOCHONGOI", soChoNgoi);
                    cmd.Parameters.AddWithValue("@GIATHUETHEONGAY", txtGiaThueTheoNgay.Text.Trim());
                    cmd.Parameters.AddWithValue("@TRANGTHAIXE", cbbTrangThaiXe.SelectedItem.ToString() == "CÓ SẴN" ? "COSAN" : cbbTrangThaiXe.SelectedItem.ToString() == "ĐÃ THUÊ" ? "DATHUE" : "BAOTRI");
                    cmd.Parameters.AddWithValue("@SO_LUONG", numericUpDownSoLuong.Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            lstvQuanLyXe.Items.Clear();
            LoadDuLieuVaoListView();
        }

        private void cbbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbHangXe.SelectedIndex>0)
            {
                KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>) cbbHangXe.SelectedItem;
                string idHangXe = selectedItem.Key;  // Lấy ID hãng xe
                string tenHangXe = selectedItem.Value;  // Lấy tên hãng xe
            }    
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (lstvQuanLyXe.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idXe = lstvQuanLyXe.SelectedItems[0].SubItems[0].Text;

            // Xác nhận xóa xe
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa xe có ID '{idXe}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return; // Hủy thao tác nếu người dùng chọn "No"
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_databaseHelper.GetConnectionString()))
                {
                    connection.Open();

                    // Kiểm tra mã xe có tồn tại trong bảng DATXE hay không
                    string checkDatXeQuery = "SELECT COUNT(*) FROM DATXE WHERE ID_XE = @ID_XE";
                    using (SqlCommand checkCmd = new SqlCommand(checkDatXeQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ID_XE", idXe);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Xe đang được sử dụng trong bảng đặt xe. Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Nếu không tồn tại trong bảng DATXE, tiến hành xóa
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Tắt ràng buộc khóa ngoại tạm thời
                        string disableForeignKeys = "ALTER TABLE THANHTOAN NOCHECK CONSTRAINT ALL;";
                        using (SqlCommand cmd = new SqlCommand(disableForeignKeys, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa bản ghi trong bảng THANHTOAN
                        string deleteThanhToan = @"
                    DELETE FROM THANHTOAN
                    WHERE MADATXE IN (SELECT MADATXE FROM DATXE WHERE ID_XE = @ID_XE)";
                        using (SqlCommand cmd = new SqlCommand(deleteThanhToan, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID_XE", idXe);
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa bản ghi trong bảng DATXE
                        string deleteDatXe = "DELETE FROM DATXE WHERE ID_XE = @ID_XE";
                        using (SqlCommand cmd = new SqlCommand(deleteDatXe, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID_XE", idXe);
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa bản ghi trong bảng XE
                        string deleteXe = "DELETE FROM XE WHERE ID_XE = @ID_XE";
                        using (SqlCommand cmd = new SqlCommand(deleteXe, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID_XE", idXe);
                            cmd.ExecuteNonQuery();
                        }

                        // Bật lại ràng buộc khóa ngoại
                        string enableForeignKeys = "ALTER TABLE THANHTOAN CHECK CONSTRAINT ALL;";
                        using (SqlCommand cmd = new SqlCommand(enableForeignKeys, connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction nếu không có lỗi
                        transaction.Commit();

                        // Xóa dòng khỏi ListView
                        lstvQuanLyXe.Items.Remove(lstvQuanLyXe.SelectedItems[0]);

                        MessageBox.Show("Xóa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show($"Lỗi khi xóa xe: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa xe: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        public void DatLaiMacDinh()
        {
            // Làm mới các trường văn bản
            txtTenXe.Clear();
            txtMauXe.Clear();
            txtSoChoNgoi.Clear();
            txtGiaThueTheoNgay.Clear();

            // Làm mới ComboBox với giá trị mặc định
            cbbHangXe.SelectedIndex = 0;  // Giữ giá trị mặc định của ComboBox
            int currentYear = DateTime.Now.Year;
            cbbNamSanXuat.SelectedItem = currentYear.ToString();  // Cập nhật ComboBox năm sản xuất

            cbbHangXe.Items.Clear();
            TaiHangXe();

            // Cập nhật trạng thái xe và số lượng
            cbbTrangThaiXe.SelectedItem = "CÓ SẴN";  // Giá trị mặc định của trạng thái xe
            numericUpDownSoLuong.Value = 0;  // Đặt lại số lượng

            // Đặt lại focus về trường tên xe
            txtTenXe.Focus();
        }

        private void lstvQuanLyXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstvQuanLyXe.SelectedItems.Count > 0)
            {
                btnSuaXe.Enabled = true;
                btnXoaXe.Enabled = true;
                ListViewItem selecteditem = lstvQuanLyXe.SelectedItems[0];

                txtTenXe.Text = selecteditem.SubItems[1].Text;
                string tenHangXe = selecteditem.SubItems[2].Text;
                txtMauXe.Text = selecteditem.SubItems[3].Text;
                cbbNamSanXuat.SelectedItem = selecteditem.SubItems[4].Text;
                txtSoChoNgoi.Text = selecteditem.SubItems[5].Text;
                txtGiaThueTheoNgay.Text = selecteditem.SubItems[6].Text;
                numericUpDownSoLuong.Value = int.TryParse(selecteditem.SubItems[7].Text, out int soLuong) ? soLuong : 1;
                string trangThai = selecteditem.SubItems[8].Text;
                cbbTrangThaiXe.SelectedItem = trangThai == "CÓ SẴN" ? "CÓ SẴN" :
                                              trangThai == "ĐÃ THUÊ" ? "ĐÃ THUÊ" : "BẢO TRÌ";

                string idHangXe = LayIDHangXeTrongCSDL(tenHangXe);

                if (!string.IsNullOrEmpty(idHangXe))
                {
                    ChonHangXeTrongComBoBox(idHangXe);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hãng xe trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string LayIDHangXeTrongCSDL(string tenHangXe)
        {
            string idHangXe = string.Empty;
            string query = "SELECT ID_HANGXE FROM HANGXE WHERE TENHANGXE = @TENHANGXE";

            using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TENHANGXE", tenHangXe);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    idHangXe = reader["ID_HANGXE"].ToString();
                }
            }

            return idHangXe;
        }

        private void ChonHangXeTrongComBoBox(string idHangXe)
        {
            foreach (var item in cbbHangXe.Items)
            {
                if (item is KeyValuePair<string, string> pair)
                {
                    if (pair.Key == idHangXe)  // So sánh ID hãng xe
                    {
                        cbbHangXe.SelectedItem = item;  // Chọn mục trong ComboBox
                        break;
                    }
                }
            }
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            if (lstvQuanLyXe.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvQuanLyXe.SelectedItems[0];
                string idXe = selectedItem.SubItems[0].Text;
                string tenXe = txtTenXe.Text.Trim();
                string idHangXe = ((KeyValuePair<string, string>)cbbHangXe.SelectedItem).Key;
                string mauXe = txtMauXe.Text.Trim();
                string namSanXuat = cbbNamSanXuat.SelectedItem.ToString();
                string soChoNgoi = txtSoChoNgoi.Text.Trim();
                string giaThue = txtGiaThueTheoNgay.Text.Trim();
                string soluong = numericUpDownSoLuong.Value.ToString();
                string trangThai = cbbTrangThaiXe.SelectedItem.ToString();

                string query = "UPDATE XE SET TENXE = @TENXE, ID_HANGXE = @ID_HANGXE, MAUXE = @MAUXE, " +
                           "NAMSANXUAT = @NAMSANXUAT, SOCHONGOI = @SOCHONGOI, GIATHUETHEONGAY = @GIATHUETHEONGAY, TRANGTHAIXE = @TRANGTHAIXE, SO_LUONG = @SOLUONG " +
                           "WHERE ID_XE = @ID_XE";

                using (SqlConnection connection = new SqlConnection(_databaseHelper._connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID_XE", idXe);  // ID_XE không thay đổi
                    cmd.Parameters.AddWithValue("@TENXE", tenXe);
                    cmd.Parameters.AddWithValue("@ID_HANGXE", idHangXe);
                    cmd.Parameters.AddWithValue("@MAUXE", mauXe);
                    cmd.Parameters.AddWithValue("@NAMSANXUAT", namSanXuat);
                    cmd.Parameters.AddWithValue("@SOCHONGOI", soChoNgoi);
                    cmd.Parameters.AddWithValue("@GIATHUETHEONGAY", giaThue);
                    cmd.Parameters.AddWithValue("@SOLUONG", soluong);
                    cmd.Parameters.AddWithValue("@TRANGTHAIXE", trangThai == "CÓ SẴN" ? "COSAN" : trangThai == "ĐÃ THUÊ" ? "DATHUE" : "BAOTRI");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lstvQuanLyXe.Items.Clear();
                // Sau khi sửa, tải lại dữ liệu vào ListView
                LoadDuLieuVaoListView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDatLaiMacDinh_Click(object sender, EventArgs e)
        {
            DatLaiMacDinh();
            lstvQuanLyXe.Items.Clear();
            LoadDuLieuVaoListView();
        }

        private void btnThemHangXe_Click(object sender, EventArgs e)
        {
            ThemHangXe thx = new ThemHangXe();
            thx.Show();
        }

    }
}
