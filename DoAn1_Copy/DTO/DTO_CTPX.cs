using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTPX
    {
        public DTO_CTPX(string soPhieuX, int sTT, string maSP, int sLXuat, int dGXuat)
        {
            SoPhieuX = soPhieuX;
            STT = sTT;
            MaSP = maSP;
            SLXuat = sLXuat;
            DGXuat = dGXuat;
        }
        public DTO_CTPX() { }

        public string SoPhieuX { get; set; }
        public int STT { get; set; }
        public string MaSP { get; set; }
        public int SLXuat { get; set; }
        public int DGXuat { get; set; }


    }
}
