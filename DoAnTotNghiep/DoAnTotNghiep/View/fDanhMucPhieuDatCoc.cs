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
    public partial class fDanhMucPhieuDatCoc : Form
    {
        private BatDongSanDTO batDongSanXuLy;

        public BatDongSanDTO BatDongSanXuLy { get => batDongSanXuLy; set => batDongSanXuLy = value; }

        public fDanhMucPhieuDatCoc()
        {
            InitializeComponent();
        }

        public fDanhMucPhieuDatCoc(BatDongSanDTO BatDongSanXuLy)
        {
            InitializeComponent();
            this.BatDongSanXuLy = BatDongSanXuLy;
        }

        private void fDanhMucPhieuDatCoc_Load(object sender, EventArgs e)
        {

            DataTable dataPDC;
            if (this.BatDongSanXuLy != null)
            {
                txtIDBDS.Enabled = false;
                cbbBDS.Enabled = false;
                dataPDC = PhieuDatCocDAO.Instance.GetListPhieuDatCocByIDBDS(BatDongSanXuLy.Id);

                btnThemKhachHangMoi.Visible = true;
                btnSuaKhachHangMoi.Visible = true;

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
                dataPDC = PhieuDatCocDAO.Instance.GetListPhieuDatCoc(); ;

                btnThemKhachHangMoi.Visible = false;
                btnSuaKhachHangMoi.Visible = false;
            }

            txtID.Visible = false;
            dgvDanhMucPhieuDatCoc.DataSource = dataPDC;
            dgvDanhMucPhieuDatCoc.Columns["id"].HeaderText = "ID";
            dgvDanhMucPhieuDatCoc.Columns["ngaylapphieu"].HeaderText = "Ngày Lập Phiếu";
            dgvDanhMucPhieuDatCoc.Columns["ngayhethan"].HeaderText = "Ngày Hết Hạn";
            dgvDanhMucPhieuDatCoc.Columns["tiencoc"].HeaderText = "Tiền Cọc";
            dgvDanhMucPhieuDatCoc.Columns["tiendohoanthanh"].HeaderText = "Tiến Độ Hoàn Thành";
            dgvDanhMucPhieuDatCoc.Columns["tienboithuong"].HeaderText = "Tiền Bồi Thường";
            dgvDanhMucPhieuDatCoc.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucPhieuDatCoc.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucPhieuDatCoc.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucPhieuDatCoc.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucPhieuDatCoc.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucPhieuDatCoc.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucPhieuDatCoc.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucPhieuDatCoc.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucPhieuDatCoc.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucPhieuDatCoc.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucPhieuDatCoc.Columns["email"].HeaderText = "Email";
            dgvDanhMucPhieuDatCoc.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucPhieuDatCoc.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucPhieuDatCoc.Columns["hotennhanvien"].HeaderText = "Họ Tên Nhân Viên";

            dgvDanhMucPhieuDatCoc.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucPhieuDatCoc.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucPhieuDatCoc.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucPhieuDatCoc.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucPhieuDatCoc.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucPhieuDatCoc.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucPhieuDatCoc.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucPhieuDatCoc.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucPhieuDatCoc.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucPhieuDatCoc.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucPhieuDatCoc.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucPhieuDatCoc.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucPhieuDatCoc.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucPhieuDatCoc.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucPhieuDatCoc.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucPhieuDatCoc.Columns["tylechietkhau"].HeaderText = "Tỷ Lệ Chiết Khấu";
            dgvDanhMucPhieuDatCoc.Columns["tyleVAT"].HeaderText = "Tỷ Lệ VAT";
            dgvDanhMucPhieuDatCoc.Columns["trangthaiBDS"].HeaderText = "Trạng Thái Bất Động Sản";

            txtID.Enabled = false;

            dtpNgayLapPhieu.Enabled = true;
            txtTienCoc.Enabled = true;

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
            txtID.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "id", true, DataSourceUpdateMode.Never);


            txtIDKhachHang.DataBindings.Clear();
            txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            cbbKhachHang.DataBindings.Clear();
            cbbKhachHang.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "hotenkhachhang", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "email", true, DataSourceUpdateMode.Never);


            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtIdNhanVienPhuTrach.DataBindings.Clear();
            txtIdNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbTenNhanVienPhuTrach.DataBindings.Clear();
            cbbTenNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "hotennhanvien", true, DataSourceUpdateMode.Never);



            txtIDBDS.DataBindings.Clear();
            txtIDBDS.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idBDS", true, DataSourceUpdateMode.Never);

            cbbBDS.DataBindings.Clear();
            cbbBDS.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtIDKhuDat.DataBindings.Clear();
            txtIDKhuDat.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idkhudat", true, DataSourceUpdateMode.Never);

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtIDLoaiBDS.DataBindings.Clear();
            txtIDLoaiBDS.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "idloaiBDS", true, DataSourceUpdateMode.Never);

            txtTenLoaiBDS.DataBindings.Clear();
            txtTenLoaiBDS.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            txtTyLeChietKhau.DataBindings.Clear();
            txtTyLeChietKhau.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tylechietkhau", true, DataSourceUpdateMode.Never);

            txtTyLeVAT.DataBindings.Clear();
            txtTyLeVAT.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tyleVAT", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "trangthaiBDS", true, DataSourceUpdateMode.Never);


            dtpNgayLapPhieu.DataBindings.Clear();
            dtpNgayLapPhieu.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "ngaylapphieu", true, DataSourceUpdateMode.Never);

            txtTienCoc.DataBindings.Clear();
            txtTienCoc.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tiencoc", true, DataSourceUpdateMode.Never);

            txtTienDoHoanThanh.DataBindings.Clear();
            txtTienDoHoanThanh.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tiendohoanthanh", true, DataSourceUpdateMode.Never);


            txtTienBoiThuong.DataBindings.Clear();
            txtTienBoiThuong.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "tienboithuong", true, DataSourceUpdateMode.Never);

            cbbTrangThai.DataBindings.Clear();
            cbbTrangThai.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "trangthai", true, DataSourceUpdateMode.Never);


            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucPhieuDatCoc.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
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
                if (t == txtIDKhachHang)
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
            foreach (TextBox t in gbThongTinPDC.Controls.OfType<TextBox>())
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
            txtTienBoiThuong.Text = "0";
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
            foreach (TextBox t in gbThongTinPDC.Controls.OfType<TextBox>())
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
            txtTienBoiThuong.Enabled = false;
            cbbKhachHang.Enabled = true;
            dis_en(true);
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa phiếu đặt cọc " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (PhieuDatCocDAO.Instance.XoaPhieuDatCoc(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucPhieuDatCoc_Load(sender, e);
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

                string trangthai = cbbTrangThai.Text;
                string ghichu = txtGhiChu.Text;


                if (flag == 1)
                {
                    double tiencoc = double.Parse(txtTienCoc.Text);
                    double tienboithuong = double.Parse(txtTienBoiThuong.Text);
                    double tiendohoanthanh = double.Parse(txtTienDoHoanThanh.Text);
                    if (PhieuDatCocDAO.Instance.ThemPhieuDatCoc(idkhachang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, tienboithuong, trangthai,ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucPhieuDatCoc_Load(sender, e);
                    dis_en(false);

                    btnChonAnh.Enabled = true;
                    btnLichThanhToan.Enabled = true;
                }

                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    double tiencoc = double.Parse(txtTienCoc.Text);
                    double tienboithuong = double.Parse(txtTienBoiThuong.Text);
                    double tiendohoanthanh = double.Parse(txtTienDoHoanThanh.Text);
                    if (PhieuDatCocDAO.Instance.SuaPhieuDatCoc(id, idkhachang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, tienboithuong, trangthai, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucPhieuDatCoc_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {
                    DataTable dataPDC = PhieuDatCocDAO.Instance.TimKiemPhieuDatCoc(idBDS, idkhachang, trangthai, ghichu);
                    dgvDanhMucPhieuDatCoc.DataSource = dataPDC;
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
            fDanhMucPhieuDatCoc_Load(sender, e);
            flag = 0;
            flagKH = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucPhieuDatCoc_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtTienBoiThuong_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtTienBoiThuong.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtTienBoiThuong.Text = String.Format(culture, "{0:N0}", value);
            txtTienBoiThuong.Select(txtTienBoiThuong.Text.Length, 0);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            DataTable data = PhieuDatCocDAO.Instance.GetPhieuDatCocByID(int.Parse(txtID.Text));
            PhieuDatCocDTO PDCXuLy = new PhieuDatCocDTO();

            foreach (DataRow item in data.Rows)
            {
                PDCXuLy = new PhieuDatCocDTO(item);
            }

            fAnhDatCoc f = new fAnhDatCoc(PDCXuLy);
            f.ShowDialog();
            this.Show();
        }

        private void btnLichThanhToan_Click(object sender, EventArgs e)
        {
            DataTable data = PhieuDatCocDAO.Instance.GetPhieuDatCocByID(int.Parse(txtID.Text));
            PhieuDatCocDTO PDCXuLy = new PhieuDatCocDTO();

            foreach (DataRow item in data.Rows)
            {
                PDCXuLy = new PhieuDatCocDTO(item);
            }

            fLTTDatCoc f = new fLTTDatCoc(PDCXuLy);
            f.ShowDialog();
            this.Show();

            fDanhMucPhieuDatCoc_Load(sender, e);
        }

        private void dtpNgayHetHan_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dtpNgayLapPhieu.Value;
            DateTime date2 = dtpNgayHetHan.Value;
            int tmp = DateTime.Compare(date1, date2);
            if (tmp > 0)
            {
                MessageBox.Show("Ngày hết hạn sớm hơn ngày lập phiếu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dtpNgayHetHan.Value = dtpNgayLapPhieu.Value;
        }
    }
}
