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
    public partial class frmHoSo : Form
    {
        public frmHoSo()
        {
            InitializeComponent();
        }
        private void frmHoSo_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                lblTenNhanVien.Text = "Tên: " + Session.CurrentUser.Tentaikhoan;
                lblEmail.Text = "Email: " + Session.CurrentUser.Email;
                lblVaiTro.Text = "Vai Trò: " + Session.CurrentUser.Idvaitro.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập trước.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
