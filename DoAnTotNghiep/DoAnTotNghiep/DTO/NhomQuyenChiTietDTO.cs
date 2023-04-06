using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class NhomQuyenChiTietDTO
    {
        private string id;
        private string idnhomquyen;
        private string idphanquyen;

        public string Id { get => id; set => id = value; }
        public string Idnhomquyen { get => idnhomquyen; set => idnhomquyen = value; }
        public string Idphanquyen { get => idphanquyen; set => idphanquyen = value; }

        public NhomQuyenChiTietDTO() { }

        public NhomQuyenChiTietDTO
        (
            string id,
            string idnhomquyen,
            string idphanquyen
        )
        {
            this.Id = id;
            this.Idnhomquyen = idnhomquyen;
            this.Idphanquyen = idphanquyen;
        }
    }
}
