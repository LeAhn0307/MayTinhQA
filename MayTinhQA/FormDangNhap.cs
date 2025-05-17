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
using static MayTinhQA.frmhome;

namespace MayTinhQA
{
    public partial class frmdangnhap : Form
    {
    
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
                string sql = "select * from users where tennguoidung = '" + txttaikhoan.Text + "'and matkhau ='" + txtmatkhau.Text + "'";
                if (modify.users(sql).Count != 0)
                {
                    TaiKhoan user = modify.users(sql)[0];
                    Session.CurrentUser = user;
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    frmhome home = new frmhome();
                    home.ShowDialog();
                    this.Close();
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
