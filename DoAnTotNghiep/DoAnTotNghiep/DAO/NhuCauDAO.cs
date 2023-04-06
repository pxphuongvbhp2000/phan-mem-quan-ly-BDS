using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class NhuCauDAO
    {
        private NhuCauDAO() { }

        private static NhuCauDAO instance;

        public static NhuCauDAO Instance
        {
            get { if (instance == null) instance = new NhuCauDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListNhuCau()
        {
            string query = "SELECT NhuCau.id, idkhachhang, KhachHang.hoten, NhuCau.diachi, huong, rong, dai,"
                + "dientichdat, dientichsantruoc, dientichsansau, dongia, NhuCau.ghichu "
                + "FROM NhuCau  "
                + "LEFT JOIN KhachHang ON NhuCau.idkhachhang = KhachHang.id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetListNhuCauByIDKhachHang(string idkhachhang)
        {
            string query = "SELECT NhuCau.id, idkhachhang, KhachHang.hoten, NhuCau.diachi, huong, rong, dai,"
                + "dientichdat, dientichsantruoc, dientichsansau, dongia, NhuCau.ghichu "
                + "FROM NhuCau  "
                + "LEFT JOIN KhachHang ON NhuCau.idkhachhang = KhachHang.id "
                + "WHERE NhuCau.idkhachhang = '" + idkhachhang + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }


        public bool ThemNhuCau
        (
            string idkhachhang,
            string diachi,
            string huong,
            string rong,
            string dai,
            string dientichdat,
            string dientichsantruoc,
            string dientichsansau,
            string dongia,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO NhuCau(idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau, dongia, ghichu) "
                + "VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}');"
                , idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau, dongia, ghichu); ; ; ;

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaNhuCau
        (
            int id,
            string idkhachhang,
            string diachi,
            string huong,
            string rong,
            string dai,
            string dientichdat,
            string dientichsantruoc,
            string dientichsansau,
            string dongia,
            string ghichu
        )
        {
            string query = string.Format("UPDATE NhuCau SET idkhachhang = '{0}', diachi = N'{1}', "
                + "huong = N'{2}', rong = N'{3}', dai = N'{4}',  dientichdat = N'{5}',  dientichsantruoc = N'{6}',  dientichsansau = N'{7}', "
                + " dongia = N'{8}',  ghichu = N'{9}'"
                + " WHERE id = '{10}'"
                , idkhachhang, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau, dongia, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaNhuCau(string id)
        {
            string query = string.Format("DELETE NhuCau WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemNhuCau
        (
            string idkhachhang,
            string diachi,
            string huong,
            string rong,
            string dai,
            string dientichdat,
            string dientichsantruoc,
            string dientichsansau,
            string dongia,
            string ghichu
        )
        {
            string query = "SELECT NhuCau.id, idkhachhang, KhachHang.hoten, NhuCau.diachi, huong, rong, dai,"
                + "dientichdat, dientichsantruoc, dientichsansau, dongia, NhuCau.ghichu "
                + "FROM NhuCau "
                + "LEFT JOIN KhachHang ON NhuCau.idkhachhang = KhachHang.id "
                + "WHERE idkhachhang LIKE '%" + idkhachhang +"%' "
                + "AND NhuCau.diachi LIKE N'%" + diachi +"%'  AND huong LIKE N'%" + huong +"%'  AND rong LIKE N'%" + rong +"%' AND dai LIKE N'%" + dai +"%' "
                + "AND dientichdat LIKE N'%" + dientichdat + "%' AND dientichsantruoc LIKE N'%" + dientichsantruoc + "%' AND dientichsansau LIKE N'%" + dientichsansau +"%' "
                + "AND dongia LIKE N'%" + dongia + "%'  AND NhuCau.ghichu LIKE N'%" + ghichu +"%' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

    }
}
