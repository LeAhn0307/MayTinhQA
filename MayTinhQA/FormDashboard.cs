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
            guna2GroupBox1.Visible = false;
            guna2GroupBox2.Visible = false;
            guna2GroupBox3.Visible = false;
            guna2GroupBox4.Visible = false;
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);
            btnCustomer.Checked= true;
            this.MouseClick += FormDashboard_MouseClick;
        }

        private void addUserControl(UserControl uc)
        {
            foreach (Control ctrl in panel3.Controls.OfType<UserControl>().ToList())
            {
                panel3.Controls.Remove(ctrl); 
                ctrl.Dispose(); 
            }

            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (guna2GroupBox1.Visible)
            {
                guna2GroupBox1.Visible = false;
            }
            else
            {
                HideAllGroupBoxes();
                guna2GroupBox1.Visible = true;
                guna2GroupBox1.BringToFront();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Properties.Settings.Default.SavedUsername = "";
                Properties.Settings.Default.SavedPassword = "";
                Properties.Settings.Default.IsRemembered = false;
                Properties.Settings.Default.Save();
                this.Hide();
                FormLogin dangnhap = new FormLogin();
                dangnhap.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HideAllGroupBoxes();
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);
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
        private void btndonhang_Click(object sender, EventArgs e)
        {
            UC_DonHang uC = new UC_DonHang();
            addUserControl(uC);
        }

        private void btnlienlac_Click(object sender, EventArgs e)
        {
            UC_Email uC = new UC_Email();
            addUserControl(uC);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (guna2GroupBox3.Visible)
            {
                guna2GroupBox3.Visible = false;
            }
            else
            {
                HideAllGroupBoxes();
                guna2GroupBox3.Visible = true;
                guna2GroupBox3.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndanhsach_Click(object sender, EventArgs e)
        {
            UC_Activities uC = new UC_Activities();
            addUserControl(uC);
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            if (guna2GroupBox2.Visible)
            {
                guna2GroupBox2.Visible = false;
            }
            else
            {
                HideAllGroupBoxes();
                guna2GroupBox2.Visible = true;
                guna2GroupBox2.BringToFront();
            }
        }
        private void FormDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Point clickLocation = this.PointToClient(Cursor.Position);

            if (!guna2GroupBox1.Bounds.Contains(clickLocation) &&
                !btnActivity.Bounds.Contains(clickLocation))
            {
                guna2GroupBox1.Visible = false;
            }

            if (!guna2GroupBox2.Bounds.Contains(clickLocation) &&
                !btnbaocao.Bounds.Contains(clickLocation))
            {
                guna2GroupBox2.Visible = false;
            }

            if (!guna2GroupBox3.Bounds.Contains(clickLocation) &&
                !pictureBox2.Bounds.Contains(clickLocation))
            {
                guna2GroupBox3.Visible = false;
            }
            if (!guna2GroupBox4.Bounds.Contains(clickLocation) &&
                !btndichvu.Bounds.Contains(clickLocation))
            {
                guna2GroupBox4.Visible = false;
            }
        }
        private void HideAllGroupBoxes()
        {
            guna2GroupBox1.Visible = false;
            guna2GroupBox2.Visible = false;
            guna2GroupBox3.Visible = false;
            guna2GroupBox4.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmXoaTaiKhoan xoatk = new frmXoaTaiKhoan();
            xoatk.ShowDialog();
        }

        private void btnhoso_Click(object sender, EventArgs e)
        {
            frmHoSo hs = new frmHoSo();
            hs.ShowDialog();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doimk = new frmDoiMatKhau();
            doimk.ShowDialog();
        }

        private void btndoitra_Click(object sender, EventArgs e)
        {
            frmdoitra doitra = new frmdoitra();
            doitra.ShowDialog();
        }

        private void btnNeeds_Click(object sender, EventArgs e)
        {
            UC_CustomerNeeds uc = new UC_CustomerNeeds();
            addUserControl(uc);
        }

        private void btnbh_Click(object sender, EventArgs e)
        {
            frmbaohanh bh = new frmbaohanh();
            bh.ShowDialog();
        }

        private void btndoitra_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            if (guna2GroupBox4.Visible)
            {
                guna2GroupBox4.Visible = false;
            }
            else
            {
                HideAllGroupBoxes();
                guna2GroupBox4.Visible = true;
                guna2GroupBox4.BringToFront();
            }
        }
    }
}

