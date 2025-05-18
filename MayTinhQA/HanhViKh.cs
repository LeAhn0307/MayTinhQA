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
    public partial class frmhanhvikh : Form
    {
        private string connectionString = "Data Source=DESKTOP-2023ILB\\SQLEXPRESS01;Initial Catalog=crm;Integrated Security=True";
        public frmhanhvikh()
        {
            InitializeComponent();
        }

        private void frmhanhvikh_Load(object sender, EventArgs e)
        {
            dgvthongke.Columns.Clear();
            dgvthongke.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvthongke.Columns.Add("SoLanMua", "Số Lần Mua");
            dgvthongke.Columns.Add("TongGiaTri", "Tổng Giá Trị");
            dgvphankhuc.Columns.Clear();
            dgvphankhuc.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvphankhuc.Columns.Add("PhanKhuc", "Phân Khúc");
            if (chartxuhuong.Series.IndexOf("Số Giao Dịch") >= 0)
            {
                chartxuhuong.Series["Số Giao Dịch"].Points.Clear(); // Xóa dữ liệu cũ
            }
            else
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Số Giao Dịch")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chartxuhuong.Series.Add(series);
            }
            ThongKeMuaSam();
            PhanKhucKhachHang();
            BieuDo();
        }
        private void ThongKeMuaSam()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    k.tenkhachhang AS TenKhachHang,
                    COUNT(g.idgiaodich) AS SoLanMua,
                    SUM(c.dongia * c.soluong) AS TongGiaTri
                FROM 
                    khachhang k
                LEFT JOIN 
                    giaodich g ON k.idkhachhang = g.idkhachhang
                LEFT JOIN 
                    hoadon h ON g.idhoadon = h.idhoadon
                LEFT JOIN 
                    chitietdonhang c ON g.idchitietdh = c.idchitietdh
                GROUP BY 
                    k.tenkhachhang
                ORDER BY 
                    TongGiaTri DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvthongke.Rows.Add(
                            reader["TenKhachHang"],
                            reader["SoLanMua"],
                            string.Format("{0:C}", reader["TongGiaTri"])); // Định dạng tiền tệ
                    }
                }
            }
        }
        private void BieuDo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    CAST(h.ngaytao AS DATE) AS Ngay,
                    COUNT(g.idgiaodich) AS SoGiaoDich
                FROM 
                    giaodich g
                JOIN 
                    hoadon h ON g.idhoadon = h.idhoadon
                GROUP BY 
                    CAST(h.ngaytao AS DATE)
                ORDER BY 
                    Ngay;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    chartxuhuong.Series["Số Giao Dịch"].Points.Clear();
                    while (reader.Read())
                    {
                        chartxuhuong.Series["Số Giao Dịch"].Points.AddXY(reader["Ngay"], reader["SoGiaoDich"]);
                    }
                }
            }
        }
        private void PhanKhucKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    k.tenkhachhang AS TenKhachHang,
                    CASE 
                        WHEN COUNT(g.idgiaodich) > 5 THEN 'Trung Thanh'
                        WHEN COUNT(g.idgiaodich) BETWEEN 1 AND 5 THEN 'Moi'
                        ELSE 'Khong Hoat Dong'
                    END AS PhanKhuc
                FROM 
                    khachhang k
                LEFT JOIN 
                    giaodich g ON k.idkhachhang = g.idkhachhang
                GROUP BY 
                    k.tenkhachhang
                ORDER BY 
                    PhanKhuc;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvphankhuc.Rows.Clear(); // Xóa dữ liệu cũ
                    while (reader.Read())
                    {
                        dgvphankhuc.Rows.Add(
                            reader["TenKhachHang"],
                            reader["PhanKhuc"]);
                    }
                }
            }
        }
    }
}
