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
    public class DAL_PhieuXuat : DBConnect
    {
        
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getData()
        {
            
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from PhieuXuat_", con);

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
            string sql = "Select count(*) from PhieuXuat_ where SoPhieuX='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool ThemHDB(PhieuXuat hd)
        {
            string sql = string.Format("Insert into PhieuXuat_ values('{0}','{1}', '{2}')", hd.SoPhieuX, hd.NgayXuat.ToString("yyyy/MM/dd"), hd.MaKH);
            thucthisql(sql);
            return true;
        }
        public bool SuaHDB(PhieuXuat hd)
        {
            string sql = string.Format("Update PhieuXuat_ Set MaKH = '{0}', NgayXuat = '{1}' Where SoPhieuX = '{2}'", hd.MaKH,  hd.NgayXuat.ToString("yyyy/MM/dd"), hd.SoPhieuX);
            thucthisql(sql);
            return true;
        }
        public bool XoaHDB(string ma)
        {
            string sql = "Delete from PhieuXuat_ where SoPhieuX = '" + ma.Trim() + "'";
            thucthisql(sql);
            return true;
        }
        //public DataTable TimKiem(string mahdb, string manv, string makh)
        //{
        //    string sql = "Select * from PhieuXuat_";
        //    string dk = "";
        //    if (mahdb.Trim() == "" && manv.Trim() == "" && makh.Trim() == "")
        //    {
        //        // 1
        //        return null;
        //    }
        //    if (mahdb.Trim() != "" && dk == "")
        //    {
        //        // 2
        //        dk += " MaHDB like '%" + mahdb.Trim() + "%' ";
        //    }
        //    if (manv.Trim() != "" && dk != "")
        //    {
        //        // 3
        //        dk += " and MaNV like '%" + manv.Trim() + "%' ";
        //    }
        //    if (manv.Trim() != "" && dk == "")
        //    {
        //        // 4
        //        dk += " MaNV like '%" + manv.Trim() + "%' ";
        //    }
        //    if (makh.Trim() != "" && dk != "")
        //    {
        //        // 5
        //        dk += " and MaKH like '%" + makh.Trim() + "%' ";
        //    }
        //    if (makh.Trim() != "" && dk == "")
        //    {
        //        dk += " MaKH like '%" + makh.Trim() + "%' ";
        //    }
        //    if (dk != "")
        //    {
        //        sql += " Where " + dk;
        //    }
        //    return connect.getData(sql);
        //}
    }
}

   
