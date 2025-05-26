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
    public partial class FormAddCutomer : Form
    {
        public FormAddCutomer()
        {
            InitializeComponent();
        }
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        private void btnSave_Click(object sender, EventArgs e)
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

                    // Lấy id thành phố và quận từ ComboBox (giả sử bạn dùng ComboBox để chọn)
                    int idThanhPho = (int)comboBoxtp.SelectedValue;  // ComboBox bound with id
                    int idQuan = (int)comboBoxq.SelectedValue;          // ComboBox bound with id

                    if (string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ họ tên và email.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string insertKH = $@"
INSERT INTO khachhang (tenkhachhang, email, dienthoai, diachi, ngaysinh, idthanhpho, idquanhuyen)
VALUES (N'{hoten}', '{email}', '{sdt}', N'{diachi}', '{ngaysinh}', {idThanhPho}, {idQuan})";

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
                    //napdgvKhachHang();
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
                    // Lấy dữ liệu từ TextBox, DateTimePicker (đã chỉnh sửa)
                    string id = txtidkhachhang.Text.Trim();
                    string ten = txthovatenkhach.Text.Trim();
                    string email = txtemailkhach.Text.Trim();
                    string sdt = txtsdtkhach.Text.Trim();
                    string diachi = txtdiachikhach.Text.Trim();
                    string ngaysinh = dtpkhach.Value.ToString("yyyy-MM-dd");

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
                    //dgvKhachhang.ReadOnly = true;
                    btnluu.Visible = false;
                    btnhuy.Visible = false;
                    currentEditingRowIndex = -1;

                    // Load lại dữ liệu mới lên dgv
                    //napdgvKhachHang();
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
                    //dgvKhachhang.ReadOnly = true;
                    //napdgvKhachHang(); // load lại dữ liệu, khôi phục trạng thái ban đầu

                    // Xóa hoặc reset các textbox nếu cần
                    txthovatenkhach.Clear();
                    txtemailkhach.Clear();
                    txtsdtkhach.Clear();
                    txtdiachikhach.Clear();
                    txtidkhachhang.Clear();
                    dtpkhach.Value = DateTime.Now;
                    currentEditingRowIndex = -1;

                    // Bật lại các nút Thêm, Sửa, Xóa
                    //btnthem.Enabled = true;
                    //btnsua.Enabled = true;
                    //btnxoa.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
