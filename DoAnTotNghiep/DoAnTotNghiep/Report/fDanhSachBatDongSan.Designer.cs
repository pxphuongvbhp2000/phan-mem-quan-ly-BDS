namespace DoAnTotNghiep.Report
{
    partial class fDanhSachBatDongSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachBatDongSan));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cbbLoaiBDS = new System.Windows.Forms.ComboBox();
            this.txtIDLoaiBDS = new System.Windows.Forms.TextBox();
            this.cbLoaiBDS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetThuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBatDau = new System.Windows.Forms.TextBox();
            this.cbDienTich = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDDuAn = new System.Windows.Forms.TextBox();
            this.cbbDuAn = new System.Windows.Forms.ComboBox();
            this.cbDuAn = new System.Windows.Forms.CheckBox();
            this.rptBieuMau = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.cbbTrangThai);
            this.gbThongTin.Controls.Add(this.cbTrangThai);
            this.gbThongTin.Controls.Add(this.cbbLoaiBDS);
            this.gbThongTin.Controls.Add(this.txtIDLoaiBDS);
            this.gbThongTin.Controls.Add(this.cbLoaiBDS);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.txtKetThuc);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.txtBatDau);
            this.gbThongTin.Controls.Add(this.cbDienTich);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.txtIDDuAn);
            this.gbThongTin.Controls.Add(this.cbbDuAn);
            this.gbThongTin.Controls.Add(this.cbDuAn);
            this.gbThongTin.Location = new System.Drawing.Point(13, 13);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1168, 168);
            this.gbThongTin.TabIndex = 172;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbbLoaiBDS
            // 
            this.cbbLoaiBDS.BackColor = System.Drawing.SystemColors.Window;
            this.cbbLoaiBDS.FormattingEnabled = true;
            this.cbbLoaiBDS.Location = new System.Drawing.Point(389, 51);
            this.cbbLoaiBDS.Name = "cbbLoaiBDS";
            this.cbbLoaiBDS.Size = new System.Drawing.Size(743, 24);
            this.cbbLoaiBDS.TabIndex = 183;
            this.cbbLoaiBDS.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBDS_SelectedIndexChanged);
            // 
            // txtIDLoaiBDS
            // 
            this.txtIDLoaiBDS.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDLoaiBDS.Location = new System.Drawing.Point(216, 49);
            this.txtIDLoaiBDS.Name = "txtIDLoaiBDS";
            this.txtIDLoaiBDS.ReadOnly = true;
            this.txtIDLoaiBDS.Size = new System.Drawing.Size(140, 22);
            this.txtIDLoaiBDS.TabIndex = 182;
            // 
            // cbLoaiBDS
            // 
            this.cbLoaiBDS.AutoSize = true;
            this.cbLoaiBDS.Location = new System.Drawing.Point(27, 53);
            this.cbLoaiBDS.Name = "cbLoaiBDS";
            this.cbLoaiBDS.Size = new System.Drawing.Size(140, 20);
            this.cbLoaiBDS.TabIndex = 181;
            this.cbLoaiBDS.Text = "Loại Bất Động Sản";
            this.cbLoaiBDS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1107, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 180;
            this.label2.Text = "m2";
            // 
            // txtKetThuc
            // 
            this.txtKetThuc.BackColor = System.Drawing.SystemColors.Window;
            this.txtKetThuc.Location = new System.Drawing.Point(735, 81);
            this.txtKetThuc.Name = "txtKetThuc";
            this.txtKetThuc.Size = new System.Drawing.Size(361, 22);
            this.txtKetThuc.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 178;
            this.label1.Text = "m2";
            // 
            // txtBatDau
            // 
            this.txtBatDau.BackColor = System.Drawing.SystemColors.Window;
            this.txtBatDau.Location = new System.Drawing.Point(216, 81);
            this.txtBatDau.Name = "txtBatDau";
            this.txtBatDau.Size = new System.Drawing.Size(361, 22);
            this.txtBatDau.TabIndex = 177;
            // 
            // cbDienTich
            // 
            this.cbDienTich.AutoSize = true;
            this.cbDienTich.Location = new System.Drawing.Point(27, 83);
            this.cbDienTich.Name = "cbDienTich";
            this.cbDienTich.Size = new System.Drawing.Size(86, 20);
            this.cbDienTich.TabIndex = 176;
            this.cbDienTich.Text = "Diện Tích";
            this.cbDienTich.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 175;
            this.label5.Text = "Đến";
            // 
            // txtIDDuAn
            // 
            this.txtIDDuAn.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDDuAn.Location = new System.Drawing.Point(216, 21);
            this.txtIDDuAn.Name = "txtIDDuAn";
            this.txtIDDuAn.Size = new System.Drawing.Size(140, 22);
            this.txtIDDuAn.TabIndex = 172;
            // 
            // cbbDuAn
            // 
            this.cbbDuAn.BackColor = System.Drawing.SystemColors.Window;
            this.cbbDuAn.FormattingEnabled = true;
            this.cbbDuAn.Location = new System.Drawing.Point(389, 21);
            this.cbbDuAn.Name = "cbbDuAn";
            this.cbbDuAn.Size = new System.Drawing.Size(743, 24);
            this.cbbDuAn.TabIndex = 171;
            this.cbbDuAn.SelectedIndexChanged += new System.EventHandler(this.cbbDuAn_SelectedIndexChanged);
            // 
            // cbDuAn
            // 
            this.cbDuAn.AutoSize = true;
            this.cbDuAn.Location = new System.Drawing.Point(27, 25);
            this.cbDuAn.Name = "cbDuAn";
            this.cbDuAn.Size = new System.Drawing.Size(65, 20);
            this.cbDuAn.TabIndex = 163;
            this.cbDuAn.Text = "Dự Án";
            this.cbDuAn.UseVisualStyleBackColor = true;
            // 
            // rptBieuMau
            // 
            this.rptBieuMau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptBieuMau.Location = new System.Drawing.Point(13, 202);
            this.rptBieuMau.Name = "rptBieuMau";
            this.rptBieuMau.ServerReport.BearerToken = null;
            this.rptBieuMau.Size = new System.Drawing.Size(1411, 605);
            this.rptBieuMau.TabIndex = 171;
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
            this.groupBox1.Location = new System.Drawing.Point(1189, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 168);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Location = new System.Drawing.Point(27, 109);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(95, 20);
            this.cbTrangThai.TabIndex = 184;
            this.cbTrangThai.Text = "Trạng Thái";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(216, 107);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(916, 24);
            this.cbbTrangThai.TabIndex = 185;
            // 
            // fDanhSachBatDongSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1436, 820);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.rptBieuMau);
            this.Controls.Add(this.groupBox1);
            this.Name = "fDanhSachBatDongSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Bất Động Sản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhSachBatDongSan_FormClosing);
            this.Load += new System.EventHandler(this.fDanhSachBatDongSan_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.CheckBox cbDienTich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDDuAn;
        private System.Windows.Forms.ComboBox cbbDuAn;
        private System.Windows.Forms.CheckBox cbDuAn;
        private Microsoft.Reporting.WinForms.ReportViewer rptBieuMau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLoaiBDS;
        private System.Windows.Forms.ComboBox cbbLoaiBDS;
        private System.Windows.Forms.TextBox txtIDLoaiBDS;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.ComboBox cbbTrangThai;
    }
}