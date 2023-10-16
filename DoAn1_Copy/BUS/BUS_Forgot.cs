using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BUS
{
    public class BUS_Forgot
    {
        DAL_Forgot dal_forgot = new DAL_Forgot();
        public bool CheckEmail(string Email)
        {
            return dal_forgot.CheckEmail(Email);
        }
        public string GetPassword(string Email)
        {
            return dal_forgot.GetPassword(Email);
        }
    }
}
