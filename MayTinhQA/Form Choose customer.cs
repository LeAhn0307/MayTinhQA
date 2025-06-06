using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MayTinhQA
{
    public partial class FormChooseCus : Form
    {
        private Rectangle headerCheckBoxArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public delegate void CustomerSelectedHandler(int id, string name, DataRow fullRow);
        public event CustomerSelectedHandler OnCustomerSelected;
        public FormChooseCus() 
        {
            InitializeComponent();
            LoadData();
            LoadFilterOptions();
            dgvkhachhang.Paint += DgvKhachhang_Paint;
            dgvkhachhang.MouseClick += DgvKhachhang_MouseClick;
            dgvkhachhang.DataBindingComplete += DgvKhachhang_DataBindingComplete;
            dgvkhachhang.CellValueChanged += DgvKhachhang_CellValueChanged;
            dgvkhachhang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvkhachhang.IsCurrentCellDirty)
                    dgvkhachhang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvkhachhang.AllowUserToAddRows = false;
            dgvkhachhang.RowHeadersVisible = false;
            dgvkhachhang.ColumnWidthChanged += (s, e) => dgvkhachhang.Invalidate();
            dgvkhachhang.Scroll += (s, e) => dgvkhachhang.Invalidate();
            dgvkhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void LoadData()
        {
            DataTable dt = Database.Query("SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai, kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi, ghichu FROM khachhang kh JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen");

            dgvkhachhang.DataSource = null;
            dgvkhachhang.Columns.Clear();
            dgvkhachhang.DataSource = dt;

            if (!dgvkhachhang.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check";
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;
                dgvkhachhang.Columns.Insert(0, chk);
            }


            if (!dgvkhachhang.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvkhachhang.Columns.Insert(1, sttColumn);
            }


            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dgvkhachhang.Columns.Contains("idkhachhang"))
                dgvkhachhang.Columns["idkhachhang"].Visible = false;
            if (dgvkhachhang.Columns.Contains("tenkhachhang"))
            {
                dgvkhachhang.Columns["tenkhachhang"].HeaderText = "Họ Tên";
                dgvkhachhang.Columns["tenkhachhang"].Width = 128;
            }

            if (dgvkhachhang.Columns.Contains("ngaysinh"))
            {
                dgvkhachhang.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
                dgvkhachhang.Columns["ngaysinh"].Width = 128;
            }

            if (dgvkhachhang.Columns.Contains("email"))
            {
                dgvkhachhang.Columns["email"].HeaderText = "Email";
                dgvkhachhang.Columns["email"].Width = 128;
            }

            if (dgvkhachhang.Columns.Contains("dienthoai"))
            {
                dgvkhachhang.Columns["dienthoai"].HeaderText = "Điện Thoại";
                dgvkhachhang.Columns["dienthoai"].Width = 128;
            }

            if (dgvkhachhang.Columns.Contains("diachi"))
            {
                dgvkhachhang.Columns["diachi"].HeaderText = "Địa Chỉ";
                dgvkhachhang.Columns["diachi"].Width = 128;
            }

            if (dgvkhachhang.Columns.Contains("ghichu"))
            {
                dgvkhachhang.Columns["ghichu"].HeaderText = "Ghi chú";
                dgvkhachhang.Columns["ghichu"].Width = 320;
            }

            dgvkhachhang.ClearSelection();
            dgvkhachhang.CurrentCell = null;

            dgvkhachhang.ReadOnly = false;

            DgvKhachhang_DataBindingComplete(null, null);
            if (dgvkhachhang.Columns.Contains("stt"))
            {
                dgvkhachhang.Columns["stt"].HeaderText = "STT";
                dgvkhachhang.Columns["stt"].Width = 50;
                dgvkhachhang.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvkhachhang.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvkhachhang.Columns["stt"].DefaultCellStyle.Font = dgvkhachhang.DefaultCellStyle.Font;
            }
        }
        public Action<List<DataRow>> OnCustomersSelected;
        public Action<List<string>> OnCustomerNamesSelected;
        public List<string> PreselectedCustomerNames { get; set; } = new List<string>();
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (!(dgvkhachhang.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> selectedNames = new List<string>();

            foreach (DataGridViewRow row in dgvkhachhang.Rows)
            {
                if (row.Cells["check"].Value != null && Convert.ToBoolean(row.Cells["check"].Value))
                {
                    string name = row.Cells["tenkhachhang"].Value?.ToString();
                    if (!string.IsNullOrEmpty(name))
                        selectedNames.Add(name);
                }
            }

            if (selectedNames.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            OnCustomerNamesSelected?.Invoke(selectedNames);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void LoadFilterOptions()
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new[] {
                        "Tên khách hàng", "Ngày sinh", "Địa chỉ", "Số điện thoại", "Email", "Ghi chú"
                    });
            cbbFilter.SelectedIndex = 0;
        }

        private void DgvKhachhang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Font defaultFont = new Font("Segoe UI", 10); // Cỡ chữ chuẩn
            dgvkhachhang.DefaultCellStyle.Font = defaultFont;
            dgvkhachhang.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dgvkhachhang.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dgvkhachhang.Columns.Contains("stt")) return;

            for (int i = 0; i < dgvkhachhang.Rows.Count; i++)
            {
                if (!dgvkhachhang.Rows[i].IsNewRow)
                {
                    dgvkhachhang.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }
        private void DgvKhachhang_Paint(object sender, PaintEventArgs e)
        {
            if (dgvkhachhang.Columns.Count == 0) return;

            Rectangle rect = dgvkhachhang.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // ✅ Trừ đi phần cuộn ngang để checkbox di chuyển cùng header
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvkhachhang.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );

        }

        private void DgvKhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            if (headerCheckBoxArea.Contains(e.Location))
            {
                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvkhachhang.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvkhachhang.EndEdit();
                isHeaderCheckBoxClicked = false;
                dgvkhachhang.Invalidate(); 
            }
        }
        private HashSet<string> selectedCustomerNames = new HashSet<string>();
        private void DgvKhachhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvkhachhang.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                var row = dgvkhachhang.Rows[e.RowIndex];
                string name = row.Cells["tenkhachhang"].Value?.ToString();

                if (Convert.ToBoolean(row.Cells["check"].Value))
                {
                    selectedCustomerNames.Add(name);
                }
                else
                {
                    selectedCustomerNames.Remove(name);
                }

                bool allChecked = dgvkhachhang.Rows.Cast<DataGridViewRow>()
                                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
                isHeaderCheckBoxChecked = allChecked;
                dgvkhachhang.Invalidate();
            }
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

            DataTable dt = dgvkhachhang.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0) return;

            IEnumerable<DataRow> sortedRows = dt.AsEnumerable();

            switch (tieuChiSapXep)
            {
                case "Tên khách hàng":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tenkhachhang")?.Split(' ').Last());
                    break;
                case "Ngày sinh":
                    sortedRows = sortedRows.OrderBy(row => row.Field<DateTime>("ngaysinh"));
                    break;
                case "Địa chỉ":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("diachi"));
                    break;
                case "Số điện thoại":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("dienthoai"));
                    break;
                case "Email":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("email"));
                    break;
                case "Ghi chú":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("ghichu"));
                    break;
                default:
                    return;
            }

            dgvkhachhang.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dgvkhachhang.Invalidate();
        }

        private void FormChooseCus_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[] {
        "Tên khách hàng", "Ngày sinh", "Địa chỉ", "Số điện thoại", "Email", "Ghi chú"
        });
            cbbFilter.SelectedIndex = 0;
            LoadData();
            RestoreCheckedRows();
            MarkPreselectedRows();
        }
        private void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dgvkhachhang.Rows)
            {
                string name = row.Cells["tenkhachhang"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && selectedCustomerNames.Contains(name))
                {
                    row.Cells["check"].Value = true;
                }
            }
        }
        private void MarkPreselectedRows()
        {
            if (PreselectedCustomerNames == null || PreselectedCustomerNames.Count == 0)
                return;

            foreach (DataGridViewRow row in dgvkhachhang.Rows)
            {
                string name = row.Cells["tenkhachhang"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && PreselectedCustomerNames.Contains(name))
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
            LoadData(); 
            RestoreCheckedRows(); 
            dgvkhachhang.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            isHeaderCheckBoxChecked = false; 
            LoadData(); 
            RestoreCheckedRows(); 
            dgvkhachhang.Invalidate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = !string.IsNullOrWhiteSpace(txtSearch.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi)) return;

            DataTable dt = dgvkhachhang.DataSource as DataTable;
            if (dt == null) return;

            IEnumerable<DataRow> filteredRows = null;

            switch (tieuChi)
            {
                case "Tên khách hàng":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tenkhachhang") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Ngày sinh":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => row.Field<DateTime>("ngaysinh").ToString("dd/MM/yyyy").Contains(tuKhoa));
                    break;

                case "Địa chỉ":
                    string[] parts = tuKhoa.ToLower().Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    filteredRows = dt.AsEnumerable()
                        .Where(row =>
                        {
                            var diachi = row.Field<string>("diachi")?.ToLower() ?? "";
                            return parts.All(p => diachi.Contains(p));
                        });
                    break;

                case "Số điện thoại":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("dienthoai") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Email":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("email") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Ghi chú":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("ghichu") ?? "").ToLower().Contains(tuKhoa));
                    break;
            }
            
            if (filteredRows != null && filteredRows.Any())
                dgvkhachhang.DataSource = filteredRows.CopyToDataTable();
            else
                dgvkhachhang.DataSource = dt.Clone();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvkhachhang.Invalidate();
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
            dgvkhachhang.Invalidate();
        }
    }
}

   
