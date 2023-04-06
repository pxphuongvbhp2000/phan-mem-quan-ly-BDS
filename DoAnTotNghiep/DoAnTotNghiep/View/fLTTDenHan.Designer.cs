namespace DoAnTotNghiep.View
{
    partial class fLTTDenHan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLTTDenHan));
            this.dtpU = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhMucLTTHDMB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhMucLTTPDC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhMucLTTPGC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTHDMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTPDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTPGC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpU
            // 
            this.dtpU.CustomFormat = "dd/MM/yyyy";
            this.dtpU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpU.Location = new System.Drawing.Point(790, 37);
            this.dtpU.Name = "dtpU";
            this.dtpU.Size = new System.Drawing.Size(213, 22);
            this.dtpU.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(673, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 153;
            this.label5.Text = "Đến Ngày";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1035, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 61);
            this.btnTimKiem.TabIndex = 152;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpD
            // 
            this.dtpD.CustomFormat = "dd/MM/yyyy";
            this.dtpD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpD.Location = new System.Drawing.Point(428, 37);
            this.dtpD.Name = "dtpD";
            this.dtpD.Size = new System.Drawing.Size(213, 22);
            this.dtpD.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(79, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 29);
            this.label4.TabIndex = 150;
            this.label4.Text = ">>>> LTT Hợp Đồng Mua Bán:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDanhMucLTTHDMB
            // 
            this.dgvDanhMucLTTHDMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucLTTHDMB.Location = new System.Drawing.Point(35, 528);
            this.dgvDanhMucLTTHDMB.Name = "dgvDanhMucLTTHDMB";
            this.dgvDanhMucLTTHDMB.ReadOnly = true;
            this.dgvDanhMucLTTHDMB.RowHeadersWidth = 51;
            this.dgvDanhMucLTTHDMB.RowTemplate.Height = 24;
            this.dgvDanhMucLTTHDMB.Size = new System.Drawing.Size(1130, 160);
            this.dgvDanhMucLTTHDMB.TabIndex = 149;
            this.dgvDanhMucLTTHDMB.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucLTT_DataError);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(79, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 29);
            this.label3.TabIndex = 148;
            this.label3.Text = ">>>> LTT Phiếu Đặt Cọc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(79, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 29);
            this.label2.TabIndex = 147;
            this.label2.Text = ">>>> LTT Phiếu Giữ Chỗ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDanhMucLTTPDC
            // 
            this.dgvDanhMucLTTPDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucLTTPDC.Location = new System.Drawing.Point(35, 309);
            this.dgvDanhMucLTTPDC.Name = "dgvDanhMucLTTPDC";
            this.dgvDanhMucLTTPDC.ReadOnly = true;
            this.dgvDanhMucLTTPDC.RowHeadersWidth = 51;
            this.dgvDanhMucLTTPDC.RowTemplate.Height = 24;
            this.dgvDanhMucLTTPDC.Size = new System.Drawing.Size(1130, 163);
            this.dgvDanhMucLTTPDC.TabIndex = 146;
            this.dgvDanhMucLTTPDC.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucLTT_DataError);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 29);
            this.label1.TabIndex = 145;
            this.label1.Text = ">>>> Lịch Thanh Toán Từ Ngày:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDanhMucLTTPGC
            // 
            this.dgvDanhMucLTTPGC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucLTTPGC.Location = new System.Drawing.Point(35, 112);
            this.dgvDanhMucLTTPGC.Name = "dgvDanhMucLTTPGC";
            this.dgvDanhMucLTTPGC.ReadOnly = true;
            this.dgvDanhMucLTTPGC.RowHeadersWidth = 51;
            this.dgvDanhMucLTTPGC.RowTemplate.Height = 24;
            this.dgvDanhMucLTTPGC.Size = new System.Drawing.Size(1130, 152);
            this.dgvDanhMucLTTPGC.TabIndex = 144;
            this.dgvDanhMucLTTPGC.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhMucLTT_DataError);
            // 
            // fLTTDenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1179, 700);
            this.Controls.Add(this.dtpU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtpD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDanhMucLTTHDMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDanhMucLTTPDC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhMucLTTPGC);
            this.Name = "fLTTDenHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Thanh Toán Đến Hạn";
            this.Load += new System.EventHandler(this.fLTTDenHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTHDMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTPDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucLTTPGC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhMucLTTHDMB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhMucLTTPDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhMucLTTPGC;
    }
}