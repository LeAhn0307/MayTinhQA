using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace MayTinhQA
{
    public partial class frmdangki : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True;";
        
        public frmdangki()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,20}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{6,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btndangki_Click(object sender, EventArgs e)
        {
            {
                string tentaikhoan = txttentaikhoan.Text;
                string matkhau = txtmatkhau_dk.Text;
                string xacnhanmk = txtxacnhanmk.Text;
                string email = txtemail.Text;
                if (!checkAccount(tentaikhoan)) { MessageBox.Show("Vui lòng nhập tên tài khoản có 6-20 ký tự, chữ hoa, chữ thường, số"); return; }
                if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu có 6-20 ký tự, chữ hoa, chữ thường, số"); return; }
                if (matkhau != xacnhanmk) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác"); return; }
                if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email"); return; }
                if (modify.users("select * from users where email = '" + email + "'").Count != 0)
                {
                    MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí bằng Email khác!");
                    return;
                }
                    try
                    {
                    string sql = "insert into users VALUES ('" + tentaikhoan + "','" + matkhau + "','" + email + "',2)";
                    modify.Command(sql);
                   
                    if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        this.Hide();
                        frmhome home = new frmhome();
                        home.ShowDialog();
                        this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng đăng kí tên tài khoản khác!");
                    }
            }
        }
    }
}
