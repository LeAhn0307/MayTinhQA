using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MayTinhQA
{
    public partial class frmkhachhang : Form
    {
        private Rectangle headerCheckBoxArea;
        private Rectangle headerLabelArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public frmkhachhang()
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

            // Không cho nhảy dòng ở phần tiêu đề
            dgvKhachhang.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Các thuộc tính khác
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

                if (isChecked)
                {
                    // Bỏ chọn tất cả checkbox khác (nếu không đang chỉnh sửa)
                    foreach (DataGridViewRow row in dgvKhachhang.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells["check"].Value = false;
                        }
                    }
                }

                // Cập nhật lại trạng thái header checkbox
                bool allChecked = dgvKhachhang.Rows.Cast<DataGridViewRow>()
                    .All(r => Convert.ToBoolean(r.Cells["check"].EditedFormattedValue));
                isHeaderCheckBoxChecked = allChecked;
                dgvKhachhang.Invalidate(); // Vẽ lại header
            }
        }
        


        private void btnthem_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void datagridkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachhang.CurrentRow != null)
                {
                    string idkhachhang = dgvKhachhang.CurrentRow.Cells["idkhachhang"].Value.ToString();
                    string deleteGiaoDich = "DELETE FROM giaodich WHERE idkhachhang = " + idkhachhang;
                    Database.Excute(deleteGiaoDich);
                    string deleteHoaDon = "DELETE FROM hoadon WHERE idkhachhang = " + idkhachhang;
                    Database.Excute(deleteHoaDon);
                    string deleteChiTiet = "DELETE FROM chitietdonhang WHERE idkhachhang = " + idkhachhang;
                    Database.Excute(deleteChiTiet);
                    string deleteDonHang = "DELETE FROM donhang WHERE idkhachhang = " + idkhachhang;
                    Database.Excute(deleteDonHang);
                    string deleteLoaiKH = "DELETE FROM loaikhachhang WHERE idkhachhang = " + idkhachhang;
                    Database.Excute(deleteLoaiKH);
                    string sql = "delete khachhang where idkhachhang =" + idkhachhang;
                    Database.Excute(sql);
                    napdgvKhachHang();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi dữ liệu! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

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

        private void datagridkhach_RowEnter_1(object sender, DataGridViewCellEventArgs e)
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
        private void LoadComboBox()
        {
            cbloaikhach.Items.Clear();
            cbloaikhach.Items.Add("VIP");
            cbloaikhach.Items.Add("Trung thành");
            cbloaikhach.Items.Add("Tiềm năng");
            cbloaikhach.Items.Add("Ngủ quên");
            cbloaikhach.Items.Add("Mới");

        }
        private void frmkhachhang_Load_1(object sender, EventArgs e)
        {
            LoadComboBox();
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

        private void cbloaikhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nhomKhachHang = cbloaikhach.SelectedItem.ToString();

                string query = @"
        SELECT
            kh.idkhachhang,
            kh.tenkhachhang,
            kh.ngaysinh,
            kh.email,
            kh.diachi,
            kh.dienthoai
        FROM
            khachhang kh
        JOIN loaikhachhang nhom ON kh.idkhachhang = nhom.idkhachhang
        WHERE
            nhom.loaikhachhang = N'" + nhomKhachHang + "'";

                DataTable dt = Database.Query(query);
                dgvKhachhang.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                try
                {
                    string hoten = txthovatenkhach.Text.Trim();
                    string email = txtemailkhach.Text.Trim();
                    string sdt = txtsdtkhach.Text.Trim();
                    string diachi = txtdiachikhach.Text.Trim();
                    string ngaysinh = dtpkhach.Value.ToString("yyyy-MM-dd");

                    if (string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ họ tên và email.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string insertKH = $@"
INSERT INTO khachhang (tenkhachhang, email, dienthoai, diachi, ngaysinh)
VALUES (N'{hoten}', '{email}', '{sdt}', N'{diachi}', '{ngaysinh}')";

                    Database.Excute(insertKH);

                    // Lấy id vừa thêm
                    DataTable dt = Database.Query(@"
SELECT TOP 1 idkhachhang FROM khachhang ORDER BY idkhachhang DESC");

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        int idKhachHang = Convert.ToInt32(dt.Rows[0]["idkhachhang"]);
                        string insertLoai = $"INSERT INTO loaikhachhang (idkhachhang, loaikhachhang) VALUES ({idKhachHang}, N'Tiềm Năng')";
                        Database.Excute(insertLoai);
                    }

                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    napdgvKhachHang();
                    isAdding = false;
                    btnluu.Visible = false;
                    btnhuy.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
                }
            }
            else if (isEditing)
            {
                try
                {
                    if (dgvKhachhang.CurrentRow == null)
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng để lưu cập nhật.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    DataGridViewRow row = dgvKhachhang.CurrentRow;

                    string id = row.Cells["idkhachhang"].Value.ToString();
                    string ten = row.Cells["tenkhachhang"].Value?.ToString() ?? "";
                    string email = row.Cells["email"].Value?.ToString() ?? "";
                    string sdt = row.Cells["dienthoai"].Value?.ToString() ?? "";
                    string diachi = row.Cells["diachi"].Value?.ToString() ?? "";
                    string ngaysinh = Convert.ToDateTime(row.Cells["ngaysinh"].Value).ToString("yyyy-MM-dd");

                    if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Tên khách hàng và Email không được để trống.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string sql = $@"
UPDATE khachhang
SET tenkhachhang = N'{ten}',
    email = '{email}',
    dienthoai = '{sdt}',
    diachi = N'{diachi}',
    ngaysinh = '{ngaysinh}'
WHERE idkhachhang = {id}";

                    Database.Excute(sql);

                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);

                    isEditing = false;
                    dgvKhachhang.ReadOnly = true;
                    btnluu.Visible = false;
                    btnhuy.Visible = false;
                    currentEditingRowIndex = -1;
                    napdgvKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật khách hàng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (isAdding || isEditing)
            {
                var result = MessageBox.Show("Bạn có chắc muốn hủy thao tác chưa lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    isAdding = false;
                    isEditing = false;
                    btnluu.Visible = false;
                    btnhuy.Visible = false;
                    dgvKhachhang.ReadOnly = true;
                    napdgvKhachHang(); // load lại dữ liệu, khôi phục trạng thái ban đầu

                    // Xóa hoặc reset các textbox nếu cần
                    txthovatenkhach.Clear();
                    txtemailkhach.Clear();
                    txtsdtkhach.Clear();
                    txtdiachikhach.Clear();
                    txtidkhachhang.Clear();
                    dtpkhach.Value = DateTime.Now;
                    currentEditingRowIndex = -1;

                    // Bật lại các nút Thêm, Sửa, Xóa
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
