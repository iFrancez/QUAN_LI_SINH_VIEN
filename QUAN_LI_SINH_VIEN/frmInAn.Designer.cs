namespace QLSV_TEST2
{
    partial class frmInAn
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
            this.HocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblThoigan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QLSVDataSet = new QLSV_TEST2.QLSVDataSet();
            this.HocSinhTableAdapter = new QLSV_TEST2.QLSVDataSetTableAdapters.HocSinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM IN ẤN";
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "HocSinh";
            reportDataSource1.Value = this.HocSinhBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QLSV_TEST2.rpInAn.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 44);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1375, 583);
            this.reportViewer2.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgay.Location = new System.Drawing.Point(117, 650);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 20);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày";
            // 
            // lblThoigan
            // 
            this.lblThoigan.AutoSize = true;
            this.lblThoigan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoigan.Location = new System.Drawing.Point(117, 630);
            this.lblThoigan.Name = "lblThoigan";
            this.lblThoigan.Size = new System.Drawing.Size(77, 20);
            this.lblThoigan.TabIndex = 2;
            this.lblThoigan.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(16, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian:";
            // 
            // QLSVDataSet
            // 
            this.QLSVDataSet.DataSetName = "QLSVDataSet";
            this.QLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HocSinhTableAdapter
            // 
            this.HocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmInAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThoigan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label1);
            this.Name = "frmInAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmInAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource HocSinhBindingSource;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblThoigan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private QLSVDataSet QLSVDataSet;
        private QLSVDataSetTableAdapters.HocSinhTableAdapter HocSinhTableAdapter;
    }
}