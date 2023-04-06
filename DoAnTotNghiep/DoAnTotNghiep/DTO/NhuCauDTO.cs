using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class NhuCauDTO
    {
		private int id;
        private string idkhachhang;
		private string diachi;
		private string huong;
		private string rong;
		private string dai;
		private string dientichdat;
		private string dientichsantruoc;
		private string dientichsansau;
		private string dongia;
		private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Huong { get => huong; set => huong = value; }
        public string Rong { get => rong; set => rong = value; }
        public string Dai { get => dai; set => dai = value; }
        public string Dientichdat { get => dientichdat; set => dientichdat = value; }
        public string Dientichsantruoc { get => dientichsantruoc; set => dientichsantruoc = value; }
        public string Dientichsansau { get => dientichsansau; set => dientichsansau = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public NhuCauDTO() { }

        public NhuCauDTO
        (
            int id,
            string loainhucau,
            string idkhachhang,
            string diachi,
            string huong,
            string rong,
            string dai,
            string dientichdat,
            string dientichsantruoc,
            string dientichsansau,
            string dongia,
            string ghichu
        )
        {
            this.Id = id;
            this.Idkhachhang = idkhachhang;
            this.Diachi = diachi;
            this.Huong = huong;
            this.Rong = rong;
            this.Dai = dai;
            this.Dientichdat = dientichdat;
            this.Dientichsantruoc = dientichsantruoc;
            this.Dientichsansau = dientichsansau;
            this.Dongia = dongia;
            this.Ghichu = ghichu;
        }
    }
}
