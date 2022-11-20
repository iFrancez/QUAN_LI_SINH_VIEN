
namespace QLSV_TEST2
{
    partial class frmPass
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
            this.DtDanhSach = new System.Windows.Forms.DataGridView();
            this.btnQL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQL)).BeginInit();
            this.SuspendLayout();
            // 
            // DtDanhSach
            // 
            this.DtDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtDanhSach.Location = new System.Drawing.Point(0, 0);
            this.DtDanhSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtDanhSach.Name = "DtDanhSach";
            this.DtDanhSach.RowHeadersWidth = 51;
            this.DtDanhSach.RowTemplate.Height = 24;
            this.DtDanhSach.Size = new System.Drawing.Size(935, 590);
            this.DtDanhSach.TabIndex = 0;
            // 
            // btnQL
            // 
            this.btnQL.Image = global::QLSV_TEST2.Properties.Resources.quaylai;
            this.btnQL.Location = new System.Drawing.Point(878, 536);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(45, 42);
            this.btnQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQL.TabIndex = 1;
            this.btnQL.TabStop = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 590);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.DtDanhSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qua môn";
            this.Load += new System.EventHandler(this.frmPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtDanhSach;
        private System.Windows.Forms.PictureBox btnQL;
    }
}