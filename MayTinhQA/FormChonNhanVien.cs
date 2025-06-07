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
    public partial class FormChonNhanVien : Form
    {
        private Rectangle headerCheckBoxArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public delegate void EmployeeSelectedHandler(int id, string name, DataRow fullRow);
        public event EmployeeSelectedHandler OnEmployeeSelected;
        public FormChonNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadFilterOptions();
            dgvnhanvien.DataBindingComplete += dgvnhanvien_DataBindingComplete;
            dgvnhanvien.ColumnHeaderMouseClick += dgvnhanvien_ColumnHeaderMouseClick;
            dgvnhanvien.CellValueChanged += dgvnhanvien_CellValueChanged;
            dgvnhanvien.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvnhanvien.IsCurrentCellDirty)
                    dgvnhanvien.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.RowHeadersVisible = false;
            dgvnhanvien.ColumnWidthChanged += (s, e) => dgvnhanvien.Invalidate();
            dgvnhanvien.Scroll += (s, e) => dgvnhanvien.Invalidate();
            dgvnhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[] {
        "Tên nhân viên", "Chức vụ"
        });
            cbbFilter.SelectedIndex = 0;
            LoadNhanVien();
            RestoreCheckedRows();
            MarkPreselectedRows();
        }
            private void LoadNhanVien()
        {
            DataTable dt = Database.Query("SELECT nv.idnhanvien, nv.tennhanvien, cv.tenchucvu FROM nhanvien nv join chucvu cv on nv.chucvu=cv.idchucvu");
            dgvnhanvien.DataSource = null;
            dgvnhanvien.Columns.Clear();
            dgvnhanvien.DataSource = dt;
            dgvnhanvien.Invalidate();

            if (!dgvnhanvien.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check";
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;
                dgvnhanvien.Columns.Insert(0, chk);
            }


            if (!dgvnhanvien.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvnhanvien.Columns.Insert(1, sttColumn);
            }


            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dgvnhanvien.Columns.Contains("idnhanvien"))
                dgvnhanvien.Columns["idnhanvien"].Visible = false;

            if (dgvnhanvien.Columns.Contains("tennhanvien"))
            {
                dgvnhanvien.Columns["tennhanvien"].HeaderText = "Họ Tên";
                dgvnhanvien.Columns["tennhanvien"].Width = 210;
            }
            if (dgvnhanvien.Columns.Contains("tenchucvu"))
            {
                dgvnhanvien.Columns["tenchucvu"].HeaderText = "Chức vụ";
                dgvnhanvien.Columns["tenchucvu"].Width = 124;
            }
            dgvnhanvien.ClearSelection();
            dgvnhanvien.CurrentCell = null;

            dgvnhanvien.ReadOnly = false;

            dgvnhanvien_DataBindingComplete(null, null);
            if (dgvnhanvien.Columns.Contains("stt"))
            {
                dgvnhanvien.Columns["stt"].HeaderText = "STT";
                dgvnhanvien.Columns["stt"].Width = 50;
                dgvnhanvien.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvnhanvien.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvnhanvien.Columns["stt"].DefaultCellStyle.Font = dgvnhanvien.DefaultCellStyle.Font;
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
        public Action<List<DataRow>> OnEmployeesSelected;
        public Action<List<string>> OnEmployeeNamesSelected;
        public List<string> PreselectedEmployeeNames { get; set; } = new List<string>();
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (!(dgvnhanvien.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> selectedNames = new List<string>();

            foreach (DataGridViewRow row in dgvnhanvien.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    string name = row.Cells["tennhanvien"].Value?.ToString();
                    if (!string.IsNullOrEmpty(name))
                        selectedNames.Add(name);
                }
            }

            if (selectedNames.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OnEmployeeNamesSelected?.Invoke(selectedNames);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void LoadFilterOptions()
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new[] {
                        "Tên nhân viên", "Chức vụ"
                    });
            cbbFilter.SelectedIndex = 0;
        }

        private void dgvnhanvien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Font defaultFont = new Font("Segoe UI", 10); // Cỡ chữ chuẩn
            dgvnhanvien.DefaultCellStyle.Font = defaultFont;
            dgvnhanvien.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dgvnhanvien.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dgvnhanvien.Columns.Contains("stt")) return;

            for (int i = 0; i < dgvnhanvien.Rows.Count; i++)
            {
                if (!dgvnhanvien.Rows[i].IsNewRow)
                {
                    dgvnhanvien.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }

        private void dgvnhanvien_Paint(object sender, PaintEventArgs e)
        {
            if (dgvnhanvien.Columns.Count == 0) return;

            Rectangle rect = dgvnhanvien.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14;

            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvnhanvien.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );

        }

        private void dgvnhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Mouse click at {e.Location}, header area: {headerCheckBoxArea}");
            if (headerCheckBoxArea.Contains(e.Location))
            {
                Console.WriteLine("Header checkbox clicked!");
                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvnhanvien.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvnhanvien.EndEdit();
                isHeaderCheckBoxClicked = false;
                dgvnhanvien.Invalidate();
            }
        }
        private HashSet<string> selectedEmployeeNames = new HashSet<string>();

        private void dgvnhanvien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var checkColumn = dgvnhanvien.Columns["check"];
            if (checkColumn == null || e.ColumnIndex != checkColumn.Index || isHeaderCheckBoxClicked)
                return;
            var row = dgvnhanvien.Rows[e.RowIndex];
            string name = row.Cells["tennhanvien"].Value?.ToString();

            if (Convert.ToBoolean(row.Cells["check"].Value))
            {
                selectedEmployeeNames.Add(name);
            }
            else
            {
                selectedEmployeeNames.Remove(name);
            }
            bool allChecked = dgvnhanvien.Rows.Cast<DataGridViewRow>()
                                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
            isHeaderCheckBoxChecked = allChecked;
            dgvnhanvien.Invalidate();

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

            DataTable dt = dgvnhanvien.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0) return;

            IEnumerable<DataRow> sortedRows = dt.AsEnumerable();

            switch (tieuChiSapXep)
            {
                case "Tên nhân viên":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tennhanvien")?.Split(' ').Last());
                    break;
                case "Chức vụ":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tenchucvu")?.Split(' ').Last());
                    break; 
                default:
                    return;
            }

            dgvnhanvien.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dgvnhanvien.Invalidate();
        }
        private void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dgvnhanvien.Rows)
            {
                string name = row.Cells["tennhanvien"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && selectedEmployeeNames.Contains(name))
                {
                    row.Cells["check"].Value = true;
                }
            }
        }
        private void MarkPreselectedRows()
        {
            if (PreselectedEmployeeNames == null || PreselectedEmployeeNames.Count == 0)
                return;

            foreach (DataGridViewRow row in dgvnhanvien.Rows)
            {
                string name = row.Cells["tennhanvien"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && PreselectedEmployeeNames.Contains(name))
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
            LoadNhanVien();
            RestoreCheckedRows();
            dgvnhanvien.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            isHeaderCheckBoxChecked = false;
            LoadNhanVien();
            RestoreCheckedRows();
            dgvnhanvien.Invalidate();
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

            DataTable dt = dgvnhanvien.DataSource as DataTable;
            if (dt == null) return;

            IEnumerable<DataRow> filteredRows = null;

            switch (tieuChi)
            {
                case "Tên nhân viên":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tennhanvien") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Chức vụ":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tenchucvu") ?? "").ToLower().Contains(tuKhoa));
                    break;
            }

            if (filteredRows != null && filteredRows.Any())
                dgvnhanvien.DataSource = filteredRows.CopyToDataTable();
            else
                dgvnhanvien.DataSource = dt.Clone();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvnhanvien.Invalidate();
        }

        private void picboxrs_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = false;
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            LoadNhanVien();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvnhanvien.Invalidate();
        }

        private void dgvnhanvien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvnhanvien.Columns["check"].Index)
            {
                // Toggle trạng thái
                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;

                foreach (DataGridViewRow row in dgvnhanvien.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvnhanvien.EndEdit();
                dgvnhanvien.Invalidate(); // Vẽ lại lưới
            }
        }
    }
}

