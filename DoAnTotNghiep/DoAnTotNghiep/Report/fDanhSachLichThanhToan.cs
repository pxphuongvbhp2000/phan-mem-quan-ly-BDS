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
    public partial class fDanhSachLichThanhToan : Form
    {
        public fDanhSachLichThanhToan()
        {
            InitializeComponent();
        }

        

        private void fDanhSachLichThanhToan_Load(object sender, EventArgs e)
        {
            rbPGC.Checked = true;
            string query = "";
            query = "SELECT * FROM v_LTTPGCChiTiet WHERE 1 = 1";
            LoadReportLTTPGC(query);
            this.rptBieuMau.RefreshReport();
        }

        public void LoadReportLTTPGC(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptLTTPGC.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_LTTPGCChiTiet";
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

        public void LoadReportLTTPDC(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptLTTPDC.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_LTTPDCChiTiet";
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

        public void LoadReportLTTHDMB(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptLTTHDMB.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_LTTHDMBChiTiet";
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
            string query = "";
            string d = "";
            string u = "";
            string tmp = "";

            if (cbNgayThu.Checked)
            {

                d = dtpNgayBatDau.Value.ToString("yyyy/MM/dd");
                u = dtpNgayKetThuc.Value.ToString("yyyy/MM/dd");
                tmp = " AND ngaythu >= '" + d  + "' AND ngaythu <= '" + u + "'"; 
            }

            if (rbPGC.Checked)
            {
                query = "SELECT * FROM v_LTTPGCChiTiet WHERE 1 = 1" + tmp;
                LoadReportLTTPGC(query);
            }
            if (rbPDC.Checked)
            {
                query = "SELECT * FROM v_LTTPDCChiTiet WHERE 1 = 1" + tmp;
                LoadReportLTTPGC(query);
            }
            if (rbHDMB.Checked)
            {
                query = "SELECT * FROM v_LTTHDMBChiTiet WHERE 1 = 1" + tmp;
                LoadReportLTTPGC(query);
            }

            cbNgayThu.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhSachLichThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
