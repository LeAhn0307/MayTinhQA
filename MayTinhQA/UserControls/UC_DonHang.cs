using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA.UserControls
{
    public partial class UC_DonHang : UserControl
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        private CheckBox headerCheckBox = new CheckBox();
        public UC_DonHang()
        {
            InitializeComponent();
            dgvdonhang.DataBindingComplete += dgvdonhang_DataBindingComplete;
            dgvdonhang.CellValueChanged += dgvdonhang_CellValueChanged;
                        dgvdonhang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvdonhang.IsCurrentCellDirty)
                {
                    dgvdonhang.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };


            dgvdonhang.Scroll += dgvdonhang_Scroll;

            dgvdonhang.CellClick += dgvdonhang_CellClick;
            napdgvdonhang();

            dgvdonhang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvdonhang.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvdonhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvdonhang.RowTemplate.Height = 24;
            dgvdonhang.AllowUserToAddRows = false;
            dgvdonhang.RowHeadersVisible = false;
        }
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        public void napdgvdonhang()
        {
            DataTable dt = Database.Query(@"SELECT chitietdonhang.idchitietdh,
khachhang.tenkhachhang,
sanpham.tensanpham,sanpham.gia,chitietdonhang.soluong,
FORMAT(sanpham.gia, 'N0', 'vi-VN') AS DonGia,
FORMAT((chitietdonhang.soluong * sanpham.gia), 'N0', 'vi-VN') AS ThanhTien,
donhang.trangthai
FROM chitietdonhang
JOIN donhang ON donhang.iddonhang = chitietdonhang.iddonhang
JOIN khachhang ON khachhang.idkhachhang = chitietdonhang.idkhachhang
JOIN sanpham ON sanpham.idsanpham = chitietdonhang.idsanpham");
            dgvdonhang.DataSource = null;
            dgvdonhang.Columns.Clear();
            dgvdonhang.DataSource = dt;
            dgvdonhang.ReadOnly = false;

            if (!dgvdonhang.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check";
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;
                dgvdonhang.Columns.Insert(0, chk);
            }
            if (!dgvdonhang.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvdonhang.Columns.Insert(1, sttColumn);
            }
            if (dgvdonhang.Columns.Contains("idchitietdh"))
                dgvdonhang.Columns["idchitietdh"].Visible = false;
            if (dgvdonhang.Columns.Contains("gia"))
                dgvdonhang.Columns["gia"].Visible = false;
            if (dgvdonhang.Columns.Contains("trangthai"))
                dgvdonhang.Columns["trangthai"].HeaderText = "Trạng thái";
            if (dgvdonhang.Columns.Contains("tenkhachhang"))
                dgvdonhang.Columns["tenkhachhang"].HeaderText = "Tên khách hàng";
            if (dgvdonhang.Columns.Contains("soluong"))
                dgvdonhang.Columns["soluong"].HeaderText = "Số lượng";
            if (dgvdonhang.Columns.Contains("tensanpham"))
                dgvdonhang.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
            if (dgvdonhang.Columns.Contains("DonGia"))
                dgvdonhang.Columns["DonGia"].HeaderText = "Đơn Giá";
            if (dgvdonhang.Columns.Contains("ThanhTien"))
                dgvdonhang.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvdonhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dgvdonhang.Columns.Contains("trangthai"))
                dgvdonhang.Columns["trangthai"].Width = 160;
            if (dgvdonhang.Columns.Contains("soluong"))
                dgvdonhang.Columns["soluong"].Width = 160;
            if (dgvdonhang.Columns.Contains("tenkhachhang"))
                dgvdonhang.Columns["tenkhachhang"].Width = 162;
            if (dgvdonhang.Columns.Contains("tensanpham"))
                dgvdonhang.Columns["tensanpham"].Width = 160;
            if (dgvdonhang.Columns.Contains("DonGia"))
                dgvdonhang.Columns["DonGia"].Width = 160;
            if (dgvdonhang.Columns.Contains("ThanhTien"))
                dgvdonhang.Columns["ThanhTien"].Width = 160;
            dgvdonhang.ClearSelection();
            dgvdonhang.CurrentCell = null;

            dgvdonhang.ReadOnly = false;
            if (!dgvdonhang.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.HeaderText = "";
                editColumn.Text = "Sửa";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.FlatStyle = FlatStyle.Flat;
                editColumn.Width = 60;
                editColumn.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvdonhang.Columns.Add(editColumn);
            }
            dgvdonhang_DataBindingComplete(null, null);
            if (dgvdonhang.Columns.Contains("stt"))
            {
                dgvdonhang.Columns["stt"].HeaderText = "STT";
                dgvdonhang.Columns["stt"].Width = 50;
                dgvdonhang.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvdonhang.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvdonhang.Columns["stt"].DefaultCellStyle.Font = dgvdonhang.DefaultCellStyle.Font;
            }
            if (dgvdonhang.Controls.Contains(headerCheckBox))
                dgvdonhang.Controls.Remove(headerCheckBox);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            AddDonHang frmdh = new AddDonHang(this);
            frmdh.BatCheDoThem();
            frmdh.ShowDialog();
        }
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                MessageBox.Show("Bạn đang chỉnh sửa. Vui lòng lưu hoặc huỷ trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                headerCheckBox.CheckedChanged -= HeaderCheckBox_CheckedChanged;
                headerCheckBox.Checked = !headerCheckBox.Checked;
                headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;
                return;
            }

            foreach (DataGridViewRow row in dgvdonhang.Rows)
            {
                row.Cells["check"].Value = headerCheckBox.Checked;
            }

            dgvdonhang.EndEdit();
        }
        private void dgvdonhang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Font defaultFont = new Font("Segoe UI", 10); // Cỡ chữ chuẩn
            dgvdonhang.DefaultCellStyle.Font = defaultFont;
            dgvdonhang.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dgvdonhang.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dgvdonhang.Columns.Contains("stt")) return;
            for (int i = 0; i < dgvdonhang.Rows.Count; i++)
            {
                if (!dgvdonhang.Rows[i].IsNewRow)
                {
                    dgvdonhang.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }

        private void dgvdonhang_Paint(object sender, PaintEventArgs e)
        {
            if (dgvdonhang.Columns.Count == 0) return;

            Rectangle rect = dgvdonhang.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // ✅ Trừ đi phần cuộn ngang để checkbox di chuyển cùng header
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvdonhang.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );
        }

        private void dgvdonhang_MouseClick(object sender, MouseEventArgs e)
        {
            if (headerCheckBoxArea.Contains(e.Location))
            {
                if (isEditing)
                {
                    MessageBox.Show("Bạn đang chỉnh sửa một đơn hàng. Vui lòng lưu hoặc hủy trước khi chọn tất cả đơn hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                dgvdonhang.Invalidate(); // Vẽ lại header

                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvdonhang.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dgvdonhang.EndEdit();

                isHeaderCheckBoxClicked = false;
            }
        }

        private void dgvdonhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var checkColumn = dgvdonhang.Columns["check"];
            if (checkColumn == null || e.ColumnIndex != checkColumn.Index || isHeaderCheckBoxClicked)
                return;

            object cellValue = dgvdonhang.Rows[e.RowIndex].Cells["check"].Value;
            bool isChecked = cellValue != null && Convert.ToBoolean(cellValue);

            if (isEditing)
            {
                if (e.RowIndex != currentEditingRowIndex)
                {
                    MessageBox.Show("Bạn đang chỉnh sửa đơn hàng. Vui lòng lưu hoặc hủy trước khi chọn đơn hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvdonhang.Rows[e.RowIndex].Cells["check"].Value = false;
                    dgvdonhang.Rows[currentEditingRowIndex].Cells["check"].Value = true;
                    return;
                }
                else
                {
                    if (!isChecked)
                    {
                        MessageBox.Show("Không thể bỏ chọn checkbox đang chỉnh sửa. Vui lòng lưu hoặc hủy trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvdonhang.Rows[e.RowIndex].Cells["check"].Value = true;
                        return;
                    }
                }
            }

            bool allChecked = dgvdonhang.Rows.Cast<DataGridViewRow>()
                .All(r => Convert.ToBoolean(r.Cells["check"].Value));

            headerCheckBox.CheckedChanged -= HeaderCheckBox_CheckedChanged;
            headerCheckBox.Checked = allChecked;
            headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;
        }

        private void dgvdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdonhang.Columns[e.ColumnIndex].Name == "Edit")
            {
                isEditing = true;
                currentEditingRowIndex = e.RowIndex;

                int idchitietdh = Convert.ToInt32(dgvdonhang.Rows[e.RowIndex].Cells["idchitietdh"].Value);
                AddDonHang addDonHang = new AddDonHang(this, idchitietdh);
                addDonHang.FormClosed += (s, args) =>
                {
                    isEditing = false;
                    currentEditingRowIndex = -1;
                    napdgvdonhang();
                };
                addDonHang.ShowDialog();
            }
        }

        private void dgvdonhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing)
            {
                if (currentEditingRowIndex != -1 && e.RowIndex != currentEditingRowIndex)
                {
                    dgvdonhang.ClearSelection();
                    dgvdonhang.Rows[currentEditingRowIndex].Selected = true;
                    MessageBox.Show("Bạn đang chỉnh sửa. Vui lòng lưu hoặc hủy trước khi chọn hoạt động!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void dgvdonhang_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                dgvdonhang.Invalidate();
            }
        }
        private HashSet<string> selectedCustomerNames = new HashSet<string>();
        private void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dgvdonhang.Rows)
            {
                string name = row.Cells["tenkhachhang"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && selectedCustomerNames.Contains(name))
                {
                    row.Cells["check"].Value = true;
                }
            }
        }

        private void UC_DonHang_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[]
            {
            "Chọn tiêu chí",
            "Tên khách hàng",
            "Sản phẩm",
            "Khuyến mãi",
            });
            cbbFilter.SelectedIndex = 0;
            
            RestoreCheckedRows();
            napdgvdonhang();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi) || tieuChi == "Chọn tiêu chí")
            {
                MessageBox.Show("Vui lòng nhập từ khóa và chọn tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = dgvdonhang.DataSource as DataTable;
            if (dt == null) return;

            IEnumerable<DataRow> filteredRows = null;

            switch (tieuChi)
            {
                case "Tên khách hàng":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tenkhachhang") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Tên hoạt động":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tendichvu") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Tên nhân viên":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("tennhanvien") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Ngày tạo":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => row.Field<DateTime>("ngaykhoitao").ToString("dd/MM/yyyy").Contains(tuKhoa));
                    break;

                case "Trạng thái":
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("trangthai") ?? "").ToLower().Contains(tuKhoa));
                    break;

                case "Mô tả":
                case "Ghi chú": // Cùng tra trong cột "mota"
                    filteredRows = dt.AsEnumerable()
                        .Where(row => (row.Field<string>("mota") ?? "").ToLower().Contains(tuKhoa));
                    break;

                default:
                    MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            if (filteredRows != null && filteredRows.Any())
                dgvdonhang.DataSource = filteredRows.CopyToDataTable();
            else
                dgvdonhang.DataSource = dt.Clone(); // Trả về bảng rỗng nếu không tìm thấy

            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvdonhang.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();

            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvdonhang.Invalidate();
        }

        private void labelloaitieuchi_Click(object sender, EventArgs e)
        {
            labelloaitieuchi.Visible = false;
            cbbFilter.SelectedIndex = 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvdonhang.Invalidate();
        }

        private void picboxsort_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tieuChiSapXep = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tieuChiSapXep) || tieuChiSapXep == "Chọn tiêu chí") return;

            DataTable dt = dgvdonhang.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0) return;

            IEnumerable<DataRow> sortedRows = dt.AsEnumerable();

            switch (tieuChiSapXep)
            {
                case "Tên khách hàng":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tenkhachhang")?.Split(' ').Last() ?? "");
                    break;

                case "Tên hoạt động":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tendichvu") ?? "");
                    break;

                case "Tên nhân viên":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("tennhanvien")?.Split(' ').Last() ?? "");
                    break;

                case "Ngày tạo":
                    sortedRows = sortedRows.OrderBy(row => row.Field<DateTime>("ngaykhoitao"));
                    break;

                case "Trạng thái":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("trangthai") ?? "");
                    break;

                case "Mô tả":
                    sortedRows = sortedRows.OrderBy(row => row.Field<string>("mota") ?? "");
                    break;

                default:
                    MessageBox.Show("Tiêu chí sắp xếp không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            dgvdonhang.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dgvdonhang.Invalidate();
        }

        private void picboxrs_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = false;
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = 0;
            //cbbloaidv.SelectedIndex = 0;
            napdgvdonhang();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dgvdonhang.Invalidate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = !string.IsNullOrWhiteSpace(txtSearch.Text);
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();

            foreach (DataGridViewRow row in dgvdonhang.Rows)
            {
                if (row.Cells["check"].Value != null && Convert.ToBoolean(row.Cells["check"].Value))
                {
                    if (int.TryParse(row.Cells["idchitietdh"].Value?.ToString(), out int id))
                    {
                        selectedIds.Add(id);
                    }
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {selectedIds.Count} dòng đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            foreach (int iddv in selectedIds)
            {
                try
                {
                    //Database.Excute($"DELETE FROM lienlac WHERE iddichvu = {iddv}");
                    //Database.Excute($"DELETE FROM donhang WHERE iddichvu = {iddv}");
                    //Database.Excute($"DELETE FROM phanhoi WHERE iddichvu = {iddv}");
                    //Database.Excute($"DELETE FROM phieubaohanh WHERE iddichvu = {iddv}");
                    //Database.Excute($"DELETE FROM phieudoitra WHERE iddichvu = {iddv}");
                    //Database.Excute($"DELETE FROM dichvu WHERE iddichvu = {iddv}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa hoạt động ID {iddv}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Đã xóa hoạt động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            napdgvdonhang();
        }
    }
}
