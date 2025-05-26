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
    public partial class UC_Behaviour : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-2023ILB\\SQLEXPRESS01;Initial Catalog=crm;Integrated Security=True";

        public UC_Behaviour()
        {
            InitializeComponent();
            //chart1.Size = new Size(400, 300); // Tăng kích thước biểu đồ
            //chart2.Size = new Size(400, 300); // Tăng kích thước biểu đồ
        }
        private void frmhanhvikh_Load(object sender, EventArgs e)
        {
        /*    guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.Columns.Add("Ngay", "Ngày");
            guna2DataGridView1.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            guna2DataGridView1.Columns.Add("SoLanMua", "Số Lần Mua");
            guna2DataGridView1.Columns.Add("TongGiaTri", "Tổng Giá Trị");

            guna2DataGridView2.Columns.Clear();
            guna2DataGridView2.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            guna2DataGridView2.Columns.Add("PhanKhuc", "Phân Khúc");

            // Biểu đồ giao dịch
            if (chart1.Series.IndexOf("Số Giao Dịch") >= 0)
            {
                chart1.Series["Số Giao Dịch"].Points.Clear();
            }
            else
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Số Giao Dịch")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chart1.Series.Add(series);
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
            BieuDoPhanKhuc();*/
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
                        guna2DataGridView1.Rows.Add(
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
            chart1.Series["Số Giao Dịch"].Points.Clear();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["SoLanMua"].Value != null && row.Cells["TenKhachHang"].Value != null && row.Cells["Ngay"].Value != null)
                {
                    int soLanMua = Convert.ToInt32(row.Cells["SoLanMua"].Value);
                    string ngay = row.Cells["Ngay"].Value.ToString();

                    var point = chart1.Series["Số Giao Dịch"].Points.AddXY(ngay, soLanMua);
                    chart1.Series["Số Giao Dịch"].Points[point].Label = soLanMua.ToString();

                }
            }
        }

        private void BieuDoPhanKhuc()
        {
            chart2.Series["Phân Khúc Khách Hàng"].Points.Clear();

            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                if (row.Cells["PhanKhuc"].Value != null)
                {
                    string phanKhuc = row.Cells["PhanKhuc"].Value.ToString();
                    int soKhachHang = 1;
                    var point = chart2.Series["Phân Khúc Khách Hàng"].Points.AddXY(phanKhuc, soKhachHang);
                    chart2.Series["Phân Khúc Khách Hàng"].Points[point].Label = phanKhuc;
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
                    guna2DataGridView2.Rows.Clear();
                    while (reader.Read())
                    {
                        guna2DataGridView2.Rows.Add(
                            reader["TenKhachHang"],
                            reader["PhanKhuc"]);
                    }
                }
            }
        }

        private void UC_Behaviour_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.Columns.Add("Ngay", "Ngày");
            guna2DataGridView1.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            guna2DataGridView1.Columns.Add("SoLanMua", "Số Lần Mua");
            guna2DataGridView1.Columns.Add("TongGiaTri", "Tổng Giá Trị");

            guna2DataGridView2.Columns.Clear();
            guna2DataGridView2.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            guna2DataGridView2.Columns.Add("PhanKhuc", "Phân Khúc");

            // Biểu đồ giao dịch
            if (chart1.Series.IndexOf("Số Giao Dịch") >= 0)
            {
                chart1.Series["Số Giao Dịch"].Points.Clear();
            }
            else
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Số Giao Dịch")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chart1.Series.Add(series);
            }

            // Biểu đồ phân khúc
            if (chart2.Series.IndexOf("Phân Khúc Khách Hàng") < 0)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Phân Khúc Khách Hàng")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                };
                chart2.Series.Add(series);
            }

            ThongKeMuaSam();
            PhanKhucKhachHang();
            BieuDoGiaoDich();
            BieuDoPhanKhuc();
        }
    }
}
