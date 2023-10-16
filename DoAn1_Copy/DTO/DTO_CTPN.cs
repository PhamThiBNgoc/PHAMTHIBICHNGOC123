using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTPN
    {
        public DTO_CTPN(string soPhieuN, int sTT, string maSP, int sLNhap, int dGNhap)
        {
            SoPhieuN = soPhieuN;
            STT = sTT;
            MaSP = maSP;
            SLNhap = sLNhap;
            DGNhap = dGNhap;
        }
        public DTO_CTPN() { }

        public string SoPhieuN { get; set; }
        public int STT { get; set; }
        public string MaSP { get; set; }
        public int SLNhap { get; set; }
        public int DGNhap { get; set; }
    }
}
