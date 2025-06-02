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
    public partial class FormAddActivities : Form
    {
        private int _idDichvu;
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        public string SelectedCustomerName { get; private set; }
        public DataRow SelectedCustomerRow { get; private set; }
        private UC_Activities activitiesControl;
        
        public FormAddActivities(UC_Activities parent, int idDichvu)
        {
            InitializeComponent();
            this.activitiesControl = parent;
            this._idDichvu = idDichvu;
            this.isEditing = true;
            LoadThongTinDichVu();
           
        }
        private UC_Activities _parent;

        public FormAddActivities(UC_Activities parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void BatCheDoThem()
        {
            isAdding = true;
            btnluu.Visible = true;
            btnhuy.Visible = true;

            txttendichvu.Clear();
            txtghichu.Clear();
            txttennhanvien.Clear();
            txtiddichvu.Clear();
            dtpngaytao.Value = DateTime.Now;

        }
        private void LoadThongTinDichVu()
        {
           try
            {
                string query = $"SELECT * FROM dichvu WHERE iddichvu = {_idDichvu}";
                DataTable dt = Database.Query(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtiddichvu.Text = row["iddichvu"].ToString();
                    txttendichvu.Text = row["tendichvu"].ToString();
                    txttenkhachhang.Text = row["tenkhachhang"].ToString();
                    txttennhanvien.Text = row["tennhanvien"].ToString();
                    txtghichu.Text = row["ghichu"].ToString();
                    dtpngaytao.Value = Convert.ToDateTime(row["ngaytao"]);

                    txtiddichvu.Enabled = false;
                    btnluu.Visible = true;
                    btnhuy.Visible = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin dịch vụ: " + ex.Message);
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                try
                {
                    string tendv = txttendichvu.Text.Trim();
                    string tennv = txttennhanvien.Text.Trim();
                    string ngaytao = dtpngaytao.Value.ToString("yyyy-MM-dd");
                    string ghichu = txtghichu.Text.Trim();
                    string tenkhach = txttenkhachhang.Text.Trim();

                    if (comboBoxldv.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn loại dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idLoaiDV = (int)comboBoxldv.SelectedValue;

                    if (string.IsNullOrWhiteSpace(tendv))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ tên dịch vụ.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    // Lấy idnhanvien theo tên nhân viên (giả sử có)
                    string queryNhanVien = $"SELECT idnhanvien FROM nhanvien WHERE tennhanvien = N'{tennv}'";
                    DataTable dtNV = Database.Query(queryNhanVien);
                    if (dtNV.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                        return;
                    }
                    int idNhanVien = Convert.ToInt32(dtNV.Rows[0][0]);

                    // Lấy idkhachhang
                    string queryKhachHang = $"SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'{tenkhach}'";
                    DataTable dtKH = Database.Query(queryKhachHang);
                    if (dtKH.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng!");
                        return;
                    }
                    int idKhachHang = Convert.ToInt32(dtKH.Rows[0][0]);

                    // Sau đó bạn tạo câu Insert
                    string insertKH = $@"
                    INSERT INTO dichvu (tendichvu, idnhanvien, ngaykhoitao, mota, idkhachhang, idloaidichvu)
                    VALUES (N'{tendv}', {idNhanVien}, '{ngaytao}', N'{ghichu}', {idKhachHang}, {idLoaiDV})
                    ";
                    Database.Excute(insertKH);

                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    activitiesControl.napdgvhoatdong();
                    this.Close();
                    isAdding = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dịch vụ: " + ex.Message);
                }
            }
            else if (isEditing)
            {
                try
                {
                    string tendv = txttendichvu.Text.Trim();
                    string tennv = txttennhanvien.Text.Trim();
                    string ngaytao = dtpngaytao.Value.ToString("yyyy-MM-dd");
                    string ghichu = txtghichu.Text.Trim();
                    string tenkhach = txttenkhachhang.Text.Trim();
                    int idLoaiDV = (int)comboBoxldv.SelectedValue;

                    // Lấy idnhanvien theo tên nhân viên
                    string queryNhanVien = $"SELECT idnhanvien FROM nhanvien WHERE tennhanvien = N'{tennv}'";
                    DataTable dtNV = Database.Query(queryNhanVien);
                    if (dtNV.Rows.Count == 0)
                    {
                        MessageBox.Show("Nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int idNhanVien = Convert.ToInt32(dtNV.Rows[0][0]);

                    // Lấy idkhachhang theo tên khách hàng
                    string queryKhachHang = $"SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'{tenkhach}'";
                    DataTable dtKH = Database.Query(queryKhachHang);
                    if (dtKH.Rows.Count == 0)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int idKhachHang = Convert.ToInt32(dtKH.Rows[0][0]);

                    string updateQuery = $@"
            UPDATE dichvu 
            SET tendichvu = N'{tendv}', 
                idnhanvien = {idNhanVien}, 
                ngaykhoitao = '{ngaytao}', 
                mota = N'{ghichu}', 
                idkhachhang = {idKhachHang}, 
                idloaidichvu = {idLoaiDV}
            WHERE iddichvu = {_idDichvu}";

                    Database.Excute(updateQuery);

                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    activitiesControl.napdgvhoatdong();
                    this.Close();

                    isEditing = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dịch vụ: " + ex.Message);
                }
            }
        }
        private void btnchonkhachhan_Click(object sender, EventArgs e)
        {
            
            FormChooseCus chooseCustomerControl = new FormChooseCus();
            chooseCustomerControl.ShowDialog();
        } 
    }
}
