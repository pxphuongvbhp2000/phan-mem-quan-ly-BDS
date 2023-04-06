namespace DoAnTotNghiep.Report
{
    partial class fDanhSachLichThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachLichThanhToan));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.rbHDMB = new System.Windows.Forms.RadioButton();
            this.rbPDC = new System.Windows.Forms.RadioButton();
            this.rbPGC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNgayThu = new System.Windows.Forms.CheckBox();
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
            this.gbThongTin.Controls.Add(this.rbHDMB);
            this.gbThongTin.Controls.Add(this.rbPDC);
            this.gbThongTin.Controls.Add(this.rbPGC);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.cbNgayThu);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.gbThongTin.Controls.Add(this.dtpNgayBatDau);
            this.gbThongTin.Location = new System.Drawing.Point(14, 14);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1168, 168);
            this.gbThongTin.TabIndex = 166;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Tìm Kiếm";
            // 
            // rbHDMB
            // 
            this.rbHDMB.AutoSize = true;
            this.rbHDMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHDMB.ForeColor = System.Drawing.Color.Red;
            this.rbHDMB.Location = new System.Drawing.Point(842, 39);
            this.rbHDMB.Name = "rbHDMB";
            this.rbHDMB.Size = new System.Drawing.Size(161, 20);
            this.rbHDMB.TabIndex = 167;
            this.rbHDMB.TabStop = true;
            this.rbHDMB.Text = "Hợp Đồng Mua Bán";
            this.rbHDMB.UseVisualStyleBackColor = true;
            // 
            // rbPDC
            // 
            this.rbPDC.AutoSize = true;
            this.rbPDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPDC.ForeColor = System.Drawing.Color.Red;
            this.rbPDC.Location = new System.Drawing.Point(543, 41);
            this.rbPDC.Name = "rbPDC";
            this.rbPDC.Size = new System.Drawing.Size(125, 20);
            this.rbPDC.TabIndex = 166;
            this.rbPDC.TabStop = true;
            this.rbPDC.Text = "Phiếu Đặt Cọc";
            this.rbPDC.UseVisualStyleBackColor = true;
            // 
            // rbPGC
            // 
            this.rbPGC.AutoSize = true;
            this.rbPGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPGC.ForeColor = System.Drawing.Color.Red;
            this.rbPGC.Location = new System.Drawing.Point(242, 41);
            this.rbPGC.Name = "rbPGC";
            this.rbPGC.Size = new System.Drawing.Size(125, 20);
            this.rbPGC.TabIndex = 165;
            this.rbPGC.TabStop = true;
            this.rbPGC.Text = "Phiếu Giữ Chỗ";
            this.rbPGC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 164;
            this.label1.Text = "Chọn Loại Lịch Thanh Toán";
            // 
            // cbNgayThu
            // 
            this.cbNgayThu.AutoSize = true;
            this.cbNgayThu.Location = new System.Drawing.Point(22, 80);
            this.cbNgayThu.Name = "cbNgayThu";
            this.cbNgayThu.Size = new System.Drawing.Size(88, 20);
            this.cbNgayThu.TabIndex = 163;
            this.cbNgayThu.Text = "Ngày Thu";
            this.cbNgayThu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "Đến";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(758, 80);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayKetThuc.TabIndex = 140;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(173, 80);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayBatDau.TabIndex = 139;
            // 
            // rptBieuMau
            // 
            this.rptBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptBieuMau.Location = new System.Drawing.Point(14, 203);
            this.rptBieuMau.Name = "rptBieuMau";
            this.rptBieuMau.ServerReport.BearerToken = null;
            this.rptBieuMau.Size = new System.Drawing.Size(1411, 605);
            this.rptBieuMau.TabIndex = 165;
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
            this.groupBox1.Location = new System.Drawing.Point(1190, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // fDanhSachLichThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1439, 823);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.rptBieuMau);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDanhSachLichThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lịch Thanh Toán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhSachLichThanhToan_FormClosing);
            this.Load += new System.EventHandler(this.fDanhSachLichThanhToan_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.CheckBox cbNgayThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private Microsoft.Reporting.WinForms.ReportViewer rptBieuMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHDMB;
        private System.Windows.Forms.RadioButton rbPDC;
        private System.Windows.Forms.RadioButton rbPGC;
    }
}