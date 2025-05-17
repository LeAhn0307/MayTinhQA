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
    public partial class frmquenmk : Form
    {
        public frmquenmk()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void btnlaylaimk_Click(object sender, EventArgs e)
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
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu:" + modify.users(sql)[0].Matkhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }
            }
        }
    }
}
