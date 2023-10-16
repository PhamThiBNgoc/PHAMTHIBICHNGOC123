using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        public DTO_PhieuNhap(string soPhieuN, DateTime ngayNhap, string maNCC, string maNV)
        {
            SoPhieuN = soPhieuN;
            NgayNhap = ngayNhap;
            MaNCC = maNCC;
            MaNV = maNV;
        }

        public string SoPhieuN { get; set; }
        
        public DateTime NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public string MaNV { get; set; }

    }
}
