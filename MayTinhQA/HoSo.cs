using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MayTinhQA
{
    public partial class frmhoso : Form
    {       
        public frmhoso()
        {
            InitializeComponent();         
        }

        private void frmhoso_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
