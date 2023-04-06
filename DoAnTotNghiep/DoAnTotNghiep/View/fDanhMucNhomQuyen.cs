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
    public partial class fDanhMucNhomQuyen : Form
    {
        public fDanhMucNhomQuyen()
        {
            InitializeComponent();
        }

        private void fDanhMucNhomQuyen_Load(object sender, EventArgs e)
        {
            DataTable dataNhomQuyen = NhomQuyenDAO.Instance.GetListNhomQuyen();
            dgvDanhMucNhomQuyen.DataSource = dataNhomQuyen;
            dgvDanhMucNhomQuyen.Columns["id"].HeaderText = "ID";
            dgvDanhMucNhomQuyen.Columns["tennhomquyen"].HeaderText = "Tên Nhóm Quyền";
            dgvDanhMucNhomQuyen.Columns["ghichu"].HeaderText = "Ghi Chú";

            
            txtID.Enabled = false;
            dis_en(false);
            Bingding();
        }

        void dis_en(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnChiTiet.Enabled = !e;
            btnXoa.Enabled = !e;
            btnTimKiem.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }

        int flag = 0;

        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucNhomQuyen.DataSource, "id", true, DataSourceUpdateMode.Never);

            txtTenNhomQuyen.DataBindings.Clear();
            txtTenNhomQuyen.DataBindings.Add("Text", dgvDanhMucNhomQuyen.DataSource, "tennhomquyen", true, DataSourceUpdateMode.Never);

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvDanhMucNhomQuyen.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
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
            dis_en(true);
            foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            {
                t.Clear();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataTable data = NhomQuyenDAO.Instance.GetNhomQuyenByID(txtID.Text);
            NhomQuyenDTO NhomQuyenXuLy = new NhomQuyenDTO();

            foreach (DataRow item in data.Rows)
            {
                NhomQuyenXuLy = new NhomQuyenDTO(item);
            }

            fChiTietNhomQuyen f = new fChiTietNhomQuyen(NhomQuyenXuLy);
            f.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhóm quyền " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (NhomQuyenDAO.Instance.XoaNhomQuyen(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fDanhMucNhomQuyen_Load(sender, e);
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
                string tennhomquyen = txtTenNhomQuyen.Text;
                string ghichu = txtGhiChu.Text;

                if (flag == 1)
                {
                    if(NhomQuyenDAO.Instance.ThemNhomQuyen(id,tennhomquyen, ghichu))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhomQuyen_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    if(NhomQuyenDAO.Instance.SuaNhomQuyen(id, tennhomquyen, ghichu))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fDanhMucNhomQuyen_Load(sender, e);
                    dis_en(false);

                }


                if (flag == 3)
                {

                    DataTable dataNhomQuyen = NhomQuyenDAO.Instance.TimKiemNhomQuyen(id, tennhomquyen, ghichu);
                    dgvDanhMucNhomQuyen.DataSource = dataNhomQuyen;
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
            fDanhMucNhomQuyen_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucNhomQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
