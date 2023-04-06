namespace DoAnTotNghiep.View
{
    partial class fAnhGiuCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAnhGiuCho));
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.nUuTien = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXemAnh = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDPhieuGiuCho = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhMucAnh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUuTien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(592, 21);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(303, 183);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 106;
            this.pbAnh.TabStop = false;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.nUuTien);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.cbbTrangThai);
            this.gbThongTin.Controls.Add(this.label17);
            this.gbThongTin.Controls.Add(this.dtpNgayHetHan);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.dtpNgayLapPhieu);
            this.gbThongTin.Controls.Add(this.label11);
            this.gbThongTin.Controls.Add(this.label10);
            this.gbThongTin.Controls.Add(this.txtTienCoc);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.btnChonAnh);
            this.gbThongTin.Controls.Add(this.btnXemAnh);
            this.gbThongTin.Controls.Add(this.pbAnh);
            this.gbThongTin.Controls.Add(this.txtID);
            this.gbThongTin.Controls.Add(this.txtIDPhieuGiuCho);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(920, 233);
            this.gbThongTin.TabIndex = 153;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Ảnh";
            // 
            // nUuTien
            // 
            this.nUuTien.Location = new System.Drawing.Point(140, 102);
            this.nUuTien.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUuTien.Name = "nUuTien";
            this.nUuTien.Size = new System.Drawing.Size(426, 22);
            this.nUuTien.TabIndex = 179;
            this.nUuTien.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 178;
            this.label8.Text = "Ưu Tiên";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.BackColor = System.Drawing.SystemColors.Window;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(140, 130);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(426, 24);
            this.cbbTrangThai.TabIndex = 177;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 176;
            this.label17.Text = "Trạng Thái";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(140, 47);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(426, 22);
            this.dtpNgayHetHan.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 171;
            this.label1.Text = "Ngày Hết Hạn";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(141, 21);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(426, 22);
            this.dtpNgayLapPhieu.TabIndex = 170;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 169;
            this.label11.Text = "Ngày Lập Phiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 168;
            this.label10.Text = "vnđ";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtTienCoc.Location = new System.Drawing.Point(140, 75);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(360, 22);
            this.txtTienCoc.TabIndex = 167;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 166;
            this.label5.Text = "Tiền Cọc";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.Window;
            this.btnChonAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnChonAnh.Image")));
            this.btnChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnh.Location = new System.Drawing.Point(262, 166);
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
            this.btnXemAnh.Location = new System.Drawing.Point(420, 166);
            this.btnXemAnh.Name = "btnXemAnh";
            this.btnXemAnh.Size = new System.Drawing.Size(130, 61);
            this.btnXemAnh.TabIndex = 140;
            this.btnXemAnh.Text = "Xem Ảnh";
            this.btnXemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemAnh.UseVisualStyleBackColor = false;
            this.btnXemAnh.Click += new System.EventHandler(this.btnXemAnh_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(51, 166);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 22);
            this.txtID.TabIndex = 87;
            // 
            // txtIDPhieuGiuCho
            // 
            this.txtIDPhieuGiuCho.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDPhieuGiuCho.Location = new System.Drawing.Point(51, 205);
            this.txtIDPhieuGiuCho.Name = "txtIDPhieuGiuCho";
            this.txtIDPhieuGiuCho.Size = new System.Drawing.Size(131, 22);
            this.txtIDPhieuGiuCho.TabIndex = 105;
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
            this.dgvDanhMucAnh.TabIndex = 151;
            this.dgvDanhMucAnh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucAnh_DataError);
            // 
            // fAnhGiuCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(947, 570);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhMucAnh);
            this.Name = "fAnhGiuCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ảnh Phiếu Giữ Chỗ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAnhGiuCho_FormClosing);
            this.Load += new System.EventHandler(this.fAnhGiuCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUuTien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXemAnh;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDPhieuGiuCho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhMucAnh;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUuTien;
        private System.Windows.Forms.Label label8;
    }
}