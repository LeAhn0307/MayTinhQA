using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string _idKhachHang;
        private string _idSanpham;
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

            txtmadh.Clear();
            txtidchitietdh.Clear();


        }
        private void LoadThongDonhang()
        {
            try
            {
                string query = $@"
select ctdh.idchitietdh, dh.madonhang,sp.tensanpham,kh.tenkhachhang,ctdh.soluong,sp.gia,tt.tentrangthai from chitietdonhang ctdh
join donhang dh on ctdh.iddonhang=dh.iddonhang
join sanpham sp on ctdh.idsanpham=sp.idsanpham
join khachhang kh on dh.idkhachhang=kh.idkhachhang
join trangthaidonhang tt on dh.idtrangthai= tt.idtrangthai
where ctdh.idchitietdh= {_idDonhang}";

                DataTable dt = Database.Query(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtidchitietdh.Text = row["idchitietdh"].ToString();
                    txtmadh.Text = row["madonhang"].ToString();

                    _idKhachHang = row["tenkhachhang"].ToString();
                    listboxkhachhang.Items.Clear();
                    listboxkhachhang.Items.Add(row["tenkhachhang"].ToString());

                    txtidchitietdh.Visible = false;
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
                MessageBox.Show("Lỗi khi tải thông tin đơn hàng: " + ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                try
                {
                    string SafeSql(string input) => input.Replace("'", "''");
                    string madh = SafeSql(txtmadh.Text.Trim());
                    string today = DateTime.Now.ToString("yyyy-MM-dd");
                    string queryCount = $"SELECT COUNT(*) + 1 FROM donhang WHERE CAST(ngaytao AS DATE) = '{today}'";
                    DataTable dtCount = Database.Query(queryCount);
                    int sttTrongNgay = Convert.ToInt32(dtCount.Rows[0][0]);
                    string maDon = $"DH{DateTime.Now:yyyyMMdd}{sttTrongNgay.ToString("D3")}";

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


                        string queryDV = $@"
                    SELECT TOP 1 iddichvu FROM dichvu 
                    WHERE idkhachhang = {idKhachHang} AND idloaidichvu = 1 
                    ORDER BY ngaykhoitao DESC";
                        DataTable dtDV = Database.Query(queryDV);
                        if (dtDV.Rows.Count == 0)
                        {
                            MessageBox.Show("Khách hàng chưa có dịch vụ báo giá!");
                            return;
                        }
                        int idDichVu = Convert.ToInt32(dtDV.Rows[0][0]);


                        string insertDonHang = $@"
                        INSERT INTO donhang (madonhang, idkhachhang, idtrangthai, iddichvu, ngaytao)
                        VALUES (N'{maDon}', {idKhachHang},(SELECT idtrangthai FROM trangthaidonhang WHERE tentrangthai = N'Khởi tạo'), {idDichVu}, '{today}')";

                        Database.Excute(insertDonHang);


                        string queryDonhang = $"SELECT TOP 1 iddonhang FROM donhang WHERE madonhang = N'{maDon}' ORDER BY iddonhang DESC";
                        DataTable dtDH = Database.Query(queryDonhang);
                        if (dtDH.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy đơn hàng vừa tạo!");
                            return;
                        }
                        int idDonHang = Convert.ToInt32(dtDH.Rows[0][0]);

                        foreach (string item in listBoxsanpham.Items)
                        {

                            var parts = item.Split(new[] { " - SL: " }, StringSplitOptions.None);

                            if (parts.Length < 2)
                            {
                                MessageBox.Show($"Định dạng sản phẩm không đúng: {item}");
                                continue;
                            }

                            string tenSanPham = parts[0].Trim();
                            if (!int.TryParse(parts[1].Trim(), out int soLuong))
                            {
                                MessageBox.Show($"Số lượng không hợp lệ trong: {item}");
                                continue;
                            }

                            string querySP = $"SELECT idsanpham, gia FROM sanpham WHERE tensanpham = N'{SafeSql(tenSanPham)}'";
                            DataTable dtSP = Database.Query(querySP);
                            if (dtSP.Rows.Count == 0)
                            {
                                MessageBox.Show($"Không tìm thấy sản phẩm: {tenSanPham}!");
                                continue;
                            }

                            int idSanPham = Convert.ToInt32(dtSP.Rows[0]["idsanpham"]);
                            decimal donGia = Convert.ToDecimal(dtSP.Rows[0]["gia"]);

                            string insertChiTiet = $@"
INSERT INTO chitietdonhang (iddonhang, idsanpham, soluong, dongia)
VALUES ({idDonHang}, {idSanPham}, {soLuong}, {donGia.ToString(CultureInfo.InvariantCulture)})";
                            Database.Excute(insertChiTiet);
                        }

                        MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                        UC_DonHang.napdgvdonhang();
                        isAdding = false;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm đơn hàng: " + ex.Message);
                }
            }
            else if (isEditing)
            {
                try
                {
                    string SafeSql(string input) => input.Replace("'", "''");
                    string id = txtidchitietdh.Text.Trim();
                    int idChiTietDH = Convert.ToInt32(txtidchitietdh.Text.Trim());
                    foreach (string item in listBoxsanpham.Items)
                    {
                        var parts = item.Split(new[] { " - SL: " }, StringSplitOptions.None);

                        if (parts.Length < 2)
                        {
                            MessageBox.Show($"Định dạng sản phẩm không đúng: {item}");
                            continue;
                        }

                        string tenSanPham = parts[0].Trim();
                        if (!int.TryParse(parts[1].Trim(), out int soLuong))
                        {
                            MessageBox.Show($"Số lượng không hợp lệ trong: {item}");
                            continue;
                        }
                        string querySP = $"SELECT idsanpham, gia FROM sanpham WHERE tensanpham = N'{SafeSql(tenSanPham)}'";
                        DataTable dtSP = Database.Query(querySP);
                        if (dtSP.Rows.Count == 0)
                        {
                            MessageBox.Show($"Không tìm thấy sản phẩm: {tenSanPham}!");
                            continue;
                        }
                        int idSanPham = Convert.ToInt32(dtSP.Rows[0]["idsanpham"]);
                        decimal donGia = Convert.ToDecimal(dtSP.Rows[0]["gia"]);
                        string updateChiTiet = $@"
                        UPDATE chitietdonhang
                         SET 
                         soluong = {soLuong},
                          dongia = {donGia.ToString(CultureInfo.InvariantCulture)}
                         WHERE idchitietdh = {idChiTietDH}";
                        Database.Excute(updateChiTiet);
                    }

                    MessageBox.Show("Cập nhật chi tiết đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    isEditing = false;
                    currentEditingRowIndex = -1;
                    UC_DonHang.napdgvdonhang();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật chi tiết đơn hàng: " + ex.Message);
                }
            }
        }

        private void btnchonkhachhang_Click(object sender, EventArgs e)
        {
            FormChooseCus f = new FormChooseCus();

            var selectedNames = listboxkhachhang.Items.Cast<string>().ToList();
            f.PreselectedCustomerNames = selectedNames;

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
        }

        private void btnchonsanpham_Click(object sender, EventArgs e)
        {
            FormChonSp f = new FormChonSp();

            var selectedNames = listBoxsanpham.Items.Cast<string>().ToList();
            f.OnProductNamesSelected = (newSelectedNames) =>
            {
                listBoxsanpham.Items.Clear();
                foreach (var item in newSelectedNames)
                {
                    listBoxsanpham.Items.Add(item);
                }
            };

            f.ShowDialog();
        }
    }
}
