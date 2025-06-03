using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinhQA
{
    public class TaiKhoan 
    {
        public string tentaikhoan;
        public string matkhau;
        public string email;
        public int idvaitro;
        public int idusers;

        public TaiKhoan(int idusers, string tentaikhoan, string matkhau, string email, int idvaitro)
        {
            this.idusers = idusers;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.idvaitro = idvaitro;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Email { get => email; set => email = value; }

        public int Idvaitro { get => idvaitro; set => idvaitro = value; }
        public int Idusers { get => idusers; set => idusers = value; }
    }
}
