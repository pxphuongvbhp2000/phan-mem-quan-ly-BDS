using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class PhanQuyenDAO
    {
        private PhanQuyenDAO() { }

        private static PhanQuyenDAO instance;

        public static PhanQuyenDAO Instance
        {
            get { if (instance == null) instance = new PhanQuyenDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListPhanQuyen(string idnhomquyen)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhanQuyen "
                + "WHERE id NOT IN(SELECT idphanquyen FROM NhomQuyenChiTiet WHERE idnhomquyen = '" + idnhomquyen + "')");

            return data;
        }

        public DataTable TimKiemPhanQuyen
        (   
            string id, 
            string tenphanquyen
        )
        {
            string query = "SELECT * FROM PhanQuyen WHERE id LIKE '%" + id + "%' AND tenphanquyen LIKE N'%" + tenphanquyen + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
