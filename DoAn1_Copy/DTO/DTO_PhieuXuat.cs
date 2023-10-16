using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat
    {
        public string SoPhieuX { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayXuat { get; set; }

       
        public PhieuXuat()
        {

        }

        public PhieuXuat(string maPX,   DateTime ngayXuat, string tenKH)
        {
            SoPhieuX = maPX;
            MaKH = tenKH;
      
            NgayXuat = ngayXuat;
        }
    }
   
}
