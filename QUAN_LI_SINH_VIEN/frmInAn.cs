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
using Microsoft.Reporting.WinForms;

namespace QLSV_TEST2
{
    public partial class frmInAn : Form
    {
        SqlConnection connection;
        //SqlCommand cmd;
        SqlDataAdapter myda;
        DataSet dtSet;
        public frmInAn()
        {
            InitializeComponent();
        }
        DataSet ReadDataSet(String sql)
        {
            dtSet = new DataSet();//khoi tao doi tuong dataset
            //khoi tao doi tuong dataadapter va cung cap vao cau lenh sql va connection
            myda = new SqlDataAdapter(sql, connection);
            //dung phuong thuc fill cua DataAdapter để đổ dữ liệu từ Datasource tới dataset
            myda.Fill(dtSet);
            //gan du lieu tu dataset lên datagridview
            return dtSet;
        }

        private void frmInAn_Load(object sender, EventArgs e)
        {
            lblThoigan.Text = DateTime.Now.ToLongTimeString();
            lblNgay.Text = DateTime.Now.ToLongDateString();
            connection = new SqlConnection();//khoi tao doi tuong connection
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            //đọc liệu trên dataset
            string sql;
            sql = "Select * from HocSinh";//cmd
            DataSet ds;
            ds = ReadDataSet(sql);//đọc dữ liệu
            //Khai báo chế độ xử lí báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //che do xem report
            reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);//đặt chế độ xem trước khi in
            reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer2.ZoomPercent = 100;
            //nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HocSinh"; // ten dataset phải trùng với tên thiết kế trong datasource
                rds.Value = ds.Tables[0];// dữ liệu bảng 0 trong dataset trong bộ nhớ => table HocSinh
                //xoá dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer2.LocalReport.DataSources.Clear();
                //add dữ liệu vào báo cáo 
                reportViewer2.LocalReport.DataSources.Add(rds);
                //refresh lại báo cáo
                reportViewer2.RefreshReport();// cập nhật dữ liệu mới nhất lên report
            }
        }
    }
}