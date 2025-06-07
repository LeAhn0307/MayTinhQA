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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
            label3.Text = "";
        }
        Modify modify = new Modify();
        private void btnResend_Click(object sender, EventArgs e)
        {
            string email = txtemaildangki.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email dăng kí!");
            }
            else
            {
                string sql = "select * from users where email = '" + email + "'";
                if (modify.users(sql).Count != 0)
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Mật khẩu:" + modify.users(sql)[0].Matkhau;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Email này chưa được đăng kí";
                }
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
