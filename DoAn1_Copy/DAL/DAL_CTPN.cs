using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_CTPN:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getData(string ma)
        {

            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from CTPhieuNhap  where SoPhieuN='" + ma.Trim() + "'", con);

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
            string sql = "Select count(*) from CTPhieuNhap where STT='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool ThemCTN(DTO_CTPN hd)
        {
            string sql = string.Format("Insert into CTPhieuNhap values('{0}','{1}', '{2}', '{3}','{4}')", hd.SoPhieuN, hd.STT, hd.MaSP, hd.SLNhap, hd.DGNhap);
            thucthisql(sql);
            return true;
        }
        public bool SuaCTN(DTO_CTPN hd)
        {
            string sql = string.Format("Update CTPhieuNhap Set  MaSP = '{0}', SLNhap = '{1}' , DGNhap = '{2}' Where SoPhieuN='{3}' and STT = '{4}'", hd.MaSP, hd.SLNhap, hd.DGNhap, hd.SoPhieuN, hd.STT);
            thucthisql(sql);
            return true;
        }
        public bool XoaCTN(string ma)
        {
            string sql = "Delete from CTPhieuNhap where STT='" + ma + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
