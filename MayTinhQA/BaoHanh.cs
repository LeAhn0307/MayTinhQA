using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace MayTinhQA
{
    public partial class frmbaohanh : Form
    {
        public frmbaohanh()
        {
            InitializeComponent();
            napdgvPhieubaohanh();
        }
        private void napdgvPhieubaohanh()
        {
            dgvPhieubaohanh.DataSource = Database.Query("select * from phieubaohanh");
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            string ngaytao = dtpngaytao.Value.ToString("dd/MM/yyyy");
            string ngayketthuc = dtpngayketthuc.Value.ToString("dd/MM/yyyy");
            string masp = txtidsanpham.Text;
            string manv = txtidnhanvien.Text;
            Database.Excute("insert phieubaohanh values('" + ngaytao + "', '" + ngayketthuc + "', '" + masp + "', '" + manv + "')");
            napdgvPhieubaohanh();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieubaohanh.CurrentRow != null)
                {
                    string maphieu = dgvPhieubaohanh.CurrentRow.Cells["idphieubaohanh"].Value.ToString();
                    string sql = "delete phieubaohanh where idphieubaohanh =" + maphieu;
                    Database.Excute(sql);
                    napdgvPhieubaohanh();
                }
                else MessageBox.Show("Vui lòng chọn phiếu để xoá!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra!" + ex.Message, "Thông báo", MessageBoxButtons.OK); }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieubaohanh.CurrentRow != null)
                {
                    string maphieu = dgvPhieubaohanh.CurrentRow.Cells["idphieubaohanh"].Value.ToString();
                    string ngaytao = dtpngaytao.Value.ToString("dd/MM/yyyy");
                    string ngayketthuc = dtpngayketthuc.Value.ToString("dd/MM/yyyy");
                    string masp = txtidsanpham.Text;
                    string manv = txtidnhanvien.Text;
                    Database.Excute("update phieubaohanh set ngaytao = '" + ngaytao + "', ngayketthuc = '" + ngayketthuc + "', idsanpham = '" + masp + "', idnhanvien = '" + manv + "' where idphieubaohanh = " + maphieu);
                    napdgvPhieubaohanh();
                }
                else MessageBox.Show("Vui lòng chọn phiếu để sửa!", "Thống báo", MessageBoxButtons.OK);
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi trong quá trình cập nhật!" + ex.Message, "Thông báo", MessageBoxButtons.OK); }
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công! \n" + ex.Message);
                }
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvPhieubaohanh.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvPhieubaohanh.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvPhieubaohanh.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPhieubaohanh.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvPhieubaohanh.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void dgvPhieubaohanh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvPhieubaohanh.Rows[e.RowIndex];
                txtidphieubaohanh.Text = row.Cells["idphieubaohanh"].Value.ToString();
                dtpngaytao.Value = (DateTime)row.Cells["ngaytao"].Value;
                dtpngayketthuc.Value = (DateTime)row.Cells["ngayketthuc"].Value;
                txtidsanpham.Text = row.Cells["idsanpham"].Value.ToString();
                txtidnhanvien.Text = row.Cells["idnhanvien"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi!" + ex.Message); }
        }
    }
}
