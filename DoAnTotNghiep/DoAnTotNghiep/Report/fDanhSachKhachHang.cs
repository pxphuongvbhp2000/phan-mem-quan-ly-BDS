﻿using System;
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
    public partial class fDanhSachKhachHang : Form
    {
        public fDanhSachKhachHang()
        {
            InitializeComponent();
        }

        string query = "SELECT * FROM v_KHChiTiet WHERE 1 = 1";

        private void fDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
            LoadReport(query);
            txtIDNhanVienPhuTrach.Text = "";
            this.rptBieuMau.RefreshReport();
        }

        public void LoadReport(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptKhachHang.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_KHChiTiet";
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

        void LoadComBoBox()
        {

            DataTable dataBDS = BatDongSanDAO.Instance.GetBatDongSanForCBB();
            DataTable dataNhanVienPhuTrach = NhanVienDAO.Instance.GetNhanVienForCBB();
            cbbNhanVienPhuTrach.DataSource = dataNhanVienPhuTrach;
            cbbNhanVienPhuTrach.DisplayMember = "chitietNV";
            cbbNhanVienPhuTrach.ValueMember = "id";
            cbbNhanVienPhuTrach.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbNhanVienPhuTrach.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbbNhanVienPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDNhanVienPhuTrach.Text = cbbNhanVienPhuTrach.SelectedValue.ToString();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM v_KHChiTiet WHERE 1 = 1 ";

            if (cbNhanVienPhuTrach.Checked)
            {
                query += " AND idnhanvienphutrach LIKE '%" + txtIDNhanVienPhuTrach.Text + "%' ";
            }


            LoadReport(query);

            cbNhanVienPhuTrach.Checked = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fDanhSachKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
