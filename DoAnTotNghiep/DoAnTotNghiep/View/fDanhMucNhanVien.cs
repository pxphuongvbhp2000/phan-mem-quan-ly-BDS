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
    public partial class fDanhMucNhanVien : Form
    {
        public fDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void fDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dataNhanVien = NhanVienDAO.Instance.GetListNhanVien();
            dgvDanhMucNhanVien.DataSource = dataNhanVien;
            dgvDanhMucNhanVien.Columns["id"].HeaderText = "ID";
            dgvDanhMucNhanVien.Columns["matkhaudangnhap"].HeaderText = "Mật Khẩu Đăng Nhập";
            dgvDanhMucNhanVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDanhMucNhanVien.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucNhanVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucNhanVien.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucNhanVien.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucNhanVien.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucNhanVien.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucNhanVien.Columns["email"].HeaderText = "Email";
            dgvDanhMucNhanVien.Columns["nganhang"].HeaderText = "Ngân Hàng";
            dgvDanhMucNhanVien.Columns["sotaikhoan"].HeaderText = "Số Tài Khoản";
            dgvDanhMucNhanVien.Columns["idchinhanh"].HeaderText = "Id Chi Nhánh";
            dgvDanhMucNhanVien.Columns["idphongban"].HeaderText = "Id Phòng Ban";
            dgvDanhMucNhanVien.Columns["idchucvu"].HeaderText = "Id Chức Vụ";
            dgvDanhMucNhanVien.Columns["idnhomquyen"].HeaderText = "Id Nhóm Quyền";
            dgvDanhMucNhanVien.Columns["tenchinhanh"].HeaderText = "Tên Chi Nhánh";
            dgvDanhMucNhanVien.Columns["tenphongban"].HeaderText = "Tên Phòng Ban";
            dgvDanhMucNhanVien.Columns["tenchucvu"].HeaderText = "Tên Chức Vụ";
            dgvDanhMucNhanVien.Columns["tennhomquyen"].HeaderText = "Tên Nhóm Quyền";
            dgvDanhMucNhanVien.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucNhanVien.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucNhanVien.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
            cbHienThiMatKhau.Enabled = true;
            txtMatKhauDangNhap.Enabled = true;
            txtTrangThai.Clear();
            txtTrangThai.Enabled = false;
            cbbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbKhoaTaiKhoan.Enabled = true;
            LoadComBoBox();
            dis_en(false);
            Bingding();
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

        void LoadComBoBox()
        {
            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");

            DataTable dataChiNhanh = ChiNhanhDAO.Instance.GetChiNhanhForCBB();
            cbbTenChiNhanh.DataSource = dataChiNhanh;
            cbbTenChiNhanh.DisplayMember = "chitietCN";
            cbbTenChiNhanh.ValueMember = "id";
            cbbTenChiNhanh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenChiNhanh.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataPhongBan = PhongBanDAO.Instance.GetPhongBanForCBB();
            cbbTenPhongBan.DataSource = dataPhongBan;
            cbbTenPhongBan.DisplayMember = "chitietPB";
            cbbTenPhongBan.ValueMember = "id";
            cbbTenPhongBan.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenPhongBan.AutoCompleteSource = AutoCompleteSource.ListItems;


            DataTable dataChucVu = ChucVuDAO.Instance.GetChucVuForCBB();
            cbbTenChucVu.DataSource = dataChucVu;
            cbbTenChucVu.DisplayMember = "chitietCV";
            cbbTenChucVu.ValueMember = "id";
            cbbTenChucVu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataNhomQuyen = NhomQuyenDAO.Instance.GetNhomQuyenForCBB();
            cbbTenNhomQuyen.DataSource = dataNhomQuyen;
            cbbTenNhomQuyen.DisplayMember = "chitietNQ";
            cbbTenNhomQuyen.ValueMember = "id";
            cbbTenNhomQuyen.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenNhomQuyen.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void dis_en(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnTimKiem.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }


        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtMatKhauDangNhap.DataBindings.Clear();
            txtMatKhauDangNhap.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "matkhaudangnhap", true, DataSourceUpdateMode.Never);

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "hoten", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "email", true, DataSourceUpdateMode.Never);

            txtNganHang.DataBindings.Clear();
            txtNganHang.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "nganhang", true, DataSourceUpdateMode.Never);

            txtSoTaiKhoan.DataBindings.Clear();
            txtSoTaiKhoan.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "sotaikhoan", true, DataSourceUpdateMode.Never);

            txtIdChiNhanh.DataBindings.Clear();
            txtIdChiNhanh.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "idchinhanh", true, DataSourceUpdateMode.Never);

            cbbTenChiNhanh.DataBindings.Clear();
            cbbTenChiNhanh.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "tenchinhanh", true, DataSourceUpdateMode.Never);

            txtIdPhongBan.DataBindings.Clear();
            txtIdPhongBan.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "idphongban", true, DataSourceUpdateMode.Never);

            cbbTenPhongBan.DataBindings.Clear();
            cbbTenPhongBan.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "tenPhongBan", true, DataSourceUpdateMode.Never);

            txtIdChucVu.DataBindings.Clear();
            txtIdChucVu.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "idchucvu", true, DataSourceUpdateMode.Never);

            cbbTenChucVu.DataBindings.Clear();
            cbbTenChucVu.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "tenchucvu", true, DataSourceUpdateMode.Never);

            txtIdNhomQuyen.DataBindings.Clear();
            txtIdNhomQuyen.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "idnhomquyen", true, DataSourceUpdateMode.Never);

            cbbTenNhomQuyen.DataBindings.Clear();
            cbbTenNhomQuyen.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "tennhomquyen", true, DataSourceUpdateMode.Never);

            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "trangthai", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucNhanVien.DataSource, "ghichu", true, DataSourceUpdateMode.Never);

            
        }

        int flag = 0;

        private void cbbTenChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdChucVu.Text = cbbTenChucVu.SelectedValue.ToString();
        }

        private void cbbTenPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdPhongBan.Text = cbbTenPhongBan.SelectedValue.ToString();
        }

        private void cbbTenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdChiNhanh.Text = cbbTenChiNhanh.SelectedValue.ToString();
        }

        private void cbbTenNhomQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdNhomQuyen.Text = cbbTenNhomQuyen.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            cbHienThiMatKhau.Checked = true;
            cbHienThiMatKhau.Enabled = false;
            dis_en(true);
            foreach(TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                if (t == txtIdChiNhanh || t == txtIdPhongBan || t == txtIdChucVu || t == txtIdNhomQuyen)
                {
                    continue;
                }
                t.Clear();
            }
            txtTrangThai.Text = "Offline";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtID.Enabled = false;
            cbHienThiMatKhau.Checked = true;
            cbHienThiMatKhau.Enabled = false;
            dis_en(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flag = 3;
            txtID.Enabled = true;
            cbHienThiMatKhau.Enabled = false;
            txtMatKhauDangNhap.Enabled = false;
            cbbGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtTrangThai.Enabled = true;
            cbKhoaTaiKhoan.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (NhanVienDAO.Instance.XoaNhanVien(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucNhanVien_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string matkhaudangnhap = txtMatKhauDangNhap.Text;
                string hoten = txtHoTen.Text;
                string gioitinh = cbbGioiTinh.Text;
                string ngaysinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string sothecancuoc = txtSoTheCanCuoc.Text;
                string nguyenquan = txtNguyenQuan.Text;
                string diachithuongtru = txtDiaChiThuongTru.Text;
                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string nganhang = txtNganHang.Text;
                string sotaikhoan = txtSoTaiKhoan.Text;
                string idchinhanh = txtIdChiNhanh.Text;
                string idphongban = txtIdPhongBan.Text;
                string idchucvu = txtIdChucVu.Text;
                string idnhomquyen = txtIdNhomQuyen.Text;
                string masothue = txtMaSoThue.Text;
                string trangthai = txtTrangThai.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    if 
                    (
                        NhanVienDAO.Instance.ThemNhanVien(id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
                        diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
                        trangthai, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhanVien_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    if (cbKhoaTaiKhoan.Checked)
                    {
                        trangthai = "Khóa";
                    }
                    else
                    {
                        trangthai = "Offline";
                    } 
                    if
                    (
                        NhanVienDAO.Instance.SuaNhanVien(id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
                        diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
                        trangthai, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhanVien_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataNhanVien = NhanVienDAO.Instance.TimKiemNhanVien(id, hoten, sothecancuoc, nguyenquan,
                        diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue, trangthai,
                        ghichu);
                    dgvDanhMucNhanVien.DataSource = dataNhanVien;
                    cbHienThiMatKhau.Enabled = true;
                    txtMatKhauDangNhap.Enabled = true;
                    txtTrangThai.Clear();
                    txtTrangThai.Enabled = false;
                    cbbGioiTinh.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    cbKhoaTaiKhoan.Enabled = true;
                    Bingding();
                    dis_en(false);

                }

                cbHienThiMatKhau.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn cần nhập lại thông tin!\n\n" + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fDanhMucNhanVien_Load(sender, e);
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
