using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class NhomQuyenChiTietDAO
    {
        private NhomQuyenChiTietDAO() { }

        private static NhomQuyenChiTietDAO instance;

        public static NhomQuyenChiTietDAO Instance
        {
            get { if (instance == null) instance = new NhomQuyenChiTietDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListNhomQuyenChiTietByNhomQuyen(string idnhomquyen)
        {
            string query = "SELECT idphanquyen, tenphanquyen FROM NhomQuyenChiTiet " +
                    "LEFT JOIN PhanQuyen ON PhanQuyen.id = NhomQuyenChiTiet.idphanquyen WHERE idnhomquyen = '" + idnhomquyen + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemNhomQuyenChiTiet
        (
            string idphanquyen, 
            string idnhomquyen
        )
        {
            string query = string.Format("INSERT INTO NhomQuyenChiTiet(idphanquyen, idnhomquyen) VALUES ('{0}', '{1}');", idphanquyen, idnhomquyen);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaNhomQuyenChiTiet
        (
            string idphanquyen, 
            string idnhomquyen
        )
        {
            string query = string.Format("DELETE FROM NhomQuyenChiTiet WHERE idphanquyen = '{0}' AND idnhomquyen = '{1}';", idphanquyen, idnhomquyen);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemNhomQuyenChiTiet
        (
            string idphanquyen, 
            string tenphanquyen, 
            string idnhomquyen
        )
        {
            string query = "SELECT idphanquyen, tenphanquyen FROM NhomQuyenChiTiet " +
                   "LEFT JOIN PhanQuyen ON PhanQuyen.id = NhomQuyenChiTiet.idphanquyen WHERE idnhomquyen = '" + idnhomquyen + "' " 
                   + "AND idphanquyen LIKE '%" + idphanquyen + "%' AND tenphanquyen LIKE N'%" + tenphanquyen + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
