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
    public partial class UC_Activities : UserControl
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public UC_Activities()
        {
            InitializeComponent();
            dvghoatdong.DataBindingComplete += dvghoatdong_DataBindingComplete;
            dvghoatdong.CellValueChanged += dvghoatdong_CellValueChanged;
            dvghoatdong.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dvghoatdong.IsCurrentCellDirty)
                {
                    dvghoatdong.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            dvghoatdong.Paint += dvghoatdong_Paint;
            dvghoatdong.MouseClick += dvghoatdong_MouseClick;

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
            DataTable dt = Database.Query("SELECT dv.iddichvu, dv.tendichvu,dv.ngaykhoitao,dv.trangthai,dv.mota,kh.tenkhachhang,nv.tennhanvien FROM dichvu dv join khachhang kh on kh.idkhachhang = dv.idkhachhang join nhanvien nv on nv.idnhanvien = dv.idnhanvien");
            dvghoatdong.DataSource = null;
            dvghoatdong.Columns.Clear();
            dvghoatdong.DataSource = dt;


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
            if (dvghoatdong.Columns.Contains("ngaykhoitao"))
                dvghoatdong.Columns["ngaykhoitao"].HeaderText = "Ngày tạo";
            if (dvghoatdong.Columns.Contains("trangthai"))
                dvghoatdong.Columns["trangthai"].HeaderText = "Trạng thái";
            if (dvghoatdong.Columns.Contains("loaidichvu"))
                dvghoatdong.Columns["loaidichvu"].HeaderText = "Loại dịch vụ";
            if (dvghoatdong.Columns.Contains("idkhachhang"))
                dvghoatdong.Columns["idkhachhang"].HeaderText = "Điện Thoại";
            if (dvghoatdong.Columns.Contains("idnhanvien"))
                dvghoatdong.Columns["idnhanvien"].HeaderText = "Địa Chỉ";
            if (dvghoatdong.Columns.Contains("mota"))
                dvghoatdong.Columns["mota"].HeaderText = "Ghi chú";

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
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //isAdding = true;
            //FormAddCutomer frmkh = new FormAddCutomer(this);
            //frmkh.BatCheDoThem();
            //frmkh.ShowDialog();
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

        private void dvghoatdong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvghoatdong.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                bool isChecked = Convert.ToBoolean(dvghoatdong.Rows[e.RowIndex].Cells["check"].Value);

                if (isEditing)
                {
                    if (e.RowIndex != currentEditingRowIndex)
                    {
                        // Nếu đang chỉnh sửa, không cho phép chọn checkbox khác
                        MessageBox.Show("Bạn đang chỉnh sửa khách hàng. Vui lòng lưu hoặc hủy trước khi chọn khách hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Quay lại checkbox cũ: giữ checkbox dòng đang sửa luôn được chọn
                        dvghoatdong.Rows[e.RowIndex].Cells["check"].Value = false;
                        dvghoatdong.Rows[currentEditingRowIndex].Cells["check"].Value = true;

                        return;
                    }
                    else
                    {
                        // Nếu đang chỉnh sửa dòng đó, không cho bỏ tích checkbox
                        if (!isChecked)
                        {
                            MessageBox.Show("Không thể bỏ chọn checkbox khách hàng đang chỉnh sửa. Vui lòng lưu hoặc hủy trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvghoatdong.Rows[e.RowIndex].Cells["check"].Value = true;
                            return;
                        }
                    }
                }
                bool allChecked = dvghoatdong.Rows.Cast<DataGridViewRow>()
                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
                isHeaderCheckBoxChecked = allChecked;
                dvghoatdong.Invalidate(); // Vẽ lại header
            }
        }

        private void dvghoatdong_Paint(object sender, PaintEventArgs e)
        {
            if (dvghoatdong.Columns.Count == 0) return;

            Rectangle rect = dvghoatdong.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // Tính toán vị trí căn giữa
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );

            headerLabelArea = Rectangle.Empty;
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
                dvghoatdong.Invalidate(); // Vẽ lại header

                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dvghoatdong.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                dvghoatdong.EndEdit();

                isHeaderCheckBoxClicked = false;
            }
        }

        private void dvghoatdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && dvghoatdong.Columns[e.ColumnIndex].Name == "Edit")
            //{
            //    isEditing = true;
            //    currentEditingRowIndex = e.RowIndex;

            //    int idkhachhang = Convert.ToInt32(dvghoatdong.Rows[e.RowIndex].Cells["idkhachhang"].Value);
            //    FormAddCutomer formAddCutomer = new FormAddCutomer(this, idkhachhang);
            //    formAddCutomer.FormClosed += (s, args) =>
            //    {
            //        isEditing = false;
            //        currentEditingRowIndex = -1;
            //        napdgvhoatdong();
            //    };
            //    formAddCutomer.ShowDialog();
            //}
        }
    }
}
