using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class KhachHangDTO
    {
		private string id;
		private string hoten;
		private string gioitinh;
		private DateTime? ngaysinh;
		private string sothecancuoc;
		private string nguyenquan;
		private string diachithuongtru;
		private string sdt;
		private string email;
		private string masothue;
        private string idnhanvienphutrach;
        private string ghichu;
        private byte[] anhcancuoc;
        private byte[] anhhokhau;
        private byte[] anhkethon;

        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sothecancuoc { get => sothecancuoc; set => sothecancuoc = value; }
        public string Nguyenquan { get => nguyenquan; set => nguyenquan = value; }
        public string Diachithuongtru { get => diachithuongtru; set => diachithuongtru = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Masothue { get => masothue; set => masothue = value; }
        public string Idnhanvienphutrach { get => idnhanvienphutrach; set => idnhanvienphutrach = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public byte[] Anhcancuoc { get => anhcancuoc; set => anhcancuoc = value; }
        public byte[] Anhhokhau { get => anhhokhau; set => anhhokhau = value; }
        public byte[] Anhkethon { get => anhkethon; set => anhkethon = value; }

        public KhachHangDTO() { }

        public KhachHangDTO
        (
            string id,
            string hoten,
            string gioitinh,
            DateTime? ngaysinh,
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string masothue,
            string idnhanvienphutrach,
            string ghichu,
            byte[] anhcancuoc,
            byte[] anhhokhau,
            byte[] anhkethon
        )
        {
            this.Id = id;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Sothecancuoc = sothecancuoc;
            this.Nguyenquan = nguyenquan;
            this.Diachithuongtru = diachithuongtru;
            this.Sdt = sdt;
            this.Email = email;
            this.Masothue = masothue;
            this.Idnhanvienphutrach = idnhanvienphutrach;
            this.Ghichu = ghichu;
            this.Anhcancuoc = anhcancuoc;
            this.Anhhokhau = anhhokhau;
            this.Anhkethon = anhkethon;
        }

        public KhachHangDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Ngaysinh = (DateTime?)row["ngaysinh"];
            this.Sothecancuoc = row["sothecancuoc"].ToString();
            this.Nguyenquan = row["nguyenquan"].ToString();
            this.Diachithuongtru = row["diachithuongtru"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString();
            this.Masothue = row["masothue"].ToString();
            this.Idnhanvienphutrach = row["idnhanvienphutrach"].ToString();
            this.Ghichu = row["ghichu"].ToString();        }
    }
}
