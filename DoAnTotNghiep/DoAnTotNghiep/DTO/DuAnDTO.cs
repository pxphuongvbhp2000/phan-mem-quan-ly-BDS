using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class DuAnDTO
    {
		private string id;
        private string idchudautu;
        private string tenduan;
		private string vitri;
		private double dientich;
		private string sogiayphep;
		private string noicap;
		private DateTime ngaycap;
		private string idnhanvienphutrach;
		private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Idchudautu { get => idchudautu; set => idchudautu = value; }
        public string Tenduan { get => tenduan; set => tenduan = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public double Dientich { get => dientich; set => dientich = value; }
        public string Sogiayphep { get => sogiayphep; set => sogiayphep = value; }
        public string Noicap { get => noicap; set => noicap = value; }
        public DateTime Ngaycap { get => ngaycap; set => ngaycap = value; }
        public string Idnhanvienphutrach { get => idnhanvienphutrach; set => idnhanvienphutrach = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public DuAnDTO() { }

        public DuAnDTO
        (
            string id,
            string idchudautu,
            string tenduan,
            string vitri,
            double dientich,
            string sogiayphep,
            string noicap,
            DateTime ngaycap,
            string idnhanvienphutrach,
            string ghichu
        )
        {
            this.Id = id;
            this.Idchudautu = idchudautu;
            this.Tenduan = tenduan;
            this.Vitri = vitri;
            this.Dientich = dientich;
            this.Sogiayphep = sogiayphep;
            this.Noicap = noicap;
            this.Ngaycap = ngaycap;
            this.Idnhanvienphutrach = idnhanvienphutrach;
            this.Ghichu = ghichu;
        }
    }
}
