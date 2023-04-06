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
    public partial class fAnhHopDong : Form
    {
        private HopDongMuaBanDTO hDMBXuLy;

        public HopDongMuaBanDTO HDMBXuLy { get => hDMBXuLy; set => hDMBXuLy = value; }

        public fAnhHopDong()
        {
            InitializeComponent();
        }

        public fAnhHopDong(HopDongMuaBanDTO HDMBXuLy)
        {
            InitializeComponent();
            this.HDMBXuLy = HDMBXuLy;
        }

        private void fAnhHopDong_Load(object sender, EventArgs e)
        {

            txtID.Enabled = false;
            txtIDHDMB.Enabled = false;
            DataTable dataAnh = HopDongMuaBanDAO.Instance.GetListAnhHopDong(this.HDMBXuLy.Id);

            dgvDanhMucAnh.DataSource = dataAnh;
            dgvDanhMucAnh.Columns["id"].HeaderText = "ID";
            dgvDanhMucAnh.Columns["idhopdongmuaban"].HeaderText = "ID Hợp Đồng Mua Bán";
            dgvDanhMucAnh.Columns["anhhopdong"].HeaderText = "Ảnh Hợp Đồng Mua Bán";

            txtIDHDMB.Text = HDMBXuLy.Id.ToString();
            txtID.Visible = false;
            dtpNgayLap.Value = HDMBXuLy.Ngaylap.Value;
            txtThanhTien.Text = HDMBXuLy.Thanhtien.ToString();
            txtTienDoHoanThanh.Text = HDMBXuLy.Tiendohoanthanh.ToString();
            cbbTrangThai.Text = HDMBXuLy.Trangthai.ToString();

            dtpNgayLap.Enabled = false;
            txtThanhTien.Enabled = false;
            txtTienDoHoanThanh.Enabled = false;
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


            //txtIDHDMB.DataBindings.Clear();
            //txtIDHDMB.DataBindings.Add("Text", dgvDanhMucAnh.DataSource, "idhopdongmuaban", true, DataSourceUpdateMode.Never);

            pbAnh.DataBindings.Clear();
            pbAnh.DataBindings.Add("Image", dgvDanhMucAnh.DataSource, "anhhopdong", true, DataSourceUpdateMode.Never);

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
            //    if (t == txtIDHDMB)
            //    {
            //        continue;
            //    }
            //    t.Clear();
            //}

            //if (txtIDHDMB.Text == "")
            //{
            //    txtIDHDMB.Text = HDMBXuLy.Id;
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
                if (HopDongMuaBanDAO.Instance.XoaAnhHopDong(txtID.Text))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fAnhHopDong_Load(sender, e);
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
                string idhopdongmuaban = txtIDHDMB.Text;
                var anhhopdong_tmp = new ImageConverter().ConvertTo(pbAnh.Image, typeof(Byte[]));
                byte[] anhhopdong = (byte[])anhhopdong_tmp;

                if (flag == 1)
                {

                    if
                    (
                        HopDongMuaBanDAO.Instance.ThemAnhHopDong(idhopdongmuaban, anhhopdong)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhHopDong_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    if
                    (
                        HopDongMuaBanDAO.Instance.SuaAnhHopDong(id, anhhopdong)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhHopDong_Load(sender, e);
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
            fAnhHopDong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAnhHopDong_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtThanhTien.Text = String.Format(culture, "{0:N0}", value);
            txtThanhTien.Select(txtThanhTien.Text.Length, 0);
        }
    }
}
