using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinhQA
{
    internal class Phanloaikh
    {
        public static void UpdateCustomerGroup(int idKhachHang)
        {
            string query = @"
        SELECT COUNT(*) AS OrderCount, 
               SUM(chitietdonhang.soluong * sanpham.gia) AS TotalSpent,
               MAX(donhang.ngaytao) AS LastPurchaseDate
        FROM donhang
        JOIN chitietdonhang ON donhang.iddonhang = chitietdonhang.iddonhang
        JOIN sanpham ON chitietdonhang.idsanpham = sanpham.idsanpham
        WHERE donhang.idkhachhang = " + idKhachHang;

            DataTable dt = Database.Query(query);

            if (dt.Rows.Count > 0)
            {
                int orderCount = dt.Rows[0]["OrderCount"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["OrderCount"]) : 0;
                decimal totalSpent = dt.Rows[0]["TotalSpent"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["TotalSpent"]) : 0;
                DateTime? lastPurchaseDate = dt.Rows[0]["LastPurchaseDate"] != DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["LastPurchaseDate"]) : (DateTime?)null;

                string customerGroup = "Tiềm năng";

                if (lastPurchaseDate < DateTime.Now.AddYears(-1))
                {
                    customerGroup = "Ngủ quên";
                }
                else if (orderCount > 5 && totalSpent > 30000000)
                {
                    customerGroup = "VIP";
                }
                else if (orderCount >= 3)
                {
                    customerGroup = "Trung thành";
                }
                else if (orderCount == 1)
                {
                    customerGroup = "Mới";
                }

                Database.Excute("UPDATE loaikhachhang SET loaikhachhang = N'" + customerGroup + "' WHERE idkhachhang = " + idKhachHang);
            }
        }
    }
}
