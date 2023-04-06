namespace DoAnTotNghiep.View
{
    partial class fAnhCanCuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAnhCanCuoc));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXemAnh = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhMucAnh = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChiThuongTru = new System.Windows.Forms.TextBox();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.label27);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.txtDiaChiThuongTru);
            this.gbThongTin.Controls.Add(this.label19);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.btnChonAnh);
            this.gbThongTin.Controls.Add(this.btnXemAnh);
            this.gbThongTin.Controls.Add(this.pbAnh);
            this.gbThongTin.Controls.Add(this.txtID);
            this.gbThongTin.Controls.Add(this.label29);
            this.gbThongTin.Controls.Add(this.txtIDKhachHang);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(920, 233);
            this.gbThongTin.TabIndex = 150;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Ảnh";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.Window;
            this.btnChonAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnChonAnh.Image")));
            this.btnChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnh.Location = new System.Drawing.Point(250, 162);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(130, 61);
            this.btnChonAnh.TabIndex = 141;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXemAnh
            // 
            this.btnXemAnh.BackColor = System.Drawing.SystemColors.Window;
            this.btnXemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnXemAnh.Image")));
            this.btnXemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemAnh.Location = new System.Drawing.Point(422, 162);
            this.btnXemAnh.Name = "btnXemAnh";
            this.btnXemAnh.Size = new System.Drawing.Size(130, 61);
            this.btnXemAnh.TabIndex = 140;
            this.btnXemAnh.Text = "Xem Ảnh";
            this.btnXemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemAnh.UseVisualStyleBackColor = false;
            this.btnXemAnh.Click += new System.EventHandler(this.btnXemAnh_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(592, 21);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(303, 202);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 106;
            this.pbAnh.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(25, 182);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(107, 22);
            this.txtID.TabIndex = 87;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 38);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 16);
            this.label29.TabIndex = 104;
            this.label29.Text = "ID Khách Hàng";
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDKhachHang.Location = new System.Drawing.Point(164, 32);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(388, 22);
            this.txtIDKhachHang.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThucHien);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 90);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(629, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 61);
            this.btnHuy.TabIndex = 144;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(25, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 61);
            this.btnThem.TabIndex = 143;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(178, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 61);
            this.btnSua.TabIndex = 142;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(327, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 61);
            this.btnXoa.TabIndex = 141;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.SystemColors.Window;
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(480, 21);
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
            this.btnThoat.Location = new System.Drawing.Point(765, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 61);
            this.btnThoat.TabIndex = 138;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhMucAnh
            // 
            this.dgvDanhMucAnh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucAnh.ColumnHeadersHeight = 29;
            this.dgvDanhMucAnh.Location = new System.Drawing.Point(12, 370);
            this.dgvDanhMucAnh.Name = "dgvDanhMucAnh";
            this.dgvDanhMucAnh.ReadOnly = true;
            this.dgvDanhMucAnh.RowHeadersWidth = 51;
            this.dgvDanhMucAnh.RowTemplate.Height = 24;
            this.dgvDanhMucAnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucAnh.Size = new System.Drawing.Size(920, 185);
            this.dgvDanhMucAnh.TabIndex = 148;
            this.dgvDanhMucAnh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucAnh_DataError);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 16);
            this.label19.TabIndex = 142;
            this.label19.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.Location = new System.Drawing.Point(164, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(388, 22);
            this.txtHoTen.TabIndex = 143;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.Location = new System.Drawing.Point(164, 122);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(388, 22);
            this.txtSDT.TabIndex = 147;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 16);
            this.label27.TabIndex = 146;
            this.label27.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "Địa Chỉ Thường Trú";
            // 
            // txtDiaChiThuongTru
            // 
            this.txtDiaChiThuongTru.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChiThuongTru.Location = new System.Drawing.Point(164, 94);
            this.txtDiaChiThuongTru.Name = "txtDiaChiThuongTru";
            this.txtDiaChiThuongTru.Size = new System.Drawing.Size(388, 22);
            this.txtDiaChiThuongTru.TabIndex = 145;
            // 
            // fAnhCanCuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(945, 570);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhMucAnh);
            this.Name = "fAnhCanCuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ảnh Căn Cước";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAnhCanCuoc_FormClosing);
            this.Load += new System.EventHandler(this.fAnhCanCuoc_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhMucAnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Button btnXemAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChiThuongTru;
    }
}