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
        private static string connectionString = "";
        public static DataTable Query(string sql)
            //Select
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
    }
}
