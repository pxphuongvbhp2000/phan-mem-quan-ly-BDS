namespace DoAnTotNghiep.View
{
    partial class fAnhHoKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAnhHoKhau));
            this.dgvDanhMucAnh = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnXemAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChiThuongTru = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
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
            this.dgvDanhMucAnh.TabIndex = 151;
            this.dgvDanhMucAnh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucAnh_DataError);
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
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDKhachHang.Location = new System.Drawing.Point(164, 31);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(388, 22);
            this.txtIDKhachHang.TabIndex = 105;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 16);
            this.label29.TabIndex = 104;
            this.label29.Text = "ID Khách Hàng";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(25, 175);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 22);
            this.txtID.TabIndex = 87;
            // 
            // btnXemAnh
            // 
            this.btnXemAnh.BackColor = System.Drawing.SystemColors.Window;
            this.btnXemAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnXemAnh.Image")));
            this.btnXemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemAnh.Location = new System.Drawing.Point(422, 156);
            this.btnXemAnh.Name = "btnXemAnh";
            this.btnXemAnh.Size = new System.Drawing.Size(130, 61);
            this.btnXemAnh.TabIndex = 140;
            this.btnXemAnh.Text = "Xem Ảnh";
            this.btnXemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemAnh.UseVisualStyleBackColor = false;
            this.btnXemAnh.Click += new System.EventHandler(this.btnXemAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.Window;
            this.btnChonAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnChonAnh.Image")));
            this.btnChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnh.Location = new System.Drawing.Point(204, 156);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(130, 61);
            this.btnChonAnh.TabIndex = 141;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
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
            this.gbThongTin.TabIndex = 153;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Ảnh";
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(592, 21);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(303, 196);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 106;
            this.pbAnh.TabStop = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.Location = new System.Drawing.Point(164, 121);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(388, 22);
            this.txtSDT.TabIndex = 153;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 16);
            this.label27.TabIndex = 152;
            this.label27.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 150;
            this.label1.Text = "Địa Chỉ Thường Trú";
            // 
            // txtDiaChiThuongTru
            // 
            this.txtDiaChiThuongTru.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChiThuongTru.Location = new System.Drawing.Point(164, 93);
            this.txtDiaChiThuongTru.Name = "txtDiaChiThuongTru";
            this.txtDiaChiThuongTru.Size = new System.Drawing.Size(388, 22);
            this.txtDiaChiThuongTru.TabIndex = 151;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 16);
            this.label19.TabIndex = 148;
            this.label19.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.Location = new System.Drawing.Point(164, 59);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(388, 22);
            this.txtHoTen.TabIndex = 149;
            // 
            // fAnhHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(949, 565);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhMucAnh);
            this.Name = "fAnhHoKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ảnh Hộ Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAnhHoKhau_FormClosing);
            this.Load += new System.EventHandler(this.fAnhHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucAnh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnXemAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChiThuongTru;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}