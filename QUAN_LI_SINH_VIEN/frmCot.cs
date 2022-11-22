using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV_TEST2
{
    public partial class frmCot : Form
    {
        private SqlConnection co = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
        public frmCot()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Lop",co);
            co.Open();
            da.Fill(dt);
            co.Close();
            MessageBox.Show("Thành công");
            chartCot.ChartAreas["ChartArea1"].AxisX.Title = "Mã lớp";
            chartCot.ChartAreas["ChartArea1"].AxisY.Title = "Sỉ số";
            chartCot.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chartCot.Series["SiSo"].Points.AddXY(dt.Rows[i]["MaLop"], dt.Rows[i]["SiSo"]);
            }
        }
    }
}
