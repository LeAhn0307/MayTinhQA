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

namespace MayTinhQA
{
    public partial class frmlichsu : Form
    {
        private string connectionString = "";
        public frmlichsu()
        {
            InitializeComponent();
            LoadLichSuGiaoDich();
        }
        private void LoadLichSuGiaoDich()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    g.idgiaodich,
                    k.hoten AS TenKhachHang,
                    h.idhoadon,
                    c.idchitietdh,
                    c.soluong,
                    c.gia
                FROM 
                    giaodich g
                JOIN 
                    khachhang k ON g.idkhachhang = k.idkhachhang
                JOIN 
                    hoadon h ON g.idhoadon = h.idhoadon
                JOIN 
                    chitietdonhang c ON g.idchitietdh = c.idchitietdh
                ORDER BY 
                    g.idgiaodich DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvlichsugiaodich.Rows.Add(
                            reader["idgiaodich"],
                            reader["TenKhachHang"],
                            reader["idhoadon"],
                            reader["idchitietdh"],
                            reader["soluong"],
                            reader["gia"]);
                    }
                }
            }
        }
        private void LoadThongKeGiaoDich()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) AS TongSoGiaoDich FROM giaodich";
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
                g.idgiaodich,
                k.hoten AS TenKhachHang,
                h.idhoadon,
                c.idchitietdh,
                c.soluong,
                c.gia
            FROM 
                giaodich g
            JOIN 
                khachhang k ON g.idkhachhang = k.idkhachhang
            JOIN 
                hoadon h ON g.idhoadon = h.idhoadon
            JOIN 
                chitietdonhang c ON g.idchitietdh = c.idchitietdh
            WHERE 
                k.hoten LIKE @TenKhachHang OR h.idhoadon = @IdHoaDon
            ORDER BY 
                g.idgiaodich DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenKhachHang", "%" + txttktheotenkhach.Text + "%");
                    command.Parameters.AddWithValue("@IdHoaDon", txttktheomahoadon.Text);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvlichsugiaodich.Rows.Clear(); // Xóa dữ liệu cũ
                    while (reader.Read())
                    {
                        dgvlichsugiaodich.Rows.Add(
                            reader["idgiaodich"],
                            reader["TenKhachHang"],
                            reader["idhoadon"],
                            reader["idchitietdh"],
                            reader["soluong"],
                            reader["gia"]);
                    }
                }
            }
        }
    }
}
