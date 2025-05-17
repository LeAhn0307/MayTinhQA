using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MayTinhQA
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; // insert, update, delete
        SqlDataReader dataReader; // doc du lieu trong bang

        public List<TaiKhoan> users(String sql)
        {
            List<TaiKhoan> users = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {

                    users.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetInt32(4))); // Truyền idvaitro kiểu bool
                }
                sqlConnection.Close();
            }
            return users;
        }
        public void Command(string sql)
        {
            using (SqlConnection connection = Connection.GetSqlConnection()) 
            {
                connection.Open();
                sqlCommand = new SqlCommand (sql, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
    }

}
