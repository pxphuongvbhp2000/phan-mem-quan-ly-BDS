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
    public partial class fDanhMucPhieuGiuCho : Form
    {

        private BatDongSanDTO batDongSanXuLy;

        public BatDongSanDTO BatDongSanXuLy { get => batDongSanXuLy; set => batDongSanXuLy = value; }


        public fDanhMucPhieuGiuCho()
        {
            InitializeComponent();
        }

        public fDanhMucPhieuGiuCho(BatDongSanDTO BatDongSanXuLy)
        {
            InitializeComponent();
            this.BatDongSanXuLy = BatDongSanXuLy;
        }

        private void fDanhMucPhieuGiuCho_Load(object sender, EventArgs e)
        {
            DataTable dataPGC;
            if (this.BatDongSanXuLy != null)
            {
                txtIDBDS.Enabled = false;
                cbbBDS.Enabled = false;
                dataPGC = PhieuGiuChoDAO.Instance.GetListPhieuGiuChoByIDBDS(BatDongSanXuLy.Id);

                btnThemKhachHangMoi.Visible = true;
                btnSuaKhachHangMoi.Visible = true;
                txtIDBDS.Text = BatDongSanXuLy.Id;

                txtIDBDS.Text = BatDongSanXuLy.Id.ToString();
                DataTable data = BatDongSanDAO.Instance.GetBatDongSanByID(txtIDBDS.Text);
                BatDongSanDTO BDSXuLy = new BatDongSanDTO();

                foreach (DataRow item in data.Rows)
                {
                    BDSXuLy = new BatDongSanDTO(item);
                }

                txtIDKhuDat.Text = BDSXuLy.Idkhudat;
                txtTenKhu.Text = KhuDatDAO.Instance.GetTenKhuByID(BDSXuLy.Idkhudat);
                txtIDDuAn.Text = KhuDatDAO.Instance.GetIDDuAnByIDKhuDat(BDSXuLy.Idkhudat);
                txtTenDuAn.Text = DuAnDAO.Instance.GetTenDuAnByID(txtIDDuAn.Text);
                txtIDLoaiBDS.Text = BDSXuLy.IdloaiBDS;
                txtTenLoaiBDS.Text = LoaiBatDongSanDAO.Instance.GetTenLoaiBDSByID(BDSXuLy.IdloaiBDS);
                txtDiaChi.Text = BDSXuLy.Diachi;
                txtHuong.Text = BDSXuLy.Huong;
                txtRong.Text = BDSXuLy.Rong.ToString();
                txtDai.Text = BDSXuLy.Dai.ToString();
                txtDienTichDat.Text = BDSXuLy.Dientichdat.ToString();
                txtDienTichSanTruoc.Text = BDSXuLy.Dientichsantruoc.ToString();
                txtDienTichSanSau.Text = BDSXuLy.Dientichsansau.ToString();
                txtDonGia.Text = BDSXuLy.Dongia.ToString();
                txtTyLeChietKhau.Text = BDSXuLy.Tylechietkhau.ToString();
                txtTyLeVAT.Text = BDSXuLy.TyleVAT.ToString();
                txtTrangThai.Text = BDSXuLy.Trangthai;
            }
            else
            {
                dataPGC = PhieuGiuChoDAO.Instance.GetListPhieuGiuCho();

                btnThemKhachHangMoi.Visible = false;
                btnSuaKhachHangMoi.Visible = false;
            }

            txtID.Visible = false;
            dgvDanhMucPhieuGiuCho.DataSource = dataPGC;
            dgvDanhMucPhieuGiuCho.Columns["id"].HeaderText = "ID";
            dgvDanhMucPhieuGiuCho.Columns["ngaylapphieu"].HeaderText = "Ngày Lập Phiếu";
            dgvDanhMucPhieuGiuCho.Columns["ngayhethan"].HeaderText = "Ngày Hết Hạn";
            dgvDanhMucPhieuGiuCho.Columns["tiencoc"].HeaderText = "Tiền Cọc";
            dgvDanhMucPhieuGiuCho.Columns["tiendohoanthanh"].HeaderText = "Tiến Độ Hoàn Thành";
            dgvDanhMucPhieuGiuCho.Columns["uutien"].HeaderText = "Ưu Tiên";
            dgvDanhMucPhieuGiuCho.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucPhieuGiuCho.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucPhieuGiuCho.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucPhieuGiuCho.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucPhieuGiuCho.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucPhieuGiuCho.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucPhieuGiuCho.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucPhieuGiuCho.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucPhieuGiuCho.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucPhieuGiuCho.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucPhieuGiuCho.Columns["email"].HeaderText = "Email";
            dgvDanhMucPhieuGiuCho.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucPhieuGiuCho.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucPhieuGiuCho.Columns["hotennhanvien"].HeaderText = "Họ Tên Nhân Viên";

            dgvDanhMucPhieuGiuCho.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucPhieuGiuCho.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucPhieuGiuCho.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucPhieuGiuCho.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucPhieuGiuCho.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucPhieuGiuCho.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucPhieuGiuCho.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucPhieuGiuCho.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucPhieuGiuCho.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucPhieuGiuCho.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucPhieuGiuCho.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucPhieuGiuCho.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucPhieuGiuCho.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucPhieuGiuCho.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucPhieuGiuCho.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucPhieuGiuCho.Columns["tylechietkhau"].HeaderText = "Tỷ Lệ Chiết Khấu";
            dgvDanhMucPhieuGiuCho.Columns["tyleVAT"].HeaderText = "Tỷ Lệ VAT";
            dgvDanhMucPhieuGiuCho.Columns["trangthaiBDS"].HeaderText = "Trạng Thái Bất Động Sản";

            txtID.Enabled = false;

            dtpNgayLapPhieu.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            txtTienCoc.Enabled = true;
            txtTienDoHoanThanh.Enabled = false;

            btnChonAnh.Enabled = true;
            btnLichThanhToan.Enabled = true;

            LoadComBoBox();
            dis_en(false);
            Bingding();
        }

        void LoadComBoBox()
        {

            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");

            DataTable dataNhanVien = NhanVienDAO.Instance.GetNhanVienForCBB();
            cbbTenNhanVienPhuTrach.DataSource = dataNhanVien;
            cbbTenNhanVienPhuTrach.DisplayMember = "chitietNV";
            cbbTenNhanVienPhuTrach.ValueMember = "id";
            cbbTenNhanVienPhuTrach.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenNhanVienPhuTrach.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Đang Tiến Hành");
            cbbTrangThai.Items.Add("Đã Hoàn Thành");
            cbbTrangThai.Items.Add("Đã Hủy");

            DataTable dataKhachHang = KhachHangDAO.Instance.GetKhachHangForCBB();
            cbbKhachHang.DataSource = dataKhachHang;
            cbbKhachHang.DisplayMember = "chitietKH";
            cbbKhachHang.ValueMember = "id";
            cbbKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataBDS = BatDongSanDAO.Instance.GetBatDongSanForCBB();
            cbbBDS.DataSource = dataBDS;
            cbbBDS.DisplayMember = "chitietBDS";
            cbbBDS.ValueMember = "id";
            cbbBDS.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbBDS.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void dis_en(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnThemKhachHangMoi.Enabled = !e;
            btnSuaKhachHangMoi.Enabled = !e;
            btnTimKiem.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }

        int flag = 0;

        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "id", true, DataSourceUpdateMode.Never);


            txtIDKhachHang.DataBindings.Clear();
            txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            cbbKhachHang.DataBindings.Clear();
            cbbKhachHang.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "hotenkhachhang", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "email", true, DataSourceUpdateMode.Never);


            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtIdNhanVienPhuTrach.DataBindings.Clear();
            txtIdNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbTenNhanVienPhuTrach.DataBindings.Clear();
            cbbTenNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "hotennhanvien", true, DataSourceUpdateMode.Never);



            txtIDBDS.DataBindings.Clear();
            txtIDBDS.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idBDS", true, DataSourceUpdateMode.Never);

            cbbBDS.DataBindings.Clear();
            cbbBDS.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtIDKhuDat.DataBindings.Clear();
            txtIDKhuDat.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idkhudat", true, DataSourceUpdateMode.Never);

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtIDLoaiBDS.DataBindings.Clear();
            txtIDLoaiBDS.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "idloaiBDS", true, DataSourceUpdateMode.Never);

            txtTenLoaiBDS.DataBindings.Clear();
            txtTenLoaiBDS.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            txtTyLeChietKhau.DataBindings.Clear();
            txtTyLeChietKhau.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tylechietkhau", true, DataSourceUpdateMode.Never);

            txtTyLeVAT.DataBindings.Clear();
            txtTyLeVAT.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tyleVAT", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "trangthaiBDS", true, DataSourceUpdateMode.Never);


            dtpNgayLapPhieu.DataBindings.Clear();
            dtpNgayLapPhieu.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "ngaylapphieu", true, DataSourceUpdateMode.Never);

            txtTienCoc.DataBindings.Clear();
            txtTienCoc.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tiencoc", true, DataSourceUpdateMode.Never);

            txtTienDoHoanThanh.DataBindings.Clear();
            txtTienDoHoanThanh.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "tiendohoanthanh", true, DataSourceUpdateMode.Never);

            nUuTien.DataBindings.Clear();
            nUuTien.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "uutien", true, DataSourceUpdateMode.Never);


            cbbTrangThai.DataBindings.Clear();
            cbbTrangThai.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "trangthai", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucPhieuGiuCho.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
        }


        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDKhachHang.Text = cbbKhachHang.SelectedValue.ToString();
            DataTable data = KhachHangDAO.Instance.GetKhachHangByID(txtIDKhachHang.Text);
            KhachHangDTO KhachHangXuLy = new KhachHangDTO();

            foreach (DataRow item in data.Rows)
            {
                KhachHangXuLy = new KhachHangDTO(item);
            }

            cbbGioiTinh.Text = KhachHangXuLy.Gioitinh;
            if (KhachHangXuLy.Ngaysinh != null)
            {
                dtpNgaySinh.Value = (DateTime)KhachHangXuLy.Ngaysinh;
            }
            txtSoTheCanCuoc.Text = KhachHangXuLy.Sothecancuoc;
            txtSoTheCanCuoc.Text = KhachHangXuLy.Sothecancuoc;
            txtNguyenQuan.Text = KhachHangXuLy.Nguyenquan;
            txtDiaChiThuongTru.Text = KhachHangXuLy.Diachithuongtru;
            txtSDT.Text = KhachHangXuLy.Sdt;
            txtEmail.Text = KhachHangXuLy.Email;
            txtMaSoThue.Text = KhachHangXuLy.Masothue;
            txtIdNhanVienPhuTrach.Text = KhachHangXuLy.Idnhanvienphutrach;
            cbbTenNhanVienPhuTrach.Text = NhanVienDAO.Instance.GetTenNhanVienByID(KhachHangXuLy.Idnhanvienphutrach);
        }


        private void cbbBDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.BatDongSanXuLy == null)
            {
                txtIDBDS.Text = cbbBDS.SelectedValue.ToString();
                DataTable data = BatDongSanDAO.Instance.GetBatDongSanByID(txtIDBDS.Text);
                BatDongSanDTO BDSXuLy = new BatDongSanDTO();

                foreach (DataRow item in data.Rows)
                {
                    BDSXuLy = new BatDongSanDTO(item);
                }

                txtIDKhuDat.Text = BDSXuLy.Idkhudat;
                txtTenKhu.Text = KhuDatDAO.Instance.GetTenKhuByID(BDSXuLy.Idkhudat);
                txtIDDuAn.Text = KhuDatDAO.Instance.GetIDDuAnByIDKhuDat(BDSXuLy.Idkhudat);
                txtTenDuAn.Text = DuAnDAO.Instance.GetTenDuAnByID(txtIDDuAn.Text);
                txtIDLoaiBDS.Text = BDSXuLy.IdloaiBDS;
                txtTenLoaiBDS.Text = LoaiBatDongSanDAO.Instance.GetTenLoaiBDSByID(BDSXuLy.IdloaiBDS);
                txtDiaChi.Text = BDSXuLy.Diachi;
                txtHuong.Text = BDSXuLy.Huong;
                txtRong.Text = BDSXuLy.Rong.ToString();
                txtDai.Text = BDSXuLy.Dai.ToString();
                txtDienTichDat.Text = BDSXuLy.Dientichdat.ToString();
                txtDienTichSanTruoc.Text = BDSXuLy.Dientichsantruoc.ToString();
                txtDienTichSanSau.Text = BDSXuLy.Dientichsansau.ToString();
                txtDonGia.Text = BDSXuLy.Dongia.ToString();
                txtTyLeChietKhau.Text = BDSXuLy.Tylechietkhau.ToString();
                txtTyLeVAT.Text = BDSXuLy.TyleVAT.ToString();
                txtTrangThai.Text = BDSXuLy.Trangthai;
            }


            

        }


        int flagKH = 0;

        private void btnThemKhachHangMoi_Click(object sender, EventArgs e)
        {

            dis_en(true);
            flagKH = 1;
            cbbKhachHang.Text = "";
            txtIDKhachHang.ReadOnly = false;
            cbbTenNhanVienPhuTrach.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            foreach (TextBox t in gbThongTinKhachHang.Controls.OfType<TextBox>())
            {
                if (t == txtIdNhanVienPhuTrach)
                {
                    continue;
                }
                t.Clear();
                t.Enabled = true;
            }
        }

        private void btnSuaKhachHangMoi_Click(object sender, EventArgs e)
        {

            dis_en(true);
            flagKH = 2;
            txtIDKhachHang.Enabled = false;
            cbbTenNhanVienPhuTrach.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            foreach (TextBox t in gbThongTinKhachHang.Controls.OfType<TextBox>())
            {
                if(t == txtIDKhachHang)
                {
                    continue;
                }
                t.Enabled = true;
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Clear();
            dis_en(true);
            foreach (TextBox t in gbThongTinPGC.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
            foreach (TextBox t in gbThongTinKhachHang.Controls.OfType<TextBox>())
            {
                if (t == txtIDKhachHang)
                {
                    continue;
                }
                t.Clear();
            }
            if (this.BatDongSanXuLy == null)
            {
                foreach (TextBox t in gbThongTinBDS.Controls.OfType<TextBox>())
                {
                    if (t == txtIDBDS)
                    {
                        continue;
                    }
                    t.Clear();
                }
            }
            
            btnChonAnh.Enabled = false;
            btnLichThanhToan.Enabled = false;
            txtTienCoc.Text = "0";
            txtTienDoHoanThanh.Text = "0";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtID.Enabled = false;
            dis_en(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flag = 3;
            txtID.Clear();

            dis_en(true);
            foreach (TextBox t in gbThongTinPGC.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
            foreach (TextBox t in gbThongTinKhachHang.Controls.OfType<TextBox>())
            {
                t.Clear();
            }

            if (this.BatDongSanXuLy == null)
            {
                foreach (TextBox t in gbThongTinBDS.Controls.OfType<TextBox>())
                {
                    t.Clear();
                }
            }
            
            dtpNgayLapPhieu.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            txtTienCoc.Enabled = false;
            cbbKhachHang.Enabled = true;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa phiếu giữ chỗ " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (PhieuGiuChoDAO.Instance.XoaPhieuGiuCho(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucPhieuGiuCho_Load(sender, e);
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
                string idkhachhang = txtIDKhachHang.Text;
                string hoten = cbbKhachHang.Text;
                string gioitinh = cbbGioiTinh.Text;
                string ngaysinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string sothecancuoc = txtSoTheCanCuoc.Text;
                string nguyenquan = txtNguyenQuan.Text;
                string diachithuongtru = txtDiaChiThuongTru.Text;
                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string idnhanvienphutrach = txtIdNhanVienPhuTrach.Text;
                string masothue = txtMaSoThue.Text;
                string ghichu = txtGhiChu.Text;

                if (flagKH == 1)
                {
                    if
                    (
                        KhachHangDAO.Instance.ThemKhachHang(idkhachhang, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                        idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dis_en(false);

                    btnChonAnh.Enabled = true;
                }
                if (flagKH == 2)
                {
                    if
                    (
                        KhachHangDAO.Instance.SuaKhacHang(idkhachhang, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                        idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dis_en(false);

                }

                txtIDKhachHang.ReadOnly = true;
                cbbTenNhanVienPhuTrach.Enabled = false;
                dtpNgaySinh.Enabled = false;
                cbbGioiTinh.Enabled = false;
                foreach (TextBox t in gbThongTinKhachHang.Controls.OfType<TextBox>())
                {
                    t.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn cần nhập lại thông tin!\n\n" + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string idkhachang = txtIDKhachHang.Text;
                string idBDS = txtIDBDS.Text;
                string ngaylapphieu = dtpNgayLapPhieu.Value.ToString("yyyy/MM/dd");
                string ngayhethan = dtpNgayHetHan.Value.ToString("yyyy/MM/dd");
                int uutien = (int)nUuTien.Value;
                string ghichu = txtGhiChu.Text;
                string trangthai = cbbTrangThai.Text;

                
                if (flag == 1)
                {
                    double tiencoc = double.Parse(txtTienCoc.Text);
                    double tiendohoanthanh = double.Parse(txtTienDoHoanThanh.Text);
                    if (PhieuGiuChoDAO.Instance.ThemPhieuGiuCho(idkhachang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, uutien, trangthai, ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucPhieuGiuCho_Load(sender, e);
                    dis_en(false);

                    btnChonAnh.Enabled = true;
                    btnLichThanhToan.Enabled = true;
                }

                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    double tiencoc = double.Parse(txtTienCoc.Text);

                    double tiendohoanthanh = double.Parse(txtTienDoHoanThanh.Text);
                    if (PhieuGiuChoDAO.Instance.SuaPhieuGiuCho(id, idkhachang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, uutien, trangthai, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucPhieuGiuCho_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataPGC = PhieuGiuChoDAO.Instance.TimKiemPhieuGiuCho(idBDS, idkhachang, uutien, trangthai, ghichu);
                    dgvDanhMucPhieuGiuCho.DataSource = dataPGC;
                    Bingding();
                    dis_en(false);
                    dtpNgayLapPhieu.Enabled = true;
                    dtpNgayHetHan.Enabled = true;
                    txtTienCoc.Enabled = true;

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn cần nhập lại thông tin!\n\n" + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            flag = 0;
            flagKH = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fDanhMucPhieuGiuCho_Load(sender, e);

            flag = 0;
            flagKH = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fDanhMucPhieuGiuCho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtDonGia.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtDonGia.Text = String.Format(culture, "{0:N0}", value);
            txtDonGia.Select(txtDonGia.Text.Length, 0);
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtTienCoc.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtTienCoc.Text = String.Format(culture, "{0:N0}", value);
            txtTienCoc.Select(txtTienCoc.Text.Length, 0);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            DataTable data = PhieuGiuChoDAO.Instance.GetPhieuGiuChoByID(int.Parse(txtID.Text));
            PhieuGiuChoDTO PGCXuLy = new PhieuGiuChoDTO();

            foreach (DataRow item in data.Rows)
            {
                PGCXuLy = new PhieuGiuChoDTO(item);
            }

            fAnhGiuCho f = new fAnhGiuCho(PGCXuLy);
            f.ShowDialog();
            this.Show();
        }

        private void btnLichThanhToan_Click(object sender, EventArgs e)
        {
            DataTable data = PhieuGiuChoDAO.Instance.GetPhieuGiuChoByID(int.Parse(txtID.Text));
            PhieuGiuChoDTO PGCXuLy = new PhieuGiuChoDTO();

            foreach (DataRow item in data.Rows)
            {
                PGCXuLy = new PhieuGiuChoDTO(item);
            }

            fLTTGiuCho f = new fLTTGiuCho(PGCXuLy);
            f.ShowDialog();
            this.Show();
            fDanhMucPhieuGiuCho_Load(sender, e);
        }

        private void dtpNgayHetHan_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dtpNgayLapPhieu.Value;
            DateTime date2 = dtpNgayHetHan.Value;
            int tmp = DateTime.Compare(date1, date2);
            if(tmp > 0)
            {
                MessageBox.Show("Ngày hết hạn sớm hơn ngày lập phiếu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dtpNgayHetHan.Value = dtpNgayLapPhieu.Value;
        }

       
    }
}
