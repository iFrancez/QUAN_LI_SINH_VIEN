
namespace QLSV_TEST2
{
    partial class frmtroncot
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnHC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mãLớpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBD = new QLSV_TEST2.DatabaseBD();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHT = new System.Windows.Forms.Button();
            this.sOLUONGTableAdapter = new QLSV_TEST2.DatabaseBDTableAdapters.SOLUONGTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHC
            // 
            this.btnHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHC.Location = new System.Drawing.Point(394, 640);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(141, 38);
            this.btnHC.TabIndex = 0;
            this.btnHC.Text = "Hiển thị cột";
            this.btnHC.UseVisualStyleBackColor = true;
            this.btnHC.Click += new System.EventHandler(this.btnHC_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãLớpDataGridViewTextBoxColumn,
            this.sốLượngDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sOLUONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // mãLớpDataGridViewTextBoxColumn
            // 
            this.mãLớpDataGridViewTextBoxColumn.DataPropertyName = "Mã lớp";
            this.mãLớpDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.mãLớpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãLớpDataGridViewTextBoxColumn.Name = "mãLớpDataGridViewTextBoxColumn";
            this.mãLớpDataGridViewTextBoxColumn.Width = 125;
            // 
            // sốLượngDataGridViewTextBoxColumn
            // 
            this.sốLượngDataGridViewTextBoxColumn.DataPropertyName = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sốLượngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngDataGridViewTextBoxColumn.Name = "sốLượngDataGridViewTextBoxColumn";
            this.sốLượngDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOLUONGBindingSource
            // 
            this.sOLUONGBindingSource.DataMember = "SOLUONG";
            this.sOLUONGBindingSource.DataSource = this.databaseBD;
            // 
            // databaseBD
            // 
            this.databaseBD.DataSetName = "DatabaseBD";
            this.databaseBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(40, 232);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "SiSo";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(495, 391);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "Biểu đồ cột của học sinh các lớp công nghệ thông tin";
            this.chart1.Titles.Add(title1);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(559, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 38);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHT
            // 
            this.btnHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHT.Location = new System.Drawing.Point(1009, 640);
            this.btnHT.Name = "btnHT";
            this.btnHT.Size = new System.Drawing.Size(141, 38);
            this.btnHT.TabIndex = 0;
            this.btnHT.Text = "Hiển thị tròn";
            this.btnHT.UseVisualStyleBackColor = true;
            this.btnHT.Click += new System.EventHandler(this.btnHT_Click);
            // 
            // sOLUONGTableAdapter
            // 
            this.sOLUONGTableAdapter.ClearBeforeFill = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(655, 232);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "SiSo";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(495, 391);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Title1";
            title2.Text = "Biểu đồ tròn của học sinh các lớp công nghệ thông tin";
            this.chart2.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(662, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIỂU ĐỒ THEO SỐ LƯỢNG SINH \r\nVIÊN CỦA TỪNG LỚP\r\n";
            // 
            // frmtroncot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSV_TEST2.Properties.Resources.rm222batch2_mind_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1186, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHC);
            this.Name = "frmtroncot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ cột và tròn";
            this.Load += new System.EventHandler(this.frmtroncot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHT;
        private DatabaseBD databaseBD;
        private System.Windows.Forms.BindingSource sOLUONGBindingSource;
        private DatabaseBDTableAdapters.SOLUONGTableAdapter sOLUONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãLớpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
    }
}