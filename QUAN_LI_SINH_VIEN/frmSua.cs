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
    public partial class frmSua : Form
    {
        void loaddata()
        {
            //chỉnh dòng đầu ra giữa
            DtDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //chỉnh size và font thành in đậm
            DtDanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

        }
        public frmSua()
        {
            InitializeComponent();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    select new
                                    {
                                        MaHS = u.MaHS,
                                        TenHS = u.TenHS,
                                        NgaySinh = u.NgaySinh,
                                        DiaChi = u.DiaChi,
                                        DTB = u.DTB,
                                        MaLop = u.MaLop,
                                        Phai = u.Phái
                                    };
            loaddata();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
