using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MayTinhQA
{
    public partial class frmnhanvien : Form
    {
       
        public frmnhanvien()
        {
            InitializeComponent();
            napdgvNhanVien();
        }
        private void napdgvNhanVien()
        {
            dgvNhanVien.DataSource = Database.Query("Select * from nhanvien");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                txttennhanvien.Focus();
                return;
            }

            try
            {
                string hoten = txttennhanvien.Text;
                string chucvu = txtchucvu.Text;
                Database.Excute(" insert nhanvien values('" + hoten +"','" + chucvu + "')");
                napdgvNhanVien();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập.", "Có lỗi xẩy ra!");
            }
        }
        private void txtidkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.CurrentRow != null)
                {
                    string idnhanvien = dgvNhanVien.CurrentRow.Cells["idnhanvien"].Value.ToString();
                    string hoten = txttennhanvien.Text;
                    string chucvu = txtchucvu.Text;
                    Database.Excute(" update nhanvien set tennhanvien = N'" + hoten + "', chucvu = '" + chucvu + "'");
                    napdgvNhanVien();
                }
                else MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật!" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
}

        private void btnxoa_Click(object sender, EventArgs e)
        {           
            try
            {
                if(dgvNhanVien.CurrentRow != null)
                {
                    string idnhanvien = dgvNhanVien.CurrentRow.Cells["idnhanvien"].Value.ToString();
                    string sql = " delete nhanvien where idnhanvien = " + idnhanvien;
                    napdgvNhanVien();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi dữ liệu! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void datagridnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridnhanvien_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txttennhanvien.Text = row.Cells["tennhanvien"].Value.ToString();
                txtchucvu.Text = row.Cells["tenkhachhang"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void datagridnhanvien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datagridnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {                       
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tk = txttimkiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tk))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc id nhân viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DataTable table = Database.TimKiem(tk);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                dgvNhanVien.DataSource = table;
            }
        }
    }
}
