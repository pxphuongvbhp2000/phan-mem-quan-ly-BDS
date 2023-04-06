using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class ChiNhanhDTO
    {
        private string id;
        private string tenchinhanh;
	    private string diachi;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tenchinhanh { get => tenchinhanh; set => tenchinhanh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public ChiNhanhDTO() { }

        public ChiNhanhDTO
        (
            string id,
            string tenchinhanh,
            string diachi,
            string ghichu
        )
        {
            this.Id = id;
            this.Tenchinhanh = tenchinhanh;
            this.Diachi = diachi;
            this.Ghichu = ghichu;
        }
    }
}
