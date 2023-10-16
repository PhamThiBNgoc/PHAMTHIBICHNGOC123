using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;



namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap daldn = new DAL_DangNhap();


        public bool Login(string TaiKhoan, string MatKhau, out string role)
        {
            bool result = false;
            role = "";

            if (daldn.CheckLogin(TaiKhoan, MatKhau, out role))
            {
                result = true;
            }

            return result;
        }


    }
}
