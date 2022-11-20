using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_TEST2
{
    public class Taikhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }

        private string matKhau;
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public Taikhoan(string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }   
    }
}
