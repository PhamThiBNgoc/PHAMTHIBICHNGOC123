using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaDVT { get; set; }
        public string MaNCC { get; set; }

        public DTO_SanPham()
        {

        }
        public DTO_SanPham(string ma, string ten, string maDVT, string maNCC)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.MaDVT = maDVT;
            this.MaNCC = maNCC;
        }
    }
}
