using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MayTinhQA.UserControls
{
    public partial class UC_Customer : UserControl
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public UC_Customer()
        {
            InitializeComponent();
            dgvKhachhang.DataBindingComplete += dgvKhachhang_DataBindingComplete;
            dgvKhachhang.CellValueChanged += DgvKhachhang_CellValueChanged;
            dgvKhachhang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvKhachhang.IsCurrentCellDirty)
                {
                    dgvKhachhang.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            dgvKhachhang.Paint += DgvKhachhang_Paint;
            dgvKhachhang.MouseClick += DgvKhachhang_MouseClick;

            napdgvKhachHang();


            dgvKhachhang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvKhachhang.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvKhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvKhachhang.RowTemplate.Height = 24;
            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.RowHeadersVisible = false;
        }
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        public void napdgvKhachHang()
        {
            DataTable dt = Database.Query("SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai,kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi,lkh.loaikhachhang, kh.ghichu FROM khachhang kh LEFT JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen LEFT JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho LEFT JOIN loaikhachhang lkh ON kh.idloaikhachhang = lkh.idloaikhachhang");
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
            if (dgvKhachhang.Columns.Contains("loaikhachhang"))
                dgvKhachhang.Columns["loaikhachhang"].Visible = false;
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
            
            if (!dgvKhachhang.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.HeaderText = "";
                editColumn.Text = "Sửa";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.FlatStyle = FlatStyle.Flat;
                editColumn.Width = 60;
                editColumn.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvKhachhang.Columns.Add(editColumn);
            }
            dgvKhachhang_DataBindingComplete(null, null);
            if (dgvKhachhang.Columns.Contains("stt"))
            {
                dgvKhachhang.Columns["stt"].HeaderText = "STT";
                dgvKhachhang.Columns["stt"].Width = 50;
                dgvKhachhang.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachhang.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachhang.Columns["stt"].DefaultCellStyle.Font = dgvKhachhang.DefaultCellStyle.Font;
            }
        }
        private void dgvKhachhang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                if (isEditing)
                {
                    MessageBox.Show("Bạn đang chỉnh sửa một khách hàng. Vui lòng lưu hoặc hủy trước khi chọn tất cả khách hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                dgvKhachhang.Invalidate(); // Vẽ lại header

                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvKhachhang.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvKhachhang.EndEdit();

                isHeaderCheckBoxClicked = false;
            }
        }
        private void DgvKhachhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhachhang.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                object cellValue = dgvKhachhang.Rows[e.RowIndex].Cells["check"].Value;
                bool isChecked = cellValue != null && Convert.ToBoolean(cellValue);
               
                if (isEditing)
                {
                    if (e.RowIndex != currentEditingRowIndex)
                    {
                        
                        MessageBox.Show("Bạn đang chỉnh sửa khách hàng. Vui lòng lưu hoặc hủy trước khi chọn khách hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvKhachhang.Rows[e.RowIndex].Cells["check"].Value = false;
                        dgvKhachhang.Rows[currentEditingRowIndex].Cells["check"].Value = true;
                        return;
                    }
                    else
                    {
                        // Nếu đang chỉnh sửa dòng đó, không cho bỏ tích checkbox
                        if (!isChecked)
                        {
                            MessageBox.Show("Không thể bỏ chọn checkbox khách hàng đang chỉnh sửa. Vui lòng lưu hoặc hủy trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvKhachhang.Rows[e.RowIndex].Cells["check"].Value = true;
                            return;
                        }
                    }
                }
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
                bool allChecked = dgvKhachhang.Rows.Cast<DataGridViewRow>()
                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
                isHeaderCheckBoxChecked = allChecked;
                dgvKhachhang.Invalidate();
            }
        }
        private void dgvInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            FormAddCutomer frmkh = new FormAddCutomer(this);
            frmkh.BatCheDoThem();
            frmkh.ShowDialog();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();

            foreach (DataGridViewRow row in dgvKhachhang.Rows)
            {
                if (row.Cells["check"].Value != null && Convert.ToBoolean(row.Cells["check"].Value))
                {
                    if (int.TryParse(row.Cells["idkhachhang"].Value?.ToString(), out int id))
                    {
                        selectedIds.Add(id);
                    }
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {selectedIds.Count} khách hàng đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            foreach (int idkh in selectedIds)
            {
                try
                {
                    Database.Excute($@"
                    DELETE FROM thongke WHERE idphanhoi IN (SELECT idphanhoi FROM phanhoi WHERE idkhachhang = {idkh})
                    OR iddonhang IN (SELECT iddonhang FROM donhang WHERE idkhachhang = {idkh})
                    OR idkhachhang = {idkh};
                    DELETE FROM danhmuc WHERE idkhachhang = {idkh};
                    DELETE FROM lienlac WHERE idkhachhang = {idkh};
                    DELETE FROM phanhoi WHERE idkhachhang = {idkh};
                    DELETE FROM chitietdonhang WHERE idkhachhang = {idkh};
                    DELETE FROM donhang WHERE idkhachhang = {idkh};
                    DELETE FROM dichvu WHERE idkhachhang = {idkh};
                    DELETE FROM khachhang WHERE idkhachhang = {idkh};");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa khách hàng ID {idkh}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            napdgvKhachHang();
        }

        private void dgvKhachhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing)
            {
                if (currentEditingRowIndex != -1 && e.RowIndex != currentEditingRowIndex)
                {
                    dgvKhachhang.ClearSelection();
                    dgvKhachhang.Rows[currentEditingRowIndex].Selected = true;
                    MessageBox.Show("Bạn đang chỉnh sửa. Vui lòng lưu hoặc hủy trước khi chọn khách hàng khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[]
            {
            "Chọn tiêu chí",
            "Tên khách hàng",
            "Ngày sinh",
            "Địa chỉ",
            "Số điện thoại",
            "Email",
            "Ghi chú"
            });
            cbbFilter.SelectedIndex = 0;
            RestoreCheckedRows();
            napdgvKhachHang();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi)) return;

            DataTable dt = dgvKhachhang.DataSource as DataTable;
            if (dt == null) return;

            IEnumerable<DataRow> filteredRows = null;

            switch (tieuChi)
            {
                case "Chọn tiêu chí":
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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

        private void dgvKhachhang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKhachhang.Columns[e.ColumnIndex].Name == "Edit")
            {
                isEditing = true;
                currentEditingRowIndex = e.RowIndex;

                int idkhachhang = Convert.ToInt32(dgvKhachhang.Rows[e.RowIndex].Cells["idkhachhang"].Value);
                FormAddCutomer formAddCutomer = new FormAddCutomer(this, idkhachhang);
                formAddCutomer.FormClosed += (s, args) =>
                {
                    isEditing = false;
                    currentEditingRowIndex = -1;
                    napdgvKhachHang();
                };
                formAddCutomer.ShowDialog();
            }
        }

       
        private void dgvKhachhang_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                dgvKhachhang.Invalidate();
            }
        }

        private HashSet<string> selectedCustomerNames = new HashSet<string>();
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


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible  = !string.IsNullOrWhiteSpace(txtSearch.Text);
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

        private void labelloaitieuchi_Click(object sender, EventArgs e)
        {
            labelloaitieuchi.Visible = false;
            cbbFilter.SelectedIndex = 0; 
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false; 
            dgvKhachhang.Invalidate();
        }

        private void picboxsort_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
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

        private void picboxrt_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = false;
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            napdgvKhachHang();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvKhachhang.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();

            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false; 
            dgvKhachhang.Invalidate();
        }
    }
}
