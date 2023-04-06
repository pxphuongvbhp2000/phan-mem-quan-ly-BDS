namespace DoAnTotNghiep.View
{
    partial class fDanhMucDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucDoanhThu));
            this.chDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chSoSanh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nNam = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDanhSachLichThanhToan = new System.Windows.Forms.Button();
            this.btnDanhSachHopDongMuaBan = new System.Windows.Forms.Button();
            this.btnDanhSachPhieuDatCoc = new System.Windows.Forms.Button();
            this.btnDanhSachPhieuGiuCho = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSoSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNam)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDoanhThu.Legends.Add(legend1);
            this.chDoanhThu.Location = new System.Drawing.Point(12, 94);
            this.chDoanhThu.Name = "chDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "vnđ";
            this.chDoanhThu.Series.Add(series1);
            this.chDoanhThu.Size = new System.Drawing.Size(1223, 358);
            this.chDoanhThu.TabIndex = 5;
            this.chDoanhThu.Text = "Biểu đồ";
            // 
            // chSoSanh
            // 
            chartArea2.Name = "ChartArea1";
            this.chSoSanh.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chSoSanh.Legends.Add(legend2);
            this.chSoSanh.Location = new System.Drawing.Point(12, 458);
            this.chSoSanh.Name = "chSoSanh";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "vnđ";
            this.chSoSanh.Series.Add(series2);
            this.chSoSanh.Size = new System.Drawing.Size(446, 358);
            this.chSoSanh.TabIndex = 13;
            this.chSoSanh.Text = "Biểu đồ";
            // 
            // nNam
            // 
            this.nNam.Location = new System.Drawing.Point(103, 21);
            this.nNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nNam.Name = "nNam";
            this.nNam.Size = new System.Drawing.Size(1089, 22);
            this.nNam.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDanhSachLichThanhToan);
            this.groupBox2.Controls.Add(this.btnDanhSachHopDongMuaBan);
            this.groupBox2.Controls.Add(this.btnDanhSachPhieuDatCoc);
            this.groupBox2.Controls.Add(this.btnDanhSachPhieuGiuCho);
            this.groupBox2.Controls.Add(this.btnThucHien);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(725, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 358);
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btnDanhSachLichThanhToan
            // 
            this.btnDanhSachLichThanhToan.BackColor = System.Drawing.SystemColors.Window;
            this.btnDanhSachLichThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachLichThanhToan.Image")));
            this.btnDanhSachLichThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachLichThanhToan.Location = new System.Drawing.Point(50, 291);
            this.btnDanhSachLichThanhToan.Name = "btnDanhSachLichThanhToan";
            this.btnDanhSachLichThanhToan.Size = new System.Drawing.Size(417, 61);
            this.btnDanhSachLichThanhToan.TabIndex = 145;
            this.btnDanhSachLichThanhToan.Text = "In Danh Sách Lịch Thanh Toán";
            this.btnDanhSachLichThanhToan.UseVisualStyleBackColor = false;
            this.btnDanhSachLichThanhToan.Click += new System.EventHandler(this.btnDanhSachLichThanhToan_Click);
            // 
            // btnDanhSachHopDongMuaBan
            // 
            this.btnDanhSachHopDongMuaBan.BackColor = System.Drawing.SystemColors.Window;
            this.btnDanhSachHopDongMuaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachHopDongMuaBan.Image")));
            this.btnDanhSachHopDongMuaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachHopDongMuaBan.Location = new System.Drawing.Point(50, 224);
            this.btnDanhSachHopDongMuaBan.Name = "btnDanhSachHopDongMuaBan";
            this.btnDanhSachHopDongMuaBan.Size = new System.Drawing.Size(417, 61);
            this.btnDanhSachHopDongMuaBan.TabIndex = 144;
            this.btnDanhSachHopDongMuaBan.Text = "In Danh Sách Hợp Đồng Mua Bán";
            this.btnDanhSachHopDongMuaBan.UseVisualStyleBackColor = false;
            this.btnDanhSachHopDongMuaBan.Click += new System.EventHandler(this.btnDanhSachHopDongMuaBan_Click);
            // 
            // btnDanhSachPhieuDatCoc
            // 
            this.btnDanhSachPhieuDatCoc.BackColor = System.Drawing.SystemColors.Window;
            this.btnDanhSachPhieuDatCoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuDatCoc.Image")));
            this.btnDanhSachPhieuDatCoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachPhieuDatCoc.Location = new System.Drawing.Point(50, 157);
            this.btnDanhSachPhieuDatCoc.Name = "btnDanhSachPhieuDatCoc";
            this.btnDanhSachPhieuDatCoc.Size = new System.Drawing.Size(417, 61);
            this.btnDanhSachPhieuDatCoc.TabIndex = 143;
            this.btnDanhSachPhieuDatCoc.Text = "In Danh Sách Phiếu Đặt Cọc";
            this.btnDanhSachPhieuDatCoc.UseVisualStyleBackColor = false;
            this.btnDanhSachPhieuDatCoc.Click += new System.EventHandler(this.btnDanhSachPhieuDatCoc_Click);
            // 
            // btnDanhSachPhieuGiuCho
            // 
            this.btnDanhSachPhieuGiuCho.BackColor = System.Drawing.SystemColors.Window;
            this.btnDanhSachPhieuGiuCho.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachPhieuGiuCho.Image")));
            this.btnDanhSachPhieuGiuCho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachPhieuGiuCho.Location = new System.Drawing.Point(50, 90);
            this.btnDanhSachPhieuGiuCho.Name = "btnDanhSachPhieuGiuCho";
            this.btnDanhSachPhieuGiuCho.Size = new System.Drawing.Size(417, 61);
            this.btnDanhSachPhieuGiuCho.TabIndex = 142;
            this.btnDanhSachPhieuGiuCho.Text = "In Danh Sách Phiếu Giữ Chỗ";
            this.btnDanhSachPhieuGiuCho.UseVisualStyleBackColor = false;
            this.btnDanhSachPhieuGiuCho.Click += new System.EventHandler(this.btnDanhSachPhieuGiuCho_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.SystemColors.Window;
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(50, 25);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(191, 61);
            this.btnThucHien.TabIndex = 139;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(278, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(189, 61);
            this.btnThoat.TabIndex = 138;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.nNam);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1223, 63);
            this.gbThongTin.TabIndex = 153;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Thống Kê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Năm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNV);
            this.groupBox1.Controls.Add(this.txtCT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(464, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 355);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Đơn Vị: VNĐ";
            // 
            // txtNV
            // 
            this.txtNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtNV.Location = new System.Drawing.Point(25, 120);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(189, 22);
            this.txtNV.TabIndex = 121;
            this.txtNV.TextChanged += new System.EventHandler(this.txtNV_TextChanged);
            // 
            // txtCT
            // 
            this.txtCT.BackColor = System.Drawing.SystemColors.Window;
            this.txtCT.Location = new System.Drawing.Point(25, 55);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(189, 22);
            this.txtCT.TabIndex = 120;
            this.txtCT.TextChanged += new System.EventHandler(this.txtCT_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Doanh Thu Của Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Doanh Thu Của Công Ty:";
            // 
            // fDanhMucDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1250, 825);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chSoSanh);
            this.Controls.Add(this.chDoanhThu);
            this.MaximizeBox = false;
            this.Name = "fDanhMucDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Doanh Thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhMucDoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.fDanhMucDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSoSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSoSanh;
        private System.Windows.Forms.NumericUpDown nNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Button btnDanhSachPhieuGiuCho;
        private System.Windows.Forms.Button btnDanhSachPhieuDatCoc;
        private System.Windows.Forms.Button btnDanhSachLichThanhToan;
        private System.Windows.Forms.Button btnDanhSachHopDongMuaBan;
        private System.Windows.Forms.Label label5;
    }
}