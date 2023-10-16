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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkh = new DAL_KhachHang();
        public DataTable getKH()
        {
            return dalkh.getKH();
        }

        public int kiemtramatrung(string ma)
        {
            return dalkh.kiemtramatrung(ma);
        }
        public bool themKH(DTO_KhachHang k)
        {
            return dalkh.themKH(k);
        }
        public bool suaKH(DTO_KhachHang k)
        {
            return dalkh.suaKH(k);
        }
        public bool xoaKH(string ma)
        {
            return dalkh.xoaKH(ma);
        }
    }
}
