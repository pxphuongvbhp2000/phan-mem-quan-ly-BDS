using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class PhieuDatCocDTO
    {
        private int id;
        private string idkhachhang;
        private string idBDS;
        private DateTime? ngaylapphieu;
        private DateTime? ngayhethan;
        private double tiencoc;
        private double tiendohoanthanh;
        private double tienboithuong;
        private string trangthai;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public string IdBDS { get => idBDS; set => idBDS = value; }
        public DateTime? Ngaylapphieu { get => ngaylapphieu; set => ngaylapphieu = value; }
        public DateTime? Ngayhethan { get => ngayhethan; set => ngayhethan = value; }
        public double Tiencoc { get => tiencoc; set => tiencoc = value; }
        public double Tienboithuong { get => tienboithuong; set => tienboithuong = value; }
        public double Tiendohoanthanh { get => tiendohoanthanh; set => tiendohoanthanh = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhieuDatCocDTO() { }

        public PhieuDatCocDTO
        (
            int id,
            string idkhachhang,
            string idBDS,
            DateTime? ngaylapphieu,
            DateTime? ngayhethan,
            double tiencoc,
            double tiendohoanthanh,
            double tienboithuong,
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
            this.tiendohoanthanh = tiendohoanthanh;
            this.Tienboithuong = tienboithuong;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }

        public PhieuDatCocDTO(DataRow row)
        {
            this.Id = int.Parse(row["id"].ToString());
            this.Idkhachhang = row["idkhachhang"].ToString();
            this.IdBDS = row["idBDS"].ToString();
            this.Ngaylapphieu = (DateTime?)row["ngaylapphieu"];
            this.Ngayhethan = (DateTime?)row["ngayhethan"];
            this.Tiencoc = double.Parse(row["tiencoc"].ToString());
            this.Tiendohoanthanh = double.Parse(row["tiendohoanthanh"].ToString());
            this.Tienboithuong = double.Parse(row["tienboithuong"].ToString());
            this.Trangthai = row["trangthai"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
