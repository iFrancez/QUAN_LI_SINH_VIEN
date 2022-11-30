using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_TEST2
{
    public class DanhSachTK
    {
        //han che loi
        private static DanhSachTK instance;
        public static DanhSachTK Instance
        {
            get
            {
                if (instance == null) instance = new DanhSachTK();
                return instance;
            }
            set => instance = value;
        }
        //
        List<Taikhoan> listTaiKhoan;

        public List<Taikhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        DanhSachTK()
        {
            listTaiKhoan = new List<Taikhoan>();
            listTaiKhoan.Add(new Taikhoan("Thanh Phap", "123456"));
            listTaiKhoan.Add(new Taikhoan("Tri", "123456"));
            listTaiKhoan.Add(new Taikhoan("Thanh", "123456"));
            listTaiKhoan.Add(new Taikhoan("Khiet", "123456"));
        }
    }
}
