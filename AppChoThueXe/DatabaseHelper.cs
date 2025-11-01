using System.Data;
using System.Data.SqlClient;

namespace AppChoThueXe
{
    public class DatabaseHelper
    {
        // Connection string ở đây
        public string _connectionString = "Server=localhost\\SQLEXPRESS;Database=CAR_MANAGER_DB;Integrated Security=True;";

        // Phương thức trả về connection string
        public string GetConnectionString()
        {
            return _connectionString;
        }

        // Hàm lấy dữ liệu từ database
        public DataTable GetDataFromDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Các hàm khác mà bạn cần có thể thêm vào đây, ví dụ hàm kiểm tra xe
    }
}
