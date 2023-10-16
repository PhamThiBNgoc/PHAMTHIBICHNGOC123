using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_PhieuNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getData()
        {

            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from PhieuNhap", con);

                dt = new DataTable();
                da.Fill(dt);


                con.Close();
                return dt;

            }
            catch (Exception)
            {
                // handle the exception
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        void thucthisql(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int kiemtramatrung(string ma)
        {

            con.Open();
            int i;
            string sql = "Select count(*) from PhieuNhap where SoPhieuN='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool ThemPN(DTO_PhieuNhap hd)
        {
            string sql = string.Format("Insert into PhieuNhap values('{0}','{1}', '{2}','{3}')", hd.SoPhieuN, hd.NgayNhap.ToString("yyyy/MM/dd"), hd.MaNCC,hd.MaNV);
            thucthisql(sql);
            return true;
        }
        public bool SuaPN(DTO_PhieuNhap hd)
        {
            string sql = string.Format("Update PhieuNhap Set MaNCC = '{0}', NgayNhap = '{1}',MaNV='{2}' Where SoPhieuN = '{3}'", hd.MaNCC, hd.NgayNhap.ToString("yyyy/MM/dd"), hd.MaNV,hd.SoPhieuN);
            thucthisql(sql);
            return true;
        }
        public bool XoaPN(string ma)
        {
            string sql = "Delete from PhieuNhap where SoPhieuN = '" + ma.Trim() + "'";
            thucthisql(sql);
            return true;
        }
    }
}
