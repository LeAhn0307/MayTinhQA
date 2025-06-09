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
using MayTinhQA.UserControls;

namespace MayTinhQA
{
    public partial class frmhanhvi : Form
    {
        private string connectionString = "Data Source=DESKTOP-2023ILB\\SQLEXPRESS01;Initial Catalog=crm;Integrated Security=True";
        public frmhanhvi()
        {
            InitializeComponent();
            chartgiaodich.Size = new Size(400, 300);
            chartphankhuc.Size = new Size(400, 300);
        }

        private void frmhanhvi_Load(object sender, EventArgs e)
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
        private void BieuDoPhanKhuc()
        {
            chartphankhuc.Series["Phân Khúc Khách Hàng"].Points.Clear();

            var colors = new Dictionary<string, Color>
    {
        { "Khong Hoat Dong", Color.Red },
        { "Moi", Color.Yellow },
        { "Trung Thanh", Color.Green }
    };

            var phanKhucCount = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dgvphankhuc.Rows)
            {
                if (row.Cells["PhanKhuc"].Value != null)
                {
                    string phanKhuc = row.Cells["PhanKhuc"].Value.ToString();
                    if (!phanKhucCount.ContainsKey(phanKhuc))
                    {
                        phanKhucCount[phanKhuc] = 0;
                    }
                    phanKhucCount[phanKhuc]++;
                }
            }
            foreach (var item in phanKhucCount)
            {
                var point = chartphankhuc.Series["Phân Khúc Khách Hàng"].Points.AddXY(item.Key, item.Value);
                if (colors.ContainsKey(item.Key))
                {
                    chartphankhuc.Series["Phân Khúc Khách Hàng"].Points[point].Color = colors[item.Key];
                    chartphankhuc.Series["Phân Khúc Khách Hàng"].Points[point].LegendText = item.Key; // Thêm chú thích
                }
                chartphankhuc.Series["Phân Khúc Khách Hàng"].Points[point].Label = item.Value.ToString();
            }

            // Thêm chú thích cho biểu đồ
            chartphankhuc.Legends.Add("Legend");
            chartphankhuc.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            chartphankhuc.Legends[0].Alignment = StringAlignment.Center;
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
                    dgvthongke.Rows.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
   
        }
    }
}
