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
    public partial class fDanhMucDuAn : Form
    {
        public fDanhMucDuAn()
        {
            InitializeComponent();
        }

        private void fDanhMucDuAn_Load(object sender, EventArgs e)
        {
            DataTable dataDuAn = DuAnDAO.Instance.GetListDuAn();
            dgvDanhMucDuAn.DataSource = dataDuAn;
            dgvDanhMucDuAn.Columns["id"].HeaderText = "ID";
            dgvDanhMucDuAn.Columns["idchudautu"].HeaderText = "ID Chủ Đầu Tư";
            dgvDanhMucDuAn.Columns["tencongty"].HeaderText = "Chủ Đầu Tư";
            dgvDanhMucDuAn.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucDuAn.Columns["vitri"].HeaderText = "Vị Trí";
            dgvDanhMucDuAn.Columns["dientich"].HeaderText = "Diện Tích";
            dgvDanhMucDuAn.Columns["sogiayphep"].HeaderText = "Số Giấy Phép";
            dgvDanhMucDuAn.Columns["noicap"].HeaderText = "Nơi Cấp";
            dgvDanhMucDuAn.Columns["ngaycap"].HeaderText = "Ngày Cấp";
            dgvDanhMucDuAn.Columns["idnhanvienphutrach"].HeaderText = "ID Nhân Viên Phụ Trách";
            dgvDanhMucDuAn.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDanhMucDuAn.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
            txtDienTich.Enabled = true;
            dtpNgayCap.Enabled = true;
            LoadComBoBox();
            dis_en(false);
            Bingding();
        }

        void LoadComBoBox()
        {
            DataTable dataNhanVienPhuTrach = NhanVienDAO.Instance.GetNhanVienForCBB();
            cbbNhanVienPhuTrach.DataSource = dataNhanVienPhuTrach;
            cbbNhanVienPhuTrach.DisplayMember = "chitietNV";
            cbbNhanVienPhuTrach.ValueMember = "id";
            cbbNhanVienPhuTrach.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbNhanVienPhuTrach.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataChuDauTu = ChuDauTuDAO.Instance.GetChuDauTuForCBB();
            cbbChuDauTu.DataSource = dataChuDauTu;
            cbbChuDauTu.DisplayMember = "chitietCDT";
            cbbChuDauTu.ValueMember = "id";
            cbbChuDauTu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbChuDauTu.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            txtID.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "id", true, DataSourceUpdateMode.Never);
            
            txtIDChuDauTu.DataBindings.Clear();
            txtIDChuDauTu.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "idchudautu", true, DataSourceUpdateMode.Never);

            cbbChuDauTu.DataBindings.Clear();
            cbbChuDauTu.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "tencongty", true, DataSourceUpdateMode.Never);

            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtViTri.DataBindings.Clear();
            txtViTri.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "vitri", true, DataSourceUpdateMode.Never);

            txtDienTich.DataBindings.Clear();
            txtDienTich.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "dientich", true, DataSourceUpdateMode.Never);

            txtSoGiayPhep.DataBindings.Clear();
            txtSoGiayPhep.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "sogiayphep", true, DataSourceUpdateMode.Never);

            txtNoiCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "noicap", true, DataSourceUpdateMode.Never);

            dtpNgayCap.DataBindings.Clear();
            dtpNgayCap.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "ngaycap", true, DataSourceUpdateMode.Never);

            txtIDNhanVienPhuTrach.DataBindings.Clear();
            txtIDNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "idnhanvienphutrach", true, DataSourceUpdateMode.Never);

            cbbNhanVienPhuTrach.DataBindings.Clear();
            cbbNhanVienPhuTrach.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "hoten", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "ghichu", true, DataSourceUpdateMode.Never);

        }

        int flag = 0;

        private void cbbNhanVienPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDNhanVienPhuTrach.Text = cbbNhanVienPhuTrach.SelectedValue.ToString();
        }

        private void cbbChuDauTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDChuDauTu.Text = cbbChuDauTu.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
            txtDienTich.Text = "0";
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
            txtDienTich.Enabled = false;
            dtpNgayCap.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dự án " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (DuAnDAO.Instance.XoaDuAn(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucDuAn_Load(sender, e);
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
                string idchudautu = txtIDChuDauTu.Text;
                string tenduan = txtTenDuAn.Text;
                string vitri = txtViTri.Text;
                string sogiayphep = txtSoGiayPhep.Text;
                string noicap = txtNoiCap.Text;
                string ngaycap = dtpNgayCap.Value.ToString("yyyy/MM/dd");
                string idnhanvienphutrach = txtIDNhanVienPhuTrach.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    double dientich = double.Parse(txtDienTich.Text);
                    if
                    (
                        DuAnDAO.Instance.ThemDuAn(id, idchudautu, tenduan, vitri, dientich, sogiayphep, noicap, ngaycap, idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucDuAn_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    double dientich = double.Parse(txtDienTich.Text);
                    if
                    (
                        DuAnDAO.Instance.SuaDuAn(id, idchudautu, tenduan, vitri, dientich, sogiayphep, noicap, ngaycap, idnhanvienphutrach, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucDuAn_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataDuAn = DuAnDAO.Instance.TimKiemDuAn(id, idchudautu, tenduan, vitri, sogiayphep, noicap, idnhanvienphutrach, ghichu);
                    dgvDanhMucDuAn.DataSource = dataDuAn;
                    txtDienTich.Enabled = true;
                    dtpNgayCap.Enabled = true;
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
            fDanhMucDuAn_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fDanhMucDuAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
