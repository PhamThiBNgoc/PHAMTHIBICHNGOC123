using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Role { get; set; }
        public DTO_DangNhap(string role)
        {

            Role = role;
        }

        public DTO_DangNhap() { }
    }
}
