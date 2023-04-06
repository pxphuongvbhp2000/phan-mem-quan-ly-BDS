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
    public partial class fDanhSachNhanVien : Form
    {
        public fDanhSachNhanVien()
        {
            InitializeComponent();
        }


        string query = "SELECT * FROM v_NVChiTiet WHERE 1 = 1";

        private void fDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
            LoadReport(query);
            txtIdChiNhanh.Text = "";
            txtIdPhongBan.Text = "";
            txtIdChucVu.Text = "";


            this.rptBieuMau.RefreshReport();

        }

        public void LoadReport(string query)
        {
            DataSet dsDanhSach = ThongKeBaoCao.Instance.GetDanhSach(query);

            rptBieuMau.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rptBieuMau.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rptBieuMau.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rptBieuMau.ZoomPercent = 100;

            rptBieuMau.LocalReport.ReportEmbeddedResource = "DoAnTotNghiep.Report.rptNhanVien.rdlc";

            if (dsDanhSach.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "v_NVChiTiet";
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

            DataTable dataChiNhanh = ChiNhanhDAO.Instance.GetChiNhanhForCBB();
            cbbTenChiNhanh.DataSource = dataChiNhanh;
            cbbTenChiNhanh.DisplayMember = "chitietCN";
            cbbTenChiNhanh.ValueMember = "id";
            cbbTenChiNhanh.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenChiNhanh.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable dataPhongBan = PhongBanDAO.Instance.GetPhongBanForCBB();
            cbbTenPhongBan.DataSource = dataPhongBan;
            cbbTenPhongBan.DisplayMember = "chitietPB";
            cbbTenPhongBan.ValueMember = "id";
            cbbTenPhongBan.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenPhongBan.AutoCompleteSource = AutoCompleteSource.ListItems;


            DataTable dataChucVu = ChucVuDAO.Instance.GetChucVuForCBB();
            cbbTenChucVu.DataSource = dataChucVu;
            cbbTenChucVu.DisplayMember = "chitietCV";
            cbbTenChucVu.ValueMember = "id";
            cbbTenChucVu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbTenChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cbbTenChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdChucVu.Text = cbbTenChucVu.SelectedValue.ToString();
        }

        private void cbbTenPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdPhongBan.Text = cbbTenPhongBan.SelectedValue.ToString();

        }

        private void cbbTenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdChiNhanh.Text = cbbTenChiNhanh.SelectedValue.ToString();

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM v_NVChiTiet WHERE 1 = 1 ";

            if (cbChiNhanh.Checked)
            {
                query += " AND idchinhanh LIKE '%" + txtIdChiNhanh.Text + "%' ";
            }

            if (cbPhongBan.Checked)
            {
                query += " AND idphongban LIKE '%" + txtIdPhongBan.Text + "%' ";
            }

            if (cbChucVu.Checked)
            {
                query += " AND idchucvu LIKE '%" + txtIdChucVu.Text + "%' ";
            }


            LoadReport(query);

            cbChiNhanh.Checked = false;
            cbPhongBan.Checked = false;
            cbChucVu.Checked = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhSachNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
