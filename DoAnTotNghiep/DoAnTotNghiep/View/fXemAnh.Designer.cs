namespace DoAnTotNghiep.View
{
    partial class fXemAnh
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
            this.pbAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(13, 13);
            this.pbAnh.Margin = new System.Windows.Forms.Padding(4);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(1144, 802);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 133;
            this.pbAnh.TabStop = false;
            // 
            // fXemAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1170, 828);
            this.Controls.Add(this.pbAnh);
            this.Name = "fXemAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Ảnh";
            this.Load += new System.EventHandler(this.fXemAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnh;
    }
}