using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MayTinhQA
{
    public partial class frmHoSo : Form
    {
        public frmHoSo()
        {
            InitializeComponent();
        }

        private void frmHoSo_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }
        private void LoadUserProfile()
        {
            if (Session.CurrentUser != null)
            {
                int userId = Session.CurrentUser.Idusers;
                txtemail.Text = Session.CurrentUser.Email;
                LoadNhanVienAndChucVu(userId);
            }
            else
            {
                MessageBox.Show("Chưa có người dùng nào đăng nhập.");
            }
        }
        private void LoadNhanVienAndChucVu(int userId)
        {
            string connectionString = " ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT nv.tennhanvien, cv.tenchucvu
                    FROM nhanvien nv
                    JOIN chucvu cv ON nv.chucvu = cv.idchucvu
                    WHERE nv.idusers = @userId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenNhanVien = reader["tennhanvien"].ToString();
                            string tenChucVu = reader["tenchucvu"].ToString();
                            txttennguoidung.Text = tenNhanVien; 
                            txtchucvu.Text = tenChucVu; 
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                        }
                    }
                }
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

