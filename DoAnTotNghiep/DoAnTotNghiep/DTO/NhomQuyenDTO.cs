using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class NhomQuyenDTO
    {
        private string id;
        private string tennhomquyen;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tennhomquyen { get => tennhomquyen; set => tennhomquyen = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public NhomQuyenDTO() { }

        public NhomQuyenDTO
        (
            string id,
            string tennhomquyen,
            string ghichu
        )
        {
            this.Id = id;
            this.Tennhomquyen = tennhomquyen;
            this.Ghichu = ghichu;
        }

        public NhomQuyenDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Tennhomquyen = row["tennhomquyen"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
