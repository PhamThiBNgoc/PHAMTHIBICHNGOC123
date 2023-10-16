using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string TaiKhoa { get; set; }
        public string MatKhau { get; set; }

        public DTO_NhanVien()
        {

        }
     
        public DTO_NhanVien(string maNV, string tenNV, string diaChi, string sDT, string email, string chucVu, string taiKhoa, string matKhau)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
            ChucVu = chucVu;
            TaiKhoa = taiKhoa;
            MatKhau = matKhau;
        }
    }
}
