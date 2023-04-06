namespace DoAnTotNghiep.View
{
    partial class fDanhMucLoaiBatDongSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucLoaiBatDongSan));
            this.btnThem = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiBDS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhMucLoaiBatDongSan = new System.Windows.Forms.DataGridView();
            this.gbThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiBatDongSan)).BeginInit();
            this.SuspendLayout();
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
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtGhiChu);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.txtTenLoaiBDS);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.txtID);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1195, 95);
            this.gbThongTin.TabIndex = 151;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Loại Bất Động Sản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 120;
            this.label3.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this.txtGhiChu.Location = new System.Drawing.Point(113, 58);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1057, 22);
            this.txtGhiChu.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Tên Loại BĐS";
            // 
            // txtTenLoaiBDS
            // 
            this.txtTenLoaiBDS.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLoaiBDS.Location = new System.Drawing.Point(763, 21);
            this.txtTenLoaiBDS.Name = "txtTenLoaiBDS";
            this.txtTenLoaiBDS.Size = new System.Drawing.Size(407, 22);
            this.txtTenLoaiBDS.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(113, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(407, 22);
            this.txtID.TabIndex = 87;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnThucHien);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 90);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(876, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 61);
            this.btnHuy.TabIndex = 144;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(199, 21);
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
            this.btnXoa.Location = new System.Drawing.Point(371, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 61);
            this.btnXoa.TabIndex = 141;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(546, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 61);
            this.btnTimKiem.TabIndex = 140;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.SystemColors.Window;
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHien.Location = new System.Drawing.Point(714, 21);
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
            this.btnThoat.Location = new System.Drawing.Point(1038, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 61);
            this.btnThoat.TabIndex = 138;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhMucLoaiBatDongSan
            // 
            this.dgvDanhMucLoaiBatDongSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucLoaiBatDongSan.ColumnHeadersHeight = 29;
            this.dgvDanhMucLoaiBatDongSan.Location = new System.Drawing.Point(12, 223);
            this.dgvDanhMucLoaiBatDongSan.Name = "dgvDanhMucLoaiBatDongSan";
            this.dgvDanhMucLoaiBatDongSan.ReadOnly = true;
            this.dgvDanhMucLoaiBatDongSan.RowHeadersWidth = 51;
            this.dgvDanhMucLoaiBatDongSan.RowTemplate.Height = 24;
            this.dgvDanhMucLoaiBatDongSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMucLoaiBatDongSan.Size = new System.Drawing.Size(1195, 234);
            this.dgvDanhMucLoaiBatDongSan.TabIndex = 152;
            // 
            // fDanhMucLoaiBatDongSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1219, 468);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDanhMucLoaiBatDongSan);
            this.MaximizeBox = false;
            this.Name = "fDanhMucLoaiBatDongSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Loại Bất Động Sản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhMucLoaiBatDongSan_FormClosing);
            this.Load += new System.EventHandler(this.fDanhMucLoaiBatDongSan_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLoaiBatDongSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiBDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhMucLoaiBatDongSan;
    }
}