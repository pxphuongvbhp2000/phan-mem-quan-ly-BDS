using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTotNghiep.DTO
{
    public class NhanVienDTO
    {
		private string id;
		private string matkhaudangnhap;
		private string hoten;
		private string gioitinh;
		private DateTime? ngaysinh;
		private string sothecancuoc;
		private string nguyenquan;
		private string diachithuongtru;
		private string sdt;
		private string email;
		private string nganhang;
		private string sotaikhoan;
		private string idchinhanh;
		private string idphongban;
		private string idchucvu;
		private string idnhomquyen;
		private string masothue;
		private string trangthai;
		private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Matkhaudangnhap { get => matkhaudangnhap; set => matkhaudangnhap = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sothecancuoc { get => sothecancuoc; set => sothecancuoc = value; }
        public string Nguyenquan { get => nguyenquan; set => nguyenquan = value; }
        public string Diachithuongtru { get => diachithuongtru; set => diachithuongtru = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Nganhang { get => nganhang; set => nganhang = value; }
        public string Sotaikhoan { get => sotaikhoan; set => sotaikhoan = value; }
        public string Idchinhanh { get => idchinhanh; set => idchinhanh = value; }
        public string Idphongban { get => idphongban; set => idphongban = value; }
        public string Idchucvu { get => idchucvu; set => idchucvu = value; }
        public string Idnhomquyen { get => idnhomquyen; set => idnhomquyen = value; }
        public string Masothue { get => masothue; set => masothue = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public NhanVienDTO() { }

        public NhanVienDTO
        (
            string id, 
            string matkhaudangnhap, 
            string hoten, 
            string gioitinh, 
            DateTime? ngaysinh, 
            string sothecancuoc,
            string nguyenquan,
            string diachithuongtru,
            string sdt,
            string email,
            string nganhang,
            string sotaikhoan,
            string idchinhanh,
            string idphongban,
            string idchucvu,
            string idnhomquyen,
            string masothue,
            string trangthai,
		    string ghichu
        )
        {
            this.Id = id;
            this.Matkhaudangnhap = matkhaudangnhap;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Sothecancuoc = sothecancuoc;
            this.Nguyenquan = nguyenquan;
            this.Diachithuongtru = diachithuongtru;
            this.Sdt = sdt;
            this.Email = email;
            this.Nganhang = nganhang;
            this.Sotaikhoan = sotaikhoan;
            this.Idchinhanh = idchinhanh;
            this.Idphongban = idphongban;
            this.Idchucvu = idchucvu;
            this.Idnhomquyen = idnhomquyen;
            this.Masothue = masothue;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
        }

        public NhanVienDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Matkhaudangnhap = row["matkhaudangnhap"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Ngaysinh = (DateTime?)row["ngaysinh"];
            this.Sothecancuoc = row["sothecancuoc"].ToString();
            this.Nguyenquan = row["nguyenquan"].ToString();
            this.Diachithuongtru = row["diachithuongtru"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString();
            this.Nganhang = row["nganhang"].ToString();
            this.Sotaikhoan = row["sotaikhoan"].ToString();
            this.Idchinhanh = row["idchinhanh"].ToString();
            this.Idphongban = row["idphongban"].ToString();
            this.Idchucvu = row["idchucvu"].ToString();
            this.Idnhomquyen = row["idnhomquyen"].ToString();
            this.Masothue = row["masothue"].ToString();
            this.Trangthai = row["trangthai"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
