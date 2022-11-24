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
    public partial class frmtroncot : Form
    {
        public frmtroncot()
        {
            InitializeComponent();
        }

        private void frmtroncot_Load(object sender, EventArgs e)
        {
            this.sOLUONGTableAdapter.Fill(this.databaseBD.SOLUONG);

        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            //chèn dữ liệu
            chart1.Series["SiSo"].XValueMember = "Mã lớp";
            chart1.Series["SiSo"].YValueMembers = "Số lượng";
            //chèn tiêu đề
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã lớp";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Sỉ số";
            chart1.Series["SiSo"]["DrawingStyle"] = "Cylinder"; //ve cot theo font cylinder
            chart1.DataSource = databaseBD.SOLUONG;
            chart1.DataBind();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                sOLUONGBindingSource.EndEdit();
                sOLUONGTableAdapter.Update(databaseBD.SOLUONG);
                MessageBox.Show("Dữ liệu của bạn đã được lưu. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            //chèn dữ liệu
            chart2.Series["SiSo"].XValueMember = "Mã lớp";
            chart2.Series["SiSo"].YValueMembers = "Số lượng";
            //chèn tiêu đề
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã lớp";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Sỉ số";
            chart2.DataSource = databaseBD.SOLUONG;
            chart2.DataBind();
        }
    }
}
