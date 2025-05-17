using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MayTinhQA
{
    public partial class frmdangnhap : Form
    {
        Danhsachtaikhoan danhsachtaikhoan = new Danhsachtaikhoan();
        public frmdangnhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (tentaikhoan.Trim() == "" || matkhau.Trim() == "")
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            else
            {
                TaiKhoan loggedInUser = danhsachtaikhoan.Listtaikhoan
               .FirstOrDefault(user => user.Tentaikhoan == tentaikhoan && user.Matkhau == matkhau);

                if (loggedInUser != null)  // If found
                {
                    if (loggedInUser.Idvaitro == 1)  // Admin
                    {
                        MessageBox.Show("Đăng nhập thành công! Chào mừng Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmhome home = new frmhome();
                        home.ShowDialog();
                        this.Close();
                    }
                    else if (loggedInUser.Idvaitro == 2)  // Regular user
                    {
                        MessageBox.Show("Đăng nhập thành công! Chào mừng người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmhome home = new frmhome();
                        home.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void linkLabel_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmquenmk quenmatkhau = new frmquenmk();
            quenmatkhau.ShowDialog();
        }

        private void linkLabel_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdangki dangki = new frmdangki();
            dangki.ShowDialog();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
