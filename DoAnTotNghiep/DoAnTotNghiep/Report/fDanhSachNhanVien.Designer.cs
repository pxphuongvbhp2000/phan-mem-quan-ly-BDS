namespace DoAnTotNghiep.Report
{
    partial class fDanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachNhanVien));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.CheckBox();
            this.cbPhongBan = new System.Windows.Forms.CheckBox();
            this.cbbTenChucVu = new System.Windows.Forms.ComboBox();
            this.cbbTenPhongBan = new System.Windows.Forms.ComboBox();
            this.cbbTenChiNhanh = new System.Windows.Forms.ComboBox();
            this.txtIdChiNhanh = new System.Windows.Forms.TextBox();
            this.txtIdChucVu = new System.Windows.Forms.TextBox();
            this.txtIdPhongBan = new System.Windows.Forms.TextBox();
            this.cbChiNhanh = new System.Windows.Forms.CheckBox();
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
            this.gbThongTin.Controls.Add(this.cbChucVu);
            this.gbThongTin.Controls.Add(this.cbPhongBan);
            this.gbThongTin.Controls.Add(this.cbbTenChucVu);
            this.gbThongTin.Controls.Add(this.cbbTenPhongBan);
            this.gbThongTin.Controls.Add(this.cbbTenChiNhanh);
            this.gbThongTin.Controls.Add(this.txtIdChiNhanh);
            this.gbThongTin.Controls.Add(this.txtIdChucVu);
            this.gbThongTin.Controls.Add(this.txtIdPhongBan);
            this.gbThongTin.Controls.Add(this.cbChiNhanh);
            this.gbThongTin.Location = new System.Drawing.Point(15, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1168, 168);
            this.gbThongTin.TabIndex = 166;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbChucVu
            // 
            this.cbChucVu.AutoSize = true;
            this.cbChucVu.Location = new System.Drawing.Point(28, 80);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(78, 20);
            this.cbChucVu.TabIndex = 174;
            this.cbChucVu.Text = "Chức Vụ";
            this.cbChucVu.UseVisualStyleBackColor = true;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.AutoSize = true;
            this.cbPhongBan.Location = new System.Drawing.Point(28, 54);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(95, 20);
            this.cbPhongBan.TabIndex = 173;
            this.cbPhongBan.Text = "Phòng Ban";
            this.cbPhongBan.UseVisualStyleBackColor = true;
            // 
            // cbbTenChucVu
            // 
            this.cbbTenChucVu.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTenChucVu.FormattingEnabled = true;
            this.cbbTenChucVu.Location = new System.Drawing.Point(316, 80);
            this.cbbTenChucVu.Name = "cbbTenChucVu";
            this.cbbTenChucVu.Size = new System.Drawing.Size(835, 24);
            this.cbbTenChucVu.TabIndex = 172;
            this.cbbTenChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbTenChucVu_SelectedIndexChanged);
            // 
            // cbbTenPhongBan
            // 
            this.cbbTenPhongBan.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTenPhongBan.FormattingEnabled = true;
            this.cbbTenPhongBan.Location = new System.Drawing.Point(317, 50);
            this.cbbTenPhongBan.Name = "cbbTenPhongBan";
            this.cbbTenPhongBan.Size = new System.Drawing.Size(835, 24);
            this.cbbTenPhongBan.TabIndex = 171;
            this.cbbTenPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbbTenPhongBan_SelectedIndexChanged);
            // 
            // cbbTenChiNhanh
            // 
            this.cbbTenChiNhanh.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTenChiNhanh.FormattingEnabled = true;
            this.cbbTenChiNhanh.Location = new System.Drawing.Point(316, 23);
            this.cbbTenChiNhanh.Name = "cbbTenChiNhanh";
            this.cbbTenChiNhanh.Size = new System.Drawing.Size(835, 24);
            this.cbbTenChiNhanh.TabIndex = 170;
            this.cbbTenChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbTenChiNhanh_SelectedIndexChanged);
            // 
            // txtIdChiNhanh
            // 
            this.txtIdChiNhanh.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdChiNhanh.Location = new System.Drawing.Point(159, 23);
            this.txtIdChiNhanh.Name = "txtIdChiNhanh";
            this.txtIdChiNhanh.Size = new System.Drawing.Size(140, 22);
            this.txtIdChiNhanh.TabIndex = 165;
            // 
            // txtIdChucVu
            // 
            this.txtIdChucVu.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdChucVu.Location = new System.Drawing.Point(160, 80);
            this.txtIdChucVu.Name = "txtIdChucVu";
            this.txtIdChucVu.Size = new System.Drawing.Size(140, 22);
            this.txtIdChucVu.TabIndex = 169;
            // 
            // txtIdPhongBan
            // 
            this.txtIdPhongBan.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdPhongBan.Location = new System.Drawing.Point(160, 52);
            this.txtIdPhongBan.Name = "txtIdPhongBan";
            this.txtIdPhongBan.Size = new System.Drawing.Size(140, 22);
            this.txtIdPhongBan.TabIndex = 167;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.AutoSize = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(27, 25);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(90, 20);
            this.cbChiNhanh.TabIndex = 163;
            this.cbChiNhanh.Text = "Chi Nhánh";
            this.cbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rptBieuMau
            // 
            this.rptBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptBieuMau.Location = new System.Drawing.Point(15, 201);
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
            this.groupBox1.Location = new System.Drawing.Point(1191, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // fDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1440, 818);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.rptBieuMau);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDanhSachNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhSachNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.fDanhSachNhanVien_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.CheckBox cbChiNhanh;
        private Microsoft.Reporting.WinForms.ReportViewer rptBieuMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenChucVu;
        private System.Windows.Forms.ComboBox cbbTenPhongBan;
        private System.Windows.Forms.ComboBox cbbTenChiNhanh;
        private System.Windows.Forms.TextBox txtIdChiNhanh;
        private System.Windows.Forms.TextBox txtIdChucVu;
        private System.Windows.Forms.TextBox txtIdPhongBan;
        private System.Windows.Forms.CheckBox cbChucVu;
        private System.Windows.Forms.CheckBox cbPhongBan;
    }
}