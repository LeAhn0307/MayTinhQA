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
    public partial class frmxoataikhoan : Form
    {
        public frmxoataikhoan()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (DeleteAccount(Session.CurrentUser.Tentaikhoan))
                {
                    MessageBox.Show("Tài khoản đã được xóa thành công!");
                    FormLogin login = new FormLogin();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa tài khoản.");
                }
            }
        }

        private bool DeleteAccount(string username)
        {
            string sql = $"DELETE FROM users WHERE tennguoidung = '{username}'";
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
    }
}
