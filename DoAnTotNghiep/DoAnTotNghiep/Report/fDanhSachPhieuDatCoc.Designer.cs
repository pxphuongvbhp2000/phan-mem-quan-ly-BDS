namespace DoAnTotNghiep.Report
{
    partial class fDanhSachPhieuDatCoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachPhieuDatCoc));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cbNgayLapPhieu = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.rptBieuMau = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.cbNgayLapPhieu);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.gbThongTin.Controls.Add(this.dtpNgayBatDau);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1176, 168);
            this.gbThongTin.TabIndex = 163;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbNgayLapPhieu
            // 
            this.cbNgayLapPhieu.AutoSize = true;
            this.cbNgayLapPhieu.Location = new System.Drawing.Point(21, 51);
            this.cbNgayLapPhieu.Name = "cbNgayLapPhieu";
            this.cbNgayLapPhieu.Size = new System.Drawing.Size(125, 20);
            this.cbNgayLapPhieu.TabIndex = 163;
            this.cbNgayLapPhieu.Text = "Ngày Lập Phiếu";
            this.cbNgayLapPhieu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "Đến";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(752, 47);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayKetThuc.TabIndex = 140;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(182, 47);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayBatDau.TabIndex = 139;
            // 
            // rptBieuMau
            // 
            this.rptBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptBieuMau.Location = new System.Drawing.Point(12, 201);
            this.rptBieuMau.Name = "rptBieuMau";
            this.rptBieuMau.ServerReport.BearerToken = null;
            this.rptBieuMau.Size = new System.Drawing.Size(1431, 602);
            this.rptBieuMau.TabIndex = 162;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(47, 97);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 61);
            this.btnThoat.TabIndex = 138;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.SystemColors.Window;
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(47, 30);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(130, 61);
            this.btnThucHien.TabIndex = 139;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Location = new System.Drawing.Point(1198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 168);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // fDanhSachPhieuDatCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1455, 815);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.rptBieuMau);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDanhSachPhieuDatCoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Phiếu Đặt Cọc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhSachPhieuDatCoc_FormClosing);
            this.Load += new System.EventHandler(this.fDanhSachPhieuDatCoc_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.CheckBox cbNgayLapPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private Microsoft.Reporting.WinForms.ReportViewer rptBieuMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}