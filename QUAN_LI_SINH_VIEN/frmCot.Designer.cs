
namespace QLSV_TEST2
{
    partial class frmCot
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLoad.Location = new System.Drawing.Point(1007, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 41);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Hiển thị";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chartCot
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCot.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCot.Legends.Add(legend2);
            this.chartCot.Location = new System.Drawing.Point(48, 53);
            this.chartCot.Name = "chartCot";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "SiSo";
            this.chartCot.Series.Add(series2);
            this.chartCot.Size = new System.Drawing.Size(1071, 711);
            this.chartCot.TabIndex = 1;
            this.chartCot.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Title1";
            title2.Text = "Biểu đồ cột";
            this.chartCot.Titles.Add(title2);
            // 
            // frmCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSV_TEST2.Properties.Resources.rm222batch2_mind_03;
            this.ClientSize = new System.Drawing.Size(1147, 792);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chartCot);
            this.Name = "frmCot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu đồ cột";
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
    }
}