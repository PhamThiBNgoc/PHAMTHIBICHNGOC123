using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DVT
    {
        public string MaDVT { get; set; }
        public string TenDVT { get; set; }
        public DTO_DVT() { }
        public DTO_DVT(string maDVT, string tenDVT)
        {
            MaDVT = maDVT;
            TenDVT = tenDVT;
        }
    }
}
