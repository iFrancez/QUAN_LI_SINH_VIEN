
namespace QLSV_TEST2
{
    partial class frmMenu
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
            this.btnDN = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.PictureBox();
            this.btnThanhVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDN.ForeColor = System.Drawing.Color.Black;
            this.btnDN.Location = new System.Drawing.Point(327, 155);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(154, 52);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnGT
            // 
            this.btnGT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGT.ForeColor = System.Drawing.Color.Black;
            this.btnGT.Location = new System.Drawing.Point(327, 212);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(154, 52);
            this.btnGT.TabIndex = 1;
            this.btnGT.Text = "Hướng dẫn";
            this.btnGT.UseVisualStyleBackColor = false;
            this.btnGT.Click += new System.EventHandler(this.btnGT_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(327, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_
            // 
            this.btn_.Image = global::QLSV_TEST2.Properties.Resources.minimize;
            this.btn_.Location = new System.Drawing.Point(694, 12);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(45, 45);
            this.btn_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_.TabIndex = 1;
            this.btn_.TabStop = false;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // btnX
            // 
            this.btnX.Image = global::QLSV_TEST2.Properties.Resources.close;
            this.btnX.Location = new System.Drawing.Point(743, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(45, 45);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnX.TabIndex = 1;
            this.btnX.TabStop = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhVien.ForeColor = System.Drawing.Color.Black;
            this.btnThanhVien.Location = new System.Drawing.Point(327, 269);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(154, 52);
            this.btnThanhVien.TabIndex = 1;
            this.btnThanhVien.Text = "Thành viên";
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSV_TEST2.Properties.Resources.rm222batch2_mind_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThanhVien);
            this.Controls.Add(this.btnGT);
            this.Controls.Add(this.btnDN);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.btn_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox btn_;
        private System.Windows.Forms.PictureBox btnX;
        private System.Windows.Forms.Button btnThanhVien;
    }
}