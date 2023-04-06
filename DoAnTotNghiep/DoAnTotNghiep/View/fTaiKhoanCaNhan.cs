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
    public partial class fTaiKhoanCaNhan : Form
    {
        private NhanVienDTO tKDangNhap;

        public NhanVienDTO TKDangNhap { get => tKDangNhap; set => tKDangNhap = value; }

        public fTaiKhoanCaNhan()
        {
            InitializeComponent();
        }

        public fTaiKhoanCaNhan(NhanVienDTO TKDangNhap)
        {
            InitializeComponent();
            this.TKDangNhap = TKDangNhap;
        }

        private void fTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            txtID.Text = this.TKDangNhap.Id.ToString();
            txtMatKhauDangNhap.Text = this.TKDangNhap.Matkhaudangnhap.ToString();
            txtHoTen.Text = this.TKDangNhap.Hoten.ToString();
            txtGioiTinh.Text = this.TKDangNhap.Gioitinh.ToString();
            txtNgaySinh.Text = this.TKDangNhap.Ngaysinh.ToString();
            txtSoTheCanCuoc.Text = this.TKDangNhap.Sothecancuoc.ToString();
            txtNguyenQuan.Text = this.TKDangNhap.Nguyenquan.ToString();
            txtDiaChiThuongTru.Text = this.TKDangNhap.Diachithuongtru.ToString();
            txtSDT.Text = this.TKDangNhap.Sdt.ToString();
            txtEmail.Text = this.TKDangNhap.Email.ToString();
            txtNganHang.Text = this.TKDangNhap.Nganhang.ToString();
            txtSoTaiKhoan.Text = this.TKDangNhap.Sotaikhoan.ToString();
            txtIdChiNhanh.Text = this.TKDangNhap.Idchinhanh.ToString();
            txtIdPhongBan.Text = this.TKDangNhap.Idphongban.ToString();
            txtIdChucVu.Text = this.TKDangNhap.Idchucvu.ToString();
            txtIdNhomQuyen.Text = this.TKDangNhap.Idnhomquyen.ToString();
            txtMaSoThue.Text = this.TKDangNhap.Masothue.ToString();
            txtTrangThai.Text = this.TKDangNhap.Trangthai.ToString();
            txtGhiChu.Text = this.TKDangNhap.Ghichu.ToString();
            txtTenChiNhanh.Text = ChiNhanhDAO.Instance.GetChiNhanhByID(txtIdChiNhanh.Text.ToString()).Rows[0]["tenchinhanh"].ToString();
            txtTenPhongBan.Text = PhongBanDAO.Instance.GetPhongBanByID(txtIdPhongBan.Text.ToString()).Rows[0]["tenphongban"].ToString();
            txtTenChucVu.Text = ChucVuDAO.Instance.GetChucVuByID(txtIdChucVu.Text.ToString()).Rows[0]["tenchucvu"].ToString();
            txtTenNhomQuyen.Text = NhomQuyenDAO.Instance.GetNhomQuyenByID(txtIdNhomQuyen.Text.ToString()).Rows[0]["tennhomquyen"].ToString();
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            fThayDoiMatKhau f = new fThayDoiMatKhau(TKDangNhap);
            f.ShowDialog(); 
            this.Show();
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
