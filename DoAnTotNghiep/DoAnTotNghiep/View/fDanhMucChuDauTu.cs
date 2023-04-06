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
    public partial class fDanhMucChuDauTu : Form
    {
        public fDanhMucChuDauTu()
        {
            InitializeComponent();
        }

        private void fDanhMucChuDauTu_Load(object sender, EventArgs e)
        {
            DataTable dataChuDauTu = ChuDauTuDAO.Instance.GetListChuDauTu();
            dgvDanhMucDuAn.DataSource = dataChuDauTu;
            dgvDanhMucDuAn.Columns["id"].HeaderText = "ID";
            dgvDanhMucDuAn.Columns["tencongty"].HeaderText = "Tên Công Ty";
            dgvDanhMucDuAn.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDanhMucDuAn.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDanhMucDuAn.Columns["email"].HeaderText = "Email";
            dgvDanhMucDuAn.Columns["website"].HeaderText = "Website";
            dgvDanhMucDuAn.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
            txtEmail.Enabled = true;
            txtWebsite.Enabled = true;
            txtSDT.Enabled = true;
            dis_en(false);
            Bingding();
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

            txtTenCongTy.DataBindings.Clear();
            txtTenCongTy.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "tencongty", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "diachi", true, DataSourceUpdateMode.Never);


            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "sdt", true, DataSourceUpdateMode.Never);


            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "email", true, DataSourceUpdateMode.Never);

            txtWebsite.DataBindings.Clear();
            txtWebsite.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "website", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucDuAn.DataSource, "ghichu", true, DataSourceUpdateMode.Never);

        }

        int flag = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtID.Enabled = true;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
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
            txtEmail.Enabled = false;
            txtWebsite.Enabled = false;
            txtSDT.Enabled = false;
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa chủ đầu tư " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (ChuDauTuDAO.Instance.XoaChuDauTu(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucChuDauTu_Load(sender, e);
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
                string tencongty = txtTenCongTy.Text;
                string diachi = txtDiaChi.Text;

                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string website = txtWebsite.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    if
                    (
                        ChuDauTuDAO.Instance.ThemChuDauTu(id, tencongty, diachi, sdt, email, website, ghichu)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucChuDauTu_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    if
                    (
                        ChuDauTuDAO.Instance.SuaChuDauTu(id, tencongty, diachi, sdt, email, website, ghichu)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucChuDauTu_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataChuDauTu = ChuDauTuDAO.Instance.TimKiemChuDauTu(id, tencongty, diachi, ghichu);
                    dgvDanhMucDuAn.DataSource = dataChuDauTu;

                    txtEmail.Enabled = false;
                    txtWebsite.Enabled = false;
                    txtSDT.Enabled = false;
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
            fDanhMucChuDauTu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucChuDauTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
