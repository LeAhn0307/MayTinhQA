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
using System.Net;
using System.Net.Mail;

namespace MayTinhQA
{
    public partial class FormEmail : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=crm1;Integrated Security=True"; 
        public FormEmail()
        {
            InitializeComponent();
            LoadKhachHang();
        }
        private void LoadKhachHang()
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idkhachhang, tenkhachhang FROM khachhang";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idKhachHang = reader.GetInt32(0);
                        string tenKhachHang = reader.GetString(1);
                        comboBoxKhachHang.Items.Add(new { Id = idKhachHang, Name = tenKhachHang });
                    }
                }
            }

            comboBoxKhachHang.DisplayMember = "Name";
            comboBoxKhachHang.ValueMember = "Id";
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
                if (comboBoxKhachHang.SelectedItem != null && !string.IsNullOrEmpty(txtMessage.Text))
                {
                    var selectedCustomer = (dynamic)comboBoxKhachHang.SelectedItem;
                    int khachHangId = selectedCustomer.Id;

                    string email = GetEmailById(khachHangId);
                    if (!string.IsNullOrEmpty(email))
                    {
                        SendEmail(email, txtMessage.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy email của khách hàng.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng và nhập tin nhắn.");
                }
            }
        
        private string GetEmailById(int idKhachHang)
        {
            string email = string.Empty;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT email FROM khachhang WHERE idkhachhang = @idKhachHang";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idKhachHang", idKhachHang);
                    email = command.ExecuteScalar()?.ToString();
                }
            }
            return email;
        }
        private void SendEmail(string toEmail, string messageBody)
        {
            try
            {
                MailMessage mail = new MailMessage("katoriii372003@gmail.com", toEmail)
                {
                    Subject = "Thông báo từ hệ thống",
                    Body = messageBody,
                    IsBodyHtml = false
                };

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com") 
                {
                    Port = 587,
                    Credentials = new NetworkCredential("katoriii372003@gmail.com", "pddj kpii mcpj omcj"),  
                    EnableSsl = true
                };

                smtpClient.Send(mail);
                MessageBox.Show("Email đã được gửi thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
            }
        }
    }
}
