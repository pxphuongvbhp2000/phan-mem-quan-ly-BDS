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
    public partial class fAnhKetHon : Form
    {
        private KhachHangDTO khachHangXuLy;

        public KhachHangDTO KhachHangXuLy { get => khachHangXuLy; set => khachHangXuLy = value; }

        public fAnhKetHon()
        {
            InitializeComponent();
        }

        public fAnhKetHon(KhachHangDTO KhachHangXuLy)
        {
            InitializeComponent();
            this.KhachHangXuLy = KhachHangXuLy;
        }

        private void fAnhKetHon_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtIDKhachHang.Enabled = false;
            DataTable dataAnh = KhachHangDAO.Instance.GetListAnhKetHon(this.KhachHangXuLy.Id);

            dgvDanhMucAnh.DataSource = dataAnh;
            dgvDanhMucAnh.Columns["id"].HeaderText = "ID";
            dgvDanhMucAnh.Columns["idkhachhang"].HeaderText = "ID Khách Hàng";
            dgvDanhMucAnh.Columns["anhkethon"].HeaderText = "Ảnh Kết Hôn";

            txtIDKhachHang.Text = KhachHangXuLy.Id.ToString();
            txtHoTen.Text = KhachHangXuLy.Hoten.ToString();
            txtDiaChiThuongTru.Text = KhachHangXuLy.Diachithuongtru.ToString();
            txtSDT.Text = KhachHangXuLy.Sdt.ToString();
            txtID.Visible = false;
            txtHoTen.Enabled = false;
            txtDiaChiThuongTru.Enabled = false;
            txtSDT.Enabled = false;

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


            //txtIDKhachHang.DataBindings.Clear();
            //txtIDKhachHang.DataBindings.Add("Text", dgvDanhMucAnh.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never);

            pbAnh.DataBindings.Clear();
            pbAnh.DataBindings.Add("Image", dgvDanhMucAnh.DataSource, "anhkethon", true, DataSourceUpdateMode.Never);

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
            //    if (t == txtIDKhachHang)
            //    {
            //        continue;
            //    }
            //    t.Clear();
            //}

            //if (txtIDKhachHang.Text == "")
            //{
            //    txtIDKhachHang.Text = KhachHangXuLy.Id;
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
                if (KhachHangDAO.Instance.XoaAnhKetHon(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fAnhKetHon_Load(sender, e);
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
                var anhkethon_tmp = new ImageConverter().ConvertTo(pbAnh.Image, typeof(Byte[]));
                byte[] anhkethon = (byte[])anhkethon_tmp;

                if (flag == 1)
                {

                    if
                    (
                        KhachHangDAO.Instance.ThemAnhKetHon(idkhachhang, anhkethon)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhKetHon_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    if
                    (
                        KhachHangDAO.Instance.SuaAnhKetHon(id, anhkethon)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhKetHon_Load(sender, e);
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
            fAnhKetHon_Load(sender, e);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAnhKetHon_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
