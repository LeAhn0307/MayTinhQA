using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace MayTinhQA
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
            
        }
        public class Session
        {
            public static TaiKhoan CurrentUser;
        }
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                frmdangnhap dangnhap = new frmdangnhap();
                dangnhap.ShowDialog();
            }
        }

        private void khachHangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void khachHangToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null && Session.CurrentUser.Idvaitro == 1)
            {
                DMquanlydvkh.Visible = true; 
            }
            else
            {
                DMquanlydvkh.Visible = false; 
            }
        }

        private void donBanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taiKhoanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void donBanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void danhmucNV_Click(object sender, EventArgs e)
        {
            frmnhanvien nhanvien = new frmnhanvien();
            nhanvien.ShowDialog();
        }

        private void danhmucSP_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DMquanlysp_Click(object sender, EventArgs e)
        {
            frmsanpham sp = new frmsanpham();
            sp.ShowDialog();
        }

        private void DMdonhang_Click(object sender, EventArgs e)
        {
            frmdonhang dh = new frmdonhang();
            dh.ShowDialog();
        }

        private void DMhoadon_Click(object sender, EventArgs e)
        {
            frmhoadon hoadon = new frmhoadon();
            hoadon.ShowDialog();
        }

        private void DMkhuyenmai_Click(object sender, EventArgs e)
        {
            frmkhuyenmai km = new frmkhuyenmai();
            km.ShowDialog();
        }

        private void DMlichsu_Click(object sender, EventArgs e)
        {
            frmlichsu ls = new frmlichsu();
            ls.ShowDialog();
        }

        private void DMkhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang khachhang = new frmkhachhang();
            khachhang.ShowDialog();
        }

        private void DMhanhvikh_Click(object sender, EventArgs e)
        {
            frmhanhvikh hanhvi = new frmhanhvikh();
            hanhvi.ShowDialog();
        }

        private void DMlichsugiaodich_Click(object sender, EventArgs e)
        {
            frmlichsu lichsu = new frmlichsu();
            lichsu.ShowDialog();
        }
    }
}
