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
    public partial class UC_Customer : UserControl
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public UC_Customer()
        {
            InitializeComponent();
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
        private void napdgvKhachHang()
        {
            DataTable dt = Database.Query("select * from khachhang");
            dgvKhachhang.DataSource = null; // Ngắt DataSource cũ nếu có

            dgvKhachhang.Columns.Clear(); // Xóa tất cả cột cũ

            // Thêm cột checkbox thủ công trước
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "check";
            chk.Width = 30;
            chk.Resizable = DataGridViewTriState.False;
            chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            chk.ReadOnly = false;
            dgvKhachhang.Columns.Add(chk);

            // Bây giờ gán DataSource - cột sẽ tự động thêm sau
            dgvKhachhang.DataSource = dt;

            // Đặt lại tiêu đề cột (bây giờ đã có các cột từ dt)
            if (dgvKhachhang.Columns.Contains("idkhachhang"))
                dgvKhachhang.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
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

            dgvKhachhang.ClearSelection();
            dgvKhachhang.CurrentCell = null;

            dgvKhachhang.ReadOnly = false;
        }
        private void DgvKhachhang_Paint(object sender, PaintEventArgs e)
        {
            if (dgvKhachhang.Columns.Count == 0) return;

            Rectangle rect = dgvKhachhang.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 18;
            int padding = 3;

            int xCheckbox = rect.X + 5;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;
            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(e.Graphics, headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal);

            // Bỏ phần vẽ chữ
            headerLabelArea = Rectangle.Empty;
            return;
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
            if (isAdding || isEditing)
            {
                MessageBox.Show("Bạn chưa lưu thông tin hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = true;
            isEditing = false;

            txthovatenkhach.Clear();
            txtemailkhach.Clear();
            txtsdtkhach.Clear();
            txtdiachikhach.Clear();
            dtpkhach.Value = DateTime.Now;
            txtidkhachhang.Clear();
            btnluu.Visible = true;
            btnhuy.Visible = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();

            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dgvKhachhang.Rows)
            {
                // Kiểm tra nếu checkbox được chọn
                if (Convert.ToBoolean(row.Cells["check"].Value) == true)
                {
                    if (int.TryParse(row.Cells["idkhachhang"].Value?.ToString(), out int id))
                    {
                        selectedIds.Add(id);
                    }
                }
            }

            // Nếu không có khách hàng nào được chọn
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {selectedIds.Count} khách hàng đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Thực hiện xóa từng khách hàng
            foreach (int idkh in selectedIds)
            {
                try
                {
                    // Xóa bảng con trước, theo thứ tự tránh lỗi FK
                    Database.Excute($"DELETE FROM giaodich WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM thongke WHERE idphanhoi IN (SELECT idphanhoi FROM phanhoi WHERE idkhachhang = {idkh})");
                    Database.Excute($"DELETE FROM thongke WHERE idgiaodich IN (SELECT idgiaodich FROM giaodich WHERE idkhachhang = {idkh})");
                    Database.Excute($"DELETE FROM thongke WHERE idcongno IN (SELECT idcongno FROM congno WHERE idkhachhang = {idkh})");

                    Database.Excute($"DELETE FROM congno WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM hoadon WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM chitietdonhang WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM dichvu WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM danhmuc WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM phanhoi WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM donhang WHERE idkhachhang = {idkh}");
                    Database.Excute($"DELETE FROM loaikhachhang WHERE idkhachhang = {idkh}");

                    // Cuối cùng xóa khách hàng
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
        private void EnableTextBoxes(bool enable)
        {
            txtidkhachhang.ReadOnly = !enable;
            txthovatenkhach.ReadOnly = !enable;
            dtpkhach.Enabled = enable;
            txtemailkhach.ReadOnly = !enable;
            txtdiachikhach.ReadOnly = !enable;
            txtsdtkhach.ReadOnly = !enable;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvKhachhang.Rows
       .Cast<DataGridViewRow>()
       .FirstOrDefault(r => Convert.ToBoolean(r.Cells["check"].Value) == true);

            if (selectedRow != null)
            {
                // Gán dữ liệu từ DataGridView vào các TextBox
                txtidkhachhang.Text = selectedRow.Cells["idkhachhang"].Value?.ToString();
                txthovatenkhach.Text = selectedRow.Cells["tenkhachhang"].Value?.ToString();

                string rawDate = selectedRow.Cells["ngaysinh"].Value?.ToString();
                if (DateTime.TryParse(rawDate, out DateTime parsedDate))
                {
                    dtpkhach.Value = parsedDate;
                }
                else
                {
                    dtpkhach.Value = DateTime.Now;
                }

                txtemailkhach.Text = selectedRow.Cells["email"].Value?.ToString();
                txtdiachikhach.Text = selectedRow.Cells["diachi"].Value?.ToString();
                txtsdtkhach.Text = selectedRow.Cells["dienthoai"].Value?.ToString();

                // Đặt cờ đang chỉnh sửa
                isEditing = true;
                currentEditingRowIndex = selectedRow.Index;

                EnableTextBoxes(true);

                btnluu.Visible = true;
                btnhuy.Visible = true;

            }
            else
            {
                MessageBox.Show("Vui lòng tích chọn một khách hàng bằng checkbox để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            string tk = txttimkiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(tk))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc id khách hàng!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DataTable table = Database.TimKiem(tk);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                dgvKhachhang.DataSource = table;
            }
        }
    }
}
