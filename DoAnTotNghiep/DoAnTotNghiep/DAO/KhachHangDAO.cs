using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class KhachHangDAO
    {
        private KhachHangDAO() { }

        private static KhachHangDAO instance;

        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=DoAnTotNghiep;Integrated Security=True";

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetKhachHangForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, hoten + ' -- ' + sdt + ' -- ' + id AS chitietKH FROM KhachHang");

            return data;
        }

        public DataTable GetKhachHangByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang WHERE id = '" + id + "'");

            return data;
        }

        public DataTable GetListAnhCanCuoc(string idkhachhang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhCanCuoc WHERE idkhachhang = '" + idkhachhang + "'");

            return data;
        }

        public DataTable GetListAnhHoKhau(string idkhachhang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhHoKhau WHERE idkhachhang = '" + idkhachhang + "'");

            return data;
        }

        public DataTable GetListAnhKetHon(string idkhachhang)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM AnhKetHon WHERE idkhachhang = '" + idkhachhang + "'");

            return data;
        }


        public DataTable GetListKhachHang()
        {
            String query = "SELECT KhachHang.id,KhachHang.hoten, KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,"
                + "KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, "
                + "KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien', KhachHang.ghichu "
                + "FROM KhachHang "
                + "LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id ;";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemKhachHang
        (
            string id,
            string hoten,
            string gioitinh,
            string ngaysinh,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string masothue,
            string idnhanvienphutrach,
            string ghichu
        )
        {

            string query = string.Format(
                "INSERT INTO KhachHang "
                + " VALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', '{7}', '{8}', '{9}', '{10}', N'{11}') ;"
                , id, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                idnhanvienphutrach, ghichu
                );

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool ThemAnhCanCuoc
        (
            string idkhachhang,
            byte[] anhcancuoc
        )
        {

            string query = string.Format("INSERT INTO AnhCanCuoc(idkhachhang, anhcancuoc) VALUES ('{0}', @anhcancuoc );", idkhachhang);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhcancuoc});

            return result > 0;
        }

        public bool ThemAnhHoKhau
        (
            string idkhachhang,
            byte[] anhhokhau
        )
        {

            string query = string.Format("INSERT INTO AnhHoKhau(idkhachhang, anhhokhau) VALUES ('{0}', @anhhokhau );", idkhachhang);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhhokhau });

            return result > 0;
        }

        public bool ThemAnhKetHon
        (
            string idkhachhang,
            byte[] anhkethon
        )
        {

            string query = string.Format("INSERT INTO AnhKetHon(idkhachhang, anhkethon) VALUES ('{0}', @anhcancuoc );", idkhachhang);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhkethon });

            return result > 0;
        }

        public bool SuaKhacHang
        (
            string id,
            string hoten,
            string gioitinh,
            string ngaysinh,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string masothue,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            string query = string.Format(
                "UPDATE KhachHang SET hoten = N'{0}', gioitinh = N'{1}', ngaysinh = '{2}', sothecancuoc = '{3}',"
                + "nguyenquan = N'{4}', diachithuongtru = N'{5}', sdt = '{6}', email = '{7}', "
                + " masothue = '{8}', idnhanvienphutrach = '{9}', ghichu = N'{10}' "
                + " WHERE id = '{11}'"
                , hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan, diachithuongtru, sdt, email, masothue,
                idnhanvienphutrach, ghichu, id
                );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaAnhCanCuoc
        (
            int id,
            byte[] anhcancuoc
        )
        {

            string query = string.Format( "UPDATE AnhCanCuoc SET anhcancuoc = @anhcancuoc WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhcancuoc });

            return result > 0;
        }

        public bool SuaAnhHoKhau
        (
            int id,
            byte[] anhhokhau
        )
        {

            string query = string.Format("UPDATE AnhHoKhau SET anhhokhau = @anhhokhau WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhhokhau });

            return result > 0;
        }

        public bool SuaAnhKetHon
        (
            int id,
            byte[] anhkethon
        )
        {

            string query = string.Format("UPDATE AnhKetHon SET anhkethon = @anhkethon WHERE id = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { anhkethon });

            return result > 0;
        }

        public bool XoaKhachHang(string id)
        {
            string query = string.Format("DELETE NhuCau WHERE idkhachhang = '{0}'; DELETE KhachHang WHERE id = '{1}';", id, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaAnhCanCuoc(string id)
        {
            string query = string.Format("DELETE AnhCanCuoc WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaAnhHoKhau(string id)
        {
            string query = string.Format("DELETE AnhHoKhau WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool XoaAnhKetHon(string id)
        {
            string query = string.Format("DELETE AnhKetHon WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        
        public DataTable TimKiemKhachHang
        (
            string id,
            string hoten,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string masothue,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            string query =
                "SELECT KhachHang.id,KhachHang.hoten, KhachHang.gioitinh, KhachHang.ngaysinh, KhachHang.sothecancuoc,"
                + "KhachHang.nguyenquan, KhachHang.diachithuongtru, KhachHang.sdt, KhachHang.email, KhachHang.masothue, "
                + "KhachHang.idnhanvienphutrach, NhanVien.hoten AS 'hotennhanvien', KhachHang.ghichu "
                + "FROM KhachHang "
                + "LEFT JOIN NhanVien ON KhachHang.idnhanvienphutrach = NhanVien.id "
                + "WHERE KhachHang.id LIKE '%" + id + "%' AND KhachHang.hoten LIKE N'%" + hoten + "%'"
                + " AND KhachHang.sothecancuoc LIKE '%" + sothecancuoc + "%' AND KhachHang.nguyenquan LIKE N'%" + nguyenquan 
                + "%' AND KhachHang.diachithuongtru LIKE N'%" + diachithuongtru + "%'" + "AND KhachHang.sdt LIKE '%" + sdt 
                + "%' AND KhachHang.email LIKE '%" + email+ "%' AND KhachHang.masothue LIKE '%" + masothue + "%'"
                + " AND KhachHang.idnhanvienphutrach LIKE N'%" + idnhanvienphutrach + "%'" + " AND KhachHang.ghichu LIKE N'%" + ghichu + "%'";



            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
