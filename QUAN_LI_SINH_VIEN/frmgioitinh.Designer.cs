
namespace QLSV_TEST2
{
    partial class frmgioitinh
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
            this.DSsinhvientheogioitinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSVDataSet1 = new QLSV_TEST2.QLSVDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btntim = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DSsinhvientheogioitinhTableAdapter = new QLSV_TEST2.QLSVDataSet1TableAdapters.DSsinhvientheogioitinhTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThoigan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheogioitinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DSsinhvientheogioitinhBindingSource
            // 
            this.DSsinhvientheogioitinhBindingSource.DataMember = "DSsinhvientheogioitinh";
            this.DSsinhvientheogioitinhBindingSource.DataSource = this.QLSVDataSet1;
            // 
            // QLSVDataSet1
            // 
            this.QLSVDataSet1.DataSetName = "QLSVDataSet1";
            this.QLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSsinhviengioitinh";
            reportDataSource1.Value = this.DSsinhvientheogioitinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV_TEST2.rptdssinhvientheogioitinh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(721, 23);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 39);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.Location = new System.Drawing.Point(443, 27);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(220, 30);
            this.txtGioiTinh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập giới tính";
            // 
            // DSsinhvientheogioitinhTableAdapter
            // 
            this.DSsinhvientheogioitinhTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian:";
            // 
            // lblThoigan
            // 
            this.lblThoigan.AutoSize = true;
            this.lblThoigan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoigan.Location = new System.Drawing.Point(113, 626);
            this.lblThoigan.Name = "lblThoigan";
            this.lblThoigan.Size = new System.Drawing.Size(77, 20);
            this.lblThoigan.TabIndex = 9;
            this.lblThoigan.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgay.Location = new System.Drawing.Point(113, 646);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 20);
            this.lblNgay.TabIndex = 11;
            this.lblNgay.Text = "Ngày";
            // 
            // frmgioitinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThoigan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmgioitinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên theo giới tính";
            this.Load += new System.EventHandler(this.frmgioitinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSsinhvientheogioitinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource DSsinhvientheogioitinhBindingSource;
        private QLSVDataSet1 QLSVDataSet1;
        private QLSVDataSet1TableAdapters.DSsinhvientheogioitinhTableAdapter DSsinhvientheogioitinhTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThoigan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgay;
    }
}