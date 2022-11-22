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
    public partial class frmdssvtheolop : Form
    {
        public frmdssvtheolop()
        {
            InitializeComponent();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            this.DSsinhvientheolopTableAdapter.Fill(this.dssinhvien_lop.DSsinhvientheolop,txtLop.Text);
            this.reportViewer1.RefreshReport();
        }

        private void frmdssvtheolop_Load(object sender, EventArgs e)
        {
            lblThoigan.Text = DateTime.Now.ToLongTimeString();
            lblNgay.Text = DateTime.Now.ToLongDateString();
        }
    }
}
