using MayTinhQA.UserControls;
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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            UC_Home uC = new UC_Home();
            addUserControl(uC);
        }
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FormLogin dangnhap = new FormLogin();
                dangnhap.ShowDialog();
            }
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            UC_Home uC = new UC_Home();
            addUserControl(uC);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);

        }
    }
}
