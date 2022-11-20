using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_TEST2
{
    public partial class frmDN : Form
    {
        //list thong qua class DanhSachTK
        List<Taikhoan> taikhoanList = DanhSachTK.Instance.ListTaiKhoan;

        public frmDN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes) this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes) this.Close();
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //đăng nhập 
        private void btnDN_Click(object sender, EventArgs e)
        {
            //neu kiem tra == true
            if (kiemtraDangNhap(txtTK.Text,txtMK.Text))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                frmQL f = new frmQL();
                f.ShowDialog(); //hiện chương trình và không thao tác được với form đăng nhập khi chưa thoát form qlsv
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi");
                txtTK.Focus();//chọn ô TK
            }
        }
        bool kiemtraDangNhap(string t,string p)
        {
            for(int i = 0; i < taikhoanList.Count; i++)
            {
                if(t == taikhoanList[i].TenTaiKhoan&&p == taikhoanList[i].MatKhau)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
