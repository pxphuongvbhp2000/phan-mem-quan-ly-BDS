using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class BatDongSanDTO
    {
        private string id;
		private string idkhudat;
		private string idloaiBDS;
		private string diachi;
		private string huong;
		private double rong;
		private double dai;
		private double dientichdat;
		private double dientichsantruoc;
		private double dientichsansau;
		private double dongia;
        private double tylechietkhau;
        private double tyleVAT;
		private string trangthai;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Idkhudat { get => idkhudat; set => idkhudat = value; }
        public string IdloaiBDS { get => idloaiBDS; set => idloaiBDS = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Huong { get => huong; set => huong = value; }
        public double Rong { get => rong; set => rong = value; }
        public double Dai { get => dai; set => dai = value; }
        public double Dientichdat { get => dientichdat; set => dientichdat = value; }
        public double Dientichsantruoc { get => dientichsantruoc; set => dientichsantruoc = value; }
        public double Dientichsansau { get => dientichsansau; set => dientichsansau = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public double Tylechietkhau { get => tylechietkhau; set => tylechietkhau = value; }
        public double TyleVAT { get => tyleVAT; set => tyleVAT = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public BatDongSanDTO() { }

        public BatDongSanDTO
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
            this.Id = id;
            this.Idkhudat = idkhudat;
            this.IdloaiBDS = idloaiBDS;
            this.Diachi = diachi;
            this.Huong = huong;
            this.Rong = rong;
            this.Dai = dai;
            this.Dientichdat = dientichdat;
            this.Dientichsantruoc = dientichsantruoc;
            this.Dientichsansau = dientichsansau;
            this.Dongia = dongia;
            this.Tylechietkhau = tylechietkhau;
            this.TyleVAT = tyleVAT;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }

        public BatDongSanDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Idkhudat = row["idkhudat"].ToString();
            this.IdloaiBDS = row["idloaiBDS"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Huong = row["huong"].ToString();
            this.Rong = double.Parse(row["rong"].ToString());
            this.Dai = double.Parse(row["dai"].ToString());
            this.Dientichdat = double.Parse(row["dientichdat"].ToString());
            this.Dientichsantruoc = double.Parse(row["dientichsantruoc"].ToString());
            this.Dientichsansau = double.Parse(row["dientichsansau"].ToString());
            this.Dongia = double.Parse(row["dongia"].ToString());
            this.Tylechietkhau = double.Parse(row["tylechietkhau"].ToString());
            this.TyleVAT = double.Parse(row["tyleVAT"].ToString());
            this.Trangthai = row["trangthai"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
