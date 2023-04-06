using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class HopDongMuaBanDAO
    {
        private HopDongMuaBanDAO() { }

        private static HopDongMuaBanDAO instance;

        public static HopDongMuaBanDAO Instance
        {
            get { if (instance == null) instance = new HopDongMuaBanDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListHopDongMuaBan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_HopDongMuaBanChiTiet;");

            return data;
        }

        public DataTable GetListHDMBByIDBDS(string idBDS)
        {
            string query = "SELECT * FROM v_HopDongMuaBanChiTiet WHERE idBDS = '" + idBDS + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetHopDongMuaBanForCBB()
        {
            string query = "SELECT id, id + ' -- ' + hotenkhachhang + ' -- ' + diachi  AS chitietHDMB FROM v_HopDongMuaBanChiTiet";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetHopDongMuaBanByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_HopDongMuaBanChiTiet WHERE id = '" + id + "'");

            return data;
        }

        public bool ThemHopDongMuaBan
        (
            string id,
            string idkhachhang,
            string idBDS,
            string ngaylap,
            double thanhtien,
            double tiendohoanthanh,
            double muchoahongCT,
            double muchoahongNV,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO HopDongMuaBan VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, N'{8}', N'{9}');"
                , id, idkhachhang, idBDS, ngaylap, thanhtien, tiendohoanthanh, muchoahongCT, muchoahongNV, trangthai, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaHopDongMuaBan
        (
            string id,
            string idkhachhang,
            string idBDS,
            string ngaylap,
            double thanhtien,
            double muchoahongCT,
            double muchoahongNV,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("UPDATE HopDongMuaBan SET idkhachhang = '{0}', idBDS = '{1}', ngaylap = '{2}', thanhtien = {3}, muchoahongCT = {4}, muchoahongNV = {5}, trangthai = N'{6}', ghichu = N'{7}' WHERE id = '{8}'"
                , idkhachhang, idBDS, ngaylap, thanhtien, muchoahongCT, muchoahongNV, trangthai, ghichu, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaHopDongMuaBan(string id)
        {
            string query = string.Format("DELETE AnhHopDong WHERE idhopdongmuaban = '{0}';", id)
                + string.Format("DELETE LichThanhToanHopDong WHERE idhopdongmuaban = '{0}';", id)
                + string.Format("DELETE HopDongMuaBan WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemHopDongMuaBan
        (
            string id,
            string idBDS,
            string idkhachhang,
            string trangthai,
            string ghichu
        )
        {
            string query = "SELECT * FROM v_HopDongMuaBanChiTiet WHERE id LIKE '%" + id
                + "%' AND idkhachhang LIKE '%" + idkhachhang.ToString() 
                + "%' AND idBDS LIKE '%" + idBDS.ToString()
                + "%' AND trangthai LIKE N'%" + trangthai
                + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetListAnhHopDong(string idhopdongmuaban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhHopDong WHERE idhopdongmuaban = '" + idhopdongmuaban + "'");

            return data;
        }

        public bool ThemAnhHopDong
        (
            string idhopdongmuaban,
            byte[] anhhopdong
        )
        {

            string query = string.Format("INSERT INTO AnhHopDong(idhopdongmuaban, anhhopdong) VALUES ('{0}', @anhhopdong );", idhopdongmuaban);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhhopdong });

            return result > 0;
        }

        public bool SuaAnhHopDong
        (
            int id,
            byte[] anhhopdong
        )
        {

            string query = string.Format("UPDATE AnhHopDong SET AnhHopDong = @anhhopdong WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhhopdong });

            return result > 0;
        }

        public bool XoaAnhHopDong(string id)
        {
            string query = string.Format("DELETE AnhHopDong WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetLichThanhToanByIDHDMB(string idhopdongmuaban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM v_LTTHopDongChiTiet WHERE idhopdongmuaban = '" + idhopdongmuaban.ToString() + "'");

            return data;
        }

        public bool ThemLTTHopDong
        (
            string idhopdongmuaban,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO LichThanhToanHopDong(idhopdongmuaban, ngaythu, sotien, phantram, trangthai, ghichu, anhphieuthu) "
                + " VALUES ('{0}', '{1}', {2}, {3}, N'{4}', N'{5}', @anhphieuthu );"
                , idhopdongmuaban, ngaythu, sotien, phantram, trangthai, ghichu);


            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });

            return result > 0;
        }

        public bool SuaLTTHopDong
        (
            int id,
            string idhopdongmuaban,
            string ngaythu,
            double sotien,
            double phantram,
            string trangthai,
            byte[] anhphieuthu,
            string ghichu
        )
        {
            string query = string.Format("UPDATE LichThanhToanHopDong SET idhopdongmuaban = '{0}', ngaythu = '{1}', sotien = {2}, phantram = {3}, trangthai = N'{4}', anhphieuthu = @anhphieuthu , ghichu = N'{5}' WHERE id = '{6}'"
                , idhopdongmuaban, ngaythu, sotien, phantram, trangthai, ghichu, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhphieuthu });


            return result > 0;
        }

        public bool XoaLTTHopDong(int id)
        {
            string query = string.Format("DELETE LichThanhToanHopDong WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public double GetThanhTien(string id)
        {
            string query = string.Format("SELECT thanhtien FROM HopDongMuaBan WHERE id = '{0}';", id);

            double res;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            try
            {
                res = Convert.ToDouble(data.Rows[0]["thanhtien"]);
            }
            catch (Exception ex)
            {
                res = 0;
            }



            return res;
        }
        public DataTable GetLTTHDMBByNgayThu(string idnhanvien, string ngayD, string ngayU)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT v_LTTHopDongChiTiet.* FROM v_LTTHopDongChiTiet LEFT JOIN KhachHang ON idkhachhang = KhachHang.id WHERE KhachHang.idnhanvienphutrach = '" + idnhanvien + "' AND ngaythu >= '" + ngayD + "' AND ngaythu <= '" + ngayU + "'");

            return data;
        }
    }
}
