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
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap dalpn = new DAL_PhieuNhap();
        public DataTable getData()
        {
            return dalpn.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return dalpn.kiemtramatrung(ma);
        }
        public bool ThemPN(DTO_PhieuNhap phieuNhap)
        {
            return dalpn.ThemPN(phieuNhap);
        }
        public bool SuaPN(DTO_PhieuNhap phieuNhap)
        {
            return dalpn.SuaPN(phieuNhap);
        }
        public bool XoaPN(string ma)
        {
            return dalpn.XoaPN(ma);
        }
    }
}
