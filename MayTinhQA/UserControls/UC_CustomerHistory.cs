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

namespace MayTinhQA.UserControls
{
    public partial class UC_CustomerHistory : UserControl
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=crm1;Integrated Security=True";

        public UC_CustomerHistory()
        {
            InitializeComponent();
            dgvlichsugiaodich.Columns.Clear();
            dgvlichsugiaodich.Columns.Add("idDonHang", "ID Đơn Hàng");
            dgvlichsugiaodich.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvlichsugiaodich.Columns.Add("idChiTietDH", "ID Chi Tiết Đơn Hàng");
            dgvlichsugiaodich.Columns.Add("SoLuong", "Số Lượng");
            dgvlichsugiaodich.Columns.Add("DonGia", "Đơn Giá");
            LoadLichSuGiaoDich();
            LoadThongKeGiaoDich();
        }
        private void LoadLichSuGiaoDich()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    d.iddonhang AS idDonHang,
                    k.tenkhachhang AS TenKhachHang,
                    c.idchitietdh AS idChiTietDH,
                    c.soluong,
                    c.dongia AS DonGia
                FROM 
                    donhang d
                JOIN 
                    khachhang k ON d.idkhachhang = k.idkhachhang
                JOIN 
                    chitietdonhang c ON d.iddonhang = c.iddonhang
                ORDER BY 
                    d.iddonhang DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvlichsugiaodich.Rows.Add(
                            reader["idDonHang"],
                            reader["TenKhachHang"],
                            reader["idChiTietDH"],
                            reader["soluong"],
                            reader["DonGia"]);
                    }
                }
            }
        }
        private void LoadThongKeGiaoDich()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) AS TongSoDonHang FROM donhang";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    lbltongsogiaodich.Text = command.ExecuteScalar().ToString();
                }
            }
        }
        private void btntk_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            d.iddonhang AS idDonHang,
            k.tenkhachhang AS TenKhachHang,
            c.idchitietdh AS idChiTietDH,
            c.soluong,
            c.dongia AS DonGia
        FROM 
            donhang d
        JOIN 
            khachhang k ON d.idkhachhang = k.idkhachhang
        JOIN 
            chitietdonhang c ON d.iddonhang = c.iddonhang
        WHERE 
            k.tenkhachhang LIKE @TenKhachHang 
            OR d.iddonhang = @IdDonHang
        ORDER BY 
            d.iddonhang DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenKhachHang", "%" + txttktheotenkhach.Text + "%");
                    command.Parameters.AddWithValue("@IdDonHang", string.IsNullOrEmpty(txttktheoiddonhang.Text) ? (object)DBNull.Value : Convert.ToInt32(txttktheoiddonhang.Text));
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvlichsugiaodich.Rows.Clear();
                    while (reader.Read())
                    {
                        dgvlichsugiaodich.Rows.Add(
                            reader["idDonHang"],
                            reader["TenKhachHang"],
                            reader["idChiTietDH"],
                            reader["soluong"],
                            reader["DonGia"]);
                    }
                }
            }
        }
    }
}
