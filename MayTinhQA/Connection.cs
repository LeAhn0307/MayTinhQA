﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace MayTinhQA
{
    class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
