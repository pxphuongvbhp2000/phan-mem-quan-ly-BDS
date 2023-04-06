using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class LoaiBatDongSanDAO
    {
        private LoaiBatDongSanDAO() { }

        private static LoaiBatDongSanDAO instance;

        public static LoaiBatDongSanDAO Instance
        {
            get { if (instance == null) instance = new LoaiBatDongSanDAO(); return instance; }
            private set { instance = value; }
        }

        public string GetTenLoaiBDSByID(string id)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LoaiBatDongSan WHERE id = '" + id + "'");
            try
            {
                result = data.Rows[0]["tenloaiBDS"].ToString();
            }
            catch
            {
                result = "";
            }

            return result;
        }

        public DataTable GetLoaiBatDongSanForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenloaiBDS + ' -- ' + id AS chitietLBDS FROM LoaiBatDongSan");

            return data;
        }

        public DataTable GetLoaiBatDongSan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LoaiBatDongSan");

            return data;
        }

        public bool ThemLoaiBatDongSan
        (
            string id,
            string tenloaiBDS,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO LoaiBatDongSan VALUES ('{0}', N'{1}', N'{2}');"
                , id, tenloaiBDS, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaLoaiBatDongSan
        (
            string id,
            string tenloaiBDS,
            string ghichu
        )
        {
            string query = string.Format("UPDATE LoaiBatDongSan SET tenloaiBDS = N'{0}', ghichu = N'{1}' WHERE id = '{2}'"
                , tenloaiBDS, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaLoaiBatDongSan(string id)
        {
            string query = string.Format("DELETE LoaiBatDongSan WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemLoaiBatDongSan
        (
            string id,
            string tenloaiBDS,
            string ghichu
        )
        {
            string query = "SELECT * FROM LoaiBatDongSan WHERE id LIKE '%" + id + "%' AND tenloaiBDS LIKE N'%" + tenloaiBDS
                 + "%' AND ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
