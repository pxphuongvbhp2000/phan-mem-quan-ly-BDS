using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class PhongBanDAO
    {
        private PhongBanDAO() { }

        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetPhongBanForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenphongban + ' -- ' + id AS chitietPB FROM PhongBan");

            return data;
        }

        public DataTable GetPhongBanByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhongBan WHERE id = '" + id + "'");

            return data;
        }

        public DataTable GetListPhongBan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhongBan");

            return data;
        }

        public bool ThemPhongBan
        (
            string id,
            string tenphongban,
            string vitri,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO PhongBan VALUES ('{0}', N'{1}', N'{2}', N'{3}');"
                , id, tenphongban, vitri, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaPhongBan
        (
            string id,
            string tenphongban,
            string vitri,
            string ghichu
        )
        {
            string query = string.Format("UPDATE PhongBan SET tenphongban = N'{0}', vitri = N'{1}', ghichu = N'{2}' WHERE id = '{3}'"
                , tenphongban, vitri, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaPhongBan(string id)
        {
            string query = string.Format("DELETE PhongBan WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemPhongBan
        (
            string id,
            string tenphongban,
            string vitri,
            string ghichu
        )
        {
            string query = "SELECT * FROM PhongBan WHERE id LIKE '%" + id + "%' AND tenphongban LIKE N'%" + tenphongban
                + "%' AND vitri LIKE N'%" + vitri + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
