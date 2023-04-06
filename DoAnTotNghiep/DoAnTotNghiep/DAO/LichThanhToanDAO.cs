using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class LichThanhToanDAO
    {
        private LichThanhToanDAO() { }

        private static LichThanhToanDAO instance;

        public static LichThanhToanDAO Instance
        {
            get { if (instance == null) instance = new LichThanhToanDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListLichThanhToan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_LichThanhToanChiTiet;");

            return data;
        }

        public DataTable GetLichThanhToanByIDHDMB(string idhopdongmuaban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_LichThanhToanChiTiet WHERE idhopdongmuaban = '" + idhopdongmuaban + "'");

            return data;

        }


        public bool ThemLichThanhToan
        (
            string idhopdongmuaban,
            string ngaythu,
            double sotien,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO LichThanhToan(idhopdongmuaban, ngaythu, sotien, trangthai, ghichu) "
                + " VALUES ('{0}', '{1}', {2}, N'{3}', N'{4}')"
                , idhopdongmuaban, ngaythu, sotien, trangthai, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool SuaLichThanhToan
        (
            int id,
            string idhopdongmuaban,
            string ngaythu,
            double sotien,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("UPDATE LichThanhToan SET idhopdongmuaban = '{0}', ngaythu = '{1}', sotien = {2}, trangthai = N'{3}', ghichu = N'{4}' WHERE id = '{5}'"
                , idhopdongmuaban, ngaythu, sotien, trangthai, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaLichThanhToan(string id)
        {
            string query = string.Format("DELETE LichThanhToan WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemLichThanhToan
        (
            string idBDS,
            string idhopdongmuaban,
            string idkhachhang,
            string trangthai,
            string ghichu
        )
        {
            string query = "SELECT * FROM v_LichThanhToanChiTiet WHERE idkhachhang LIKE '%" + idkhachhang.ToString()
                + "%' AND idhopdongmuaban LIKE '%" + idhopdongmuaban.ToString()
                + "%' AND idBDS LIKE '%" + idBDS.ToString()
                + "%' AND trangthai LIKE N'%" + trangthai 
                + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
