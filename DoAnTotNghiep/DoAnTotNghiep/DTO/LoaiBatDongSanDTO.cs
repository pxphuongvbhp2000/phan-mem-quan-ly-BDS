using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class LoaiBatDongSanDTO
    {
        private string id;
        private string tenloaiBDS;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string TenloaiBDS { get => tenloaiBDS; set => tenloaiBDS = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }


        public LoaiBatDongSanDTO() { }

        public LoaiBatDongSanDTO
        (
            string id,
            string tenloaiBDS,
            string ghichu
        )
        {
            this.Id = id;
            this.TenloaiBDS = tenloaiBDS;
            this.Ghichu = ghichu;
        }
    }
}
