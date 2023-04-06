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
    public partial class fTaskMannager : Form
    {
        private NhanVienDTO tKDangNhap;

        public NhanVienDTO TKDangNhap { get => tKDangNhap; set => tKDangNhap = value; }

        public fTaskMannager()
        {
            InitializeComponent();
        }

        public fTaskMannager(NhanVienDTO TKDangNhap)
        {
            InitializeComponent();
            this.TKDangNhap = TKDangNhap;
        }

        

        private void fTaskMannager_Load(object sender, EventArgs e)
        {
            Desing();
            lbWelcome.Text = this.TKDangNhap.Id.ToString() + " - " + this.TKDangNhap.Hoten.ToString();

            string query = "SELECT BatDongSan.id, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,"
                + "BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,"
                + "dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai, BatDongSan.ghichu "
                + "FROM BatDongSan "
                + "LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id "
                + "LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id";

            LoadBDS(query);
            LoadComBoBox();
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "id", true, DataSourceUpdateMode.Never);

        }

        void LoadBDS(string query)
        {

            DataTable dataBatDongSan = ThongKeBaoCao.Instance.GetDanhSachBDS(query);
            dgvDanhMucBatDongSan.DataSource = dataBatDongSan;
            dgvDanhMucBatDongSan.Columns["id"].HeaderText = "ID";
            dgvDanhMucBatDongSan.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucBatDongSan.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucBatDongSan.Columns["idkhudat"].HeaderText = "ID Khu Đất";
            dgvDanhMucBatDongSan.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucBatDongSan.Columns["idloaiBDS"].HeaderText = "ID Loại BĐS";
            dgvDanhMucBatDongSan.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucBatDongSan.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucBatDongSan.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucBatDongSan.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucBatDongSan.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucBatDongSan.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucBatDongSan.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucBatDongSan.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucBatDongSan.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucBatDongSan.Columns["tylechietkhau"].HeaderText = "Tỷ Lệ Chiết Khấu";
            dgvDanhMucBatDongSan.Columns["tyleVAT"].HeaderText = "Tỷ Lệ VAT";
            dgvDanhMucBatDongSan.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvDanhMucBatDongSan.Columns["ghichu"].HeaderText = "Ghi Chú";

        }

        void LoadComBoBox()
        {
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Chưa Bán");
            cbbTrangThai.Items.Add("Mở Bán");
            cbbTrangThai.Items.Add("Giữ Chỗ");
            cbbTrangThai.Items.Add("Đặt Cọc");
            cbbTrangThai.Items.Add("Đang Tiến Hành");
            cbbTrangThai.Items.Add("Đã Hoàn Thành");

            DataTable dataLoaiBDS = LoaiBatDongSanDAO.Instance.GetLoaiBatDongSanForCBB();
            cbbLoaiBDS.DataSource = dataLoaiBDS;
            cbbLoaiBDS.DisplayMember = "chitietLBDS";
            cbbLoaiBDS.ValueMember = "id";
            cbbLoaiBDS.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbLoaiBDS.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataDuAn = DuAnDAO.Instance.GetDuAnForCBB();
            cbbDuAn.DataSource = dataDuAn;
            cbbDuAn.DisplayMember = "chitietDA";
            cbbDuAn.ValueMember = "id";
            cbbDuAn.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbDuAn.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void txtIDDuAn_TextChanged(object sender, EventArgs e)
        {
            DataTable dataKhuDat = KhuDatDAO.Instance.GetKhuDatForCBBByIDDuAn(txtIDDuAn.Text);
            cbbKhuDat.DataSource = dataKhuDat;
            cbbKhuDat.DisplayMember = "chitietKD";
            cbbKhuDat.ValueMember = "id";
            cbbKhuDat.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbKhuDat.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbbDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDDuAn.Text = cbbDuAn.SelectedValue.ToString();
        }

        private void cbbKhuDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDKhuDat.Text = cbbKhuDat.SelectedValue.ToString();
        }

        private void cbbLoaiBDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDLoaiBDS.Text = cbbLoaiBDS.SelectedValue.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT BatDongSan.id, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,"
                + "BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,"
                + "dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai, BatDongSan.ghichu "
                + "FROM BatDongSan "
                + "LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id "
                + "LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id"
                + " WHERE 1 = 1";


            

            

            if (cbDuAn.Checked)
            {
                query += " AND idduan LIKE '%" + txtIDDuAn.Text + "%' ";
            }

            if (cbKhuDat.Checked)
            {
                query += " AND idkhudat LIKE '%" + txtIDKhuDat.Text + "%' ";
            }

            if (cbKhuDat.Checked)
            {
                query += " AND BatDongSan.diachi LIKE '%" + txtDiaChi.Text + "%' ";
            }

            if (cbLoaiBDS.Checked)
            {
                query += " AND idLoaiBDS LIKE '%" + txtIDLoaiBDS.Text + "%' ";
            }

            if (cbDienTich.Checked)
            {
                try
                {
                    double tmp = 0;
                    tmp = double.Parse(txtDTKetThuc.Text);
                    tmp = double.Parse(txtDTBatDau.Text);
                }
                catch
                {
                    MessageBox.Show("Bạn cần nhập lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDTKetThuc.Text = "0";
                }
                query += " AND dientichdat >= '" + txtDTBatDau.Text + "' AND dientichdat <= '" + txtDTKetThuc.Text + "'";
            }

            if (cbDonGia.Checked)
            {
                try
                {
                    double tmp = 0;
                    tmp = double.Parse(txtDGKetThuc.Text);
                    tmp = double.Parse(txtDGBatDau.Text);
                }
                catch
                {
                    MessageBox.Show("Bạn cần nhập lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDTKetThuc.Text = "0";
                }
                query += " AND dongia >= '" + txtDGBatDau.Text + "' AND dongia <= '" + txtDGKetThuc.Text + "'";
            }

            if (cbTrangThai.Checked)
            {
                query += " AND trangthai LIKE N'%" + cbbTrangThai.Text + "%' ";
            }


            LoadBDS(query);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            DataTable data = BatDongSanDAO.Instance.GetBatDongSanByID(txtID.Text);
            BatDongSanDTO BatDongSanXuLy = new BatDongSanDTO();

            foreach (DataRow item in data.Rows)
            {
                BatDongSanXuLy = new BatDongSanDTO(item);
            }

            if (rbGiuCho.Checked)
            {
                
                fDanhMucPhieuGiuCho f = new fDanhMucPhieuGiuCho(BatDongSanXuLy);
                f.ShowDialog();
                this.Show();
            }

            if (rbDatCoc.Checked)
            {

                fDanhMucPhieuDatCoc f = new fDanhMucPhieuDatCoc(BatDongSanXuLy);
                f.ShowDialog();
                this.Show();
            }

            if (rbHopDongMuaBan.Checked)
            {

                fDanhMucHopDongMuaBan f = new fDanhMucHopDongMuaBan(BatDongSanXuLy);
                f.ShowDialog();
                this.Show();
            }
        }


        void Desing()
        {
            pQUANLYNHANVIEN.Visible = false;
            pQUANLYNHADAT.Visible = false;
            pQUANLYKHACHHANG.Visible = false;
            pQUANLYHOPDONG.Visible = false;
            pTHONGKEBAOCAO.Visible = false;
        }

        private void btnTAIKHOANCANHAN_Click(object sender, EventArgs e)
        {
            fTaiKhoanCaNhan f = new fTaiKhoanCaNhan(TKDangNhap);
            f.ShowDialog();
            this.Show();
        }

        private void btnQUANLYNHANVIEN_Click(object sender, EventArgs e)
        {
            if (pQUANLYNHANVIEN.Visible == true)
            {
                pQUANLYNHANVIEN.Visible = false;
            }
            else
            {
                pQUANLYNHANVIEN.Visible = true;
            }
        }

        private void btnDanhMucNhanVien_Click(object sender, EventArgs e)
        {
            if(NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Nhân Viên"))
            {
                fDanhMucNhanVien f = new fDanhMucNhanVien();
                f.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);
        }

        private void btnDanhMucNhomQuyen_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Nhóm Quyền"))
            {
                fDanhMucNhomQuyen f = new fDanhMucNhomQuyen();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);
        }

        private void btnDanhMucChiNhanh_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Chi Nhánh"))
            {
                fDanhMucChiNhanh f = new fDanhMucChiNhanh();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);
            
        }

        private void btnDanhMucPhongBan_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Phòng Ban"))
            {
                fDanhMucPhongBan f = new fDanhMucPhongBan();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);
            
        }

        private void btnDanhMucChucVu_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Chức Vụ"))
            {
                fDanhMucChucVu f = new fDanhMucChucVu();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);

            
        }


        

        private void btnQUANLYBATDONGSAN_Click(object sender, EventArgs e)
        {
            if (pQUANLYNHADAT.Visible == true)
            {
                pQUANLYNHADAT.Visible = false;
            }
            else
            {
                pQUANLYNHADAT.Visible = true;
            }
        }


        private void btnDanhMucChuDauTu_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Chủ Đầu Tư"))
            {

                fDanhMucChuDauTu f = new fDanhMucChuDauTu();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);


        }

        private void btnDanhMucDuAn_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Dự Án"))
            {

                fDanhMucDuAn f = new fDanhMucDuAn();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);


        }

        private void btnDanhMucKhuDat_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Khu Đất"))
            {

                fDanhMucKhuDat f = new fDanhMucKhuDat();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);

            
        }

        private void btnDanhMucLoaiBatDongSan_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Loại Bất Động Sản"))
            {

                fDanhMucLoaiBatDongSan f = new fDanhMucLoaiBatDongSan();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);


        }

        private void btnDanhMucBatDongSan_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Bất Động Sản"))
            {

                fDanhMucBatDongSan f = new fDanhMucBatDongSan();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);

            
        }

        private void btnQUANLYKHACHHANG_Click(object sender, EventArgs e)
        {
            if (pQUANLYKHACHHANG.Visible == true)
            {
                pQUANLYKHACHHANG.Visible = false;
            }
            else
            {
                pQUANLYKHACHHANG.Visible = true;
            }
        }

        private void btnDanhMucKhachHang_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Khách Hàng"))
            {

                fDanhMucKhachHang f = new fDanhMucKhachHang();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);

           
        }

        private void btnDanhMucNhuCau_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Nhu Cầu"))
            {

                fDanhMucNhuCau f = new fDanhMucNhuCau();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fTaskMannager_Load(sender, e);
            
        }

        private void btnQUANLYHOPDONG_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Quản Lý Hợp Đồng"))
            {
                if (pQUANLYHOPDONG.Visible == true)
                {
                    pQUANLYHOPDONG.Visible = false;
                }
                else
                {
                    pQUANLYHOPDONG.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnDanhMucPGC_Click(object sender, EventArgs e)
        {
            fDanhMucPhieuGiuCho f = new fDanhMucPhieuGiuCho();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhMucPDC_Click(object sender, EventArgs e)
        {
            fDanhMucPhieuDatCoc f = new fDanhMucPhieuDatCoc();
            f.ShowDialog();
            this.Show();
        }


        private void btnDanhMucHDMB_Click(object sender, EventArgs e)
        {
            fDanhMucHopDongMuaBan f = new fDanhMucHopDongMuaBan();
            f.ShowDialog();
            this.Show();
        }



        private void btnTHONGKEBAOCAO_Click(object sender, EventArgs e)
        {
            if (NhanVienDAO.Instance.KiemTraQuyen(TKDangNhap.Id, "Thống Kê Báo Cáo"))
            {
                if (pTHONGKEBAOCAO.Visible == true)
                {
                    pTHONGKEBAOCAO.Visible = false;
                }
                else
                {
                    pTHONGKEBAOCAO.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDanhMucDoanhThu_Click(object sender, EventArgs e)
        {
            fDanhMucDoanhThu f = new fDanhMucDoanhThu();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            fDanhSachNhanVien f = new fDanhSachNhanVien();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachDuAn_Click(object sender, EventArgs e)
        {
            fDanhSachDuAn f = new fDanhSachDuAn();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachBatDongSan_Click(object sender, EventArgs e)
        {
            fDanhSachBatDongSan f = new fDanhSachBatDongSan();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            fDanhSachKhachHang f = new fDanhSachKhachHang();
            f.ShowDialog();
            this.Show();
        }

        private void btnDENHAN_Click(object sender, EventArgs e)
        {
            fLTTDenHan f = new fLTTDenHan(TKDangNhap);
            f.ShowDialog();
            this.Show();
        }

        private void btnDANGXUAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTaskMannager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                NhanVienDAO.Instance.DangXuat(this.TKDangNhap.Id);
            }
            
        }

        private void txtDGKetThuc_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtDGKetThuc.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtDGKetThuc.Text = String.Format(culture, "{0:N0}", value);
            txtDGKetThuc.Select(txtDGKetThuc.Text.Length, 0);
        }

        private void txtDGBatDau_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtDGBatDau.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtDGBatDau.Text = String.Format(culture, "{0:N0}", value);
            txtDGBatDau.Select(txtDGBatDau.Text.Length, 0);
        }

        
    }
}
