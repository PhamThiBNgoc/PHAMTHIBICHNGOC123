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
    public class DAL_KhachHang:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getKH()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM KhachHang", con);

                dt = new DataTable();
                da.Fill(dt);


                con.Close();
                return dt;

            }
            catch (Exception )
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
            string sql = "Select count(*) from KhachHang where MaKH='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool themKH(DTO_KhachHang k)
        {

            string sql = "Insert into KhachHang values('" + k.MaKH + "',N'" + k.TenKH + "','" + k.SDT + "','" + k.DiaChi + "','" + k.Email + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaKH(DTO_KhachHang k)
        {

            string sql = "Update KhachHang set TenKH=N'" + k.TenKH + " ',SDT='" + k.SDT + "',DiaChi='" + k.DiaChi + "',Email='" + k.Email + "' where MaKH='" + k.MaKH + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaKH(string ma)
        {
            string sql = "Delete from KhachHang where MaKH='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
