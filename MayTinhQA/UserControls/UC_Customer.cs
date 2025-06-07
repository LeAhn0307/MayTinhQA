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
            
            DataTable dt = Database.Query("SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai,kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi,ghichu FROM khachhang kh JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen");
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
            if (dgvKhachhang.Columns.Contains("idkhachhang"))
                dgvKhachhang.Columns["idkhachhang"].Visible = false;
            if (dgvKhachhang.Columns.Contains("tenkhachhang"))
                dgvKhachhang.Columns["tenkhachhang"].HeaderText = "Họ Tên";
            if (dgvKhachhang.Columns.Contains("ngaysinh"))
                dgvKhachhang.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            if (dgvKhachhang.Columns.Contains("email"))
                dgvKhachhang.Columns["email"].HeaderText = "Email";
            if (dgvKhachhang.Columns.Contains("dienthoai"))
                dgvKhachhang.Columns["dienthoai"].HeaderText = "Điện Thoại";
            if (dgvKhachhang.Columns.Contains("diachi"))
                dgvKhachhang.Columns["diachi"].HeaderText = "Địa Chỉ";
            if (dgvKhachhang.Columns.Contains("ghichu"))
                dgvKhachhang.Columns["ghichu"].HeaderText = "Ghi chú";

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
            Font defaultFont = new Font("Segoe UI", 10); // Font chữ chung
            dgvKhachhang.DefaultCellStyle.Font = defaultFont;
            dgvKhachhang.DefaultCellStyle.ForeColor = Color.DarkSlateBlue; // Màu chữ

            // Đặt font và màu cho header (tiêu đề cột)
            dgvKhachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKhachhang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachhang.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;

            // Thiết lập màu nền cho toàn bộ lưới nếu muốn
            dgvKhachhang.BackgroundColor = Color.White;
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
                bool isChecked = Convert.ToBoolean(dgvKhachhang.Rows[e.RowIndex].Cells["check"].Value);

                if (isEditing)
                {
                    if (e.RowIndex != currentEditingRowIndex)
                    {
                        // Nếu đang chỉnh sửa, không cho phép chọn checkbox khác
                        MessageBox.Show("Bạn đang chỉnh sửa khách hàng. Vui lòng lưu hoặc hủy trước khi chọn khách hàng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Quay lại checkbox cũ: giữ checkbox dòng đang sửa luôn được chọn
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
                bool allChecked = dgvKhachhang.Rows.Cast<DataGridViewRow>()
                    .All(r => Convert.ToBoolean(r.Cells["check"].EditedFormattedValue));
                isHeaderCheckBoxChecked = allChecked;
                dgvKhachhang.Invalidate(); // Vẽ lại header
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
                    Database.Excute($"DELETE FROM thongke WHERE idphanhoi IN (SELECT idphanhoi FROM phanhoi WHERE idkhachhang = {idkh})");
                    Database.Excute($"DELETE FROM thongke WHERE iddonhang IN (SELECT iddonhang FROM donhang WHERE idkhachhang = {idkh})");
                    Database.Excute($"DELETE FROM chitietdonhang WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM dichvu WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM danhmuc WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM phanhoi WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM donhang WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM khuyenmai WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM loaikhachhang WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM khachhang WHERE idkhachhang = {idkh}");
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

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //string tk = txttimkiem.Text.Trim();
            //if (string.IsNullOrWhiteSpace(tk))
            //{
            //    MessageBox.Show("Vui lòng nhập tên hoặc id khách hàng!", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
            //DataTable table = Database.TimKiem(tk);
            //if (table.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    dgvKhachhang.DataSource = table;
            //}
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
    }
}
