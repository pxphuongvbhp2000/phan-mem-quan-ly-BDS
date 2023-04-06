using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class KhuDatDTO
    {
		private string id;
		private string idduan;
		private string tenkhu;
		private string vitri;
		private int soluonglo;
		private double dientich;
		private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Idduan { get => idduan; set => idduan = value; }
        public string Tenkhu { get => tenkhu; set => tenkhu = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public int Soluonglo { get => soluonglo; set => soluonglo = value; }
        public double Dientich { get => dientich; set => dientich = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public KhuDatDTO() { }

        public KhuDatDTO
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
            this.Id = id;
            this.Idduan = idduan;
            this.Tenkhu = tenkhu;
            this.Vitri = vitri;
            this.Soluonglo = soluonglo;
            this.Dientich = dientich;
            this.Ghichu = ghichu;
        }
    }
}
