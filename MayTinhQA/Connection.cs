using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MayTinhQA
{
    class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-2023ILB\\SQLEXPRESS01;Initial Catalog=crm;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
