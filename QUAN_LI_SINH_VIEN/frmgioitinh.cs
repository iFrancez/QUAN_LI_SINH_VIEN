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
    public partial class frmgioitinh : Form
    {
        public frmgioitinh()
        {
            InitializeComponent();
        }

        private void frmgioitinh_Load(object sender, EventArgs e)
        {
            lblThoigan.Text = DateTime.Now.ToLongTimeString();
            lblNgay.Text = DateTime.Now.ToLongDateString();

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            this.DSsinhvientheogioitinhTableAdapter.Fill(this.QLSVDataSet1.DSsinhvientheogioitinh, txtGioiTinh.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
