using System;
using DoAnTotNghiep.DAO;
using DoAnTotNghiep.DTO;
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
    public partial class fDangNhap : Form
    {
        
        public fDangNhap()
        {
            InitializeComponent();
        }

        bool DangNhap(string id, string matkhaudangnhap)
        {
            return NhanVienDAO.Instance.DangNhap(id, matkhaudangnhap);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string matkhaudangnhap = txtMatKhauDangNhap.Text;
            if (DangNhap(id, matkhaudangnhap))
            {
                DataTable data = NhanVienDAO.Instance.GetNhanVienByID(id);
                NhanVienDTO TKDangNhap = new NhanVienDTO();

                foreach (DataRow item in data.Rows)
                {
                    TKDangNhap = new NhanVienDTO(item);
                }

                fTaskMannager f = new fTaskMannager(TKDangNhap);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked == true)
            {
                txtMatKhauDangNhap.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauDangNhap.UseSystemPasswordChar = true;
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
