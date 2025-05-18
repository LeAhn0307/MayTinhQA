using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayTinhQA.frmhome;

namespace MayTinhQA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (tentaikhoan.Trim() == "" || matkhau.Trim() == "")
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            else
            {
                string sql = "select * from users where tennguoidung = '" + txttaikhoan.Text + "'and matkhau ='" + txtmatkhau.Text + "'";
                if (modify.users(sql).Count != 0)
                {
                    TaiKhoan user = modify.users(sql)[0];
                    Session.CurrentUser = user;
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    FormDashboard home = new FormDashboard();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            frmquenmk quenmatkhau = new frmquenmk();
            quenmatkhau.ShowDialog();
        }

        private void labelOut_Click(object sender, EventArgs e)
        {
            frmdangki dangki = new frmdangki();
            dangki.ShowDialog();
        }
    }
}
