using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV_TEST2
{
    public partial class frmQL : Form
    {

        // Co tac dung de lam button thanh hinh Eliipse
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEliipse
            );
        //
        SqlConnection connection;
        SqlCommand command;
        //co dau / nen them @
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            //chỉnh dòng đầu ra giữa
            DtDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //chỉnh size và font thành in đậm
            DtDanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            command = connection.CreateCommand();
            command.CommandText = "select *from HocSinh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DtDanhSach.DataSource = table;

        }
        public frmQL()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //để hình thành hình bo tròn
            btnThem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 30, 30));
            btnXoa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXoa.Width, btnXoa.Height, 30, 30));
            btnSua.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSua.Width, btnSua.Height, 30, 30));
            btnTim.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTim.Width, btnTim.Height, 30, 30));
            btnXemThôngTin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXemThôngTin.Width, btnXemThôngTin.Height, 30, 30));
            btnKT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKT.Width, btnKT.Height, 30, 30));
            btnpass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnpass.Width, btnpass.Height, 30, 30));
            btnfalse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnfalse.Width, btnfalse.Height, 30, 30));
            btnAZ.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAZ.Width, btnAZ.Height, 30, 30));
            sortZA.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sortZA.Width, sortZA.Height, 30, 30));
            btnClass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClass.Width, btnClass.Height, 30, 30));
            btnExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 30, 30));
            btnDx.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDx.Width, btnDx.Height, 30, 30));
            btnKHL.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKHL.Width, btnKHL.Height, 30, 30));
            btnXL.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXL.Width, btnKHL.Height, 30, 30));
            //
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DtDanhSach.CurrentRow.Index;
            txtMaHS.Text = DtDanhSach.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = DtDanhSach.Rows[i].Cells[1].Value.ToString();
            dtNgaySinh.Text = DtDanhSach.Rows[i].Cells[2].Value.ToString();
            txtDC.Text = DtDanhSach.Rows[i].Cells[3].Value.ToString();
            txtDTB.Text = DtDanhSach.Rows[i].Cells[4].Value.ToString();
            txtMaLop.Text = DtDanhSach.Rows[i].Cells[5].Value.ToString();
            Phai.Text = DtDanhSach.Rows[i].Cells[6].Value.ToString();
        }
        // kiểm tra xem ô đó nhập hay chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtMaHS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDC.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDTB.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm trung bình của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDTB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Phai.Text))
            {
                MessageBox.Show("Bạn chưa nhập phái của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Phai.Focus();
                return false;
            }
            return true;
        }
        private void btnXemThôngTin_Click(object sender, EventArgs e)
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
            frmCapNhat f = new frmCapNhat();
            f.ShowDialog();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                command.Connection.CreateCommand();
                command.CommandText = "insert into HocSinh values('" + txtMaHS.Text + "',N'" + txtTen.Text + "','" + dtNgaySinh.Text + "',N'" + txtDC.Text + "','" + txtDTB.Text + "','" + txtMaLop.Text + "',N'" + Phai.Text + "')";
                //chi ra loi
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Thêm thành công", "Thêm");
                frmThem f = new frmThem();
                f.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from HocSinh where MaHS='" + txtMaHS.Text + "'";
            //chi ra loi
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xoá thành công", "Xoá");
            frmXoa f = new frmXoa();
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            //ko sua mahs vi do la primary key
            command.CommandText = "update HocSinh set TenHS= N'" + txtTen.Text + "', NgaySinh= '" + dtNgaySinh.Text + "',DiaChi= N'" + txtDC.Text + "',DTB= '" + txtDTB.Text + "',MaLop= '" + txtMaLop.Text + "',Phái= N'" + Phai.Text + "'where MaHS = '" + txtMaHS.Text + "'";
            command.ExecuteNonQuery(); // kiem tra lỗi nếu sai thì trỏ đến
            loaddata();
            MessageBox.Show("Sửa thành công", "Sửa");
            frmSua f = new frmSua();
            f.ShowDialog();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            txtTen.Text = "";
            dtNgaySinh.Text = "1/1/1800";
            txtDC.Text = "";
            txtDTB.Text = "";
            txtMaLop.Text = "";
            Phai.Text = "";
            MessageBox.Show("Khởi tạo thành công", "Khởi tạo");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    where u.MaHS == txtTim.Text || u.TenHS == txtTim.Text || u.DTB.ToString() == txtTim.Text || u.DiaChi == txtTim.Text || u.MaLop == txtTim.Text
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
            if (DtDanhSach.RowCount > 0) MessageBox.Show("Tìm thành công", "Tìm");
            else MessageBox.Show("Không tìm sinh viên trong danh sách", "Tìm");
        }

        private void sortAZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sắp xếp thành công", "Sort");
            frmSortAZ f = new frmSortAZ();
            f.ShowDialog();
        }

        private void sortZA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sắp xếp thành công", "Sort");
            frmSortZA f = new frmSortZA();
            f.ShowDialog();
        }
        private void btnClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sắp xếp theo lớp thành công", "Sort");
            frmClass f = new frmClass();
            f.ShowDialog();
        }
        private void btnpass_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    where u.DTB >= 4 && u.DTB <= 10
                                    orderby u.DTB ascending
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
            if (DtDanhSach.RowCount > 0) MessageBox.Show("Các sinh viên qua môn", "Pass");
            else MessageBox.Show("Không sinh viên nào qua môn", "UnPass");
            frmPass f = new frmPass();
            f.ShowDialog();
        }

        private void btnfalse_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    where u.DTB < 4 && u.DTB >= 0
                                    orderby u.DTB ascending
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
            if (DtDanhSach.RowCount > 0) MessageBox.Show("Các sinh viên không qua môn", "False");
            else MessageBox.Show("Các sinh viên đều qua môn", "Pass");
            frmRot f = new frmRot();
            f.ShowDialog();
        }
        private void btnKHL_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    where u.DTB < 0 || u.DTB > 10
                                    orderby u.DTB ascending
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
            if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên có điểm DTB không hợp lệ", "Thông báo");
            else MessageBox.Show("Tất cả sinh viên đều có điểm DTB hợp lệ", "Thông báo");
            frmKhongHopLe f = new frmKhongHopLe();
            f.ShowDialog();
        }
        private void btnXL_Click(object sender, EventArgs e)
        {
            if (cbXepLoai.Text == "Giỏi")
            {
                QLSVDataContext db = new QLSVDataContext();
                DtDanhSach.DataSource = from u in db.HocSinhs
                                        where u.DTB <= 10 && u.DTB >= 8.5
                                        orderby u.DTB ascending
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
                if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên xếp loại giỏi", "Thông báo");
                else MessageBox.Show("Không có sinh viên nào xếp loại giỏi", "Thông báo");
            }
            if (cbXepLoai.Text == "Khá")
            {
                QLSVDataContext db = new QLSVDataContext();
                DtDanhSach.DataSource = from u in db.HocSinhs
                                        where u.DTB >= 7 && u.DTB <= 8.4
                                        orderby u.DTB ascending
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
                if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên xếp loại khá", "Thông báo");
                else MessageBox.Show("Không có sinh viên nào xếp loại khá", "Thông báo");
            }
            if (cbXepLoai.Text == "Trung bình")
            {
                QLSVDataContext db = new QLSVDataContext();
                DtDanhSach.DataSource = from u in db.HocSinhs
                                        where u.DTB >= 5.5 && u.DTB <= 6.9
                                        orderby u.DTB ascending
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
                if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên xếp loại trung bình", "Thông báo");
                else MessageBox.Show("Không có sinh viên nào xếp loại trung bình", "Thông báo");
            }
            if (cbXepLoai.Text == "Trung bình yếu")
            {
                QLSVDataContext db = new QLSVDataContext();
                DtDanhSach.DataSource = from u in db.HocSinhs
                                        where u.DTB >= 4 && u.DTB <= 5.4
                                        orderby u.DTB ascending
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
                if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên xếp loại trung bình yếu", "Thông báo");
                else MessageBox.Show("Không có sinh viên nào xếp loại trung bình yếu", "Thông báo");
            }
            if (cbXepLoai.Text == "Kém")
            {
                QLSVDataContext db = new QLSVDataContext();
                DtDanhSach.DataSource = from u in db.HocSinhs
                                        where u.DTB >= 0 && u.DTB <= 3.9
                                        orderby u.DTB ascending
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
                if (DtDanhSach.RowCount > 0) MessageBox.Show("Sinh viên xếp loại kém", "Thông báo");
                else MessageBox.Show("Không có sinh viên xếp loại kém", "Thông báo");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnDX_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void inẤnDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInAn dn = new frmInAn();
            dn.ShowDialog();
        }

        private void inẤnDanhSáchTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdssvtheolop f = new frmdssvtheolop();
            f.ShowDialog();
        }

        private void inẤnDanhSáchTheoGiớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgioitinh f = new frmgioitinh();
            f.ShowDialog();
        }

        private void soLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            DtDanhSach.DataSource = from u in db.HocSinhs
                                    join y in db.Lops on u.MaLop equals y.MaLop
                                    group u by u.MaLop into d
                                    select new
                                    {
                                        SiSo = d.Count()
                                    };
        }

        private void biểuĐồCộtVàTrònTheoSỉSốCủaHọcSinhTừngLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtroncot f = new frmtroncot();
            f.ShowDialog();
        }
    }
}
