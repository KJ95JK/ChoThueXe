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
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Input;

namespace AppChoThueXe
{
    public partial class ThongTinXe_DatDon : Form
    {

        private int _carID;
        public ThongTinXe_DatDon(int selectedCarID)
        {
            InitializeComponent();
            _carID = selectedCarID;
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            // Sử dụng DatabaseHelper để lấy dữ liệu chi tiết của xe
            DatabaseHelper dbHelper = new DatabaseHelper();

            if (int.TryParse(_carID.ToString(), out int validCarID))
            {
                string query = @"
                    SELECT 
                        ID_XE,
                        TENXE, 
                        ID_HANGXE, 
                        MAUXE, 
                        NAMSANXUAT, 
                        SOCHONGOI, 
                        GIATHUETHEONGAY, 
                        TRANGTHAIXE, 
                        SO_LUONG, 
                        (SELECT TENHANGXE FROM HANGXE WHERE HANGXE.ID_HANGXE = XE.ID_HANGXE) AS TENHANGXE
                    FROM XE
                    WHERE ID_XE = " + _carID;

                DataTable details = dbHelper.GetDataFromDatabase(query);

                // Thực hiện truy vấn
                if (details.Rows.Count > 0)
                {
                    DataRow row = details.Rows[0];

                    // Tạo và hiển thị thông tin chi tiết xe
                    lb1.Text = row["TENXE"].ToString();
                    lb2.Text = row["TENHANGXE"].ToString();
                    lb3.Text = row["MAUXE"].ToString();
                    lb4.Text = row["NAMSANXUAT"].ToString();
                    lb5.Text = row["SOCHONGOI"].ToString();
                    lb6.Text = row["GIATHUETHEONGAY"].ToString();
                    lb7.Text = row["TRANGTHAIXE"].ToString();
                    lb8.Text = row["SO_LUONG"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lb1.Text = "null";
                    lb2.Text = "null";
                    lb3.Text = "null";
                    lb4.Text = "null";
                    lb5.Text = "null";
                    lb6.Text = "null";
                    lb7.Text = "null";
                    lb8.Text = "null";
                }
            }
            else
            {
                MessageBox.Show("ID xe không hợp lệ.");
            }
        }

        public delegate void CarSelectedEventHandler(int selectedCarID);
        public event CarSelectedEventHandler CarSelected;
        private void btnChonXe_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện để thông báo form trước đó biết
            CarSelected?.Invoke(_carID);

            // Đóng form chọn xe
            this.Close();
        }
    }
}
