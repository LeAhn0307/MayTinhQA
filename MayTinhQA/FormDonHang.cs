using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA
{
    public partial class frmdonhang : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True;";
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private SqlConnection myConnection;
        private DataSet myDataSet;
        private DataTable myTable;
        private DataTable myTableLop;
        public frmdonhang()
        {
            InitializeComponent();
        }
        private void Display()
        {
            string SqlStr = @"SELECT 
    chitietdonhang.idchitietdh,
    khachhang.tenkhachhang,
    sanpham.tensanpham,
    chitietdonhang.soluong,
    FORMAT(sanpham.gia, 'N0', 'vi-VN') AS DonGia,
    FORMAT((chitietdonhang.soluong * sanpham.gia), 'N0', 'vi-VN') AS ThanhTien,
    donhang.trangthai
FROM chitietdonhang
JOIN donhang ON donhang.iddonhang = chitietdonhang.iddonhang
JOIN khachhang ON khachhang.idkhachhang = chitietdonhang.idkhachhang
JOIN sanpham ON sanpham.idsanpham = chitietdonhang.idsanpham";
            myDataAdapter = new SqlDataAdapter(SqlStr, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "donhang");
            myTable = myDataSet.Tables["donhang"];
            datagriddonhang.DataSource = myTable;
            foreach (DataGridViewRow row in datagriddonhang.Rows)
            {
                string status = row.Cells["trangthai"].Value?.ToString();

                if (status == "Đang chờ xác nhận")
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                else if (status == "Chờ thanh toán")
                    row.DefaultCellStyle.BackColor = Color.Orange;
                else if (status == "Đã thanh toán")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txthovatenkhach.Text == "")
            {
                MessageBox.Show("Tên khach chưa có.", "Thông báo lỗi");
                txthovatenkhach.Focus();
                return;
            }

            try
            {
                EnsureConnectionOpen();
                string sql1 = @"INSERT INTO donhang(trangthai, idkhachhang) 
                        VALUES(N'Chờ thanh toán', (SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'" + txthovatenkhach.Text + "'))";
                myCommand = new SqlCommand(sql1, myConnection);
                myCommand.ExecuteNonQuery();

                string sql2 = @"INSERT INTO chitietdonhang(iddonhang, idkhachhang, idsanpham, soluong)
                VALUES ((SELECT TOP 1 iddonhang FROM donhang WHERE idkhachhang = (SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'" + txthovatenkhach.Text + "') ORDER BY iddonhang DESC),(SELECT idkhachhang FROM khachhang WHERE tenkhachhang = N'" + txthovatenkhach.Text + "'), (SELECT idsanpham FROM sanpham WHERE tensanpham = N'" + txtsanpham.Text + "')," + txtsoluong.Text + ")";
                myCommand = new SqlCommand(sql2, myConnection);
                myCommand.ExecuteNonQuery();

            
                Display();
                MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập.", "Có lỗi xẩy ra!");
            }
        }

        

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            Display();
        }

        private void datagriddonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idchitietdh = datagriddonhang.Rows[e.RowIndex].Cells["idchitietdh"].Value.ToString();
                string tenkhachhang = datagriddonhang.Rows[e.RowIndex].Cells["tenkhachhang"].Value.ToString();
                string tensanpham = datagriddonhang.Rows[e.RowIndex].Cells["tensanpham"].Value.ToString();
                string soLuong = datagriddonhang.Rows[e.RowIndex].Cells["soluong"].Value.ToString();
                string donGia = datagriddonhang.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                string thanhTien = datagriddonhang.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();

                txtiddonhang.Text = idchitietdh;
                txthovatenkhach.Text = tenkhachhang;
                txtsanpham.Text = tensanpham;
                txtsoluong.Text = soLuong;
            }
        }

        private void datagriddonhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void EnsureConnectionOpen()
        {
            if (myConnection == null)
                myConnection = new SqlConnection(connectionString);
            if (myConnection.State != ConnectionState.Open)
                myConnection.Open();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            EnsureConnectionOpen();
            if (txthovatenkhach.Text == "")
            {
                MessageBox.Show("Ten khach hang chưa có.", "Thông báo lỗi");
                txthovatenkhach.Focus();
                return;
            }
            try
            {
                string sSql1 = "Delete From giaodich Where idchitietdh = " + txtiddonhang.Text;
                myCommand = new SqlCommand(sSql1, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql2 = "Delete From hoadon Where idchitietdh = " + txtiddonhang.Text;
                myCommand = new SqlCommand(sSql2, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql3 = "Delete From chitietdonhang Where idchitietdh = " + txtiddonhang.Text;
                myCommand = new SqlCommand(sSql3, myConnection);
                myCommand.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Có lỗi dữ liệu. Bạn không thể xóa.", "Thông báo lỗi");
            }
            Display();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureConnectionOpen();
                string queryId = "SELECT idkhachhang FROM chitietdonhang WHERE idchitietdh = @idchitiet";
                SqlCommand cmd = new SqlCommand(queryId, myConnection);
                cmd.Parameters.AddWithValue("@idchitiet", txtiddonhang.Text);
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng cho đơn hàng đã chọn.", "Lỗi");
                    return;
                }
                int idKhach = Convert.ToInt32(result);

                Phanloaikh.UpdateCustomerGroup(idKhach); 

                MessageBox.Show("Đã xác nhận!", "Thông báo");


                string queryUpdateTrangThai = @"UPDATE donhang
                                        SET trangthai = N'Đã thanh toán'
                                        WHERE iddonhang = (SELECT iddonhang FROM chitietdonhang WHERE idchitietdh = @idct)";
                SqlCommand cmdTrangThai = new SqlCommand(queryUpdateTrangThai, myConnection);
                cmdTrangThai.Parameters.AddWithValue("@idct", txtiddonhang.Text);
                cmdTrangThai.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi");
            }
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            if (datagriddonhang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để gửi.", "Thông báo");
                return;
            }

            try
            {
                EnsureConnectionOpen();


                int idDonHang = Convert.ToInt32(datagriddonhang.SelectedRows[0].Cells["iddonhang"].Value);


                string queryIdKhach = "SELECT idkhachhang FROM chitietdonhang WHERE idchitietdonhang = @id";
                SqlCommand cmdIdKhach = new SqlCommand(queryIdKhach, myConnection);
                cmdIdKhach.Parameters.AddWithValue("@id", idDonHang);
                int idKhach = Convert.ToInt32(cmdIdKhach.ExecuteScalar());


                string queryEmail = "SELECT email FROM khachhang WHERE idkhachhang = @idkhach";
                SqlCommand cmdEmail = new SqlCommand(queryEmail, myConnection);
                cmdEmail.Parameters.AddWithValue("@idkhach", idKhach);
                string emailKhach = cmdEmail.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(emailKhach))
                {
                    MessageBox.Show("Không tìm thấy email khách hàng!", "Lỗi");
                    return;
                }


                string queryChiTiet = @"SELECT s.tensanpham, c.soluong
                                FROM chitietdonhang c
                                JOIN sanpham s ON c.idsanpham = s.idsanpham
                                WHERE c.iddonhang = @iddonhang";

                SqlCommand cmdCT = new SqlCommand(queryChiTiet, myConnection);
                cmdCT.Parameters.AddWithValue("@iddonhang", idDonHang);

                SqlDataReader reader = cmdCT.ExecuteReader();
                string body = $"Thông tin đơn hàng #{idDonHang}:\n\n";

                while (reader.Read())
                {
                    string tenSP = reader.GetString(0);
                    int soLuong = reader.GetInt32(1);
                    body += $"Sản phẩm: {tenSP}\nSố lượng: {soLuong}\n\n";
                }

                reader.Close();


                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your_email@example.com");
                mail.To.Add(emailKhach);
                mail.Subject = $"Đơn hàng #{idDonHang} của bạn";
                mail.Body = body;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("your_email@example.com", "your_app_password");
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);

                MessageBox.Show("Đã gửi đơn hàng cho khách!", "Thành công");


                string updateTrangThai = "UPDATE donhang SET trangthai = N'Chờ thanh toán' WHERE iddonhang = @iddonhang";
                SqlCommand cmdUpdate = new SqlCommand(updateTrangThai, myConnection);
                cmdUpdate.Parameters.AddWithValue("@iddonhang", idDonHang);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Lỗi");
            }
        }

    }
}

