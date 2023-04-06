using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class ChucVuDTO
    {
        private string id;
        private string tenchucvu;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tenchucvu { get => tenchucvu; set => tenchucvu = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public ChucVuDTO() { }

        public ChucVuDTO
        (
            string id,
            string tenchucvu,
            string ghichu
        )
        {
            this.Id = id;
            this.Tenchucvu = tenchucvu;
            this.Ghichu = ghichu;
        }
    }
}
