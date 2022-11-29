
namespace QLSV_TEST2
{
    partial class frmdssvtheolop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DSsinhvientheolopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dssinhvien_lop = new QLSV_TEST2.dssinhvien_lop();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.lblThoigan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.DSsinhvientheolopTableAdapter = new QLSV_TEST2.dssinhvien_lopTableAdapters.DSsinhvientheolopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheolopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien_lop)).BeginInit();
            this.SuspendLayout();
            // 
            // DSsinhvientheolopBindingSource
            // 
            this.DSsinhvientheolopBindingSource.DataMember = "DSsinhvientheolop";
            this.DSsinhvientheolopBindingSource.DataSource = this.dssinhvien_lop;
            // 
            // dssinhvien_lop
            // 
            this.dssinhvien_lop.DataSetName = "dssinhvien_lop";
            this.dssinhvien_lop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã lớp";
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLop.Location = new System.Drawing.Point(441, 37);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(220, 30);
            this.txtLop.TabIndex = 1;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(719, 33);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 39);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // lblThoigan
            // 
            this.lblThoigan.AutoSize = true;
            this.lblThoigan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoigan.Location = new System.Drawing.Point(113, 632);
            this.lblThoigan.Name = "lblThoigan";
            this.lblThoigan.Size = new System.Drawing.Size(77, 20);
            this.lblThoigan.TabIndex = 5;
            this.lblThoigan.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgay.Location = new System.Drawing.Point(113, 652);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 20);
            this.lblNgay.TabIndex = 7;
            this.lblNgay.Text = "Ngày";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSsinhvientheolop";
            reportDataSource1.Value = this.DSsinhvientheolopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV_TEST2.rptdssvtheolop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1150, 525);
            this.reportViewer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian:";
            // 
            // DSsinhvientheolopTableAdapter
            // 
            this.DSsinhvientheolopTableAdapter.ClearBeforeFill = true;
            // 
            // frmdssvtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThoigan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label1);
            this.Name = "frmdssvtheolop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên theo lớp";
            this.Load += new System.EventHandler(this.frmdssvtheolop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheolopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien_lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label lblThoigan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSsinhvientheolopBindingSource;
        private dssinhvien_lop dssinhvien_lop;
        private System.Windows.Forms.Label label3;
        private dssinhvien_lopTableAdapters.DSsinhvientheolopTableAdapter DSsinhvientheolopTableAdapter;
    }
}