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
    public partial class fDanhSachPhieuDatCoc : Form
    {
        public fDanhSachPhieuDatCoc()
        {
            InitializeComponent();
        }
        string query = "SELECT * FROM v_PDCChiTiet WHERE 1 = 1";

        private void fDanhSachPhieuDatCoc_Load(object sender, EventArgs e)
        {
            LoadReport(query);
            this.rptBieuMau.RefreshReport();
        }

        public void LoadReport(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptPhieuDatCoc.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_PDCChiTiet";
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


        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM v_PGCChiTiet WHERE 1 = 1 ";

            if (cbNgayLapPhieu.Checked)
            {

                string d = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
                string u = dtpNgayKetThuc.Value.ToString("yyyy/MM/dd");
                query += " AND ngaylapphieu >= '" + d + "' AND ngaylapphieu <= '" + u + "'";
            }

            LoadReport(query);

            cbNgayLapPhieu.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhSachPhieuDatCoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
