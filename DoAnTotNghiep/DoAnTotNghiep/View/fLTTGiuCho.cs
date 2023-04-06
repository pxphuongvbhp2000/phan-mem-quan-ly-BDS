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
    public partial class fLTTGiuCho : Form
    {
        private PhieuGiuChoDTO pGCXuLy;

        public PhieuGiuChoDTO PGCXuLy { get => pGCXuLy; set => pGCXuLy = value; }


        public fLTTGiuCho()
        {
            InitializeComponent();
        }

        public fLTTGiuCho(PhieuGiuChoDTO PGCXuLy)
        {
            InitializeComponent();
            this.PGCXuLy = PGCXuLy;
        }

        private void fLTTGiuCho_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            DataTable dataLTT = PhieuGiuChoDAO.Instance.GetLichThanhToanByIDPGC(this.PGCXuLy.Id);

            dgvDanhMucLichThanhToan.DataSource = dataLTT;
            dgvDanhMucLichThanhToan.Columns["id"].HeaderText = "ID";

            dgvDanhMucLichThanhToan.Columns["idphieugiucho"].HeaderText = "ID Phiếu Giữ Chỗ";
            dgvDanhMucLichThanhToan.Columns["ngaythu"].HeaderText = "Ngày Thu";
            dgvDanhMucLichThanhToan.Columns["sotien"].HeaderText = "Số Tiền";
            dgvDanhMucLichThanhToan.Columns["phantram"].HeaderText = "Phần Trăm";
            dgvDanhMucLichThanhToan.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucLichThanhToan.Columns["anhphieuthu"].HeaderText = "Ảnh Phiếu Thu";
            dgvDanhMucLichThanhToan.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvDanhMucLichThanhToan.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucLichThanhToan.Columns["hotenkhachhang"].HeaderText = "Họ Tên Khách Hàng";
            dgvDanhMucLichThanhToan.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucLichThanhToan.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucLichThanhToan.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucLichThanhToan.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucLichThanhToan.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucLichThanhToan.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucLichThanhToan.Columns["email"].HeaderText = "Email";
            dgvDanhMucLichThanhToan.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucLichThanhToan.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucLichThanhToan.Columns["hotennhanvien"].HeaderText = "Họ Tên Nhân Viên";

            dgvDanhMucLichThanhToan.Columns["idBDS"].HeaderText = "ID BĐS";
            dgvDanhMucLichThanhToan.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucLichThanhToan.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucLichThanhToan.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucLichThanhToan.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucLichThanhToan.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucLichThanhToan.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucLichThanhToan.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucLichThanhToan.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucLichThanhToan.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucLichThanhToan.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucLichThanhToan.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucLichThanhToan.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucLichThanhToan.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucLichThanhToan.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucLichThanhToan.Columns["tylechietkhau"].HeaderText = "Tỷ Lệ Chiết Khấu";
            dgvDanhMucLichThanhToan.Columns["tyleVAT"].HeaderText = "Tỷ Lệ VAT";
            dgvDanhMucLichThanhToan.Columns["trangthaiBDS"].HeaderText = "Trạng Thái Bất Động Sản";

            txtID.Enabled = false;

            dtpNgayThu.Enabled = true;
            txtSoTien.Enabled = true;
            cbbKhachHang.Enabled = false;
            cbbBDS.Enabled = false;

            LoadComBoBox();
            dis_en(false);
            Bingding();
        }
        void LoadComBoBox()
        {
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Chưa Hoàn Thành");
            cbbTrangThai.Items.Add("Đã Hoàn Thành");


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
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }

        int flag = 0;


        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtIDPGC.DataBindings.Clear();
            txtIDPGC.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idphieugiucho", true, DataSourceUpdateMode.Never);


            txtIDKhachHang.DataBindings.Clear();
            txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            cbbKhachHang.DataBindings.Clear();
            cbbKhachHang.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "hotenkhachhang", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "email", true, DataSourceUpdateMode.Never);


            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtIdNhanVienPhuTrach.DataBindings.Clear();
            txtIdNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbTenNhanVienPhuTrach.DataBindings.Clear();
            cbbTenNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "hotennhanvien", true, DataSourceUpdateMode.Never);



            txtIDBDS.DataBindings.Clear();
            txtIDBDS.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idBDS", true, DataSourceUpdateMode.Never);

            cbbBDS.DataBindings.Clear();
            cbbBDS.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtIDKhuDat.DataBindings.Clear();
            txtIDKhuDat.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idkhudat", true, DataSourceUpdateMode.Never);

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtIDLoaiBDS.DataBindings.Clear();
            txtIDLoaiBDS.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "idloaiBDS", true, DataSourceUpdateMode.Never);

            txtTenLoaiBDS.DataBindings.Clear();
            txtTenLoaiBDS.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            txtTyLeChietKhau.DataBindings.Clear();
            txtTyLeChietKhau.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "tylechietkhau", true, DataSourceUpdateMode.Never);

            txtTyLeVAT.DataBindings.Clear();
            txtTyLeVAT.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "tyleVAT", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "trangthaiBDS", true, DataSourceUpdateMode.Never);


            dtpNgayThu.DataBindings.Clear();
            dtpNgayThu.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "ngaythu", true, DataSourceUpdateMode.Never);

            txtSoTien.DataBindings.Clear();
            txtSoTien.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "sotien", true, DataSourceUpdateMode.Never);


            txtPhanTram.DataBindings.Clear();
            txtPhanTram.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "phantram", true, DataSourceUpdateMode.Never);

            cbbTrangThai.DataBindings.Clear();
            cbbTrangThai.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "trangthai", true, DataSourceUpdateMode.Never);

            pbAnhPhieuThu.DataBindings.Clear();
            pbAnhPhieuThu.DataBindings.Add("Image", dgvDanhMucLichThanhToan.DataSource, "anhphieuthu", true, DataSourceUpdateMode.Never);


            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucLichThanhToan.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
        }

        private void btnXemAnh_Click(object sender, EventArgs e)
        {
            fXemAnh f = new fXemAnh(pbAnhPhieuThu.Image);
            f.Show();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                pbAnhPhieuThu.Load(OD.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Clear();
            dis_en(true);
            foreach (TextBox t in gbThongTinLTT.Controls.OfType<TextBox>())
            {
                if (t == txtIDPGC)
                {
                    continue;
                }
                t.Clear();
            }

            txtPhanTram.Text = "0";
            txtSoTien.Text = "0";
            if(txtIDPGC.Text == "")
            {
                txtIDPGC.Text = PGCXuLy.Id.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtID.Enabled = false;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa lịch thanh toán " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (PhieuGiuChoDAO.Instance.XoaLTTGiuCho(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fLTTGiuCho_Load(sender, e);
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
                int idphieugiucho = int.Parse(txtIDPGC.Text);
                string ngaythu = dtpNgayThu.Value.ToString("yyyy/MM/dd");
                string trangthai = cbbTrangThai.Text;
                string ghichu = txtGhiChu.Text; 
                var anhphieuthu_tmp = new ImageConverter().ConvertTo(pbAnhPhieuThu.Image, typeof(Byte[]));
                byte[] anhphieuthu = (byte[])anhphieuthu_tmp;


                if (flag == 1)
                {
                    double sotien = double.Parse(txtSoTien.Text);

                    double phantram = double.Parse(txtPhanTram.Text);
                    if (PhieuGiuChoDAO.Instance.ThemLTTGiuCho(idphieugiucho, ngaythu, sotien, phantram, trangthai, anhphieuthu, ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fLTTGiuCho_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    double sotien = double.Parse(txtSoTien.Text);
                    double phantram = double.Parse(txtPhanTram.Text);
                    if (PhieuGiuChoDAO.Instance.SuaLTTGiuCho(id, idphieugiucho, ngaythu, sotien, phantram, trangthai, anhphieuthu, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fLTTGiuCho_Load(sender, e);
                    dis_en(false);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn cần nhập lại thông tin!\n\n" + ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fLTTGiuCho_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLTTGiuCho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtSoTien.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtSoTien.Text = String.Format(culture, "{0:N0}", value);
            txtSoTien.Select(txtSoTien.Text.Length, 0);
            double sotien = double.Parse(txtSoTien.Text);
            double tiencoc = PhieuGiuChoDAO.Instance.GetTienCoc(this.PGCXuLy.Id);
            double tmp = sotien / tiencoc * 100;
            txtPhanTram.Text = tmp.ToString();
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

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {
            if (txtPhanTram.Text == "")
            {
                txtPhanTram.Text = "0";
            }
        }

        private void dgvDanhMucLichThanhToan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvDanhMucLichThanhToan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }
    }
}
