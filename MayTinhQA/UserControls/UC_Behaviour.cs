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
        }

        private void ThongKeMuaSam()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            CAST(d.ngaytao AS DATE) AS Ngay,
            k.tenkhachhang AS TenKhachHang,
            COUNT(c.idchitietdh) AS SoLanMua,
            SUM(c.dongia * c.soluong) AS TongGiaTri
        FROM 
            khachhang k
        LEFT JOIN 
            donhang d ON k.idkhachhang = d.idkhachhang
        LEFT JOIN 
            chitietdonhang c ON d.iddonhang = c.iddonhang
        GROUP BY 
            k.tenkhachhang, CAST(d.ngaytao AS DATE)
        ORDER BY 
            Ngay DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvgd.Rows.Clear();
                    while (reader.Read())
                    {
                        dgvgd.Rows.Add(
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
            chartgd.Series["Số Giao Dịch"].Points.Clear();

            foreach (DataGridViewRow row in dgvgd.Rows)
            {
                if (row.Cells["SoLanMua"].Value != null && row.Cells["TenKhachHang"].Value != null && row.Cells["Ngay"].Value != null)
                {
                    int soLanMua = Convert.ToInt32(row.Cells["SoLanMua"].Value);
                    string ngay = row.Cells["Ngay"].Value.ToString();

                    var point = chartgd.Series["Số Giao Dịch"].Points.AddXY(ngay, soLanMua);
                    chartgd.Series["Số Giao Dịch"].Points[point].Label = soLanMua.ToString();

                }
            }
            chartgd.Invalidate();
        }

        private void BieuDoPhanKhuc()
        {
            chartpk.Series["Phân Khúc Khách Hàng"].Points.Clear();

            foreach (DataGridViewRow row in dgvpk.Rows)
            {
                if (row.Cells["PhanKhuc"].Value != null)
                {
                    string phanKhuc = row.Cells["PhanKhuc"].Value.ToString();
                    int soKhachHang = 1;
                    var point = chartpk.Series["Phân Khúc Khách Hàng"].Points.AddXY(phanKhuc, soKhachHang);
                    chartpk.Series["Phân Khúc Khách Hàng"].Points[point].Label = phanKhuc;
                }
            }
            chartpk.Invalidate();
        }

        private void PhanKhucKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            k.tenkhachhang AS TenKhachHang,
            CASE 
                WHEN COUNT(d.iddonhang) > 5 THEN 'Trung Thanh'
                WHEN COUNT(d.iddonhang) BETWEEN 1 AND 5 THEN 'Moi'
                ELSE 'Khong Hoat Dong'
            END AS PhanKhuc
        FROM 
            khachhang k
        LEFT JOIN 
            donhang d ON k.idkhachhang = d.idkhachhang
        GROUP BY 
            k.tenkhachhang
        ORDER BY 
            PhanKhuc;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dgvpk.Rows.Clear();
                    while (reader.Read())
                    {
                        dgvpk.Rows.Add(
                            reader["TenKhachHang"],
                            reader["PhanKhuc"]);
                    }
                }
            }
        }

        private void UC_Behaviour_Load(object sender, EventArgs e)
        {
            dgvgd.Columns.Clear();
            dgvgd.Columns.Add("Ngay", "Ngày");
            dgvgd.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvgd.Columns.Add("SoLanMua", "Số Lần Mua");
            dgvgd.Columns.Add("TongGiaTri", "Tổng Giá Trị");

            dgvpk.Columns.Clear();
            dgvpk.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dgvpk.Columns.Add("PhanKhuc", "Phân Khúc");

            if (chartgd.Series.IndexOf("Số Giao Dịch") >= 0)
            {
                chartgd.Series["Số Giao Dịch"].Points.Clear();
            }
            else
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Số Giao Dịch")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chartgd.Series.Add(series);
            }

            if (chartpk.Series.IndexOf("Phân Khúc Khách Hàng") < 0)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Phân Khúc Khách Hàng")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                };
                chartpk.Series.Add(series);
            }

            ThongKeMuaSam();
            PhanKhucKhachHang();
            BieuDoGiaoDich();
            BieuDoPhanKhuc();
        }

        private void btntopcus_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT TOP 1 
            k.tenkhachhang AS TenKhachHang,
            COUNT(d.iddonhang) AS SoLanMua
        FROM 
            khachhang k
        LEFT JOIN 
            donhang d ON k.idkhachhang = d.idkhachhang
        GROUP BY 
            k.tenkhachhang
        ORDER BY 
            SoLanMua DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tenKhachHang = reader["TenKhachHang"].ToString();
                        txttopcus.Text = tenKhachHang;
                    }
                    else
                    {
                        txttopcus.Text = "Không có dữ liệu khách hàng!";
                    }
                }
            }
        }
    }
}
