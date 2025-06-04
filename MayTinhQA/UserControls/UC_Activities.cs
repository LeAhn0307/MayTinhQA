using System;
using System.Collections;
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
    public partial class UC_Activities : UserControl
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        private CheckBox headerCheckBox = new CheckBox();
        public UC_Activities()
        {
            InitializeComponent();
            dvghoatdong.DataBindingComplete += dvghoatdong_DataBindingComplete;
            dvghoatdong.CellValueChanged += dvghoatdong_CellValueChanged;
            cbbloaidv.SelectedIndexChanged += cbbloaidv_SelectedIndexChanged;
            dvghoatdong.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dvghoatdong.IsCurrentCellDirty)
                {
                    dvghoatdong.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            
            dvghoatdong.Scroll += dvghoatdong_Scroll_1;
            
            dvghoatdong.CellClick += dvghoatdong_CellClick;
            napdgvhoatdong();

            dvghoatdong.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dvghoatdong.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dvghoatdong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dvghoatdong.RowTemplate.Height = 24;
            dvghoatdong.AllowUserToAddRows = false;
            dvghoatdong.RowHeadersVisible = false;
        }
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        
        public void napdgvhoatdong()
        {
            
            DataTable dt = Database.Query("SELECT dv.iddichvu, dv.tendichvu, dv.ngaykhoitao, kh.tenkhachhang, nv.tennhanvien, dv.mota, tt.tentrangthai AS trangthai, ldv.tenloaidichvu " +
            "FROM dichvu dv " +
            "JOIN khachhang kh ON kh.idkhachhang = dv.idkhachhang " +
            "JOIN nhanvien nv ON nv.idnhanvien = dv.idnhanvien " +
            "JOIN trangthaidichvu tt ON tt.idtrangthai = dv.idtrangthai " +
            "JOIN loaidichvu ldv ON ldv.idloaidichvu = dv.idloaidichvu;");
            dvghoatdong.DataSource = null;
            dvghoatdong.Columns.Clear();
            dvghoatdong.DataSource = dt;
            dvghoatdong.ReadOnly = false;

            if (!dvghoatdong.Columns.Contains("check"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "check";
                chk.Width = 30;
                chk.Resizable = DataGridViewTriState.False;
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                chk.ReadOnly = false;
                dvghoatdong.Columns.Insert(0, chk);
            }
            if (!dvghoatdong.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.HeaderText = "STT";
                sttColumn.Name = "stt";
                sttColumn.Width = 50;
                sttColumn.ReadOnly = true;
                sttColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvghoatdong.Columns.Insert(1, sttColumn);
            }
            if (dvghoatdong.Columns.Contains("iddichvu"))
                dvghoatdong.Columns["iddichvu"].Visible = false;
            if (dvghoatdong.Columns.Contains("tenloaidichvu"))
                dvghoatdong.Columns["tenloaidichvu"].Visible = false;
            if (dvghoatdong.Columns.Contains("tendichvu"))
                dvghoatdong.Columns["tendichvu"].HeaderText = "Tên hoạt động";
            if (dvghoatdong.Columns.Contains("ngaykhoitao"))
                dvghoatdong.Columns["ngaykhoitao"].HeaderText = "Ngày thực hiện";
            if (dvghoatdong.Columns.Contains("trangthai"))
                dvghoatdong.Columns["trangthai"].HeaderText = "Trạng thái";
            if (dvghoatdong.Columns.Contains("tenkhachhang"))
                dvghoatdong.Columns["tenkhachhang"].HeaderText = "Tên khách hàng";
            if (dvghoatdong.Columns.Contains("tennhanvien"))
                dvghoatdong.Columns["tennhanvien"].HeaderText = "Nhân viên phụ trách";
            if (dvghoatdong.Columns.Contains("mota"))
                dvghoatdong.Columns["mota"].HeaderText = "Mô tả";
            dvghoatdong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dvghoatdong.Columns.Contains("tendichvu"))
                dvghoatdong.Columns["tendichvu"].Width = 160;
            if (dvghoatdong.Columns.Contains("ngaykhoitao"))
                dvghoatdong.Columns["ngaykhoitao"].Width = 160;
            if (dvghoatdong.Columns.Contains("trangthai"))
                dvghoatdong.Columns["trangthai"].Width = 160;
            if (dvghoatdong.Columns.Contains("tenkhachhang"))
                dvghoatdong.Columns["tenkhachhang"].Width = 160;
            if (dvghoatdong.Columns.Contains("tennhanvien"))
                dvghoatdong.Columns["tennhanvien"].Width = 160;
            if (dvghoatdong.Columns.Contains("mota"))
                dvghoatdong.Columns["mota"].Width = 162;
            dvghoatdong.ClearSelection();
            dvghoatdong.CurrentCell = null;

            dvghoatdong.ReadOnly = false;
            if (!dvghoatdong.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.HeaderText = "";
                editColumn.Text = "Sửa";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.FlatStyle = FlatStyle.Flat;
                editColumn.Width = 60;
                editColumn.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dvghoatdong.Columns.Add(editColumn);
            }
            dvghoatdong_DataBindingComplete(null, null);
            if (dvghoatdong.Columns.Contains("stt"))
            {
                dvghoatdong.Columns["stt"].HeaderText = "STT";
                dvghoatdong.Columns["stt"].Width = 50;
                dvghoatdong.Columns["stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvghoatdong.Columns["stt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dvghoatdong.Columns["stt"].DefaultCellStyle.Font = dvghoatdong.DefaultCellStyle.Font;
            }
            if (dvghoatdong.Controls.Contains(headerCheckBox))
                dvghoatdong.Controls.Remove(headerCheckBox);


           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isAdding = true;
            FormAddActivities frmkh = new FormAddActivities(this);
            frmkh.BatCheDoThem();
            frmkh.ShowDialog();
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

            foreach (DataGridViewRow row in dvghoatdong.Rows)
            {
                row.Cells["check"].Value = headerCheckBox.Checked;
            }

            dvghoatdong.EndEdit();
        }
        private void dvghoatdong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Font defaultFont = new Font("Segoe UI", 10); // Cỡ chữ chuẩn
            dvghoatdong.DefaultCellStyle.Font = defaultFont;
            dvghoatdong.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ

            foreach (DataGridViewRow row in dvghoatdong.Rows)
            {
                row.DefaultCellStyle.Font = defaultFont;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Font = defaultFont;
                }
            }

            if (!dvghoatdong.Columns.Contains("stt")) return;
            for (int i = 0; i < dvghoatdong.Rows.Count; i++)
            {
                if (!dvghoatdong.Rows[i].IsNewRow)
                {
                    dvghoatdong.Rows[i].Cells["stt"].Value = (i + 1).ToString();
                }
            }
        }
        private void dvghoatdong_Paint(object sender, PaintEventArgs e)
        {
            if (dvghoatdong.Columns.Count == 0) return;

            Rectangle rect = dvghoatdong.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // ✅ Trừ đi phần cuộn ngang để checkbox di chuyển cùng header
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dvghoatdong.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );
        }

        private void dvghoatdong_MouseClick(object sender, MouseEventArgs e)
        {
            if (headerCheckBoxArea.Contains(e.Location))
            {
                if (isEditing)
                {
                    MessageBox.Show("Bạn đang chỉnh sửa một khách hàng. Vui lòng lưu hoặc hủy trước khi chọn tất cả khách hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                

                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dvghoatdong.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dvghoatdong.EndEdit();
                isHeaderCheckBoxClicked = false;
                dvghoatdong.Invalidate();
            }
        }
        private void dvghoatdong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvghoatdong.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                object cellValue = dvghoatdong.Rows[e.RowIndex].Cells["check"].Value;
                bool isChecked = cellValue != null && Convert.ToBoolean(cellValue);
                if (isEditing)
                {
                    if (e.RowIndex != currentEditingRowIndex)
                    {

                        MessageBox.Show("Bạn đang chỉnh sửa hoạt động. Vui lòng lưu hoặc hủy trước khi chọn hoạt động khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dvghoatdong.Rows[e.RowIndex].Cells["check"].Value = false;
                        dvghoatdong.Rows[currentEditingRowIndex].Cells["check"].Value = true;
                        return;
                    }
                    else
                    {
                        // Nếu đang chỉnh sửa dòng đó, không cho bỏ tích checkbox
                        if (!isChecked)
                        {
                            MessageBox.Show("Không thể bỏ chọn checkbox đang chỉnh sửa. Vui lòng lưu hoặc hủy trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvghoatdong.Rows[e.RowIndex].Cells["check"].Value = true;
                            return;
                        }
                    }
                }
                bool allChecked = dvghoatdong.Rows.Cast<DataGridViewRow>()
                .All(r => Convert.ToBoolean(r.Cells["check"].Value));

                headerCheckBox.CheckedChanged -= HeaderCheckBox_CheckedChanged;
                headerCheckBox.Checked = allChecked;
                headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;
            }
        }


        private void dvghoatdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvghoatdong.Columns[e.ColumnIndex].Name == "Edit")
            {
                isEditing = true;
                currentEditingRowIndex = e.RowIndex;

                int iddichvu= Convert.ToInt32(dvghoatdong.Rows[e.RowIndex].Cells["iddichvu"].Value);
                FormAddActivities formAddActivities = new FormAddActivities(this, iddichvu);
                formAddActivities.FormClosed += (s, args) =>
                {
                    isEditing = false;
                    currentEditingRowIndex = -1;
                    napdgvhoatdong();
                };
                formAddActivities.ShowDialog();
            }
        }
       
        private void dvghoatdong_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing)
            {
                if (currentEditingRowIndex != -1 && e.RowIndex != currentEditingRowIndex)
                {
                    dvghoatdong.ClearSelection();
                    dvghoatdong.Rows[currentEditingRowIndex].Selected = true;
                    MessageBox.Show("Bạn đang chỉnh sửa. Vui lòng lưu hoặc hủy trước khi chọn hoạt động!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
        
        private void dvghoatdong_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                dvghoatdong.Invalidate();
            }
        }
        private HashSet<string> selectedCustomerNames = new HashSet<string>();
        private void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dvghoatdong.Rows)
            {
                string name = row.Cells["tenkhachhang"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && selectedCustomerNames.Contains(name))
                {
                    row.Cells["check"].Value = true;
                }
            }
        }
        private void UC_Activities_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new string[]
            {
            "Chọn tiêu chí",
            "Tên hoạt động",
            "Ngày tạo",
            "Tên khách hàng",
            "Tên nhân viên",
            "Email",
            "Ghi chú"
            });
            cbbFilter.SelectedIndex = 0;
            cbbloaidv.Items.Clear();
            cbbloaidv.Items.AddRange(new string[]
            {
            "Loại dịch vụ",
            "Báo giá đơn hàng tiềm năng",
            "Chăm sóc khách hàng định kỳ",
            "Đổi trả & bảo hành sửa chữa",
            "Giải đáp khiếu nại",
            });
            cbbloaidv.SelectedIndex = 0;
            RestoreCheckedRows();
            napdgvhoatdong();
        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tuKhoa = txtSearch.Text.Trim().ToLower();
            string tieuChi = cbbFilter.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tuKhoa) || string.IsNullOrEmpty(tieuChi) || tieuChi == "Chọn tiêu chí")
            {
                MessageBox.Show("Vui lòng nhập từ khóa và chọn tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = dvghoatdong.DataSource as DataTable;
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
                dvghoatdong.DataSource = filteredRows.CopyToDataTable();
            else
                dvghoatdong.DataSource = dt.Clone(); // Trả về bảng rỗng nếu không tìm thấy

            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }

        private void labelxoatimkiem_Click(object sender, EventArgs e)
        {
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();

            cbbFilter.SelectedIndex = cbbFilter.SelectedIndex >= 0 ? cbbFilter.SelectedIndex : 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }

        private void labelloaitieuchi_Click(object sender, EventArgs e)
        {
            labelloaitieuchi.Visible = false;
            cbbFilter.SelectedIndex = 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }

        private void picboxsort_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = true;
            string tieuChiSapXep = cbbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tieuChiSapXep) || tieuChiSapXep == "Chọn tiêu chí") return;

            DataTable dt = dvghoatdong.DataSource as DataTable;
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

            dvghoatdong.DataSource = sortedRows.CopyToDataTable();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }

        private void picboxrs_Click(object sender, EventArgs e)
        {
            picboxrs.Visible = false;
            labelxoatimkiem.Visible = false;
            txtSearch.Clear();
            cbbFilter.SelectedIndex = 0;
            cbbloaidv.SelectedIndex = 0; 
            napdgvhoatdong();
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
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

        private void cbbloaidv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaidv.SelectedIndex == 0)
            {
                labelloaidichvu.Visible = false;
                napdgvhoatdong();
                RestoreCheckedRows();
                isHeaderCheckBoxChecked = false;
                dvghoatdong.Invalidate();
                return;
            }

            labelloaidichvu.Visible = true;

            string selectedLoaiDV = cbbloaidv.SelectedItem?.ToString();
            string query =
            @"SELECT dv.iddichvu, dv.tendichvu, dv.ngaykhoitao, kh.tenkhachhang, nv.tennhanvien, dv.mota,
            tt.tentrangthai AS trangthai, ldv.tenloaidichvu
            FROM dichvu dv
            JOIN khachhang kh ON kh.idkhachhang = dv.idkhachhang
            JOIN nhanvien nv ON nv.idnhanvien = dv.idnhanvien
            JOIN trangthaidichvu tt ON tt.idtrangthai = dv.idtrangthai
            JOIN loaidichvu ldv ON ldv.idloaidichvu = dv.idloaidichvu WHERE ldv.tenloaidichvu = N'" + selectedLoaiDV.Replace("'", "''") + "'";
            DataTable dt = Database.Query(query);
            dvghoatdong.DataSource = dt;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }


        private void labelloaidichvu_Click(object sender, EventArgs e)
        {
            labelloaidichvu.Visible = false;
            cbbloaidv.SelectedIndex = 0;
            RestoreCheckedRows();
            isHeaderCheckBoxChecked = false;
            dvghoatdong.Invalidate();
        }
    }
}
