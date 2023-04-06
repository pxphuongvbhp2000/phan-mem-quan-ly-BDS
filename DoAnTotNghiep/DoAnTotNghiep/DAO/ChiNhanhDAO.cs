using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class ChiNhanhDAO
    {
        private ChiNhanhDAO() { }

        private static ChiNhanhDAO instance;

        public static ChiNhanhDAO Instance
        {
            get { if (instance == null) instance = new ChiNhanhDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetChiNhanhForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenchinhanh + ' -- ' + id AS chitietCN FROM ChiNhanh");

            return data;
        }

        public DataTable GetChiNhanhByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ChiNhanh WHERE id = '" + id + "'");

            return data;
        }

        public DataTable GetListChiNhanh()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ChiNhanh");

            return data;
        }


        public bool ThemChiNhanh
        (
            string id,
            string tenchinhanh,
            string diachi,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO ChiNhanh VALUES ('{0}', N'{1}', N'{2}', N'{3}');"
                , id, tenchinhanh, diachi, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaChiNhanh
        (
            string id,
            string tenchinhanh,
            string diachi,
            string ghichu
        )
        {
            string query = string.Format("UPDATE ChiNhanh SET tenchinhanh = N'{0}', diachi = N'{1}', ghichu = N'{2}' WHERE id = '{3}'"
                , tenchinhanh, diachi, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaChiNhanh(string id)
        {
            string query = string.Format("DELETE ChiNhanh WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemChiNhanh
        (
            string id,
            string tenchinhanh,
            string diachi,
            string ghichu
        )
        {
            string query = "SELECT * FROM ChiNhanh WHERE id LIKE '%" + id + "%' AND tenchinhanh LIKE N'%" + tenchinhanh
                + "%' AND diachi LIKE N'%" + diachi + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
