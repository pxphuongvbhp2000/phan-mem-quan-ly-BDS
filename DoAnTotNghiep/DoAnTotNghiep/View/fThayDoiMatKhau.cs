using System;
using DoAnTotNghiep.DAO;
using DoAnTotNghiep.DTO;
using DoAnTotNghiep.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTotNghiep.View
{
    public partial class fThayDoiMatKhau : Form
    {
        private NhanVienDTO tKDangNhap;

        public NhanVienDTO TKDangNhap { get => tKDangNhap; set => tKDangNhap = value; }

        public fThayDoiMatKhau()
        {
            InitializeComponent();
        }

        public fThayDoiMatKhau(NhanVienDTO TKDangNhap)
        {
            InitializeComponent();
            this.TKDangNhap = TKDangNhap;
        }

        private void btnLuuVaThayDoi_Click(object sender, EventArgs e)
        {
            if (this.TKDangNhap.Matkhaudangnhap == txtMatKhauCu.Text)
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                {
                    if (NhanVienDAO.Instance.ThayDoiMatKhau(this.TKDangNhap.Id, txtMatKhauMoi.Text))
                    {
                        if (MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                        {
                            this.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Bạn nhập mật khẩu mới không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked == true)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
