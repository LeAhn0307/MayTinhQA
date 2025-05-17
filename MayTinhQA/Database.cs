using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MayTinhQA
{
    class Database
    {
        private static string connectionString = "Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True";
        public static DataTable Query(string sql)
        //Select --> Table
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public static void Excute(string sql)
        //thuc thi cac cau lenh Insert, Update, Delete,...
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable TimKiem(string search)
        {
            string sql = "SELECT * FROM khachhang WHERE tenkhachhang LIKE @tk OR idkhachhang = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {               
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tk", "%" + search + "%");
                    command.Parameters.AddWithValue("@id", search);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
