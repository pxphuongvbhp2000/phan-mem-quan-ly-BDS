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

using System.Globalization;

namespace DoAnTotNghiep.View
{
    public partial class fDanhMucHopDongMuaBan : Form
    {
        private BatDongSanDTO batDongSanXuLy;

        public BatDongSanDTO BatDongSanXuLy { get => batDongSanXuLy; set => batDongSanXuLy = value; }


        public fDanhMucHopDongMuaBan()
        {
            InitializeComponent();
        }

        public fDanhMucHopDongMuaBan(BatDongSanDTO BatDongSanXuLy)
        {
            InitializeComponent();
            this.BatDongSanXuLy = BatDongSanXuLy;
        }

        private void fDanhMucHopDongMuaBan_Load(object sender, EventArgs e)
        {

            DataTable dataHDMB;
            if (this.BatDongSanXuLy != null)
            {
                txtIDBDS.Enabled = false;
                cbbBDS.Enabled = false;
                dataHDMB = HopDongMuaBanDAO.Instance.GetListHDMBByIDBDS(BatDongSanXuLy.Id);

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
                dataHDMB = HopDongMuaBanDAO.Instance.GetListHopDongMuaBan();

                btnThemKhachHangMoi.Visible = false;
                btnSuaKhachHangMoi.Visible = false;
            }

            dgvDanhMucHopDongMuaBan.DataSource = dataHDMB;
            dgvDanhMucHopDongMuaBan.Columns["id"].HeaderText = "ID";
            dgvDanhMucHopDongMuaBan.Columns["ngaylap"].HeaderText = "Ngày Lập";
            dgvDanhMucHopDongMuaBan.Columns["thanhtien"].HeaderText = "Thành Tiền";
            dgvDanhMucHopDongMuaBan.Columns["tiendohoanthanh"].HeaderText = "Tiến Độ Hoàn Thành";
            dgvDanhMucHopDongMuaBan.Columns["muchoahongCT"].HeaderText = "Mức Hoa Hồng CT";
            dgvDanhMucHopDongMuaBan.Columns["muchoahongNV"].HeaderText = "Mức Hoa Hồng NV";
            dgvDanhMucHopDongMuaBan.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucHopDongMuaBan.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucHopDongMuaBan.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucHopDongMuaBan.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucHopDongMuaBan.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucHopDongMuaBan.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucHopDongMuaBan.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucHopDongMuaBan.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucHopDongMuaBan.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucHopDongMuaBan.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucHopDongMuaBan.Columns["email"].HeaderText = "Email";
            dgvDanhMucHopDongMuaBan.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucHopDongMuaBan.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucHopDongMuaBan.Columns["hotennhanvien"].HeaderText = "Họ Tên Nhân Viên";

            dgvDanhMucHopDongMuaBan.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucHopDongMuaBan.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucHopDongMuaBan.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucHopDongMuaBan.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucHopDongMuaBan.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucHopDongMuaBan.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucHopDongMuaBan.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucHopDongMuaBan.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucHopDongMuaBan.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucHopDongMuaBan.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucHopDongMuaBan.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucHopDongMuaBan.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucHopDongMuaBan.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucHopDongMuaBan.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucHopDongMuaBan.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucHopDongMuaBan.Columns["tylechietkhau"].HeaderText = "Tỷ Lệ Chiết Khấu";
            dgvDanhMucHopDongMuaBan.Columns["tyleVAT"].HeaderText = "Tỷ Lệ VAT";
            dgvDanhMucHopDongMuaBan.Columns["trangthaiBDS"].HeaderText = "Trạng Thái Bất Động Sản";

            txtID.Enabled = false;

            dtpNgayLap.Enabled = true;
            txtThanhTien.Enabled = true;
            txtTienDoHoanThanh.ReadOnly = true;

            txtMucHoaHongCT.Enabled = true;
            txtMucHoaHongNV.Enabled = true;


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
            btnTimKiem.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }

        int flag = 0;

        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "id", true, DataSourceUpdateMode.Never);


