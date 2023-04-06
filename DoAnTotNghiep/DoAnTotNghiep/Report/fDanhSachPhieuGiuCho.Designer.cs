namespace DoAnTotNghiep.Report
{
    partial class fDanhSachPhieuGiuCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachPhieuGiuCho));
            this.rptBieuMau = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cbNgayLapPhieu = new System.Windows.Forms.CheckBox();
            this.cbBatDongSan = new System.Windows.Forms.CheckBox();
            this.cbbBDS = new System.Windows.Forms.ComboBox();
            this.txtIDBDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptBieuMau
            // 
            this.rptBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptBieuMau.Location = new System.Drawing.Point(12, 201);
            this.rptBieuMau.Name = "rptBieuMau";
            this.rptBieuMau.ServerReport.BearerToken = null;
            this.rptBieuMau.Size = new System.Drawing.Size(1421, 605);
            this.rptBieuMau.TabIndex = 0;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.cbNgayLapPhieu);
            this.gbThongTin.Controls.Add(this.cbBatDongSan);
            this.gbThongTin.Controls.Add(this.cbbBDS);
            this.gbThongTin.Controls.Add(this.txtIDBDS);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.gbThongTin.Controls.Add(this.dtpNgayBatDau);
            this.gbThongTin.Location = new System.Drawing.Point(22, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1168, 168);
            this.gbThongTin.TabIndex = 151;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbNgayLapPhieu
            // 
            this.cbNgayLapPhieu.AutoSize = true;
            this.cbNgayLapPhieu.Location = new System.Drawing.Point(20, 73);
            this.cbNgayLapPhieu.Name = "cbNgayLapPhieu";
            this.cbNgayLapPhieu.Size = new System.Drawing.Size(125, 20);
            this.cbNgayLapPhieu.TabIndex = 163;
            this.cbNgayLapPhieu.Text = "Ngày Lập Phiếu";
            this.cbNgayLapPhieu.UseVisualStyleBackColor = true;
            // 
            // cbBatDongSan
            // 
            this.cbBatDongSan.AutoSize = true;
            this.cbBatDongSan.Location = new System.Drawing.Point(20, 30);
            this.cbBatDongSan.Name = "cbBatDongSan";
            this.cbBatDongSan.Size = new System.Drawing.Size(111, 20);
            this.cbBatDongSan.TabIndex = 161;
            this.cbBatDongSan.Text = "Bất Động Sản";
            this.cbBatDongSan.UseVisualStyleBackColor = true;
            // 
            // cbbBDS
            // 
            this.cbbBDS.FormattingEnabled = true;
            this.cbbBDS.Location = new System.Drawing.Point(317, 27);
            this.cbbBDS.Name = "cbbBDS";
            this.cbbBDS.Size = new System.Drawing.Size(838, 24);
            this.cbbBDS.TabIndex = 160;
            this.cbbBDS.SelectedIndexChanged += new System.EventHandler(this.cbbBDS_SelectedIndexChanged);
            // 
            // txtIDBDS
            // 
            this.txtIDBDS.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDBDS.Location = new System.Drawing.Point(181, 27);
            this.txtIDBDS.Name = "txtIDBDS";
            this.txtIDBDS.ReadOnly = true;
            this.txtIDBDS.Size = new System.Drawing.Size(130, 22);
            this.txtIDBDS.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 141;
            this.label5.Text = "Đến";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(751, 69);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayKetThuc.TabIndex = 140;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(181, 69);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(404, 22);
            this.dtpNgayBatDau.TabIndex = 139;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Location = new System.Drawing.Point(1198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // fDanhSachPhieuGiuCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1445, 818);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.rptBieuMau);
            this.Name = "fDanhSachPhieuGiuCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu Phiếu Giữ Chỗ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhSachPhieuGiuCho_FormClosing);
            this.Load += new System.EventHandler(this.fDanhSachPhieuGiuCho_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBieuMau;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbBDS;
        private System.Windows.Forms.TextBox txtIDBDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBatDongSan;
        private System.Windows.Forms.CheckBox cbNgayLapPhieu;
    }
}