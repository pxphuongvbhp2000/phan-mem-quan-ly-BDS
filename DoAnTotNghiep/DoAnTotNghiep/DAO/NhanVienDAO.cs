using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class NhanVienDAO
    {
        private NhanVienDAO() { }

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public bool DangNhap(string id, string matkhaudangnhap)
        {
            //byte[] temp = asciiencoding.ascii.getbytes(matkhau);
            //byte[] hasdata = new md5cryptoserviceprovider().computehash(temp);

            //string haspass = "";

            //foreach (byte item in hasdata)
            //{
            //    haspass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse();

            String query = "SELECT * FROM NhanVien WHERE trangthai <> N'Khóa' AND id = '" + id + "' AND matkhaudangnhap = N'" + matkhaudangnhap + "';";
            query += "UPDATE NhanVien SET trangthai = 'Online' WHERE id = '" + id + "';";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public void DangXuat(string id)
        {
            String query = "UPDATE NhanVien SET trangthai = 'Offline' WHERE id = '" + id + "';";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool ThayDoiMatKhau(string id, string matkhaumoi)
        {
            String query = "UPDATE NhanVien SET matkhaudangnhap = '" + matkhaumoi + "' WHERE id = '" + id + "';";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool KiemTraQuyen(string id, string tenphanquyen)
        {
            String query = "SELECT * FROM NhanVien "
                + "LEFT JOIN NhomQuyen ON NhanVien.idnhomquyen = NhomQuyen.id "
                + "LEFT JOIN NhomQuyenChiTiet ON NhomQuyenChiTiet.idnhomquyen = NhomQuyen.id "
                + "LEFT JOIN PhanQuyen ON NhomQuyenChiTiet.idphanquyen =  PhanQuyen.id "
                + "WHERE NhanVien.id = '" + id + "' AND tenphanquyen = N'" + tenphanquyen + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public DataTable GetNhanVienForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, hoten + ' -- ' + id AS chitietNV FROM NhanVien");

            return data;
        }

        public DataTable GetNhanVienByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien WHERE id = '" + id + "'");

            return data;
        }

        public string GetTenNhanVienByID(string id)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien WHERE id = '" + id + "'");
            try
            {
                result = data.Rows[0]["hoten"].ToString();
            }
            catch
            {
                result = "";
            }

            return result;
        }

        public DataTable GetListNhanVien()
        {
            String query = "SELECT NhanVien.id, NhanVien.matkhaudangnhap, NhanVien.hoten, NhanVien.gioitinh, NhanVien.ngaysinh,"
                + "NhanVien.sothecancuoc, NhanVien.nguyenquan, NhanVien.diachithuongtru, NhanVien.sdt, NhanVien.email, "
                + "NhanVien.nganhang, NhanVien.sotaikhoan, NhanVien.idchinhanh, ChiNhanh.tenchinhanh, NhanVien.idphongban,"
                + "PhongBan.tenphongban, NhanVien.idchucvu, ChucVu.tenchucvu, NhanVien.idnhomquyen, NhomQuyen.tennhomquyen,"
                + "NhanVien.masothue, NhanVien.trangthai, NhanVien.ghichu "
                + "FROM NhanVien "
                + "LEFT JOIN ChiNhanh ON NhanVien.idchinhanh = ChiNhanh.id "
                + "LEFT JOIN PhongBan ON NhanVien.idphongban = PhongBan.id "
                + "LEFT JOIN ChucVu ON NhanVien.idchucvu = ChucVu.id "
                + "LEFT JOIN NhomQuyen ON NhanVien.idnhomquyen = NhomQuyen.id;";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        

        public bool ThemNhanVien
        (
            string id,
            string matkhaudangnhap,
            string hoten,
            string gioitinh,
            string ngaysinh,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string nganhang,
            string sotaikhoan,
            string idchinhanh,
            string idphongban,
            string idchucvu,
            string idnhomquyen,
            string masothue,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format(
                "INSERT INTO NhanVien (id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan," 
                + "diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,"
                + " trangthai, ghichu)"
                + " VALUES ("
                + "'{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}', N'{6}', N'{7}',"
                + "'{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}',"
                + "'{16}', N'{17}', N'{18}');"
                ,id, matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
                diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
                 trangthai, ghichu

                );

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaNhanVien
        (
            string id,
            string matkhaudangnhap,
            string hoten,
            string gioitinh,
            string ngaysinh,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string nganhang,
            string sotaikhoan,
            string idchinhanh,
            string idphongban,
            string idchucvu,
            string idnhomquyen,
            string masothue,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format(
                "UPDATE NhanVien SET matkhaudangnhap = '{0}', hoten = N'{1}', gioitinh = N'{2}', ngaysinh = '{3}', sothecancuoc = '{4}',"
                + "nguyenquan = N'{5}', diachithuongtru = N'{6}', sdt = '{7}', email = '{8}', nganhang = N'{9}', sotaikhoan = '{10}', idchinhanh = '{11}',"
                + "idphongban = '{12}', idchucvu = '{13}', idnhomquyen = '{14}', masothue = '{15}', trangthai = N'{16}', ghichu = N'{17}'"
                + " WHERE id = '{18}'"
                , matkhaudangnhap, hoten, gioitinh, ngaysinh, sothecancuoc, nguyenquan,
                diachithuongtru, sdt, email, nganhang, sotaikhoan, idchinhanh, idphongban, idchucvu, idnhomquyen, masothue,
                trangthai, ghichu, id
                );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaNhanVien(string id)
        {
            string query = string.Format("DELETE NhanVien WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemNhanVien
        (
            string id,
            string hoten,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string nganhang,
            string sotaikhoan,
            string idchinhanh,
            string idphongban,
            string idchucvu,
            string idnhomquyen,
            string masothue,
            string trangthai,
            string ghichu
        )
        {
            string query =
                "SELECT NhanVien.id, NhanVien.matkhaudangnhap, NhanVien.hoten, NhanVien.gioitinh, NhanVien.ngaysinh,"
                + "NhanVien.sothecancuoc, NhanVien.nguyenquan, NhanVien.diachithuongtru, NhanVien.sdt, NhanVien.email, "
                + "NhanVien.nganhang, NhanVien.sotaikhoan, NhanVien.idchinhanh, ChiNhanh.tenchinhanh, NhanVien.idphongban,"
                + "PhongBan.tenphongban, NhanVien.idchucvu, ChucVu.tenchucvu, NhanVien.idnhomquyen, NhomQuyen.tennhomquyen,"
                + "NhanVien.masothue, NhanVien.trangthai, NhanVien.ghichu "
                + "FROM NhanVien "
                + "LEFT JOIN ChiNhanh ON NhanVien.idchinhanh = ChiNhanh.id "
                + "LEFT JOIN PhongBan ON NhanVien.idphongban = PhongBan.id "
                + "LEFT JOIN ChucVu ON NhanVien.idchucvu = ChucVu.id "
                + "LEFT JOIN NhomQuyen ON NhanVien.idnhomquyen = NhomQuyen.id "
                + "WHERE NhanVien.id LIKE '%" + id + "%' AND hoten LIKE N'%" + hoten + "%'" 
                + " AND sothecancuoc LIKE '%" + sothecancuoc + "%' AND nguyenquan LIKE N'%" + nguyenquan + "%' AND diachithuongtru LIKE N'%" + diachithuongtru + "%'"
                + "AND sdt LIKE '%" + sdt + "%' AND email LIKE '%" + email + "%' AND nganhang LIKE N'%" + nganhang + "%' AND sotaikhoan LIKE '%" + sotaikhoan + "%' AND idchinhanh LIKE '%" + idchinhanh + "%' AND "
                + "idphongban LIKE '%" + idphongban + "%' AND idchucvu LIKE '%" + idchucvu + "%' AND idnhomquyen LIKE '%" + idnhomquyen + "%' AND masothue LIKE '%" + masothue + "%'"
                + " AND NhanVien.trangthai LIKE N'%" + trangthai + "%'" + " AND NhanVien.ghichu LIKE N'%" + ghichu + "%'";



            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
