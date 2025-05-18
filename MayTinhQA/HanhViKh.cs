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
            chartgiaodich.Size = new Size(400, 300); // Tăng kích thước biểu đồ
            chartphankhuc.Size = new Size(400, 300); // Tăng kích thước biểu đồ
        }

        private void frmhanhvikh_Load(object sender, EventArgs e)
        {
            dgvthongke.Columns.Clear();
            dgvthongke.Columns.Add("Ngay", "Ngày");
            dgvthongke.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvthongke.Columns.Add("SoLanMua", "Số Lần Mua");
            dgvthongke.Columns.Add("TongGiaTri", "Tổng Giá Trị");

            dgvphankhuc.Columns.Clear();
            dgvphankhuc.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvphankhuc.Columns.Add("PhanKhuc", "Phân Khúc");

            // Biểu đồ giao dịch
            if (chartgiaodich.Series.IndexOf("Số Giao Dịch") >= 0)
            {
                chartgiaodich.Series["Số Giao Dịch"].Points.Clear(); 
            }
            else
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Số Giao Dịch")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chartgiaodich.Series.Add(series);
            }

            // Biểu đồ phân khúc
            if (chartphankhuc.Series.IndexOf("Phân Khúc Khách Hàng") < 0)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Phân Khúc Khách Hàng")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                };
                chartphankhuc.Series.Add(series);
            }

            ThongKeMuaSam();
            PhanKhucKhachHang();
            BieuDoGiaoDich();
            BieuDoPhanKhuc();
        }

        private void ThongKeMuaSam()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            CAST(h.ngaytao AS DATE) AS Ngay,
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
            k.tenkhachhang, CAST(h.ngaytao AS DATE)
        ORDER BY 
            Ngay DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvthongke.Rows.Add(
                            reader["Ngay"], 
                            reader["TenKhachHang"],
                            reader["SoLanMua"],
                            string.Format("{0:C}", reader["TongGiaTri"]));
                    }
                }
            }
        }

        private void BieuDoGiaoDich()
        {
            chartgiaodich.Series["Số Giao Dịch"].Points.Clear();

            foreach (DataGridViewRow row in dgvthongke.Rows)
            {
                if (row.Cells["SoLanMua"].Value != null && row.Cells["TenKhachHang"].Value != null && row.Cells["Ngay"].Value != null)
                {
                    int soLanMua = Convert.ToInt32(row.Cells["SoLanMua"].Value);
                    string ngay = row.Cells["Ngay"].Value.ToString();

                    var point = chartgiaodich.Series["Số Giao Dịch"].Points.AddXY(ngay, soLanMua);
                    chartgiaodich.Series["Số Giao Dịch"].Points[point].Label = soLanMua.ToString();

                }
            }
        }

        private void BieuDoPhanKhuc()
        {
            chartphankhuc.Series["Phân Khúc Khách Hàng"].Points.Clear();

            foreach (DataGridViewRow row in dgvphankhuc.Rows)
            {
                if (row.Cells["PhanKhuc"].Value != null)
                {
                    string phanKhuc = row.Cells["PhanKhuc"].Value.ToString();
                    int soKhachHang = 1;
                    var point = chartphankhuc.Series["Phân Khúc Khách Hàng"].Points.AddXY(phanKhuc, soKhachHang);
                    chartphankhuc.Series["Phân Khúc Khách Hàng"].Points[point].Label = phanKhuc;
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
                    dgvphankhuc.Rows.Clear();
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