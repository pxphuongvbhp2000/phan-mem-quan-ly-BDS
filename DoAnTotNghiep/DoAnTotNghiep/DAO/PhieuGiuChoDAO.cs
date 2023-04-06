using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class PhieuGiuChoDAO
    {
        private PhieuGiuChoDAO() { }

        private static PhieuGiuChoDAO instance;

        public static PhieuGiuChoDAO Instance
        {
            get { if (instance == null) instance = new PhieuGiuChoDAO(); return instance; }
            private set { instance = value; }
        }


        public DataTable GetListPhieuGiuCho()
        {
            string query = "SELECT * FROM v_PhieuGiuChoChiTiet";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetListPhieuGiuChoByIDBDS(string idBDS)
        {
            string query = "SELECT * FROM v_PhieuGiuChoChiTiet WHERE idBDS = '" + idBDS + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool ThemPhieuGiuCho
        (
            string idkhachhang,
            string idBDS,
            string ngaylapphieu,
            string ngayhethan,
            double tiencoc,
            double tiendohoanthanh,
            int uutien,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO PhieuGiuCho(idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, uutien, trangthai, ghichu) "
                + "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, N'{7}', N'{8}');"
                , idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, uutien, trangthai, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool SuaPhieuGiuCho
        (
            int id,
            string idkhachhang,
            string idBDS,
            string ngaylapphieu,
            string ngayhethan,
            double tiencoc, 
            double tiendohoanthanh,
            int uutien,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("UPDATE PhieuGiuCho SET idkhachhang = '{0}', idBDS = '{1}', ngaylapphieu = '{2}', ngayhethan = '{3}', tiencoc = {4}, uutien = {5}, ghichu = N'{6}', tiendohoanthanh = {7}, trangthai = N'{8}' WHERE id = '{9}'"
                , idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, uutien, ghichu, tiendohoanthanh, trangthai, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaPhieuGiuCho(string id)
        {
            string query = string.Format("DELETE AnhGiuCho WHERE idphieugiucho = '{0}';", id)
                + string.Format("DELETE LichThanhToanGiuCho WHERE idphieugiucho = '{0}';", id)
                + string.Format("DELETE PhieuGiuCho WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemPhieuGiuCho
        (
            string idBDS,
            string idkhachhang,
            int uutien,
            string trangthai,
            string ghichu
        )
        {
            string query = "SELECT * FROM v_PhieuGiuChoChiTiet WHERE idkhachhang LIKE '%"
                + idkhachhang.ToString() + "%' AND idBDS LIKE '%" + idBDS.ToString()
                + "%' AND uutien = " + uutien.ToString()
                + " AND trangthai LIKE N'%" + trangthai + "%'"
                + " AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetPhieuGiuChoByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhieuGiuCho WHERE id = '" + id.ToString() + "'");

            return data;
        }

        public DataTable GetListAnhGiuCho(int idphieugiucho)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhGiuCho WHERE idphieugiucho = '" + idphieugiucho + "'");

            return data;
        }

        public bool ThemAnhGiuCho
        (
            int idphieugiucho,
            byte[] anhgiucho
        )
        {

            string query = string.Format("INSERT INTO AnhGiuCho(idphieugiucho, anhgiucho) VALUES ('{0}', @anhgiucho );", idphieugiucho);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhgiucho });

            return result > 0;
        }

        public bool SuaAnhGiuCho
        (
            int id,
            byte[] anhgiucho
        )
        {

            string query = string.Format("UPDATE AnhGiuCho SET anhgiucho = @anhgiucho WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhgiucho });

            return result > 0;
        }

        public bool XoaAnhGiuCho(int id)
        {
            string query = string.Format("DELETE AnhGiuCho WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetLichThanhToanByIDPGC(int idphieugiucho)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_LTTGiuChoChiTiet WHERE idphieugiucho = '" + idphieugiucho.ToString() + "'");

            return data;
        }

        public bool ThemLTTGiuCho
        (
            int idphieugiucho,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO LichThanhToanGiuCho(idphieugiucho, ngaythu, sotien, phantram, trangthai, ghichu, anhphieuthu) "
                + " VALUES ({0}, '{1}', {2}, {3}, N'{4}', N'{5}', @anhphieuthu );"
                , idphieugiucho, ngaythu, sotien, phantram, trangthai, ghichu);


            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });

            return result > 0;
        }

        public bool SuaLTTGiuCho
        (
            int id,
            int idphieugiucho,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("UPDATE LichThanhToanGiuCho SET idphieugiucho = '{0}', ngaythu = '{1}', sotien = {2}, phantram = {3}, trangthai = N'{4}', anhphieuthu = @anhphieuthu , ghichu = N'{5}' WHERE id = '{6}'"
                , idphieugiucho, ngaythu, sotien, phantram, trangthai, ghichu, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });


            return result > 0;
        }

        public bool XoaLTTGiuCho(int id)
        {
            string query = string.Format("DELETE LichThanhToanGiuCho WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public double GetTienCoc(int id)
        {
            string query = string.Format("SELECT tiencoc FROM PhieuGiuCho WHERE id = '{0}';", id);

            double res;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            try
            {
                res = Convert.ToDouble(data.Rows[0]["tiencoc"]);
            }
            catch (Exception ex)
            {
                res = 0;
            }



            return res;
        }

        public DataTable GetLTTPGCByNgayThu(string idnhanvien, string ngayD, string ngayU)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT v_LTTGiuChoChiTiet.* FROM v_LTTGiuChoChiTiet LEFT JOIN KhachHang ON idkhachhang = KhachHang.id WHERE KhachHang.idnhanvienphutrach = '" + idnhanvien + "' AND ngaythu >= '" + ngayD + "' AND ngaythu <= '" + ngayU + "'");

            return data;
        }
    }
}
