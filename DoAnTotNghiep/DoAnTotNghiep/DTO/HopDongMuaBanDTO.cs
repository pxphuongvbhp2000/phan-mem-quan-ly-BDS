using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class HopDongMuaBanDTO
    {
        private string id;
        private string idkhachhang;
        private string idBDS;
        private DateTime? ngaylap;
        private double thanhtien;
        private double tiendohoanthanh;
        private double muchoahongCT;
        private double muchoahongNV;
        private string trangthai;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public string IdBDS { get => idBDS; set => idBDS = value; }
        public DateTime? Ngaylap { get => ngaylap; set => ngaylap = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
        public double Tiendohoanthanh { get => tiendohoanthanh; set => tiendohoanthanh = value; }
        public double MuchoahongCT { get => muchoahongCT; set => muchoahongCT = value; }
        public double MuchoahongNV { get => muchoahongNV; set => muchoahongNV = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public HopDongMuaBanDTO() { }

        public HopDongMuaBanDTO
        (
            string id,
            string idkhachhang,
            string idBDS,
            DateTime? ngaylap,
            double thanhtien,
            double tiendohoanthanh,
            double muchoahongCT,
            double muchoahongNV,
            string trangthai,
            string ghichu
        )
        {
            this.Id = id;
            this.Idkhachhang = idkhachhang;
            this.IdBDS = idBDS;
            this.Ngaylap = ngaylap;
            this.Thanhtien = thanhtien;
            this.Tiendohoanthanh = tiendohoanthanh;
            this.MuchoahongCT = muchoahongCT;
            this.MuchoahongNV = muchoahongNV;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }

        public HopDongMuaBanDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Idkhachhang = row["idkhachhang"].ToString();
            this.IdBDS = row["idBDS"].ToString();
            this.Ngaylap = (DateTime?)row["ngaylap"];
            this.Thanhtien = double.Parse(row["thanhtien"].ToString());
            this.Tiendohoanthanh = double.Parse(row["tiendohoanthanh"].ToString());
            this.MuchoahongCT = double.Parse(row["muchoahongCT"].ToString());
            this.MuchoahongNV = double.Parse(row["muchoahongNV"].ToString());
            this.Trangthai = row["trangthai"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
