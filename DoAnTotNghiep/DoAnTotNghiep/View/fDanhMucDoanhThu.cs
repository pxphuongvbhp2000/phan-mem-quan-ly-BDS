using System;
using DoAnTotNghiep.DAO;
using DoAnTotNghiep.DTO;
using DoAnTotNghiep.View;
using DoAnTotNghiep.Report;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DoAnTotNghiep.View
{
    public partial class fDanhMucDoanhThu : Form
    {
        public fDanhMucDoanhThu()
        {
            InitializeComponent();
        }

        private void fDanhMucDoanhThu_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            nNam.Value = now.Year;
            LoadBieuDo();
        }

        void LoadBieuDo ()
        {

            chDoanhThu.Series["vnđ"].Points.Clear();
            for (int i = 1; i <= 12; i++)
            {
                double tmp = ThongKeBaoCao.Instance.DoanhThuByThangAndNam(i, (int)nNam.Value);
                chDoanhThu.Series["vnđ"].Points.Add(tmp);
                chDoanhThu.Series["vnđ"].Points[i - 1].Label = String.Format("{0:N2}", tmp);
                chDoanhThu.Series["vnđ"].Points[i - 1].Color = Color.Blue;
                chDoanhThu.Series["vnđ"].Points[i - 1].AxisLabel = "Tháng " + i.ToString();

                chDoanhThu.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            }

            double CT = ThongKeBaoCao.Instance.DoanhThuCTByNam((int)nNam.Value);
            double NV = ThongKeBaoCao.Instance.DoanhThuNVByNam((int)nNam.Value);
            txtCT.Text = CT.ToString();
            txtNV.Text = NV.ToString();

            chSoSanh.Series["vnđ"].Points.Clear();

            chSoSanh.Series["vnđ"].Points.Add(CT);
            chSoSanh.Series["vnđ"].Points[0].Color = Color.Blue;
            chSoSanh.Series["vnđ"].Points[0].Label = "Doanh Thu Của Công Ty";

            chSoSanh.Series["vnđ"].Points.Add(NV);
            chSoSanh.Series["vnđ"].Points[1].Color = Color.Red;
            chSoSanh.Series["vnđ"].Points[1].Label = "Doanh Thu Của Nhân Viên";


        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            LoadBieuDo();
        }

        private void btnDanhSachPhieuGiuCho_Click(object sender, EventArgs e)
        {
            fDanhSachPhieuGiuCho f = new fDanhSachPhieuGiuCho();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachPhieuDatCoc_Click(object sender, EventArgs e)
        {
            fDanhSachPhieuDatCoc f = new fDanhSachPhieuDatCoc();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachHopDongMuaBan_Click(object sender, EventArgs e)
        {
            fDanhSachHopDongMuaBan f = new fDanhSachHopDongMuaBan();
            f.ShowDialog();
            this.Show();
        }

        private void btnDanhSachLichThanhToan_Click(object sender, EventArgs e)
        {
            fDanhSachLichThanhToan f = new fDanhSachLichThanhToan();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtCT_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtCT.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtCT.Text = String.Format(culture, "{0:N0}", value);
            txtCT.Select(txtCT.Text.Length, 0);
        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = 0;
            try
            {
                value = decimal.Parse(txtNV.Text, System.Globalization.NumberStyles.AllowThousands);
            }
            catch
            {
                value = 0;
            }
            txtNV.Text = String.Format(culture, "{0:N0}", value);
            txtNV.Select(txtNV.Text.Length, 0);
        }
    }
}
