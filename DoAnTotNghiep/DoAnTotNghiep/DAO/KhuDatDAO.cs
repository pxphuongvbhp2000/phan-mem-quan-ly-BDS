using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class KhuDatDAO
    {
        private KhuDatDAO() { }

        private static KhuDatDAO instance;

        public static KhuDatDAO Instance
        {
            get { if (instance == null) instance = new KhuDatDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable GetKhuDatForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenkhu + ' -- ' + id AS chitietKD FROM KhuDat");

            return data;
        }

        public string GetTenKhuByID(string id)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhuDat WHERE id = '" + id + "'");
            try
            {
                result = data.Rows[0]["tenkhu"].ToString();
            }
            catch
            {
                result = "";
            }

            return result;
        }

        public string GetIDDuAnByIDKhuDat(string id)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhuDat WHERE id = '" + id + "'");
            try
            {
                result = data.Rows[0]["idduan"].ToString();
            }
            catch
            {
                result = "";
            }

            return result;
        }


        public DataTable GetKhuDatForCBBByIDDuAn(string idduan)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenkhu + ' -- ' + id AS chitietKD FROM KhuDat WHERE idduan LIKE '%" + idduan + "%'");

            return data;
        }

        public DataTable GetListKhuDat()
        {
            string query = "SELECT KhuDat.id, KhuDat.idduan, DuAn.tenduan, KhuDat.tenkhu, KhuDat.vitri"
                + ", KhuDat.soluonglo, KhuDat.dientich, KhuDat.ghichu "
                + "FROM KhuDat "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemKhuDat
        (
            string id,
            string idduan,
            string tenkhu,
            string vitri,
            int soluonglo,
            double dientich,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO KhuDat VALUES ('{0}', '{1}', N'{2}', N'{3}', {4}, {5}, N'{6}')"
                , id, idduan, tenkhu, vitri, soluonglo, dientich, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaKhuDat
        (
            string id,
            string idduan,
            string tenkhu,
            string vitri,
            int soluonglo,
            double dientich,
            string ghichu
        )
        {
            string query = string.Format("UPDATE KhuDat SET idduan = '{0}', tenkhu = N'{1}', vitri = N'{2}', soluonglo = {3},"
                + "dientich = {4}, ghichu = N'{5}'"
                + " WHERE id = '{6}'"
                , idduan, tenkhu, vitri, soluonglo, dientich, ghichu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaKhuDat(string id)
        {
            string query = string.Format("DELETE KhuDat WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemKhuDat
        (
            string id,
            string idduan,
            string tenkhu,
            string vitri,
            string ghichu
        )
        {
            string query = "SELECT KhuDat.id, KhuDat.idduan, DuAn.tenduan, KhuDat.tenkhu, KhuDat.vitri"
                + ", KhuDat.soluonglo, KhuDat.dientich, KhuDat.ghichu "
                + "FROM KhuDat "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id"
                + " WHERE DuAn.id LIKE '%" + id + "%' AND KhuDat.idduan LIKE N'%" + idduan + "%' AND KhuDat.tenkhu LIKE N'%" + tenkhu
                + "%' AND KhuDat.vitri LIKE N'%" + vitri 
                + "%' AND KhuDat.ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
