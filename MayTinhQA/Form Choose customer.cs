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
            dgvKhachhang.Paint += DgvKhachhang_Paint;
            dgvKhachhang.MouseClick += DgvKhachhang_MouseClick;
            dgvKhachhang.DataBindingComplete += DgvKhachhang_DataBindingComplete;
            dgvKhachhang.CellValueChanged += DgvKhachhang_CellValueChanged;
            dgvKhachhang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvKhachhang.IsCurrentCellDirty)
                    dgvKhachhang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.RowHeadersVisible = false;
            dgvKhachhang.ColumnWidthChanged += (s, e) => dgvKhachhang.Invalidate();
            dgvKhachhang.Scroll += (s, e) => dgvKhachhang.Invalidate();
            dgvKhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void LoadData()
        {
            DataTable dt = Database.Query("SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai, kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi, ghichu FROM khachhang kh JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen");

            dgvKhachhang.DataSource = null;
            dgvKhachhang.Columns.Clear();
            dgvKhachhang.DataSource = dt;

            if (!dgvKhachhang.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check"; 
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;

                // Thêm cột checkbox vào dgv
                dgvKhachhang.Columns.Insert(0, chk);
            }

            
            if (!dgvKhachhang.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachhang.Columns.Insert(1, sttColumn);
            }
            
            
            dgvKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dgvKhachhang.Columns.Contains("idkhachhang"))
                dgvKhachhang.Columns["idkhachhang"].Visible = false;
            if (dgvKhachhang.Columns.Contains("tenkhachhang"))
            {
                dgvKhachhang.Columns["tenkhachhang"].HeaderText = "Họ Tên";
                dgvKhachhang.Columns["tenkhachhang"].Width = 128;
            }

            if (dgvKhachhang.Columns.Contains("ngaysinh"))
            {
                dgvKhachhang.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
                dgvKhachhang.Columns["ngaysinh"].Width = 128;
            }

            if (dgvKhachhang.Columns.Contains("email"))
            {
                dgvKhachhang.Columns["email"].HeaderText = "Email";
                dgvKhachhang.Columns["email"].Width = 128;
            }

            if (dgvKhachhang.Columns.Contains("dienthoai"))
            {
                dgvKhachhang.Columns["dienthoai"].HeaderText = "Điện Thoại";
                dgvKhachhang.Columns["dienthoai"].Width = 128;
            }

            if (dgvKhachhang.Columns.Contains("diachi"))
            {
                dgvKhachhang.Columns["diachi"].HeaderText = "Địa Chỉ";
                dgvKhachhang.Columns["diachi"].Width = 128;
            }

            if (dgvKhachhang.Columns.Contains("ghichu"))
            {
                dgvKhachhang.Columns["ghichu"].HeaderText = "Ghi chú";
                dgvKhachhang.Columns["ghichu"].Width = 320;
            }

            dgvKhachhang.ClearSelection();
            dgvKhachhang.CurrentCell = null;

            dgvKhachhang.ReadOnly = false;

            DgvKhachhang_DataBindingComplete(null, null);
            if (dgvKhachhang.Columns.Contains("stt"))
            {
                dgvKhachhang.Columns["stt"].HeaderText = "STT";
                dgvKhachhang.Columns["stt"].Width = 50;
                dgvKhachhang.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachhang.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachhang.Columns["stt"].DefaultCellStyle.Font = dgvKhachhang.DefaultCellStyle.Font;
            }

        }
        private void btnxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();

            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;

            LoadData(); // Nạp lại toàn bộ dữ liệu

            isHeaderCheckBoxChecked = false; // Reset trạng thái checkbox đầu
            dgvKhachhang.Invalidate();
        }
        public Action<List<DataRow>> OnCustomersSelected;
        public Action<List<string>> OnCustomerNamesSelected;
        public List<string> PreselectedCustomerNames { get; set; } = new List<string>();
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (!(dgvKhachhang.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> selectedNames = new List<string>();

            foreach (DataGridViewRow row in dgvKhachhang.Rows)
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

            // Gửi danh sách tên về form gọi nó
            OnCustomerNamesSelected?.Invoke(selectedNames);

            // Đóng form
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
            dgvKhachhang.DefaultCellStyle.Font = defaultFont;
            dgvKhachhang.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dgvKhachhang.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dgvKhachhang.Columns.Contains("stt")) return;

            for (int i = 0; i < dgvKhachhang.Rows.Count; i++)
            {
                if (!dgvKhachhang.Rows[i].IsNewRow)
                {
                    dgvKhachhang.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }
        private void DgvKhachhang_Paint(object sender, PaintEventArgs e)
        {
            if (dgvKhachhang.Columns.Count == 0) return;

            Rectangle rect = dgvKhachhang.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // ✅ Trừ đi phần cuộn ngang để checkbox di chuyển cùng header
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvKhachhang.HorizontalScrollingOffset;
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

                foreach (DataGridViewRow row in dgvKhachhang.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvKhachhang.EndEdit();
                isHeaderCheckBoxClicked = false;
                dgvKhachhang.Invalidate(); // Vẽ lại header
            }
        }
        private HashSet<string> selectedCustomerNames = new HashSet<string>();
        private void DgvKhachhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhachhang.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                var row = dgvKhachhang.Rows[e.RowIndex];
                string name = row.Cells["tenkhachhang"].Value?.ToString();

                if (Convert.ToBoolean(row.Cells["check"].Value))
                {
                    selectedCustomerNames.Add(name);
                }
                else
                {
                    selectedCustomerNames.Remove(name);
                }

                // Cập nhật trạng thái header checkbox
                bool allChecked = dgvKhachhang.Rows.Cast<DataGridViewRow>()
                                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
                isHeaderCheckBoxChecked = allChecked;
                dgvKhachhang.Invalidate();
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
            string tieuChiSapXep = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tieuChiSapXep)) return;

            DataTable dt = dgvKhachhang.DataSource as DataTable;
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

            dgvKhachhang.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dgvKhachhang.Invalidate();
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
            foreach (DataGridViewRow row in dgvKhachhang.Rows)
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

            foreach (DataGridViewRow row in dgvKhachhang.Rows)
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
            isHeaderCheckBoxChecked = false; // Reset trạng thái checkbox đầu
            LoadData(); // Nạp lại toàn bộ dữ liệu
            RestoreCheckedRows(); // <<< Thêm dòng này
            dgvKhachhang.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();

            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;

            // Nạp lại toàn bộ dữ liệu

            isHeaderCheckBoxChecked = false; // Reset trạng thái checkbox đầu
            LoadData(); // Nạp lại toàn bộ dữ liệu
            RestoreCheckedRows(); // <<< Thêm dòng này
            dgvKhachhang.Invalidate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = !string.IsNullOrWhiteSpace(txtSearch.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi)) return;

            DataTable dt = dgvKhachhang.DataSource as DataTable;
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
                dgvKhachhang.DataSource = filteredRows.CopyToDataTable();
            else
                dgvKhachhang.DataSource = dt.Clone();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvKhachhang.Invalidate();
        }
    }
}

   
