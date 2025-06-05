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
    public partial class AddDonHang : Form
    {
        private UC_DonHang UC_DonHang;
        private int _idDonhang;
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        
        private int _idNhanVien;
        private int _idKhachHang;
        public AddDonHang(UC_DonHang parent, int idDonhang)
        {
            InitializeComponent();
            this.UC_DonHang = parent;
            this._idDonhang = idDonhang;
            isEditing = true;
            LoadThongDonhang();
        }

        public AddDonHang(UC_DonHang parent)
        {
            InitializeComponent();
            this.UC_DonHang = parent;
            BatCheDoThem();
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
        private void LoadThongDonhang()
        {
            try
            {
                string query = $@"
        SELECT dv.iddichvu, dv.tendichvu, dv.ngaykhoitao, dv.mota, 
               kh.idkhachhang, kh.tenkhachhang, 
               nv.idnhanvien, nv.tennhanvien,
               dv.idloaidichvu
        FROM dichvu dv
        JOIN khachhang kh ON kh.idkhachhang = dv.idkhachhang
        JOIN nhanvien nv ON nv.idnhanvien = dv.idnhanvien
        LEFT JOIN loaidichvu ld ON dv.idloaidichvu = ld.idloaidichvu
        WHERE dv.iddichvu = {_idDonhang}";

                DataTable dt = Database.Query(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtiddichvu.Text = row["iddichvu"].ToString();
                    txttendichvu.Text = row["tendichvu"].ToString();
                    txttennhanvien.Text = row["tennhanvien"].ToString();
                    txtghichu.Text = row["mota"].ToString();
                    dtpngaytao.Value = Convert.ToDateTime(row["ngaykhoitao"]);

                    _idNhanVien = Convert.ToInt32(row["idnhanvien"]);
                    _idKhachHang = Convert.ToInt32(row["idkhachhang"]);

                    listboxkhachhang.Items.Clear();
                    listboxkhachhang.Items.Add(row["tenkhachhang"].ToString());

                    txtiddichvu.Visible = false;
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
                    string SafeSql(string input) => input.Replace("'", "''");
                    string id = txtiddichvu.Text.Trim();
                    string tendv = SafeSql(txttendichvu.Text.Trim());
                    string ghichu = SafeSql(txtghichu.Text.Trim());
                    string tennv = txttennhanvien.Text.Trim();
                    string ngaytao = dtpngaytao.Value.ToString("yyyy-MM-dd");
                    int idLoaiDV = (int)comboBoxldv.SelectedValue;
                    string tenTrangThai = "Mới tạo";


                    if (comboBoxldv.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn loại dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(tendv))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ tên hoạt động.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string queryNhanVien = $"SELECT idnhanvien FROM nhanvien WHERE tennhanvien = N'{tennv}'";
                    DataTable dtNV = Database.Query(queryNhanVien);
                    if (dtNV.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                        return;
                    }
                    int idNhanVien = Convert.ToInt32(dtNV.Rows[0][0]);

                    var selectedCustomers = listboxkhachhang.Items.Cast<string>().ToList();

                    if (selectedCustomers.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất một khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (string tenKhachHang in selectedCustomers)
                    {
                        string queryKhachHang = $"SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'{tenKhachHang}'";

                        DataTable dtKH = Database.Query(queryKhachHang);
                        if (dtKH.Rows.Count == 0)
                        {
                            MessageBox.Show($"Không tìm thấy khách hàng: {tenKhachHang}!");
                            return;
                        }
                        int idKhachHang = Convert.ToInt32(dtKH.Rows[0][0]);

                        string queryTrangThai = $@"
                    SELECT idtrangthai 
                    FROM trangthaidichvu 
                    WHERE tentrangthai = N'{tenTrangThai}' AND idloaidichvu = {idLoaiDV}
                    ";

                        DataTable dt = Database.Query(queryTrangThai);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy trạng thái phù hợp!");
                            return;
                        }

                        int idTrangThai = Convert.ToInt32(dt.Rows[0][0]);

                        string insertDV = $@"
                    INSERT INTO dichvu (
                    tendichvu, idnhanvien, ngaykhoitao, mota, idkhachhang, idloaidichvu, idtrangthai)
                    VALUES (N'{tendv}', {idNhanVien}, '{ngaytao}', N'{ghichu}', {idKhachHang}, {idLoaiDV}, {idTrangThai})";

                        Database.Excute(insertDV);
                    }
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    UC_DonHang.napdgvdonhang();
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
                    string id = txtiddichvu.Text.Trim();
                    string tendv = txttendichvu.Text.Trim();
                    string ngaytao = dtpngaytao.Value.ToString("yyyy-MM-dd");
                    string ghichu = txtghichu.Text.Trim();
                    int idLoaiDV = (int)comboBoxldv.SelectedValue;

                    if (idLoaiDV == 0)
                    {
                        MessageBox.Show("Vui lòng chọn loại dịch vụ.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    string updateQuery = $@"
        UPDATE dichvu
        SET 
            tendichvu = N'{tendv}',
            idnhanvien = N'{_idNhanVien}',
            idkhachhang = N'{_idKhachHang}',
            idloaidichvu = {idLoaiDV},
            ngaykhoitao = '{ngaytao}',
            mota = N'{ghichu}'
        WHERE iddichvu = {id}";

                    Database.Excute(updateQuery);
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);

                    isEditing = false;
                    currentEditingRowIndex = -1;
                    UC_DonHang.napdgvdonhang();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnchonkhachhang_Click(object sender, EventArgs e)
        {
            FormChooseCus f = new FormChooseCus();

            var selectedNames = listboxkhachhang.Items.Cast<string>().ToList();
            f.PreselectedCustomerNames = selectedNames;
            // Truyền sự kiện nhận khách hàng về
            f.OnCustomerNamesSelected = (newSelectedNames) =>
            {
                listboxkhachhang.Items.Clear();
                foreach (var name in newSelectedNames)
                {
                    listboxkhachhang.Items.Add(name);
                }
            };
            f.ShowDialog();
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

        private void AddDonHang_Load(object sender, EventArgs e)
        {
            if (Current_user.CurrentUser != null)
            {

                if (isAdding)
                {
                    txttennhanvien.Text = Database.LayTenNhanVienTheoUser(Current_user.CurrentUser.Idusers);
                }
                txttennhanvien.Enabled = false;
                if (Current_user.CurrentUser.Idvaitro == 1)
                {
                    txttennhanvien.Enabled = true;
                    linkLabelnhanvien.ActiveLinkColor = Color.Blue;
                    linkLabelnhanvien.LinkBehavior = LinkBehavior.AlwaysUnderline;
                    linkLabelnhanvien.Cursor = Cursors.Hand;
                    tooltipnv.SetToolTip(linkLabelnhanvien, "Click để chọn nhân viên");
                }
                else
                {
                    linkLabelnhanvien.LinkColor = this.ForeColor;
                    linkLabelnhanvien.ActiveLinkColor = this.ForeColor;
                    linkLabelnhanvien.VisitedLinkColor = this.ForeColor;
                    linkLabelnhanvien.LinkBehavior = LinkBehavior.NeverUnderline;
                    linkLabelnhanvien.Cursor = Cursors.Default;
                    linkLabelnhanvien.Links.Clear();
                }

            }
            else
            {
                MessageBox.Show("Lỗi: Không có thông tin người dùng hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
