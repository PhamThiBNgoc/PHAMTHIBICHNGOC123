using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CTPN
    {
        DAL_CTPN dal_ctpn = new DAL_CTPN();
        public DataTable getData(string ma)
        {
              return dal_ctpn.getData(ma); // Lấy dữ liệu từ DAL_CTPN
           
        }
        public int kiemtramatrung(string ma)
        {
            return dal_ctpn.kiemtramatrung(ma);
        }
        public bool ThemCTHDN(DTO_CTPN CTHDN)
        {
            return dal_ctpn.ThemCTN(CTHDN);
        }
        public bool SuaCTHDN(DTO_CTPN CTHDN)
        {
            return dal_ctpn.SuaCTN(CTHDN);
        }
        public bool XoaCTHDN(string ma)
        {
            return dal_ctpn.XoaCTN(ma);
        }
    }
}
