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
    public partial class fDanhMucKhachHang : Form
    {


        public fDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void fDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dataKhachHang = KhachHangDAO.Instance.GetListKhachHang();
            dgvDanhMucKhachHang.DataSource = dataKhachHang;
            dgvDanhMucKhachHang.Columns["id"].HeaderText = "ID";
            dgvDanhMucKhachHang.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDanhMucKhachHang.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDanhMucKhachHang.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDanhMucKhachHang.Columns["sothecancuoc"].HeaderText = "Số Thẻ Căn Cước";
            dgvDanhMucKhachHang.Columns["nguyenquan"].HeaderText = "Nguyên Quán";
            dgvDanhMucKhachHang.Columns["diachithuongtru"].HeaderText = "Địa Chỉ Thường Trú";
            dgvDanhMucKhachHang.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucKhachHang.Columns["email"].HeaderText = "Email";
            dgvDanhMucKhachHang.Columns["masothue"].HeaderText = "Mã Số Thuế";
            dgvDanhMucKhachHang.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucKhachHang.Columns["hotennhanvien"].HeaderText = "Họ Tên Nhân Viên";
            dgvDanhMucKhachHang.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
            
            cbbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnChonAnh.Enabled = true;
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
            txtID.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "id", true, DataSourceUpdateMode.Never);

            
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "hoten", true, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never);

            txtSoTheCanCuoc.DataBindings.Clear();
            txtSoTheCanCuoc.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "sothecancuoc", true, DataSourceUpdateMode.Never);

            txtNguyenQuan.DataBindings.Clear();
            txtNguyenQuan.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "nguyenquan", true, DataSourceUpdateMode.Never);

            txtDiaChiThuongTru.DataBindings.Clear();
            txtDiaChiThuongTru.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "diachithuongtru", true, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "email", true, DataSourceUpdateMode.Never);

           
            txtMaSoThue.DataBindings.Clear();
            txtMaSoThue.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "masothue", true, DataSourceUpdateMode.Never);

            txtIdNhanVienPhuTrach.DataBindings.Clear();
            txtIdNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbTenNhanVienPhuTrach.DataBindings.Clear();
            cbbTenNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "hotennhanvien", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucKhachHang.DataSource, "ghichu", true, DataSourceUpdateMode.Never);

            //pbAnhCanCuoc.DataBindings.Clear();
            //pbAnhCanCuoc.DataBindings.Add("Image", dgvDanhMucKhachHang.DataSource, "anhcancuoc", true, DataSourceUpdateMode.Never);

            //pbAnhHoKhau.DataBindings.Clear();
            //pbAnhHoKhau.DataBindings.Add("Image", dgvDanhMucKhachHang.DataSource, "anhhokhau", true, DataSourceUpdateMode.Never);

            //pbAnhKetHon.DataBindings.Clear();
            //pbAnhKetHon.DataBindings.Add("Image", dgvDanhMucKhachHang.DataSource, "anhkethon", true, DataSourceUpdateMode.Never);

        }

        int flag = 0;

        private void cbbTenNhanVienPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdNhanVienPhuTrach.Text = cbbTenNhanVienPhuTrach.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            btnChonAnh.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            { 
                if (t == txtIdNhanVienPhuTrach)
                {
                    continue;
                }
                t.Clear();
            }
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
            txtID.Enabled = true;
            cbbGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (KhachHangDAO.Instance.XoaKhachHang(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucKhachHang_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private void btnNhuCau_Click(object sender, EventArgs e)
        {
            DataTable data = KhachHangDAO.Instance.GetKhachHangByID(txtID.Text);
            KhachHangDTO KhachHangXuLy = new KhachHangDTO();

            foreach (DataRow item in data.Rows)
            {
                KhachHangXuLy = new KhachHangDTO(item);
            }


            fDanhMucNhuCau f = new fDanhMucNhuCau(KhachHangXuLy);
            f.ShowDialog();
            this.Show();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string hoten = txtHoTen.Text;
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

                //var anhcancuoc_tmp = new ImageConverter().ConvertTo(pbAnhCanCuoc.Image, typeof(Byte[]));
                //var anhhokhau_tmp = new ImageConverter().ConvertTo(pbAnhHoKhau.Image, typeof(Byte[]));
                //var anhkethon_tmp = new ImageConverter().ConvertTo(pbAnhKetHon.Image, typeof(Byte[]));
                //byte[] anhcancuoc = (byte[])anhcancuoc_tmp;
                //byte[] anhhokhau = (byte[])anhhokhau_tmp;
                //byte[] anhkethon = (byte[])anhkethon_tmp;


                if (flag == 1)
                {
                    if
                    (
                        KhachHangDAO.Instance.ThemKhachHang(id, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                        idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucKhachHang_Load(sender, e);
                    dis_en(false);

                    btnChonAnh.Enabled = true;
                }
                if (flag == 2)
                {
                    if
                    (
                        KhachHangDAO.Instance.SuaKhacHang(id, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                        idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucKhachHang_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataKhachHang = KhachHangDAO.Instance.TimKiemKhachHang(id, hoten, sothecancuoc, nguyenquan,
                        diachithuongtru, sdt, email, masothue, idnhanvienphutrach, ghichu);
                    dgvDanhMucKhachHang.DataSource = dataKhachHang;
                    
                    cbbGioiTinh.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    Bingding();
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
            fDanhMucKhachHang_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            DataTable data = KhachHangDAO.Instance.GetKhachHangByID(txtID.Text);
            KhachHangDTO KhachHangXuLy = new KhachHangDTO();

            foreach (DataRow item in data.Rows)
            {
                KhachHangXuLy = new KhachHangDTO(item);
            }



            if (rbAnhCanCuoc.Checked)
            {
                
                fAnhCanCuoc f = new fAnhCanCuoc(KhachHangXuLy);
                f.ShowDialog();
                this.Show();
            }
            if (rbAnhHoKhau.Checked)
            {
                fAnhHoKhau f = new fAnhHoKhau(KhachHangXuLy);
                f.ShowDialog();
                this.Show();
            }
            if (rbAnhKetHon.Checked)
            {
                fAnhKetHon f = new fAnhKetHon(KhachHangXuLy);
                f.ShowDialog();
                this.Show();
            }

        }

        private void dgvDanhMucKhachHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvDanhMucKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }
    }
}
