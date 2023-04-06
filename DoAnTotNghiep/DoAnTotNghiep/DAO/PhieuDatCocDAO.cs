using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class PhieuDatCocDAO
    {
        private PhieuDatCocDAO() { }

        private static PhieuDatCocDAO instance;

        public static PhieuDatCocDAO Instance
        {
            get { if (instance == null) instance = new PhieuDatCocDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListPhieuDatCoc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_PhieuDatCocChiTiet");

            return data;
        }

        public DataTable GetListPhieuDatCocByIDBDS(string idBDS)
        {
            string query = "SELECT * FROM v_PhieuDatCocChiTiet WHERE idBDS = '" + idBDS + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool ThemPhieuDatCoc
        (
            string idkhachhang,
            string idBDS,
            string ngaylapphieu,
            string ngayhethan,
            double tiencoc,
            double tiendohoanthanh,
            double tienboithuong,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO PhieuDatCoc(idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, tienboithuong, trangthai, ghichu) "
                + "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, N'{7}', N'{8}');"
                , idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, tienboithuong, trangthai, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool SuaPhieuDatCoc
        (
            int id, 
            string idkhachhang,
            string idBDS,
            string ngaylapphieu,
            string ngayhethan,
            double tiencoc,
            double tiendohoanthanh,
            double tienboithuong,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("UPDATE PhieuDatCoc SET idkhachhang = '{0}', idBDS = '{1}', ngaylapphieu = '{2}', ngayhethan = '{3}', tiencoc = {4},  tiendohoanthanh = {5}, tienboithuong = {6}, trangthai = N'{7}', ghichu = N'{8}' WHERE id = '{9}'"
                , idkhachhang, idBDS, ngaylapphieu, ngayhethan, tiencoc, tiendohoanthanh, tienboithuong, trangthai, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaPhieuDatCoc(string id)
        {
            string query = string.Format("DELETE AnhDatCoc WHERE idphieudatcoc = '{0}';", id)
                + string.Format("DELETE LichThanhToanDatCoc WHERE idphieudatcoc = '{0}';", id)
                + string.Format("DELETE PhieuDatCoc WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemPhieuDatCoc
        (
            string idBDS,
            string idkhachhang,
            string trangthai,
            string ghichu
        )
        {
            string query = "SELECT * FROM v_PhieuDatCocChiTiet WHERE idkhachhang LIKE '%"
                + idkhachhang.ToString() + "%' AND idBDS LIKE '%" + idBDS.ToString()
                + "%' AND ghichu LIKE N'%" + ghichu + "%'"
                + " AND trangthai LIKE N'%" + trangthai + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }


        public DataTable GetPhieuDatCocByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhieuDatCoc WHERE id = '" + id.ToString() + "'");

            return data;
        }

        public DataTable GetListAnhDatCoc(int idphieudatcoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhDatCoc WHERE idphieudatcoc = '" + idphieudatcoc + "'");

            return data;
        }

        public bool ThemAnhDatCoc
        (
            int idphieudatcoc,
            byte[] anhdatcoc
        )
        {

            string query = string.Format("INSERT INTO AnhDatCoc(idphieudatcoc, anhdatcoc) VALUES ('{0}', @anhdatcoc );", idphieudatcoc);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhdatcoc });

            return result > 0;
        }

        public bool SuaAnhDatCoc
        (
            int id,
            byte[] anhdatcoc
        )
        {

            string query = string.Format("UPDATE AnhDatCoc SET anhdatcoc = @anhdatcoc WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhdatcoc });

            return result > 0;
        }

        public bool XoaAnhDatCoc(int id)
        {
            string query = string.Format("DELETE AnhDatCoc WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetLichThanhToanByIDPDC(int idphieudatcoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_LTTDatCocChiTiet WHERE idphieudatcoc = '" + idphieudatcoc.ToString() + "'");

            return data;
        }

        public bool ThemLTTDatCoc
        (
            int idphieudatcoc,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO LichThanhToanDatCoc(idphieudatcoc, ngaythu, sotien, phantram, trangthai, ghichu, anhphieuthu) "
                + " VALUES ({0}, '{1}', {2}, {3}, N'{4}', N'{5}', @anhphieuthu );"
                , idphieudatcoc, ngaythu, sotien, phantram, trangthai, ghichu);


            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });

            return result > 0;
        }

        public bool SuaLTTDatCoc
        (
            int id,
            int idphieudatcoc,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("UPDATE LichThanhToanDatCoc SET idphieudatcoc = '{0}', ngaythu = '{1}', sotien = {2}, phantram = {3}, trangthai = N'{4}', anhphieuthu = @anhphieuthu , ghichu = N'{5}' WHERE id = '{6}'"
                , idphieudatcoc, ngaythu, sotien, phantram, trangthai, ghichu, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });


            return result > 0;
        }

        public bool XoaLTTDatCoc(int id)
        {
            string query = string.Format("DELETE LichThanhToanDatCoc WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public double GetTienCoc(int id)
        {
            string query = string.Format("SELECT tiencoc FROM PhieuDatCoc WHERE id = '{0}';", id);

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

        public DataTable GetLTTPDCByNgayThu(string idnhanvien, string ngayD, string ngayU)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT v_LTTDatCocChiTiet.* FROM v_LTTDatCocChiTiet LEFT JOIN KhachHang ON idkhachhang = KhachHang.id WHERE KhachHang.idnhanvienphutrach = '" + idnhanvien + "' AND ngaythu >= '" + ngayD + "' AND ngaythu <= '" + ngayU + "'");

            return data;
        }
    }
}
