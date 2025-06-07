using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MayTinhQA.FormDashboard;

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
                    Current_user.CurrentUser = user;
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    
                    if (checkboxkeeplogin.Checked)
                    {   
                        Properties.Settings.Default.SavedUsername = tentaikhoan;
                        Properties.Settings.Default.SavedPassword = matkhau;
                        Properties.Settings.Default.IsRemembered = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.SavedUsername = "";
                        Properties.Settings.Default.SavedPassword = "";
                        Properties.Settings.Default.IsRemembered = false;
                        Properties.Settings.Default.Save();
                    }
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
            this.Hide();
            FormForgotPassword quenMk = new FormForgotPassword();
            quenMk.ShowDialog();
        }

        private void labelOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp dangki = new FormSignUp();
            dangki.ShowDialog();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private bool isPasswordVisible = false;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            txtmatkhau.UseSystemPasswordChar = !isPasswordVisible;

            if (isPasswordVisible)
            {
                guna2PictureBox1.Image = Properties.Resources.Capture;  // Mở - hiển thị mật khẩu
            }
            else
            {
                guna2PictureBox1.Image = Properties.Resources._65000; // Đóng - ẩn mật khẩu
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsRemembered)
            {
                string tentaikhoan = Properties.Settings.Default.SavedUsername;
                string matkhau = Properties.Settings.Default.SavedPassword;
                string sql = $"SELECT * FROM users WHERE tennguoidung = '{tentaikhoan}' AND matkhau = '{matkhau}'";
                if (modify.users(sql).Count != 0)
                {
                    TaiKhoan user = modify.users(sql)[0];
                    Current_user.CurrentUser = user;
                    FormDashboard home = new FormDashboard();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
