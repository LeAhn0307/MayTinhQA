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
    public partial class FormChonSp : Form
    {
        private Rectangle headerCheckBoxArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public delegate void ProductSelectedHandler(int id, string name, int soluong, DataRow fullRow);
        public event ProductSelectedHandler OnProductSelectedHandler;

        public FormChonSp()
        {
            InitializeComponent();
            LoadData();
            LoadFilterOptions();
            dgvsanpham.Paint += dgvsanpham_Paint;
            dgvsanpham.MouseClick -= dgvsanpham_MouseClick;
            dgvsanpham.MouseClick += dgvsanpham_MouseClick;
            dgvsanpham.DataBindingComplete += dgvsanpham_DataBindingComplete;
            dgvsanpham.CellValueChanged += dgvsanpham_CellValueChanged;
            cbbloaisp.SelectedIndexChanged += cbbloaisp_SelectedIndexChanged;
            dgvsanpham.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvsanpham.IsCurrentCellDirty)
                    dgvsanpham.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvsanpham.AllowUserToAddRows = false;
            dgvsanpham.RowHeadersVisible = false;
            dgvsanpham.ColumnWidthChanged += (s, e) => dgvsanpham.Invalidate();
            dgvsanpham.Scroll += (s, e) => dgvsanpham.Invalidate();
            dgvsanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    private void LoadData()
        {
            DataTable dt = Database.Query("SELECT sp.idsanpham, sp.tensanpham, sp.gia, lsp.tenloaisanpham, sp.mota FROM sanpham sp JOIN loaisanpham lsp ON sp.idloaisanpham = lsp.idloaisanpham ORDER BY sp.tensanpham;");
            dgvsanpham.DataSource = null;
            dgvsanpham.Columns.Clear();
            dgvsanpham.DataSource = dt;
            
            if (!dgvsanpham.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check";
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;
                dgvsanpham.Columns.Insert(0, chk);
            }
           

            if (!dgvsanpham.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvsanpham.Columns.Insert(1, sttColumn);
            }
            if (!dgvsanpham.Columns.Contains("SoluongMua"))
            {
                DataGridViewTextBoxColumn soluongColumn = new DataGridViewTextBoxColumn();
                soluongColumn.Name = "SoluongMua";
                soluongColumn.HeaderText = "Số lượng mua";
                soluongColumn.Width = 120;
                dgvsanpham.Columns.Add(soluongColumn);
            }

            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dgvsanpham.Columns.Contains("idsanpham"))
                dgvsanpham.Columns["idsanpham"].Visible = false;

            if (dgvsanpham.Columns.Contains("tensanpham"))
            {
                dgvsanpham.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
                dgvsanpham.Columns["tensanpham"].Width = 180;
            }

            if (dgvsanpham.Columns.Contains("gia"))
            {
                dgvsanpham.Columns["gia"].HeaderText = "Giá";
                dgvsanpham.Columns["gia"].DefaultCellStyle.Format = "N0"; 
                dgvsanpham.Columns["gia"].Width = 100;
            }

            if (dgvsanpham.Columns.Contains("tenloaisanpham"))
            {
                dgvsanpham.Columns["tenloaisanpham"].HeaderText = "Loại sản phẩm";
                dgvsanpham.Columns["tenloaisanpham"].Width = 150;
            }
            if (dgvsanpham.Columns.Contains("mota"))
            {
                dgvsanpham.Columns["mota"].HeaderText = "Thông số kỹ thuật";
                dgvsanpham.Columns["mota"].Width = 300;
            }

            dgvsanpham.ClearSelection();
            dgvsanpham.CurrentCell = null;

            dgvsanpham.ReadOnly = false;

            dgvsanpham_DataBindingComplete(null, null);
            if (dgvsanpham.Columns.Contains("stt"))
            {
                dgvsanpham.Columns["stt"].HeaderText = "STT";
                dgvsanpham.Columns["stt"].Width = 50;
                dgvsanpham.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvsanpham.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvsanpham.Columns["stt"].DefaultCellStyle.Font = dgvsanpham.DefaultCellStyle.Font;
            }

        }
       

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            isHeaderCheckBoxChecked = false;
            LoadData();
            RestoreCheckedRows();
            dgvsanpham.Invalidate();
        }
        public Action<List<SelectedProduct>> OnProductSelected;
        public List<SelectedProduct> PreselectedProducts { get; set; } = new List<SelectedProduct>();
        public class SelectedProduct
        {
            public int IdSanPham { get; set; }
            public string TenSanPham { get; set; }
            public decimal Gia { get; set; }
            public int SoLuong { get; set; }
        }
        public List<string> PreselectedProductName { get; set; } = new List<string>();
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (!(dgvsanpham.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<SelectedProduct> selectedProducts = new List<SelectedProduct>();

            foreach (DataGridViewRow row in dgvsanpham.Rows)
            {
                if (row.Cells["check"].Value != null && Convert.ToBoolean(row.Cells["check"].Value))
                {
                    if (!int.TryParse(Convert.ToString(row.Cells["SoluongMua"].Value), out int soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show($"Vui lòng nhập số lượng hợp lệ cho sản phẩm: {row.Cells["tensanpham"].Value}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idSanPham = Convert.ToInt32(row.Cells["idsanpham"].Value);
                    string tenSanPham = Convert.ToString(row.Cells["tensanpham"].Value);
                    decimal gia = Convert.ToDecimal(row.Cells["gia"].Value);

                    selectedProducts.Add(new SelectedProduct
                    {
                        IdSanPham = idSanPham,
                        TenSanPham = tenSanPham,
                        Gia = gia,
                        SoLuong = soLuong
                    });
                }
            }

            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OnProductSelected?.Invoke(selectedProducts); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void LoadFilterOptions()
        {
            
        }

        private void dgvsanpham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Font defaultFont = new Font("Segoe UI", 10); // Cỡ chữ chuẩn
            dgvsanpham.DefaultCellStyle.Font = defaultFont;
            dgvsanpham.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dgvsanpham.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dgvsanpham.Columns.Contains("stt")) return;

            for (int i = 0; i < dgvsanpham.Rows.Count; i++)
            {
                if (!dgvsanpham.Rows[i].IsNewRow)
                {
                    dgvsanpham.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }

        private void dgvsanpham_Paint(object sender, PaintEventArgs e)
        {
            if (dgvsanpham.Columns.Count == 0) return;

            Rectangle rect = dgvsanpham.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14;

            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvsanpham.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );

        }

        private void dgvsanpham_MouseClick(object sender, MouseEventArgs e)
        {
            if (headerCheckBoxArea.Contains(e.Location))
            {
                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvsanpham.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvsanpham.EndEdit();
                isHeaderCheckBoxClicked = false;
                dgvsanpham.Invalidate(); 
            }
        }
        private HashSet<string> selectedProductNames = new HashSet<string>();

        private void dgvsanpham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var checkColumn = dgvsanpham.Columns["check"];
            if (checkColumn == null || e.ColumnIndex != checkColumn.Index || isHeaderCheckBoxClicked)
                return;
            var row = dgvsanpham.Rows[e.RowIndex];
            string name = row.Cells["tensanpham"].Value?.ToString();

            if (Convert.ToBoolean(row.Cells["check"].Value))
            {
                selectedProductNames.Add(name);
            }
            else
            {
                selectedProductNames.Remove(name);
            }
            bool allChecked = dgvsanpham.Rows.Cast<DataGridViewRow>()
                                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
            isHeaderCheckBoxChecked = allChecked;
            dgvsanpham.Invalidate();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.SelectedIndex == 0)
            {
                labelloaitieuchi.Visible = false;
            }
            else
            {
                labelloaitieuchi.Visible = true;
            }
        }

        private void picboxsort_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tieuChiSapXep = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tieuChiSapXep)) return;

            DataTable dt = dgvsanpham.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0) return;

            IEnumerable<DataRow> sortedRows = dt.AsEnumerable();

            switch (tieuChiSapXep)
            {
                case "Tên sản phẩm":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tensanpham")?.Split(' ').Last());
                    break;
                case "Thông số kỹ thuật":
                case "Thông số kĩ thuật":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("mota"));
                    break;
                case "Giá":
                    sortedRows = sortedRows.OrderBy(row => row.Field<decimal>("gia"));
                    break;
                default:
                    return;
            }

            dgvsanpham.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dgvsanpham.Invalidate();
        }

        private void FormChonSp_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[] {
        "Tên sản phẩm", "Thông số kỹ thuật", "Giá"
        });
            cbbFilter.SelectedIndex = 0;
            cbbloaisp.Items.Clear();
            cbbloaisp.Items.AddRange(new string[]
            {
            "Loại sản phẩm",
            "Laptop"
            });
            
            cbbloaisp.SelectedIndex = 0;
            LoadData();
            if (PreselectedProducts != null)
            {
                foreach (var sp in PreselectedProducts)
                {
                    foreach (DataGridViewRow row in dgvsanpham.Rows)
                    {
                        if (row.Cells["idsanpham"].Value == null)
                            continue;

                        int idSpInGrid = Convert.ToInt32(row.Cells["idsanpham"].Value);
                        if (idSpInGrid == sp.IdSanPham)
                        {
                            row.Cells["check"].Value = true;
                            row.Cells["SoluongMua"].Value = sp.SoLuong;
                            break;
                        }
                    }
                }
            }

        }
        private void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dgvsanpham.Rows)
            {
                string name = row.Cells["tensanpham"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && selectedProductNames.Contains(name))
                {
                    row.Cells["check"].Value = true;
                }
            }
        }

        private void labelloaitieuchi_Click(object sender, EventArgs e)
        {
            labelloaitieuchi.Visible = false;
            cbbFilter.SelectedIndex = 0;
            isHeaderCheckBoxChecked = false; 
            RestoreCheckedRows();
            dgvsanpham.Invalidate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = !string.IsNullOrWhiteSpace(txtSearch.Text);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi)) return;

            DataTable dt = dgvsanpham.DataSource as DataTable;
            if (dt == null) return;

            IEnumerable<DataRow> filteredRows = null;

            switch (tieuChi)
            {
                case "Tên sản phẩm":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tensanpham") ?? "").ToLower().Contains(tuKhoa));
                    break;
                case "Giá":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => row.Field<decimal>("gia").ToString().Contains(tuKhoa));
                    break;
                case "Thông số kỹ thuật":
                case "Thông số kĩ thuật":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("mota") ?? "").ToLower().Contains(tuKhoa));
                    break;
            }

            if (filteredRows != null && filteredRows.Any())
                dgvsanpham.DataSource = filteredRows.CopyToDataTable();
            else
                dgvsanpham.DataSource = dt.Clone();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvsanpham.Invalidate();
        }

        private void picboxrs_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = false;
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            LoadData();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvsanpham.Invalidate();
        }
        private void labelloaidichvu_Click(object sender, EventArgs e)
        {
            labelloaidichvu.Visible = false;
            cbbloaisp.SelectedIndex = 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvsanpham.Invalidate();
        }

        private void cbbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaisp.SelectedIndex == 0)
            {
                labelloaidichvu.Visible = false;

                RestoreCheckedRows();
                isHeaderCheckBoxChecked = false;
                dgvsanpham.Invalidate();
                return;
            }

            labelloaidichvu.Visible = true;
            string selectedLoaiSP = cbbloaisp.SelectedItem?.ToString();
            string query =
            @"SELECT sp.idsanpham, sp.tensanpham, sp.gia, lsp.tenloaisanpham, sp.mota FROM sanpham sp JOIN loaisanpham lsp ON sp.idloaisanpham = lsp.idloaisanpham WHERE lsp.tenloaisanpham = N'" + selectedLoaiSP.Replace("'", "''") + "'";
            DataTable dt = Database.Query(query);
            dgvsanpham.DataSource = dt;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvsanpham.Invalidate();
        }
    }

}