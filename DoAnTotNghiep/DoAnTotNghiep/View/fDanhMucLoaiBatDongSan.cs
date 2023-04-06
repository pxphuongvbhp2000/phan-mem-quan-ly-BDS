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
    public partial class fDanhMucLoaiBatDongSan : Form
    {
        public fDanhMucLoaiBatDongSan()
        {
            InitializeComponent();
        }


        private void fDanhMucLoaiBatDongSan_Load(object sender, EventArgs e)
        {
            DataTable dataLoaiBatDongSan = LoaiBatDongSanDAO.Instance.GetLoaiBatDongSan();
            dgvDanhMucLoaiBatDongSan.DataSource = dataLoaiBatDongSan;
            dgvDanhMucLoaiBatDongSan.Columns["id"].HeaderText = "ID";
            dgvDanhMucLoaiBatDongSan.Columns["tenloaiBDS"].HeaderText = "Tên Loại BĐS";
            dgvDanhMucLoaiBatDongSan.Columns["ghichu"].HeaderText = "Ghi Chú";

            txtID.Enabled = false;
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

        int flag = 0;

        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucLoaiBatDongSan.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtTenLoaiBDS.DataBindings.Clear();
            txtTenLoaiBDS.DataBindings.Add("Text", dgvDanhMucLoaiBatDongSan.DataSource, "tenloaiBDS", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucLoaiBatDongSan.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
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
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa loại BĐS " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (LoaiBatDongSanDAO.Instance.XoaLoaiBatDongSan(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucLoaiBatDongSan_Load(sender, e);
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
                string tenloaiBDS = txtTenLoaiBDS.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    if (LoaiBatDongSanDAO.Instance.ThemLoaiBatDongSan(id, tenloaiBDS, ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucLoaiBatDongSan_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    if (LoaiBatDongSanDAO.Instance.SuaLoaiBatDongSan(id, tenloaiBDS, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucLoaiBatDongSan_Load(sender, e);
                    dis_en(false);

                }

                if (flag == 3)
                {

                    DataTable dataLoaiBDS = LoaiBatDongSanDAO.Instance.TimKiemLoaiBatDongSan(id, tenloaiBDS, ghichu);
                    dgvDanhMucLoaiBatDongSan.DataSource = dataLoaiBDS;
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
            fDanhMucLoaiBatDongSan_Load(sender, e);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucLoaiBatDongSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
