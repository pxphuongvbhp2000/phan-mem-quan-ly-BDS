using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class ChuDauTuDAO
    {
        private ChuDauTuDAO() { }

        private static ChuDauTuDAO instance;

        public static ChuDauTuDAO Instance
        {
            get { if (instance == null) instance = new ChuDauTuDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetChuDauTuForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tencongty + ' -- ' + id AS chitietCDT FROM ChuDauTu");

            return data;
        }

        public DataTable GetListChuDauTu()
        {
            string query = "SELECT * FROM ChuDauTu";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemChuDauTu
        (
            string id,
            string tencongty,
            string diachi,
            string sdt,
            string email,
            string website,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO ChuDauTu VALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', N'{6}');"
                , id, tencongty, diachi, sdt, email, website, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaChuDauTu
        (
            string id,
            string tencongty,
            string diachi,
            string sdt,
            string email,
            string website,
            string ghichu
        )
        {
            string query = string.Format("UPDATE ChuDauTu SET tencongty = N'{0}', diachi = N'{1}', sdt = '{2}', email = '{3}', "
                + "website = '{4}', ghichu = N'{5}'"
                + " WHERE id = '{6}'"
                , tencongty, diachi, sdt, email, website, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaChuDauTu(string id)
        {
            string query = string.Format("DELETE ChuDauTu WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemChuDauTu
        (
            string id,
            string tencongty,
            string diachi,
            string ghichu
        )
        {
            string query = "SELECT * FROM ChuDauTu"
                + " WHERE ChuDauTu.id LIKE '%" + id + "%' AND ChuDauTu.tencongty LIKE N'%" + tencongty
                + "%' AND ChuDauTu.diachi LIKE N'%" + diachi + "%'"
                + " AND ChuDauTu.ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
