using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class DuAnDAO
    {
        private DuAnDAO() { }

        private static DuAnDAO instance;

        public static DuAnDAO Instance
        {
            get { if (instance == null) instance = new DuAnDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetDuAnForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id, tenduan + ' -- ' + id AS chitietDA FROM DuAn");

            return data;
        }

        public string GetTenDuAnByID(string id)
        {
            string result = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DuAn WHERE id = '" + id + "'");
            try
            {
                result = data.Rows[0]["tenduan"].ToString();
            }
            catch
            {
                result = "";
            }

            return result;
        }

        public DataTable GetListDuAn()
        {
            string query = "SELECT DuAn.id, DuAn.idchudautu, tencongty, DuAn.tenduan, DuAn.vitri, DuAn.dientich, DuAn.sogiayphep, DuAn.noicap"
                + ", DuAn.ngaycap, DuAn.idnhanvienphutrach, NhanVien.hoten, DuAn.ghichu "
                + "FROM DuAn "
                + "LEFT JOIN NhanVien ON DuAn.idnhanvienphutrach = NhanVien.id "
                + "LEFT JOIN ChuDauTu ON DuAn.idchudautu = ChuDauTu.id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool ThemDuAn
        (
            string id,
            string idchudautu,
            string tenduan,
            string vitri,
            double dientich,
            string sogiayphep,
            string noicap,
            string ngaycap,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO DuAn VALUES ('{0}', '{1}', N'{2}', N'{3}', {4}, '{5}', N'{6}', '{7}', '{8}', N'{9}');"
                , id, idchudautu, tenduan, vitri, dientich, sogiayphep, noicap, ngaycap, idnhanvienphutrach, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaDuAn
        (
            string id,
            string idchudautu,
            string tenduan,
            string vitri,
            double dientich,
            string sogiayphep,
            string noicap,
            string ngaycap,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            string query = string.Format("UPDATE DuAn SET tenduan = N'{0}', vitri = N'{1}', dientich = {2}, sogiayphep = '{3}', "
                + "noicap = N'{4}', ngaycap = '{5}', idnhanvienphutrach = '{6}', ghichu = N'{7}', idchudautu = '{8}'"
                + " WHERE id = '{9}'"
                , tenduan, vitri, dientich, sogiayphep, noicap, ngaycap, idnhanvienphutrach, ghichu, idchudautu, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaDuAn(string id)
        {
            string query = string.Format("DELETE DuAn WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemDuAn
        (
            string id,
            string idchudautu,
            string tenduan,
            string vitri,
            string sogiayphep,
            string noicap,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            string query = "SELECT DuAn.id, DuAn.tenduan, DuAn.vitri, DuAn.dientich, DuAn.sogiayphep, DuAn.noicap"
                + ", DuAn.ngaycap, DuAn.idnhanvienphutrach, NhanVien.hoten, DuAn.ghichu "
                + "FROM DuAn "
                + "LEFT JOIN NhanVien ON DuAn.idnhanvienphutrach = NhanVien.id"
                + " WHERE DuAn.id LIKE '%" + id + "%' AND DuAn.tenduan LIKE N'%" + tenduan
                + "%' AND DuAn.idchudautu LIKE N'%" + idchudautu 
                + "%' AND DuAn.vitri LIKE N'%" + vitri + "%' AND DuAn.sogiayphep LIKE '%" + sogiayphep + "%'"
                + " AND DuAn.noicap LIKE N'%" + noicap + "%' AND DuAn.idnhanvienphutrach LIKE '%" + idnhanvienphutrach + "%'"
                + " AND DuAn.ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
