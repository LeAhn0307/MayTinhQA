using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA
{
    public partial class frmdoimatkhau : Form
    {
        public frmdoimatkhau()
        {
            InitializeComponent();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            string oldPassword = txtmkcu.Text;
            string newPassword = txtmkmoi.Text;
            string confirmPassword = txtnhaplaimk.Text;
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!");
                return;
            }
            if (Session.CurrentUser.Matkhau != oldPassword)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                return;
            }
            if (UpdatePassword(Session.CurrentUser.Tentaikhoan, newPassword))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đổi mật khẩu.");
            }
        }
        private bool UpdatePassword(string username, string newPassword)
        {
            string sql = $"UPDATE users SET matkhau = '{newPassword}' WHERE tennguoidung = '{username}'";
            try
            {
                Database.Excute(sql); 
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                return false; 
            }

        }

        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
