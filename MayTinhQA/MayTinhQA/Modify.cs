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
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string tentaikhoan = dataReader.GetString(1); // Cột tên tài khoản
                    string matkhau = dataReader.GetString(2);    // Cột mật khẩu
                    string email = dataReader.GetString(3);
                    int idvaitro = dataReader.GetInt32(4) ; // Cột vai trò, kiểu int (0: user, 1: admin)

                    users.Add(new TaiKhoan(tentaikhoan, matkhau,email,idvaitro)); // Truyền idvaitro kiểu bool
                }
                sqlConnection.Close();
            }
            return users;
        }

    }

}
