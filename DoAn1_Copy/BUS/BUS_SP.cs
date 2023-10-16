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
    public class BUS_SP
    {
        DAL_SP dalsp = new DAL_SP();
        public DataTable getSanPham()
        {
            return dalsp.getSanPham();
        }
        public DataTable getNhaCC()
        {
            return dalsp.getNhaCC();
        }
        public DataTable getDVT()
        {
            return dalsp.getDVT();
        }
        public int kiemtramatrung(string ma)
        {
            return dalsp.kiemtramatrung(ma);
        }
        public bool themSP(DTO_SanPham sp)
        {
            return dalsp.themSP(sp);
        }
        public bool suaSP(DTO_SanPham sp)
        {
            return dalsp.suaSP(sp);
        }
        public bool xoaSP(string ma)
        {
            return dalsp.xoaSP(ma);
        }
        public DataTable SearchEmployeesByName(string searchName)
        {
            return dalsp.SearchEmployeesByName(searchName);
        }
    }
}
