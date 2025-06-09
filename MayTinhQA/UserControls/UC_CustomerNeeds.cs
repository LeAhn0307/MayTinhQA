using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MayTinhQA.UserControls
{
    public partial class UC_CustomerNeeds : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-2023ILB\\SQLEXPRESS01;Initial Catalog=crm;Integrated Security=True";
        public UC_CustomerNeeds()
        {
            InitializeComponent();
            dgvKetQua.Columns.Clear();
            dgvKetQua.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvKetQua.Columns.Add("TongSoLuong", "Tổng Số Lượng");
            dgvKetQua.Columns.Add("TongDoanhThu", "Tổng Doanh Thu");
            dgvKetQua.Columns.Add("TanSuatMua", "Tần Suất Mua");
            loadSanPham();
        }
        private void loadSanPham()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "select tensanpham from sanpham";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxsp.Items.Add(reader["tensanpham"].ToString());
                    }
                }
            }
        }

        private void btnphantich_Click(object sender, EventArgs e)
        {
            string selectedProduct = cbxsp.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedProduct))
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm!");
                return;
            }
            DateTime ngaybatdau = dtpbatdau.Value;
            DateTime ngayketthuc = dtpketthuc.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = @"
        SELECT 
            s.tensanpham AS TenSanPham,
            SUM(c.soluong) AS TongSoLuong,
            SUM(c.soluong * c.dongia) AS TongDoanhThu,
            COUNT(c.idchitietdh) AS TanSuatMua
        FROM 
            chitietdonhang c
        JOIN 
            sanpham s ON c.idsanpham = s.idsanpham
        JOIN 
            donhang d ON c.iddonhang = d.iddonhang
        WHERE 
            d.ngaytao BETWEEN @NgayBatDau AND @NgayKetThuc
            AND s.tensanpham = @TenSanPham
        GROUP BY 
            s.tensanpham
        ORDER BY 
            TongSoLuong DESC;";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
                    command.Parameters.AddWithValue("@TenSanPham", selectedProduct);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvKetQua.Rows.Clear();
                    while (reader.Read())
                    {
                        dgvKetQua.Rows.Add(
                            reader["TenSanPham"],
                            reader["TongSoLuong"],
                            reader["TongDoanhThu"],
                            reader["TanSuatMua"]);
                    }
                }
            }
        }

        private void btnmuakem_Click(object sender, EventArgs e)
        {
        }
    }
}
