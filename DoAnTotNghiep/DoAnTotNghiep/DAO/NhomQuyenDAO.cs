using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class NhomQuyenDAO
    {
        private NhomQuyenDAO() { }

        private static NhomQuyenDAO instance;

        public static NhomQuyenDAO Instance
        {
            get { if (instance == null) instance = new NhomQuyenDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetNhomQuyenForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tennhomquyen + ' -- ' + id AS chitietNQ FROM NhomQuyen");

            return data;
        }

        public DataTable GetNhomQuyenByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhomQuyen WHERE id = '" + id + "'");

            return data;
        }

        public DataTable GetListNhomQuyen()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhomQuyen");

            return data;
        }

        public bool ThemNhomQuyen
        ( 
            string id, 
            string tennhomquyen, 
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO NhomQuyen VALUES ('{0}', N'{1}', N'{2}');", id, tennhomquyen, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaNhomQuyen
        (
            string id, 
            string tennhomquyen, 
            string ghichu
        )
        {
            string query = string.Format("UPDATE NhomQuyen SET tennhomquyen = N'{0}', ghichu = N'{1}' WHERE id = '{2}'"
                , tennhomquyen, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaNhomQuyen(string id)
        {
            string query = string.Format("DELETE NhomQuyen WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemNhomQuyen
        (
            string id, 
            string tennhomquyen, 
            string ghichu
        )
        {
            string query = "SELECT * FROM NhomQuyen WHERE id LIKE '%" + id + "%' AND tennhomquyen LIKE N'%" + tennhomquyen 
                + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
