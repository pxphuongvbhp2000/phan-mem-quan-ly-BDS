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
using System.Globalization;

namespace DoAnTotNghiep.View
{
    public partial class fDanhMucBatDongSan : Form
    {
        public fDanhMucBatDongSan()
        {
            InitializeComponent();
        }

        private void fDanhMucBatDongSan_Load(object sender, EventArgs e)
        {
            DataTable dataBatDongSan = BatDongSanDAO.Instance.GetListBatDongSan();
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

            txtID.Enabled = false;
            txtRong.Enabled = true;
            txtDai.Enabled = true;
            txtDienTichDat.Enabled = true;
            txtDienTichSanTruoc.Enabled = true;
            txtDienTichSanSau.Enabled = true;
            txtDonGia.Enabled = true;
            txtTyLeChietKhau.Enabled = true;
            txtTyLeVAT.Enabled = true;
            txtTrangThai.Enabled = false;
            LoadComBoBox();
            dis_en(false);
            Bingding();
        }

        void LoadComBoBox()
        {

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
            txtID.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            cbbDuAn.DataBindings.Clear();
            cbbDuAn.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtIDKhuDat.DataBindings.Clear();
            txtIDKhuDat.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "idkhudat", true, DataSourceUpdateMode.Never);

            cbbKhuDat.DataBindings.Clear();
            cbbKhuDat.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtIDLoaiBDS.DataBindings.Clear();
            txtIDLoaiBDS.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "idloaiBDS", true, DataSourceUpdateMode.Never);

            cbbLoaiBDS.DataBindings.Clear();
            cbbLoaiBDS.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            txtTyLeChietKhau.DataBindings.Clear();
            txtTyLeChietKhau.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "tylechietkhau", true, DataSourceUpdateMode.Never);

            txtTyLeVAT.DataBindings.Clear();
            txtTyLeVAT.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "tyleVAT", true, DataSourceUpdateMode.Never);

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "trangthai", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucBatDongSan.DataSource, "ghichu", true, DataSourceUpdateMode.Never);


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

        private void cbMoBan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMoBan.Checked)
            {
                txtTrangThai.Text = "Mở Bán";
            }
            else
            {
                txtTrangThai.Text = "Chưa Bán";
            }
        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {
            if (txtTrangThai.Text == "Mở Bán" || txtTrangThai.Text == "Chưa Bán")
            {
                
                cbMoBan.Enabled = true;
            }
            else 
            {
                cbMoBan.Enabled = false;
            }
        }

        int flag = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            cbMoBan.Checked = true;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                if (t == txtIDKhuDat || t == txtIDLoaiBDS || t == txtDonGia || t == txtIDDuAn)
                {
                    continue;
                }
                t.Clear();
            }
            txtRong.Text = "0";
            txtDai.Text = "0";
            txtDienTichDat.Text = "0";
            txtDienTichSanTruoc.Text = "0";
            txtDienTichSanSau.Text = "0";
            txtDonGia.Text = "0";
            txtTyLeChietKhau.Text = "0";
            txtTyLeVAT.Text = "0";
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
            txtRong.Enabled = false;
            txtDai.Enabled = false;
            txtDienTichDat.Enabled = false;
            txtDienTichSanTruoc.Enabled = false;
            txtDienTichSanSau.Enabled = false;
            txtDonGia.Enabled = false;
            txtTyLeChietKhau.Enabled = false;
            txtTyLeVAT.Enabled = false;
            txtTrangThai.Enabled = true;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa bất động sản " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (BatDongSanDAO.Instance.XoaBatDongSan(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucBatDongSan_Load(sender, e);
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
                string idkhudat = txtIDKhuDat.Text;
                string idloaiBDS = txtIDLoaiBDS.Text;
                string diachi = txtDiaChi.Text;
                string huong = txtHuong.Text;
                
                string trangthai = txtTrangThai.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    double rong = double.Parse(txtRong.Text);
                    double dai = double.Parse(txtDai.Text);
                    double dientichdat = double.Parse(txtDienTichDat.Text);
                    double dientichsantruoc = double.Parse(txtDienTichSanTruoc.Text);
                    double dientichsansau = double.Parse(txtDienTichSanSau.Text);
                    double dongia = double.Parse(txtDonGia.Text);
                    double tylechietkhau = double.Parse(txtTyLeChietKhau.Text);
                    double tyleVAT = double.Parse(txtTyLeVAT.Text);
                    if
                    (
                        BatDongSanDAO.Instance.ThemBatDongSan(id, idkhudat, idloaiBDS, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                            dongia, tylechietkhau, tyleVAT, trangthai, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucBatDongSan_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    double rong = double.Parse(txtRong.Text);
                    double dai = double.Parse(txtDai.Text);
                    double dientichdat = double.Parse(txtDienTichDat.Text);
                    double dientichsantruoc = double.Parse(txtDienTichSanTruoc.Text);
                    double dientichsansau = double.Parse(txtDienTichSanSau.Text);
                    double dongia = double.Parse(txtDonGia.Text);
                    double tylechietkhau = double.Parse(txtTyLeChietKhau.Text);
                    double tyleVAT = double.Parse(txtTyLeVAT.Text);
                    
                    if
                    (
                        BatDongSanDAO.Instance.SuaBatDongSan(id, idkhudat, idloaiBDS, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                            dongia, tylechietkhau, tyleVAT, trangthai, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucBatDongSan_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {
                    string idduan = txtIDDuAn.Text;
                    DataTable dataBatDongSan = BatDongSanDAO.Instance.TimKiemBatDongSan(id, idduan, idkhudat, idloaiBDS, diachi, trangthai, ghichu);
                    dgvDanhMucBatDongSan.DataSource = dataBatDongSan;
                    txtRong.Enabled = true;
                    txtDai.Enabled = true;
                    txtDienTichDat.Enabled = true;
                    txtDienTichSanTruoc.Enabled = true;
                    txtDienTichSanSau.Enabled = true;
                    txtDonGia.Enabled = true;
                    txtTyLeChietKhau.Enabled = true;
                    txtTyLeVAT.Enabled = true;
                    txtTrangThai.Enabled = false;
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
            fDanhMucBatDongSan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucBatDongSan_FormClosing(object sender, FormClosingEventArgs e)
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

        
    }
}
