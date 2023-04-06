using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class LichThanhToanDTO
    {
        private string id;
        private string idhopdongmuaban;
        private DateTime ngaythu;
        private double sotien;
        private string trangthai;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Idhopdongmuaban { get => idhopdongmuaban; set => idhopdongmuaban = value; }
        public DateTime Ngaythu { get => ngaythu; set => ngaythu = value; }
        public double Sotien { get => sotien; set => sotien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public LichThanhToanDTO() { }

        public LichThanhToanDTO
        (
            string id,
            string idhopdongmuaban,
            DateTime ngaythu,
            double sotien,
            string trangthai,
            string ghichu
        )
        {
            this.Id = id;
            this.Idhopdongmuaban = idhopdongmuaban;
            this.Ngaythu = ngaythu;
            this.Sotien = sotien;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }
    }
}
