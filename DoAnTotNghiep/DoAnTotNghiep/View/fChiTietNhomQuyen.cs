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
    public partial class fChiTietNhomQuyen : Form
    {

        private NhomQuyenDTO nhomQuyenXuLy;

        public NhomQuyenDTO NhomQuyenXuLy { get => nhomQuyenXuLy; set => nhomQuyenXuLy = value; }


        public fChiTietNhomQuyen()
        {
            InitializeComponent();
        }

        public fChiTietNhomQuyen(NhomQuyenDTO NhomQuyenXuLy)
        {
            InitializeComponent();
            this.NhomQuyenXuLy = NhomQuyenXuLy; 
        }

        
        private void fChiTietNhomQuyen_Load(object sender, EventArgs e)
        {
            DataTable dataChiTietNhomQuyen = NhomQuyenChiTietDAO.Instance.GetListNhomQuyenChiTietByNhomQuyen(NhomQuyenXuLy.Id);
            dgvChiTietNhomQuyen.DataSource = dataChiTietNhomQuyen;
            dgvChiTietNhomQuyen.Columns["idphanquyen"].HeaderText = "ID Phân Quyền";
            dgvChiTietNhomQuyen.Columns["tenphanquyen"].HeaderText = "Tên Phân Quyền";

            DataTable dataPhanQuyen = PhanQuyenDAO.Instance.GetListPhanQuyen(NhomQuyenXuLy.Id);
            dgvDanhMucPhanQuyen.DataSource = dataPhanQuyen;
            dgvDanhMucPhanQuyen.Columns["id"].HeaderText = "ID";
            dgvDanhMucPhanQuyen.Columns["tenphanquyen"].HeaderText = "Tên Phân Quyền";

            lbChiTietNhomQuyen.Text = NhomQuyenXuLy.Id + " - " + NhomQuyenXuLy.Tennhomquyen;
            dis_en(false);
            Bingding();
        }

        void dis_en(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnTimKiem.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }

        int flag = 0;

        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucPhanQuyen.DataSource, "id", true, DataSourceUpdateMode.Never);
            txtTenPhanQuyen.DataBindings.Clear();
            txtTenPhanQuyen.DataBindings.Add("Text", dgvDanhMucPhanQuyen.DataSource, "tenphanquyen", true, DataSourceUpdateMode.Never);

            txtIdChiTietNhomQuyen.DataBindings.Clear();
            txtIdChiTietNhomQuyen.DataBindings.Add("Text", dgvChiTietNhomQuyen.DataSource, "idphanquyen", true, DataSourceUpdateMode.Never);

            txtTenChiTietNhomQuyen.DataBindings.Clear();
            txtTenChiTietNhomQuyen.DataBindings.Add("Text", dgvChiTietNhomQuyen.DataSource, "tenphanquyen", true, DataSourceUpdateMode.Never);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            dis_en(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flag = 3;

            txtID.Clear();
            txtID.Enabled = true;

            txtTenPhanQuyen.Clear();
            txtTenPhanQuyen.Enabled = true;

            txtIdChiTietNhomQuyen.Clear();
            txtIdChiTietNhomQuyen.Enabled = true;

            txtTenChiTietNhomQuyen.Clear();
            txtTenChiTietNhomQuyen.Enabled = true;
            dis_en(true);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (flag == 1)
                {
                    string idphanquyen = txtID.Text;
                    if (NhomQuyenChiTietDAO.Instance.ThemNhomQuyenChiTiet(idphanquyen, NhomQuyenXuLy.Id))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fChiTietNhomQuyen_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa phân quyền " + txtIdChiTietNhomQuyen.Text + " khỏi nhóm quyền " + NhomQuyenXuLy.Id.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // xoa
                        if (NhomQuyenChiTietDAO.Instance.XoaNhomQuyenChiTiet(txtIdChiTietNhomQuyen.Text, NhomQuyenXuLy.Id))
                        {
                            MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        fChiTietNhomQuyen_Load(sender, e);
                    }
                    else
                    {
                        return;
                    }

                }

                if (flag == 3)
                {

                    string idphanquyen = txtIdChiTietNhomQuyen.Text;
                    string tenphanquyen = txtTenChiTietNhomQuyen.Text;
                    DataTable dataChiTietNhomQuyen = NhomQuyenChiTietDAO.Instance.TimKiemNhomQuyenChiTiet(idphanquyen, tenphanquyen, NhomQuyenXuLy.Id);
                    dgvChiTietNhomQuyen.DataSource = dataChiTietNhomQuyen;

                    idphanquyen = txtID.Text;
                    tenphanquyen = txtTenPhanQuyen.Text;
                    DataTable dataPhanQuyen = PhanQuyenDAO.Instance.TimKiemPhanQuyen(idphanquyen, tenphanquyen);
                    dgvDanhMucPhanQuyen.DataSource = dataPhanQuyen;

                    Bingding();
                    dis_en(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fChiTietNhomQuyen_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiTietNhomQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
