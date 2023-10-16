using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


using System.Configuration;

namespace DAL
{
    public class DAL_Forgot:DBConnect
    {
        public bool CheckEmail(string Email)
        {

            con.Open();
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email=@Email";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Email", Email);
            int count = (int)command.ExecuteScalar();
            con.Close();
            return count > 0;

        }

        public string GetPassword(string Email)
        {

            con.Open();
            string sql = "SELECT MatKhau FROM NhanVien WHERE Email=@Email";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Email", Email);
            string password = (string)command.ExecuteScalar();
            con.Close();
            return password;


        }
    }
}
