using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }

        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string ma, string ten, string dc, int sdt, string email)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.Email = email;
        }
    }
}
