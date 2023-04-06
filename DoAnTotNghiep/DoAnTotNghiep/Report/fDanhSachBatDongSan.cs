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
using Microsoft.Reporting.WinForms;

namespace DoAnTotNghiep.Report
{
    public partial class fDanhSachBatDongSan : Form
    {
        public fDanhSachBatDongSan()
        {
            InitializeComponent();
        }

        string query = "SELECT * FROM v_BDSChiTiet WHERE 1 = 1";

        private void fDanhSachBatDongSan_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
            LoadReport(query);
            txtIDDuAn.Text = "";
            txtIDLoaiBDS.Text = "";
            txtBatDau.Text = "0";
            txtKetThuc.Text = "0";
            this.rptBieuMau.RefreshReport();
            txtIDDuAn.Enabled = false;
            txtIDLoaiBDS.Enabled = false;
        }
        void LoadComBoBox()
        {
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Chưa Bán");
            cbbTrangThai.Items.Add("Mở Bán");
            cbbTrangThai.Items.Add("Giữ Chỗ");
            cbbTrangThai.Items.Add("Đặt Cọc");
            cbbTrangThai.Items.Add("Đang Tiến Hành");
            cbbTrangThai.Items.Add("Đã Hoàn Thành");

            DataTable dataLoaiBDS = LoaiBatDongSanDAO.Instance.GetLoaiBatDongSanForCBB();
            cbbLoaiBDS.DataSource = dataLoaiBDS;
            cbbLoaiBDS.DisplayMember = "chitietLBDS";
            cbbLoaiBDS.ValueMember = "id";
            cbbLoaiBDS.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbLoaiBDS.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataDuAn = DuAnDAO.Instance.GetDuAnForCBB();
            cbbDuAn.DataSource = dataDuAn;
            cbbDuAn.DisplayMember = "chitietDA";
            cbbDuAn.ValueMember = "id";
            cbbDuAn.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbDuAn.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void LoadReport(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptBatDongSan.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_BDSChiTiet";
                rds.Value = dsDanhSach.Tables[0];

                rptBieuMau.LocalReport.DataSources.Clear();
                rptBieuMau.LocalReport.DataSources.Add(rds);

                this.rptBieuMau.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không có kết quả!", "Thông báo");
            }
        }

        private void cbbDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDDuAn.Text = cbbDuAn.SelectedValue.ToString();
        }

        private void cbbLoaiBDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDLoaiBDS.Text = cbbLoaiBDS.SelectedValue.ToString();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {

            try
            {
                double tmp = double.Parse(txtBatDau.Text);
            }
            catch
            {

                MessageBox.Show("Bạn cần nhập dữ liệu số?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatDau.Text = "0";
            }

            try
            {
                double tmp = double.Parse(txtKetThuc.Text);
            }
            catch
            {
                MessageBox.Show("Bạn cần nhập dữ liệu số?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetThuc.Text = "0";
            }

            string query = "SELECT * FROM v_BDSChiTiet WHERE 1 = 1 ";

            if (cbDuAn.Checked)
            {
                query += " AND idduan LIKE '%" + txtIDDuAn.Text + "%' ";
            }

            if (cbLoaiBDS.Checked)
            {
                query += " AND idLoaiBDS LIKE '%" + txtIDLoaiBDS.Text + "%' ";
            }

            if (cbDienTich.Checked)
            {
                query += " AND dientichdat >= '" + txtBatDau.Text + "' AND dientichdat <= '" + txtKetThuc.Text + "'";
            }

            if (cbTrangThai.Checked)
            {
                query += " AND trangthai LIKE N'%" + cbbTrangThai.Text + "%' ";
            }

            LoadReport(query);

            cbDienTich.Checked = false;
            cbLoaiBDS.Checked = false;
            cbDuAn.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhSachBatDongSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
