using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayTinhQA.UserControls;

namespace MayTinhQA
{
    public partial class FormAddCutomer : Form
    {
        private UC_Customer UC_Customer;
        private int _idKhachHang;
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;

        public FormAddCutomer(UC_Customer parent)
        {
            InitializeComponent();
            this.UC_Customer = parent;
            BatCheDoThem();
        }

        public FormAddCutomer(UC_Customer parent, int idKhachHang)
        {
            InitializeComponent();
            this.UC_Customer = parent;
            this._idKhachHang = idKhachHang;
            isEditing = true;
            LoadThanhPho();
            LoadThongTinKhachHang();
        }

        public void BatCheDoThem()
        {
            isAdding = true;
            btnluu.Visible = true;
            btnhuy.Visible = true;

            txthovatenkhach.Clear();
            txtemailkhach.Clear();
            txtsdtkhach.Clear();
            txtdiachikhach.Clear();
            txtidkhachhang.Clear();
            dtpkhach.Value = DateTime.Now;

            LoadThanhPho();
            LoadQuanHuyen(-1);
        }

        private void LoadThongTinKhachHang()
        {
            try
            {
                string query = $"SELECT * FROM khachhang WHERE idkhachhang = {_idKhachHang}";
                DataTable dt = Database.Query(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    int idThanhPho = Convert.ToInt32(row["idthanhpho"]);
                    int idQuanHuyen = Convert.ToInt32(row["idquanhuyen"]);

                    comboBoxtp.SelectedValue = idThanhPho;
                    LoadQuanHuyen(idThanhPho);
                    comboBoxq.SelectedValue = idQuanHuyen;

                    txtidkhachhang.Text = row["idkhachhang"].ToString();
                    txthovatenkhach.Text = row["tenkhachhang"].ToString();
                    txtemailkhach.Text = row["email"].ToString();
                    txtsdtkhach.Text = row["dienthoai"].ToString();
                    txtdiachikhach.Text = row["diachi"].ToString();
                    txtghichu.Text = row["ghichu"].ToString();
                    dtpkhach.Value = Convert.ToDateTime(row["ngaysinh"]);

                    txtidkhachhang.Enabled = false;
                    btnluu.Visible = true;
                    btnhuy.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                try
                {
                    string id = txtidkhachhang.Text.Trim();
                    string hoten = txthovatenkhach.Text.Trim();
                    string email = txtemailkhach.Text.Trim();
                    string sdt = txtsdtkhach.Text.Trim();
                    string diachi = txtdiachikhach.Text.Trim();
                    string ngaysinh = dtpkhach.Value.ToString("yyyy-MM-dd");
                    string ghichu = txtghichu.Text.Trim();

                    if (comboBoxtp.SelectedValue == null || comboBoxq.SelectedValue == null || (int)comboBoxtp.SelectedValue == -1 || (int)comboBoxq.SelectedValue == -1)
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ Thành phố và Quận/Huyện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idThanhPho = (int)comboBoxtp.SelectedValue;
                    int idQuan = (int)comboBoxq.SelectedValue;

                    if (string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ họ tên và email.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string insertKH = $@"
                        INSERT INTO khachhang (idkhachhang, tenkhachhang, email, dienthoai, diachi, ngaysinh, idthanhpho, idquanhuyen, ghichu)
                        VALUES ({id}, N'{hoten}', '{email}', '{sdt}', N'{diachi}', '{ngaysinh}', '{idThanhPho}', '{idQuan}', N'{ghichu}')";

                    Database.Excute(insertKH);

                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    UC_Customer.napdgvKhachHang();
                    this.Close();
                    isAdding = false;
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
                    string id = txtidkhachhang.Text.Trim();
                    string ten = txthovatenkhach.Text.Trim();
                    string email = txtemailkhach.Text.Trim();
                    string sdt = txtsdtkhach.Text.Trim();
                    string diachi = txtdiachikhach.Text.Trim();
                    string ngaysinh = dtpkhach.Value.ToString("yyyy-MM-dd");
                    string ghichu = txtghichu.Text.Trim();
                    int idThanhPho = (int)comboBoxtp.SelectedValue;
                    int idQuan = (int)comboBoxq.SelectedValue;

                    string sql = $@"
                        UPDATE khachhang 
                        SET tenkhachhang = N'{ten}',
                            email = '{email}',
                            dienthoai = '{sdt}',
                            diachi = N'{diachi}',
                            ngaysinh = '{ngaysinh}',
                            idthanhpho = {idThanhPho},
                            idquanhuyen = {idQuan},
                            ghichu = N'{ghichu}'
                        WHERE idkhachhang = {id}";

                    Database.Excute(sql);

                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);

                    isEditing = false;
                    currentEditingRowIndex = -1;
                    UC_Customer.napdgvKhachHang();
                    this.Close();
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
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAddCutomer_Load(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                LoadThanhPho();
                LoadQuanHuyen(-1);
            }
        }

        private void LoadThanhPho()
        {
            try
            {
                string query = "SELECT idthanhpho, tenthanhpho FROM thanhpho";
                DataTable dt = Database.Query(query);

                DataRow dr = dt.NewRow();
                dr["idthanhpho"] = -1;
                dr["tenthanhpho"] = "Chọn thành phố";
                dt.Rows.InsertAt(dr, 0);

                comboBoxtp.DataSource = dt;
                comboBoxtp.DisplayMember = "tenthanhpho";
                comboBoxtp.ValueMember = "idthanhpho";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load thành phố: " + ex.Message);
            }
        }

        private void LoadQuanHuyen(int idThanhPho)
        {
            try
            {
                string query = idThanhPho == -1 ?
                    "SELECT -1 AS idquanhuyen, N'Chọn quận/huyện' AS tenquanhuyen" :
                    $"SELECT idquanhuyen, tenquanhuyen FROM quanhuyen WHERE idthanhpho = {idThanhPho}";

                DataTable dt = Database.Query(query);

                if (idThanhPho != -1)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["idquanhuyen"] = -1;
                    newRow["tenquanhuyen"] = "Chọn quận/huyện";
                    dt.Rows.InsertAt(newRow, 0);
                }

                comboBoxq.DataSource = dt;
                comboBoxq.DisplayMember = "tenquanhuyen";
                comboBoxq.ValueMember = "idquanhuyen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load quận huyện: " + ex.Message);
            }
        }

        private void comboBoxtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxtp.SelectedValue != null && int.TryParse(comboBoxtp.SelectedValue.ToString(), out int idThanhPho))
            {
                LoadQuanHuyen(idThanhPho);
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
