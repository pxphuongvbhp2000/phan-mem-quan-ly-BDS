using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class ChuDauTuDTO
    {
		private string id;
		private string tencongty;
		private string diachi;
		private string sdt;
		private string email;
		private string website;
		private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tencongty { get => tencongty; set => tencongty = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Website { get => website; set => website = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public ChuDauTuDTO() { }

        public ChuDauTuDTO
        (
            string id,
            string tencongty,
            string diachi,
            string sdt,
            string email,
            string website,
            string ghichu
        )
        {
            this.Id = id;
            this.Tencongty = tencongty;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Email = email;
            this.Website = website;
            this.Ghichu = ghichu;
        }
    }
}
