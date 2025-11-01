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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace AppChoThueXe
{
    public partial class ChucNangThanhToan : UserControl
    {
        public ChucNangThanhToan()
        {
            InitializeComponent();
        }
        private DatabaseHelper _databaseHelper = new DatabaseHelper();
        private void LoadDuLieuVaoListView()
        {
            string query = "SELECT * FROM THANHTOAN WHERE TRANGTHAI = 'DATHANHTOAN'";  // Câu truy vấn SQL
            DataTable data = _databaseHelper.GetDataFromDatabase(query);

            // Thêm dữ liệu vào ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID_THANHTOAN"].ToString());
                item.SubItems.Add(row["MADATXE"].ToString());
                item.SubItems.Add(row["NGAYTHANHTOAN"].ToString());
                item.SubItems.Add(row["SOTIEN"].ToString()); // Hiển thị tên hãng xe từ bảng HANGXE
                string trangThai = row["TRANGTHAI"].ToString();
                string trangThaiHienThi = "";
                switch (trangThai)
                {
                    case "DATHANHTOAN":
                        trangThaiHienThi = "ĐÃ THANH TOÁN";
                        break;
                    default:
                        trangThaiHienThi = "CHƯA THANH TOÁN";
                        break;
                }
                item.SubItems.Add(trangThaiHienThi);
                lstvQuanLyThanhToan.Items.Add(item);
            }
            lstvQuanLyThanhToan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstvQuanLyThanhToan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ChucNangThanhToan_Load(object sender, EventArgs e)
        {
            LoadDuLieuVaoListView();
            lstvQuanLyThanhToan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lstvQuanLyThanhToan.Items.Clear();
            LoadDuLieuVaoListView();
        }

        private void lstvQuanLyThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvQuanLyThanhToan.SelectedItems.Count > 0)
            {   
                string maDatXe = lstvQuanLyThanhToan.SelectedItems[0].SubItems[0].Text;
                MessageBox.Show($"Debug: Mã đặt xe được chọn: {maDatXe}", "Debug");
                string query = $@"
            SELECT *
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
                            // Lấy thông tin từ kết quả truy vấn
                            string tenKhachHang = reader["TENKHACHHANG"].ToString();
                            string tenXe = reader["TENXE"].ToString();
                            DateTime ngaythanhtoan = Convert.ToDateTime(reader["NGAYTHANHTOAN"]);
                            decimal soTien = Convert.ToDecimal(reader["TONGTIEN"]);

                            txtTenXe.Text = tenXe;
                            txtTenKhachHang.Text = tenKhachHang;
                            txtSoTienThanhToan.Text = soTien.ToString();
                            dateTimeNgayThanhToan.Value = ngaythanhtoan;

                            string ngayThanhToanText = ngaythanhtoan.ToString("dd/MM/yyyy");

                            MessageBox.Show(
                            $"Thông tin đơn hàng:\n" +
                            $"- Mã đơn: {maDatXe}\n" +
                            $"- Khách hàng: {tenKhachHang}\n" +
                            $"- Tên xe: {tenXe}\n" +
                            $"- Số tiền: {soTien:C}\n" + // Định dạng số tiền
                            $"- Ngày thanh toán: {ngayThanhToanText}\n",
                            "Thông tin đơn hàng",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và DateTimePicker
            string tenKhachHang = txtTenKhachHang.Text;
            string tenXe = txtTenXe.Text;
            string soTien = txtSoTienThanhToan.Text;
            string ngayThanhToan = dateTimeNgayThanhToan.Value.ToString("dd/MM/yyyy");

            // Mở FolderBrowserDialog để chọn thư mục lưu hóa đơn
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục người dùng chọn
                string selectedFolder = folderDialog.SelectedPath;

                // Đặt tên file hóa đơn (ví dụ "invoice.pdf")
                string pdfFilePath = Path.Combine(selectedFolder, "invoice.pdf");

                // Tạo đối tượng PDF
                Document doc = new Document(PageSize.A4);

                // Tải font Unicode từ file .ttf, ví dụ Times New Roman hoặc VnArial
                string fontPath = @"C:\Windows\Fonts\times.ttf"; // Thay bằng đường dẫn đến font trên máy bạn
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                // Tạo file PDF
                PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));

                // Mở tài liệu PDF để thêm nội dung
                doc.Open();

                // Thêm tiêu đề và nội dung hóa đơn vào PDF với định dạng chuyên nghiệp
                Paragraph header = new Paragraph("HÓA ĐƠN THANH TOÁN", fontHeader)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(header);

                // Thêm thông tin khách hàng
                doc.Add(new Paragraph($"Khách hàng: {tenKhachHang}", fontNormal));
                doc.Add(new Paragraph($"Tên xe: {tenXe}", fontNormal));
                doc.Add(new Paragraph($"Số tiền: {soTien}", fontNormal));
                doc.Add(new Paragraph($"Ngày thanh toán: {ngayThanhToan}", fontNormal));

                // Đóng tài liệu PDF
                doc.Close();

                // Thông báo khi xuất PDF thành công
                MessageBox.Show($"Hóa đơn đã được xuất ra PDF: {pdfFilePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không chọn thư mục để lưu hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
