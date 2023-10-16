using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NCC
    {
            public string MaNCC { get; set; }
            public string TenNCC { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public string Email { get; set; }

            public DTO_NCC()
            {

            }
            public DTO_NCC(string ma, string ten, string dc, string sdt,string email)
            {
                this.MaNCC = ma;
                this.TenNCC = ten;
                this.DiaChi = dc;
                this.SDT = sdt;
                this.Email = email;
            }
    }
}
