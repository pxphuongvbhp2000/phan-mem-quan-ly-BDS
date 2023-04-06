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
    public partial class fDanhMucNhuCau : Form
    {

        private KhachHangDTO khachHangXuLy;

        public KhachHangDTO KhachHangXuLy { get => khachHangXuLy; set => khachHangXuLy = value; }


        public fDanhMucNhuCau()
        {
            InitializeComponent();
        }

        public fDanhMucNhuCau(KhachHangDTO KhachHangXuLy)
        {
            InitializeComponent();
            this.KhachHangXuLy = KhachHangXuLy;
        }

        private void fDanhMucNhuCau_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            DataTable dataNhuCau;
            if (this.KhachHangXuLy != null)
            {
                txtIDKhachHang.Enabled = false;
                cbbKhachHang.Enabled = false;
                dataNhuCau = NhuCauDAO.Instance.GetListNhuCauByIDKhachHang(this.KhachHangXuLy.Id);
                
            }
            else 
            {
                dataNhuCau = NhuCauDAO.Instance.GetListNhuCau();
            }

            dgvDanhMucNhuCau.DataSource = dataNhuCau;
            dgvDanhMucNhuCau.Columns["id"].HeaderText = "ID";

            dgvDanhMucNhuCau.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucNhuCau.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDanhMucNhuCau.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucNhuCau.Columns["huong"].HeaderText = "Hướng";
            dgvDanhMucNhuCau.Columns["rong"].HeaderText = "Rộng";
            dgvDanhMucNhuCau.Columns["dai"].HeaderText = "Dài";
            dgvDanhMucNhuCau.Columns["dientichdat"].HeaderText = "Diện Tích Đất";
            dgvDanhMucNhuCau.Columns["dientichsantruoc"].HeaderText = "Diện Tích Sân Trước";
            dgvDanhMucNhuCau.Columns["dientichsansau"].HeaderText = "Diện Tích Sân Sau";
            dgvDanhMucNhuCau.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvDanhMucNhuCau.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
           
            LoadComBoBox();
            dis_en(false);
            Bingding();
        }

        void LoadComBoBox()
        {

            DataTable dataKhachHang = KhachHangDAO.Instance.GetKhachHangForCBB();
            cbbKhachHang.DataSource = dataKhachHang;
            cbbKhachHang.DisplayMember = "chitietKH";
            cbbKhachHang.ValueMember = "id";
            cbbKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            txtID.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "id", true, DataSourceUpdateMode.Never);

            
            txtIDKhachHang.DataBindings.Clear();
            txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            cbbKhachHang.DataBindings.Clear();
            cbbKhachHang.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "hoten", true, DataSourceUpdateMode.Never);


            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "diachi", true, DataSourceUpdateMode.Never);

            txtHuong.DataBindings.Clear();
            txtHuong.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "huong", true, DataSourceUpdateMode.Never);

            txtRong.DataBindings.Clear();
            txtRong.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "rong", true, DataSourceUpdateMode.Never);

            txtDai.DataBindings.Clear();
            txtDai.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "dai", true, DataSourceUpdateMode.Never);

            txtDienTichDat.DataBindings.Clear();
            txtDienTichDat.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "dientichdat", true, DataSourceUpdateMode.Never);

            txtDienTichSanTruoc.DataBindings.Clear();
            txtDienTichSanTruoc.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "dientichsantruoc", true, DataSourceUpdateMode.Never);

            txtDienTichSanSau.DataBindings.Clear();
            txtDienTichSanSau.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "dientichsansau", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "dongia", true, DataSourceUpdateMode.Never);

            
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucNhuCau.DataSource, "ghichu", true, DataSourceUpdateMode.Never);


        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDKhachHang.Text = cbbKhachHang.SelectedValue.ToString();
        }

        int flag = 0;

        private void btnThem_Click(object sender, EventArgs e)
        { 
            flag = 1;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                if (t == txtIDKhachHang)
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
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhu cầu " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (NhuCauDAO.Instance.XoaNhuCau(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucNhuCau_Load(sender, e);
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
                string diachi = txtDiaChi.Text;
                string huong = txtHuong.Text;
                string rong = txtRong.Text;
                string dai = txtDai.Text;
                string dientichdat = txtDienTichDat.Text;
                string dientichsantruoc = txtDienTichSanTruoc.Text;
                string dientichsansau = txtDienTichSanSau.Text;
                string dongia = txtDonGia.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    
                    if
                    (
                        NhuCauDAO.Instance.ThemNhuCau(idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                            dongia, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhuCau_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    if
                    (
                        NhuCauDAO.Instance.SuaNhuCau(id, idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                            dongia, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhuCau_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {
                    DataTable dataNhuCau = NhuCauDAO.Instance.TimKiemNhuCau(idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                            dongia, ghichu);
                    dgvDanhMucNhuCau.DataSource = dataNhuCau;
                    
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
            fDanhMucNhuCau_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucNhuCau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       
    }
}
