using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class PhongBanDTO
    {
        private string id;
        private string tenphongban;
        private string vitri;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tenphongban { get => tenphongban; set => tenphongban = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhongBanDTO() { }

        public PhongBanDTO
        (
            string id,
            string tenphongban,
            string vitri,
            string ghichu
        )
        {
            this.Id = id;
            this.Tenphongban = tenphongban;
            this.Vitri = vitri;
            this.Ghichu = ghichu;
        }
    }
}
