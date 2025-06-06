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
            ToolStripMenuItem profile = new ToolStripMenuItem("Hồ sơ");
            ToolStripMenuItem changePassword = new ToolStripMenuItem("Đổi mật khẩu");
            ToolStripMenuItem deleteAccount = new ToolStripMenuItem("Xoá tài khoản");
            ToolStripMenuItem logout = new ToolStripMenuItem("Đăng xuất");

            contextMenuStrip1.Items.Add(profile);
            contextMenuStrip1.Items.Add(changePassword);
            contextMenuStrip1.Items.Add(deleteAccount);
            contextMenuStrip1.Items.Add(logout);

            profile.Click += toolStripMenuItem1_Click;
            changePassword.Click += toolStripMenuItem2_Click;
            deleteAccount.Click += toolStripMenuItem3_Click;
            logout.Click += toolStripMenuItem4_Click;
            UC_Home uC = new UC_Home();
            addUserControl(uC);
            //UC_Image uC = new UC_Image();
            //addUserControl(uC);
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
            
            UC_Activities uC = new UC_Activities();
            addUserControl(uC);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            UC_Home uC = new UC_Home();
            addUserControl(uC);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //UC_Reports uC = new UC_Reports();
            //addUserControl(uC);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            UC_CustomerHistory uC = new UC_CustomerHistory();
            addUserControl(uC);
        }

        private void btnBehaviour_Click(object sender, EventArgs e)
        {
            UC_Behaviour uC = new UC_Behaviour();
            addUserControl(uC);
        }

        private void btnNeeds_Click(object sender, EventArgs e)
        {
            UC_CustomerNeeds uC = new UC_CustomerNeeds();
            addUserControl(uC);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmhoso hoso = new frmhoso();
            hoso.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmdoimatkhau doimk = new frmdoimatkhau();
            doimk.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmxoataikhoan xoatk = new frmxoataikhoan();
            xoatk.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FormLogin dangnhap = new FormLogin();
                dangnhap.ShowDialog();
            }
        }
    }
}
