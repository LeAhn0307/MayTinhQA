using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA
{
    public partial class frmkhachhang : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True;Trust Server Certificate=True";
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private SqlConnection myConnection;
        private DataSet myDataSet;
        private DataTable myTable;
        private DataTable myTableLop;

        public frmkhachhang()
        {
            InitializeComponent();
        }
        private void Display()
        {
            string SqlStr = "Select * From crm";
            myDataAdapter = new SqlDataAdapter(SqlStr, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "crm");
            myTable = myDataSet.Tables["crm"];
            datagridkhach.DataSource = myTable;
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            Display();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtidkhachhang.Text = myTable.Rows[row]["idkhachhang"].ToString();
                txthovatenkhach.Text = myTable.Rows[row]["tenkhachhang"].ToString();
                dtpkhach.Value = DateTime.Parse(myTable.Rows[row]["ngaysinh"].ToString());
                txtemailkhach.Text = myTable.Rows[row]["email"].ToString();
                txtdiachikhach.Text = myTable.Rows[row]["diachi"].ToString();
                txtsdtkhach.Text = myTable.Rows[row]["dienthoai"].ToString();
            }
            catch (Exception) { }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra tên diễn viên nhập chưa:
            if (txthovatenkhach.Text == "")
            {
                MessageBox.Show("Tên diễn viên chưa có.", "Thông báo lỗi");
                txthovatenkhach.Focus();
                return;
            }

            try
            {
                string sSql = "";
                sSql = "Insert Into khachhang (tenkhachhang, email, dienthoai, diachi, ngaysinh)" +
                "Values (N'" + txthovatenkhach.Text + "', '" + dtpkhach.Value.ToString("MM/dd/yyyy") + txtemailkhach.Text + "', '" + txtsdtkhach.Text + "', '" + txtdiachikhach.Text + "')";

                myCommand = new SqlCommand(sSql, myConnection);
                myCommand.ExecuteNonQuery();
                Display();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập.", "Có lỗi xẩy ra!");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtidkhachhang.Text == "")
            {
                MessageBox.Show("Mã diễn viên chưa có.", "Thông báo lỗi");
                txtidkhachhang.Focus();
                return;
            }
            try
            {
                string sSql1 = "Delete From congno Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql1, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql2 = "Delete From chitietdonhang Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql2, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql3 = "Delete From danhmuc Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql3, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql4 = "Delete From dichvu Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql4, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql5 = "Delete From donhang Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql5, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql6 = "Delete From giaodich Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql6, myConnection);
                myCommand.ExecuteNonQuery();
                string sSql7 = "Delete From hoadon Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql7, myConnection);
                myCommand.ExecuteNonQuery();
                //Xoa dòng diễn viên
                string sSql8 = "Delete From khachhang Where idkhachhang = " + txtidkhachhang.Text;
                myCommand = new SqlCommand(sSql8, myConnection);
                myCommand.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Có lỗi dữ liệu. Bạn không thể xóa.", "Thông báo lỗi");
            }
            Display();
        }
    }
}
