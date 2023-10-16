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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNV()
        {
            return dalnv.getNV();
        }

        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool themNV(DTO_NhanVien k)
        {
            return dalnv.themNV(k);
        }
        public bool suaNV(DTO_NhanVien k)
        {
            return dalnv.suaNV(k);
        }
        public bool xoaNV(string ma)
        {
            return dalnv.xoaNV(ma);
        }
    }
}
