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
    public partial class fAnhGiuCho : Form
    {
        private PhieuGiuChoDTO pGCXuLy;

        public PhieuGiuChoDTO PGCXuLy { get => pGCXuLy; set => pGCXuLy = value; }


        public fAnhGiuCho()
        {
            InitializeComponent();
        }

        public fAnhGiuCho(PhieuGiuChoDTO PGCXuLy)
        {
            InitializeComponent();
            this.PGCXuLy = PGCXuLy;
        }

        private void fAnhGiuCho_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtIDPhieuGiuCho.Enabled = false;
            DataTable dataAnh = PhieuGiuChoDAO.Instance.GetListAnhGiuCho(this.PGCXuLy.Id);

            dgvDanhMucAnh.DataSource = dataAnh;
            dgvDanhMucAnh.Columns["id"].HeaderText = "ID";
            dgvDanhMucAnh.Columns["idphieugiucho"].HeaderText = "ID Phiếu Giữ Chỗ";
            dgvDanhMucAnh.Columns["anhgiucho"].HeaderText = "Ảnh Phiếu Giữ Chỗ";

            txtIDPhieuGiuCho.Text = PGCXuLy.Id.ToString();
            txtID.Visible = false;
            txtIDPhieuGiuCho.Visible = false;
            dtpNgayLapPhieu.Value = PGCXuLy.Ngaylapphieu.Value;
            dtpNgayHetHan.Value = PGCXuLy.Ngayhethan.Value;
            txtTienCoc.Text = PGCXuLy.Tiencoc.ToString();
            nUuTien.Text = PGCXuLy.Uutien.ToString();
            cbbTrangThai.Text = PGCXuLy.Trangthai.ToString();

            dtpNgayLapPhieu.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            txtTienCoc.Enabled = false;
            nUuTien.Enabled = false;
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


            //txtIDPhieuGiuCho.DataBindings.Clear();
            //txtIDPhieuGiuCho.DataBindings.Add("Text", dgvDanhMucAnh.DataSource, "idphieugiucho", true, DataSourceUpdateMode.Never);

            pbAnh.DataBindings.Clear();
            pbAnh.DataBindings.Add("Image", dgvDanhMucAnh.DataSource, "anhgiucho", true, DataSourceUpdateMode.Never);

        }


        int flag = 0;


        private void btnXemAnh_Click(object sender, EventArgs e)
        {
            fXemAnh f = new fXemAnh(pbAnh.Image);
            f.Show();
        }
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            pbAnh.Image = null;
            dis_en(true);
            //foreach (TextBox t in gbThongTin.Controls.OfType<TextBox>())
            //{
            //    if (t == txtIDPhieuGiuCho)
            //    {
            //        continue;
            //    }
            //    t.Clear();
            //}

            //if (txtIDPhieuGiuCho.Text == "")
            //{
            //    txtIDPhieuGiuCho.Text = PGCXuLy.Id.ToString();
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
                if (PhieuGiuChoDAO.Instance.XoaAnhGiuCho(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fAnhGiuCho_Load(sender, e);
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
                int idphieugiucho = int.Parse(txtIDPhieuGiuCho.Text);
                var anhgiucho_tmp = new ImageConverter().ConvertTo(pbAnh.Image, typeof(Byte[]));
                byte[] anhgiucho = (byte[])anhgiucho_tmp;

                if (flag == 1)
                {

                    if
                    (
                        PhieuGiuChoDAO.Instance.ThemAnhGiuCho(idphieugiucho, anhgiucho)
                    )
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhGiuCho_Load(sender, e);
                    dis_en(false);
                }
                if (flag == 2)
                {
                    int id = int.Parse(txtID.Text);
                    if
                    (
                        PhieuGiuChoDAO.Instance.SuaAnhGiuCho(id, anhgiucho)
                    )
                    {
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    fAnhGiuCho_Load(sender, e);
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
            fAnhGiuCho_Load(sender, e);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAnhGiuCho_FormClosing(object sender, FormClosingEventArgs e)
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
