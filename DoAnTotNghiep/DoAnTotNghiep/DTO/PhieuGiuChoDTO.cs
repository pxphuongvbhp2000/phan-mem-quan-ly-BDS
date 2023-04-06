using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class PhieuGiuChoDTO
    {
        private int id;
        private string idkhachhang;
        private string idBDS;
        private DateTime? ngaylapphieu;
        private DateTime? ngayhethan;
        private double tiencoc;
        private double tiendohoanthanh;
        private int uutien;
        private string trangthai;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public string IdBDS { get => idBDS; set => idBDS = value; }
        public DateTime? Ngaylapphieu { get => ngaylapphieu; set => ngaylapphieu = value; }
        public DateTime? Ngayhethan { get => ngayhethan; set => ngayhethan = value; }
        public double Tiencoc { get => tiencoc; set => tiencoc = value; }
        public double Tiendohoanthanh { get => tiendohoanthanh; set => tiendohoanthanh = value; }
        public int Uutien { get => uutien; set => uutien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhieuGiuChoDTO() { }

        public PhieuGiuChoDTO
        (
            int id,
            string idkhachhang,
            string idBDS,
            DateTime? ngaylapphieu,
            DateTime? ngayhethan,
            double tiencoc,
            double tiendohoanthanh, 
            int uutien,
            string trangthai,
            string ghichu
        )
        {
            this.Id = id;
            this.Idkhachhang = idkhachhang;
            this.IdBDS = idBDS;
            this.Ngaylapphieu = ngaylapphieu;
            this.Ngayhethan = ngayhethan;
            this.Tiencoc = tiencoc;
            this.Tiendohoanthanh = tiendohoanthanh;
            this.Uutien = uutien;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }

        public PhieuGiuChoDTO(DataRow row)
        {
            this.Id = int.Parse(row["id"].ToString());
            this.Idkhachhang = row["idkhachhang"].ToString();
            this.IdBDS = row["idBDS"].ToString();
            this.Ngaylapphieu = (DateTime?)row["ngaylapphieu"];
            this.Ngayhethan = (DateTime?)row["ngayhethan"];
            this.Tiencoc = double.Parse(row["tiencoc"].ToString());
            this.Tiendohoanthanh = double.Parse(row["tiendohoanthanh"].ToString());
            this.Uutien = int.Parse(row["uutien"].ToString());
            this.Trangthai = row["trangthai"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
