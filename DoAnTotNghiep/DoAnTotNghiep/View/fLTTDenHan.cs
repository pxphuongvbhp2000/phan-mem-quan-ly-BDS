using System;
using DoAnTotNghiep.DAO;
using DoAnTotNghiep.DTO;
using DoAnTotNghiep.View;
using DoAnTotNghiep.Report;
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
    public partial class fLTTDenHan : Form
    {
        private NhanVienDTO tKDangNhap;

        public NhanVienDTO TKDangNhap { get => tKDangNhap; set => tKDangNhap = value; }

        public fLTTDenHan()
        {
            InitializeComponent();
        }

        public fLTTDenHan(NhanVienDTO TKDangNhap)
        {
            InitializeComponent();
            this.TKDangNhap = TKDangNhap;
        }

        private void fLTTDenHan_Load(object sender, EventArgs e)
        {
            Load_DGV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Load_DGV();
        }

        void Load_DGV()
        {

            string ngayD = dtpD.Value.ToString("yyyy/MM/dd");
            string ngayU = dtpU.Value.ToString("yyyy/MM/dd");

            DataTable dataLTTPGC = PhieuGiuChoDAO.Instance.GetLTTPGCByNgayThu(TKDangNhap.Id, ngayD, ngayU);

            dgvDanhMucLTTPGC.DataSource = dataLTTPGC;
            dgvDanhMucLTTPGC.Columns["id"].HeaderText = "ID";

            dgvDanhMucLTTPGC.Columns["idphieugiucho"].HeaderText = "ID Phiếu Giữ Chỗ";
            dgvDanhMucLTTPGC.Columns["ngaythu"].HeaderText = "Ngày Thu";
            dgvDanhMucLTTPGC.Columns["sotien"].HeaderText = "Số Tiền";
            dgvDanhMucLTTPGC.Columns["phantram"].HeaderText = "Phần Trăm";
            dgvDanhMucLTTPGC.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucLTTPGC.Columns["anhphieuthu"].HeaderText = "Ảnh Phiếu Thu";
            dgvDanhMucLTTPGC.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucLTTPGC.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucLTTPGC.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucLTTPGC.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucLTTPGC.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucLTTPGC.Columns["email"].HeaderText = "Email";

            dgvDanhMucLTTPGC.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucLTTPGC.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucLTTPGC.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucLTTPGC.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucLTTPGC.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucLTTPGC.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucLTTPGC.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucLTTPGC.Columns["dongia"].HeaderText = "Đơn Giá";

            DataTable dataLTTPDC = PhieuDatCocDAO.Instance.GetLTTPDCByNgayThu(TKDangNhap.Id, ngayD, ngayU);

            dgvDanhMucLTTPDC.DataSource = dataLTTPDC;
            dgvDanhMucLTTPDC.Columns["id"].HeaderText = "ID";

            dgvDanhMucLTTPDC.Columns["idphieudatcoc"].HeaderText = "ID Phiếu Đặt Cọc";
            dgvDanhMucLTTPDC.Columns["ngaythu"].HeaderText = "Ngày Thu";
            dgvDanhMucLTTPDC.Columns["sotien"].HeaderText = "Số Tiền";
            dgvDanhMucLTTPDC.Columns["phantram"].HeaderText = "Phần Trăm";
            dgvDanhMucLTTPDC.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucLTTPDC.Columns["anhphieuthu"].HeaderText = "Ảnh Phiếu Thu";
            dgvDanhMucLTTPDC.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucLTTPDC.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucLTTPDC.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucLTTPDC.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucLTTPDC.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucLTTPDC.Columns["email"].HeaderText = "Email";

            dgvDanhMucLTTPDC.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucLTTPDC.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucLTTPDC.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucLTTPDC.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucLTTPDC.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucLTTPDC.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucLTTPDC.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucLTTPDC.Columns["dongia"].HeaderText = "Đơn Giá";

            DataTable dataLTTHDMB = HopDongMuaBanDAO.Instance.GetLTTHDMBByNgayThu(TKDangNhap.Id, ngayD, ngayU);

            dgvDanhMucLTTHDMB.DataSource = dataLTTHDMB;
            dgvDanhMucLTTHDMB.Columns["id"].HeaderText = "ID";

            dgvDanhMucLTTHDMB.Columns["idhopdongmuaban"].HeaderText = "ID Hợp Đồng Mua Bán";
            dgvDanhMucLTTHDMB.Columns["ngaythu"].HeaderText = "Ngày Thu";
            dgvDanhMucLTTHDMB.Columns["sotien"].HeaderText = "Số Tiền";
            dgvDanhMucLTTHDMB.Columns["phantram"].HeaderText = "Phần Trăm";
            dgvDanhMucLTTHDMB.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucLTTHDMB.Columns["anhphieuthu"].HeaderText = "Ảnh Phiếu Thu";
            dgvDanhMucLTTHDMB.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucLTTHDMB.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucLTTHDMB.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucLTTHDMB.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucLTTHDMB.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucLTTHDMB.Columns["email"].HeaderText = "Email";

            dgvDanhMucLTTHDMB.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucLTTHDMB.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucLTTHDMB.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucLTTHDMB.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucLTTHDMB.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucLTTHDMB.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucLTTHDMB.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucLTTHDMB.Columns["dongia"].HeaderText = "Đơn Giá";

        }

        private void dgvDanhMucLTT_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvDanhMucLTTPGC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
            if (dgvDanhMucLTTPDC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }

            if (dgvDanhMucLTTHDMB.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        
    }
}
