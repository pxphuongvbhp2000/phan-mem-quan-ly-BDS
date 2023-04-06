using System;
using DoAnTotNghiep.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DAO
{
    public class BatDongSanDAO
    {
        private BatDongSanDAO() { }

        private static BatDongSanDAO instance;

        public static BatDongSanDAO Instance
        {
            get { if (instance == null) instance = new BatDongSanDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetBatDongSanForCBB()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT BatDongSan.id, diachi + ' -- ' + idkhudat  + ' -- ' + DuAn.vitri  + ' -- ' + KhuDat.vitri AS chitietBDS FROM BatDongSan LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id");

            return data;
        }

        public DataTable GetBatDongSanByID(string id)
        {
            string query = "SELECT BatDongSan.id, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,"
                + "BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,"
                + "dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai, BatDongSan.ghichu "
                + "FROM BatDongSan "
                + "LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id "
                + "LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id"
                + " WHERE BatDongSan.id = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetListBatDongSan()
        {
            string query = "SELECT BatDongSan.id, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,"
                + "BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,"
                + "dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai, BatDongSan.ghichu "
                + "FROM BatDongSan "
                + "LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id "
                + "LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }


        public bool ThemBatDongSan
        (
            string id,
            string idkhudat,
            string idloaiBDS,
            string diachi,
            string huong,
            double rong,
            double dai,
            double dientichdat,
            double dientichsantruoc,
            double dientichsansau,
            double dongia,
            double tylechietkhau,
            double tyleVAT,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("INSERT INTO BatDongSan VALUES ('{0}', '{1}', '{2}', N'{3}', N'{4}', {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, N'{13}', N'{14}');"
                , id, idkhudat, idloaiBDS, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                dongia, tylechietkhau, tyleVAT, trangthai, ghichu);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaBatDongSan
        (
            string id,
            string idkhudat,
            string idloaiBDS,
            string diachi,
            string huong,
            double rong,
            double dai,
            double dientichdat,
            double dientichsantruoc,
            double dientichsansau,
            double dongia,
            double tylechietkhau,
            double tyleVAT,
            string trangthai,
            string ghichu
        )
        {
            string query = string.Format("UPDATE BatDongSan SET idkhudat = '{0}', idloaiBDS = '{1}', diachi = N'{2}', "
                + "huong = N'{3}', rong = {4}, dai = {5},  dientichdat = {6},  dientichsantruoc = {7},  dientichsansau = {8}, "
                + " dongia = {9},  tylechietkhau = {10},  tyleVAT = {11},  trangthai = N'{12}',  ghichu = N'{13}'"
                + " WHERE id = '{14}'"
                ,  idkhudat, idloaiBDS, diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,
                dongia, tylechietkhau, tyleVAT, trangthai, ghichu,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaBatDongSan(string id)
        {
            string query = string.Format("DELETE BatDongSan WHERE id = '{0}';", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimKiemBatDongSan
        (
            string id,
            string idduan,
            string idkhudat,
            string idloaiBDS,
            string diachi,
            string trangthai,
            string ghichu
        )
        {
            string query = "SELECT BatDongSan.id, idduan, tenduan, idkhudat, KhuDat.tenkhu, idloaiBDS, LoaiBatDongSan.tenloaiBDS,"
                + "BatDongSan.diachi, huong, rong, dai, dientichdat, dientichsantruoc, dientichsansau,"
                + "dongia, tylechietkhau, BatDongSan.tyleVAT, BatDongSan.trangthai, BatDongSan.ghichu "
                + "FROM BatDongSan "
                + "LEFT JOIN KhuDat ON BatDongSan.idkhudat = KhuDat.id "
                + "LEFT JOIN DuAn ON KhuDat.idduan = DuAn.id "
                + "LEFT JOIN LoaiBatDongSan ON BatDongSan.idloaiBDS = LoaiBatDongSan.id"
                + " WHERE BatDongSan.id LIKE '%" + id + "%' AND idkhudat LIKE '%" + idkhudat + "%' AND idloaiBDS LIKE '%" + idloaiBDS
                + "%' AND idduan LIKE '%" + idduan
                + "%' AND diachi LIKE N'%" + diachi + "%' AND BatDongSan.trangthai LIKE N'%" + trangthai + "%' AND BatDongSan.ghichu LIKE N'%" + ghichu + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

    }
}
