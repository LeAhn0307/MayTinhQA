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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }
        //void Phanquyen()
        //{
        //    // Kiểm tra quyền của người dùng, nếu Idvaitro là false (người dùng bình thường)
        //    if ( = 2)
        //    {
        //        btnQuanlytaikhoan.Enabled = false;  // Ẩn chức năng quản lý tài khoản
        //    }
        //}
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                frmdangnhap dangnhap = new frmdangnhap();
                dangnhap.ShowDialog();
            }
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            this.Text = "Trang Chủ Hệ Thống CRM";
            this.Size = new System.Drawing.Size(800, 600);

            // Tạo menu
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem customerMenu = new ToolStripMenuItem("Khách Hàng");
            ToolStripMenuItem contactMenu = new ToolStripMenuItem("Liên Hệ");
            ToolStripMenuItem settingsMenu = new ToolStripMenuItem("Cài Đặt");

            customerMenu.DropDownItems.Add("Quản Lý Khách Hàng");
            contactMenu.DropDownItems.Add("Quản Lý Liên Hệ");
            settingsMenu.DropDownItems.Add("Thiết Lập Hệ Thống");

            menuStrip.Items.Add(customerMenu);
            menuStrip.Items.Add(contactMenu);
            menuStrip.Items.Add(settingsMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            // Tạo các button chức năng chính
            Button btnCustomerManagement = new Button();
            btnCustomerManagement.Text = "Quản Lý Khách Hàng";
            btnCustomerManagement.Size = new System.Drawing.Size(200, 50);
            btnCustomerManagement.Location = new System.Drawing.Point(150, 100);
            btnCustomerManagement.Click += BtnCustomerManagement_Click;

            Button btnContactManagement = new Button();
            btnContactManagement.Text = "Quản Lý Liên Hệ";
            btnContactManagement.Size = new System.Drawing.Size(200, 50);
            btnContactManagement.Location = new System.Drawing.Point(150, 200);
            btnContactManagement.Click += BtnContactManagement_Click;

            Button btnReports = new Button();
            btnReports.Text = "Báo Cáo";
            btnReports.Size = new System.Drawing.Size(200, 50);
            btnReports.Location = new System.Drawing.Point(150, 300);
            btnReports.Click += BtnReports_Click;

            this.Controls.Add(btnCustomerManagement);
            this.Controls.Add(btnContactManagement);
            this.Controls.Add(btnReports);

            // Label chào mừng
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Chào mừng đến với hệ thống CRM!";
            welcomeLabel.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            welcomeLabel.Location = new System.Drawing.Point(200, 20);
            this.Controls.Add(welcomeLabel);
        }
        private void BtnCustomerManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đi đến màn hình quản lý khách hàng.");
        }

        private void BtnContactManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đi đến màn hình quản lý liên hệ.");
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đi đến màn hình báo cáo.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang khachhang = new frmkhachhang();
        }
    }
}