            txtIDKhachHang.DataBindings.Clear();
            txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            cbbKhachHang.DataBindings.Clear();
            cbbKhachHang.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "hotenkhachhang", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "email", true, DataSourceUpdateMode.Never);


            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtIdNhanVienPhuTrach.DataBindings.Clear();
            txtIdNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbTenNhanVienPhuTrach.DataBindings.Clear();
            cbbTenNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "hotennhanvien", true, DataSourceUpdateMode.Never);



            txtIDBDS.DataBindings.Clear();
            txtIDBDS.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idBDS", true, DataSourceUpdateMode.Never);

            cbbBDS.DataBindings.Clear();
            cbbBDS.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtIDKhuDat.DataBindings.Clear();
            txtIDKhuDat.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idkhudat", true, DataSourceUpdateMode.Never);

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtIDLoaiBDS.DataBindings.Clear();
            txtIDLoaiBDS.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "idloaiBDS", true, DataSourceUpdateMode.Never);

            txtTenLoaiBDS.DataBindings.Clear();
            txtTenLoaiBDS.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            txtTyLeChietKhau.DataBindings.Clear();
            txtTyLeChietKhau.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tylechietkhau", true, DataSourceUpdateMode.Never);

            txtTyLeVAT.DataBindings.Clear();
            txtTyLeVAT.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tyleVAT", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "trangthaiBDS", true, DataSourceUpdateMode.Never);



            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "ngaylap", true, DataSourceUpdateMode.Never);

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "thanhtien", true, DataSourceUpdateMode.Never);

            txtTienDoHoanThanh.DataBindings.Clear();
            txtTienDoHoanThanh.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "tiendohoanthanh", true, DataSourceUpdateMode.Never);

            txtMucHoaHongCT.DataBindings.Clear();
            txtMucHoaHongCT.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "muchoahongCT", true, DataSourceUpdateMode.Never);


            txtMucHoaHongNV.DataBindings.Clear();
            txtMucHoaHongNV.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "muchoahongNV", true, DataSourceUpdateMode.Never);


            cbbTrangThai.DataBindings.Clear();
            cbbTrangThai.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "trangthai", true, DataSourceUpdateMode.Never);


            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucHopDongMuaBan.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
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
            txtID.Enabled = true;
            dis_en(true);
            foreach (TextBox t in gbThongTinHDMB.Controls.OfType<TextBox>())
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

            txtThanhTien.Text = "0";
            txtMucHoaHongCT.Text = "0";
            txtMucHoaHongNV.Text = "0";


            btnChonAnh.Enabled = false;
            btnLichThanhToan.Enabled = false;
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
            txtID.Enabled = true;

            dis_en(true);
            foreach (TextBox t in gbThongTinHDMB.Controls.OfType<TextBox>())
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
            dtpNgayLap.Enabled = false;
            txtThanhTien.Enabled = false;
            txtTienDoHoanThanh.Enabled = false;
            cbbKhachHang.Enabled = true;
            txtMucHoaHongCT.Enabled = false;
            txtMucHoaHongNV.Enabled = false;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa hợp đồng thanh toán " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (HopDongMuaBanDAO.Instance.XoaHopDongMuaBan(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucHopDongMuaBan_Load(sender, e);
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
                string id = txtID.Text;
                string idkhachang = txtIDKhachHang.Text;
                string idBDS = txtIDBDS.Text;
                string ngaylap = dtpNgayLap.Value.ToString("yyyy/MM/dd");
                string ghichu = txtGhiChu.Text;
                string trangthai = cbbTrangThai.Text;



                if (flag == 1)
                {
                    double thanhtien = double.Parse(txtThanhTien.Text);
                    double muchoahongCT = double.Parse(txtMucHoaHongCT.Text);
                    double muchoahongNV = double.Parse(txtMucHoaHongNV.Text);
                    double tiendohoanthanh = 0;
                    if (HopDongMuaBanDAO.Instance.ThemHopDongMuaBan(id, idkhachang, idBDS, ngaylap, thanhtien, tiendohoanthanh, muchoahongCT, muchoahongNV, trangthai, ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucHopDongMuaBan_Load(sender, e);
                    dis_en(false);


                    btnChonAnh.Enabled = true;
                    btnLichThanhToan.Enabled = true;

                }

                if (flag == 2)
                {
                    double thanhtien = double.Parse(txtThanhTien.Text);
                    double muchoahongCT = double.Parse(txtMucHoaHongCT.Text);
                    double muchoahongNV = double.Parse(txtMucHoaHongNV.Text);
                    if (HopDongMuaBanDAO.Instance.SuaHopDongMuaBan(id, idkhachang, idBDS, ngaylap, thanhtien, muchoahongCT, muchoahongNV, trangthai, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucHopDongMuaBan_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {
                    DataTable dataHDMB = HopDongMuaBanDAO.Instance.TimKiemHopDongMuaBan(id, idBDS, idkhachang, trangthai, ghichu);
                    dgvDanhMucHopDongMuaBan.DataSource = dataHDMB;
                    Bingding();
                    dis_en(false);
                    dtpNgayLap.Enabled = true;
                    txtThanhTien.Enabled = true;
                    txtTienDoHoanThanh.Enabled = true;

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
            fDanhMucHopDongMuaBan_Load(sender, e);
            flag = 0;
            flagKH = 0;
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucHopDongMuaBan_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLichThanhToan_Click(object sender, EventArgs e)
        {
            
            DataTable data = HopDongMuaBanDAO.Instance.GetHopDongMuaBanByID(txtID.Text);
            HopDongMuaBanDTO HDMBXuLy = new HopDongMuaBanDTO();

            foreach (DataRow item in data.Rows)
            {
                HDMBXuLy = new HopDongMuaBanDTO(item);
            }


            fLTTHopDong f = new fLTTHopDong(HDMBXuLy);
            f.ShowDialog();
            this.Show();
            fDanhMucHopDongMuaBan_Load(sender, e);
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

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtThanhTien.Text = String.Format(culture, "{0:N0}", value);
            txtThanhTien.Select(txtThanhTien.Text.Length, 0);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            DataTable data = HopDongMuaBanDAO.Instance.GetHopDongMuaBanByID(txtID.Text);
            HopDongMuaBanDTO HDMBXuLy = new HopDongMuaBanDTO();

            foreach (DataRow item in data.Rows)
            {
                HDMBXuLy = new HopDongMuaBanDTO(item);
            }


            fAnhHopDong f = new fAnhHopDong(HDMBXuLy);
            f.ShowDialog();
            this.Show();
        }

        
    }
}
