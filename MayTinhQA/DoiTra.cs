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
    public partial class frmdoitra : Form
    {
        public frmdoitra()
        {
            InitializeComponent();
            napdgvPhieudoitra();
        }
        private void napdgvPhieudoitra()
        {
            dgvPhieudoitra.DataSource = Database.Query("select * from phieudoitra");
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            string ngaytao = dtpngaytao.Value.ToString("dd/MM/yyyy");
            string masp = txtidsanpham.Text;
            string manv = txtidnhanvien.Text;
            Database.Excute("insert phieudoitra values ('" + ngaytao + "', '" + masp + "', '" + manv + "')");
            napdgvPhieudoitra();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieudoitra.CurrentRow != null)
                {
                    string maphieu = dgvPhieudoitra.CurrentRow.Cells["idphieudoitra"].Value.ToString();
                    string sql = "delete phieudoitra where idphieudoitra = " + maphieu;
                    Database.Excute(sql);
                    napdgvPhieudoitra();
                }
                else MessageBox.Show("Vui lòng chọn phiếu để xoá!", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra!" + ex.Message, "Thông báo", MessageBoxButtons.OK); }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieudoitra.CurrentRow != null)
                {
                    string maphieu = dgvPhieudoitra.CurrentRow.Cells["idphieudoitra"].Value.ToString();
                    string ngaytao = dtpngaytao.Value.ToString("dd/MM/yyyy");
                    string masp = txtidsanpham.Text;
                    string manv = txtidnhanvien.Text;
                    Database.Excute("update phieudoitra set ngaytao = '" + ngaytao + "',idsanpham =  '" + masp + "',idnhanvien = '" + manv + "' where idphieudoitra = " + maphieu);
                    napdgvPhieudoitra();
                }
                else MessageBox.Show("Vui lòng chọn phiếu để sửa!", "Thống báo", MessageBoxButtons.OK);
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi trong quá trình cập nhật!" + ex.Message, "Thông báo", MessageBoxButtons.OK); }
        }

        private void btnexcel_Click(object sender, EventArgs e)
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

        private void dgvPhieudoitra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvPhieudoitra.Rows[e.RowIndex];
                txtidphieudoitra.Text = row.Cells["idphieudoitra"].Value.ToString();
                dtpngaytao.Value = (DateTime)row.Cells["ngaytao"].Value;
                txtidsanpham.Text = row.Cells["idsanpham"].Value.ToString();
                txtidnhanvien.Text = row.Cells["idnhanvien"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi!" + ex.Message); }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvPhieudoitra.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvPhieudoitra.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvPhieudoitra.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPhieudoitra.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvPhieudoitra.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
    }
}
