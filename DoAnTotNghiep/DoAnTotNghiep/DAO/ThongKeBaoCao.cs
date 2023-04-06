using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class ThongKeBaoCao
    {
        private ThongKeBaoCao() { }

        private static ThongKeBaoCao instance;
        public static ThongKeBaoCao Instance
        {
            get { if (instance == null) instance = new ThongKeBaoCao(); return instance; }
            private set { instance = value; }
        }

        public double DoanhThuByThangAndNam(int thang, int nam)
        {
            double result = 0;

            string query = "SELECT"
                + " + (SELECT ISNULL(SUM(sotien * muchoahong), 0) FROM v_HoaHongNV WHERE trangthai = N'Đã Hoàn Thành' AND MONTH(v_HoaHongNV.ngaythu) = " + thang + " AND YEAR(v_HoaHongNV.ngaythu) = " + nam + ")"
                + " + (SELECT ISNULL(SUM(sotien * muchoahong), 0) FROM v_HoaHongCT WHERE trangthai = N'Đã Hoàn Thành' AND MONTH(v_HoaHongCT.ngaythu) = " + thang + " AND YEAR(v_HoaHongCT.ngaythu) = " + nam + ") AS 'doanhthu'";
                
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            try
            {
                result = Convert.ToDouble(data.Rows[0]["doanhthu"]);
            }
            catch
            {
                result = 0;
            }

            return result;
        }
        public double DoanhThuCTByNam(int nam)
        {
            double result = 0;
            string query = "SELECT"
                + " (SELECT ISNULL(SUM(sotien * muchoahong), 0) FROM v_HoaHongCT WHERE trangthai = N'Đã Hoàn Thành' AND YEAR(v_HoaHongCT.ngaythu) = " + nam + ") AS 'doanhthu'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            try
            {
                result = Convert.ToDouble(data.Rows[0]["doanhthu"]);
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public double DoanhThuNVByNam(int nam)
        {
            double result = 0;
            string query = "SELECT"
                + " (SELECT ISNULL(SUM(sotien * muchoahong), 0) FROM v_HoaHongNV WHERE trangthai = N'Đã Hoàn Thành' AND YEAR(v_HoaHongNV.ngaythu) = " + nam + ") AS 'doanhthu'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            try
            {
                result = Convert.ToDouble(data.Rows[0]["doanhthu"]);
            }
            catch
            {
                result = 0;
            }

            return result;
        }
        public DataSet GetDanhSach(string query)
        {

            DataSet data = DataProvider.Instance.ReadDataSet(query);

            return data;
        }

        public DataTable GetDanhSachBDS(string query)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
