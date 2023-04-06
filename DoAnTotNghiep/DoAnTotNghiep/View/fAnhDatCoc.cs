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
    public partial class fAnhDatCoc : Form
    {
        private PhieuDatCocDTO pDCXuLy;

        public PhieuDatCocDTO PDCXuLy { get => pDCXuLy; set => pDCXuLy = value; }


        public fAnhDatCoc()
        {
            InitializeComponent();
        }

        public fAnhDatCoc(PhieuDatCocDTO PDCXuLy)
        {
            InitializeComponent();
            this.PDCXuLy = PDCXuLy;
        }

        private void fAnhDatCoc_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtIDPhieuDatCoc.Enabled = false;
            DataTable dataAnh = PhieuDatCocDAO.Instance.GetListAnhDatCoc(this.PDCXuLy.Id);

            dgvDanhMucAnh.DataSource = dataAnh;
            dgvDanhMucAnh.Columns["id"].HeaderText = "ID";
            dgvDanhMucAnh.Columns["idphieudatcoc"].HeaderText = "ID Phiếu Đặt Cọc";
            dgvDanhMucAnh.Columns["anhdatcoc"].HeaderText = "Ảnh Phiếu Đặt Cọc";

            txtIDPhieuDatCoc.Text = PDCXuLy.Id.ToString();
            txtID.Visible = false;
            txtIDPhieuDatCoc.Visible = false;
            dtpNgayLapPhieu.Value = PDCXuLy.Ngaylapphieu.Value;
            dtpNgayHetHan.Value = PDCXuLy.Ngayhethan.Value;
            txtTienCoc.Text = PDCXuLy.Tiencoc.ToString();
            txtTienBoiThuong.Text = PDCXuLy.Tienboithuong.ToString();
            cbbTrangThai.Text = PDCXuLy.Trangthai.ToString();

            dtpNgayLapPhieu.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            txtTienCoc.Enabled = false;
            txtTienBoiThuong.Enabled = false;
            cbbTrangThai.Enabled = false;

            dis_en(false);
            Bingding();
        }

        void dis_en(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnThucHien.Enabled = e;
            btnHuy.Enabled = e;
        }


        void Bingding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDanhMucAnh.DataSource, "id", true, DataSourceUpdateMode.Never);


            //txtIDPhieuDatCoc.DataBindings.Clear();
            //txtIDPhieuDatCoc.DataBindings.Add("Text", dgvDanhMucAnh.DataSource, "idphieudatcoc", true, DataSourceUpdateMode.Never);

            pbAnh.DataBindings.Clear();
            pbAnh.DataBindings.Add("Image", dgvDanhMucAnh.DataSource, "anhdatcoc", true, DataSourceUpdateMode.Never);

        }


        int flag = 0;


        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Load(OD.FileName);
            }
        }

        private void btnXemAnh_Click(object sender, EventArgs e)
        {
            fXemAnh f = new fXemAnh(pbAnh.Image);
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            pbAnh.Image = null;
            dis_en(true);
            //foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            //{
            //    if (t == txtIDPhieuDatCoc)
            //    {
            //        continue;
            //    }
            //    t.Clear();
            //}

            //if (txtIDPhieuDatCoc.Text == "")
            //{
            //    txtIDPhieuDatCoc.Text = PDCXuLy.Id.ToString();
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa ảnh " + txtID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // xoa
                if (PhieuDatCocDAO.Instance.XoaAnhDatCoc(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fAnhDatCoc_Load(sender, e);
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
                int idphieudatcoc = int.Parse(txtIDPhieuDatCoc.Text);
                var anhdatcoc_tmp = new ImageConverter().ConvertTo(pbAnh.Image, typeof(Byte[]));
                byte[] anhdatcoc = (byte[])anhdatcoc_tmp;

                if (flag == 1)
                {

                    if
                    (
                        PhieuDatCocDAO.Instance.ThemAnhDatCoc(idphieudatcoc, anhdatcoc)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhDatCoc_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    if
                    (
                        PhieuDatCocDAO.Instance.SuaAnhDatCoc(id, anhdatcoc)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhDatCoc_Load(sender, e);
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
            fAnhDatCoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAnhDatCoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void dgvDanhMucAnh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvDanhMucAnh.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void txtTienBoiThuong_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtTienBoiThuong.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtTienBoiThuong.Text = String.Format(culture, "{0:N0}", value);
            txtTienBoiThuong.Select(txtTienCoc.Text.Length, 0);
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtTienCoc.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtTienCoc.Text = String.Format(culture, "{0:N0}", value);
            txtTienCoc.Select(txtTienCoc.Text.Length, 0);
        }
    }
}
