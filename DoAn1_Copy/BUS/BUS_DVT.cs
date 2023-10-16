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
    public class BUS_DVT
    {
        DAL_DVT daldvt = new DAL_DVT();
        public DataTable getDVT()
        {
            return daldvt.getDVT();
        }

        public int kiemtramatrung(string ma)
        {
            return daldvt.kiemtramatrung(ma);
        }
        public bool themDVT(DTO_DVT dvt)
        {
            return daldvt.themDVT(dvt);
        }
        public bool suaDVT(DTO_DVT dvt)
        {
            return daldvt.suaDVT(dvt);
        }
        public bool xoaDVT(string ma)
        {
            return daldvt.xoaDVT(ma);
        }
    }
}
