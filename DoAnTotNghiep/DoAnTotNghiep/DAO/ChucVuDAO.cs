using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class ChucVuDAO
    {
        private ChucVuDAO() { }

        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetChucVuForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenchucvu + ' -- ' + id AS chitietCV FROM ChucVu");

            return data;
        }

        public DataTable GetChucVuByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ChucVu WHERE id = '" + id + "'");

            return data;
        }

        public DataTable GetListChucVu()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ChucVu");

            return data;
        }

        public bool ThemChucVu
        (
            string id,
            string tenchucvu,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO ChucVu VALUES ('{0}', N'{1}', N'{2}');"
                , id, tenchucvu, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaChucVu
        (
            string id,
            string tenchucvu,
            string ghichu
        )
        {
            string query = string.Format("UPDATE ChucVu SET tenchucvu = N'{0}', ghichu = N'{1}' WHERE id = '{2}'"
                , tenchucvu, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaChucVu(string id)
        {
            string query = string.Format("DELETE ChucVu WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemChucVu
        (
            string id,
            string tenchucvu,
            string ghichu
        )
        {
            string query = "SELECT * FROM ChucVu WHERE id LIKE '%" + id + "%' AND tenchucvu LIKE N'%" + tenchucvu
                 + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
