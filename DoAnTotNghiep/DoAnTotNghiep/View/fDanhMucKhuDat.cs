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
    public partial class fDanhMucKhuDat : Form
    {
        public fDanhMucKhuDat()
        {
            InitializeComponent();
        }


        private void fDanhMucKhuDat_Load(object sender, EventArgs e)
        {
            DataTable dataKhuDat = KhuDatDAO.Instance.GetListKhuDat();
            dgvDanhMucKhuDat.DataSource = dataKhuDat;
            dgvDanhMucKhuDat.Columns["id"].HeaderText = "ID";
            dgvDanhMucKhuDat.Columns["idduan"].HeaderText = "ID Dự Án";
            dgvDanhMucKhuDat.Columns["tenduan"].HeaderText = "Tên Dự Án";
            dgvDanhMucKhuDat.Columns["tenkhu"].HeaderText = "Tên Khu";
            dgvDanhMucKhuDat.Columns["vitri"].HeaderText = "Vị Trí";
            dgvDanhMucKhuDat.Columns["soluonglo"].HeaderText = "Số Lượng Lô";
            dgvDanhMucKhuDat.Columns["dientich"].HeaderText = "Diện Tích";
            dgvDanhMucKhuDat.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
            txtDienTich.Enabled = true;
            txtSoLuongLo.Enabled = true;
            LoadComBoBox();
            dis_en(false);
            Bingding();
        }

        void LoadComBoBox()
        {
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
            txtID.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtIDDuAn.DataBindings.Clear();
            txtIDDuAn.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "idduan", true, DataSourceUpdateMode.Never);

            cbbDuAn.DataBindings.Clear();
            cbbDuAn.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "tenduan", true, DataSourceUpdateMode.Never);

            txtTenKhu.DataBindings.Clear();
            txtTenKhu.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "tenkhu", true, DataSourceUpdateMode.Never);

            txtViTri.DataBindings.Clear();
            txtViTri.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "vitri", true, DataSourceUpdateMode.Never);

            txtSoLuongLo.DataBindings.Clear();
            txtSoLuongLo.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "soluonglo", true, DataSourceUpdateMode.Never);

            txtDienTich.DataBindings.Clear();
            txtDienTich.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "dientich", true, DataSourceUpdateMode.Never);

            

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucKhuDat.DataSource, "ghichu", true, DataSourceUpdateMode.Never);

        }

        int flag = 0;



        private void cbbNhanVienPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDDuAn.Text = cbbDuAn.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                if (t == txtIDDuAn)
                {
                    continue;
                }
                t.Clear();
            }
            txtSoLuongLo.Text = "0";
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
            txtSoLuongLo.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa khu đất " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (KhuDatDAO.Instance.XoaKhuDat(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucKhuDat_Load(sender, e);
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
                string idduan = txtIDDuAn.Text;
                string tenkhu = txtTenKhu.Text;
                string vitri = txtViTri.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    int soluonglo = int.Parse(txtSoLuongLo.Text);
                    double dientich = double.Parse(txtDienTich.Text);
                    if
                    (
                        KhuDatDAO.Instance.ThemKhuDat(id, idduan, tenkhu, vitri, soluonglo, dientich, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucKhuDat_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int soluonglo = int.Parse(txtSoLuongLo.Text);
                    double dientich = double.Parse(txtDienTich.Text);
                    if
                    (
                        KhuDatDAO.Instance.SuaKhuDat(id, idduan, tenkhu, vitri, soluonglo, dientich, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucKhuDat_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {
                    DataTable dataKhuDat = KhuDatDAO.Instance.TimKiemKhuDat(id, idduan, tenkhu,vitri, ghichu);
                    dgvDanhMucKhuDat.DataSource = dataKhuDat;
                    txtDienTich.Enabled = true;
                    txtSoLuongLo.Enabled = true;
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
            fDanhMucKhuDat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fDanhMucKhuDat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
