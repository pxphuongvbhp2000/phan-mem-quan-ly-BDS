using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    internal class PhanQuyenDTO
    {
        private string id;
        private string tenphanquyen;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tenphanquyen { get => tenphanquyen; set => tenphanquyen = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhanQuyenDTO() { }

        public PhanQuyenDTO
        (
            string id,
            string tenphanquyen,
            string ghichu
        )
        {
            this.Id = id;
            this.Tenphanquyen = tenphanquyen;
            this.Ghichu = ghichu;
        }
    }
}
