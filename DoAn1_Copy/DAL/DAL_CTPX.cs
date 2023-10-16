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
    public class DAL_CTPX : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getData(string ma)
        {

            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from _CTPhieuXuat  where SoPhieuX='"+ma.Trim()+"'", con);

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
            string sql = "Select count(*) from _CTPhieuXuat where STT='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool ThemCTHDB(DTO_CTPX hd)
        {
            string sql = string.Format("Insert into _CTPhieuXuat values('{0}','{1}', '{2}', '{3}','{4}')", hd.SoPhieuX, hd.STT, hd.MaSP, hd.SLXuat, hd.DGXuat);
            thucthisql(sql);
            return true;
        }
        public bool SuaCTHDB(DTO_CTPX hd)
        {
            string sql = string.Format("Update _CTPhieuXuat Set  MaSP = '{0}', SLXuat = '{1}' , DGXuat = '{2}' Where SoPhieuX='{3}' and STT = '{4}'",   hd.MaSP, hd.SLXuat, hd.DGXuat,hd.SoPhieuX, hd.STT);
            thucthisql(sql);
            return true;
        }
        public bool XoaCTHDB(string ma)
        {
            string sql = "Delete from _CTPhieuXuat where STT='" + ma+ "' ";
            thucthisql(sql);
            return true;
        }
        public double ThongKeDoanhThu(string sql)
        {
            con.Open();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public DataTable getDataTK(string sql)
        {
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public double ThongKeDoanhThuTheoThang(string thang, string nam)
        {
            string sql = "SELECT SUM(_CTPhieuXuat.DGXuat * _CTPhieuXuat.SLXuat) FROM _CTPhieuXuat INNER JOIN PhieuXuat_ ON _CTPhieuXuat.SoPhieuX = PhieuXuat_.SoPhieuX WHERE MONTH(NgayXuat) =" + thang.Trim() + " AND YEAR(NgayXuat) = " + nam.Trim() + "";
          
            return ThongKeDoanhThu(sql);
        }

        public DataTable ThongKeHoaDonTheoThang(string thang, string nam)
        {
            string sql = string.Format("Select H.SoPhieuX, H.MaKH, h.NgayXuat, C.MaSP, C.DGXuat, C.SLXuat from PhieuXuat_ H inner join _CTPhieuXuat C on H.SoPhieuX = C.SoPhieuX Where Month(NgayXuat) = " + thang.Trim() + " and Year(NgayXuat) = " + nam.Trim() + "");
            return getDataTK(sql);
        }
        public DataTable ThongKeHoaDonTheoNam(string nam)
        {
            string sql = string.Format("Select H.SoPhieuX, H.MaKH, h.NgayXuat, C.MaSP, C.DGXuat, C.SLXuat from PhieuXuat_ H inner join _CTPhieuXuat C on H.SoPhieuX = C.SoPhieuX WhereYear(NgayXuat) = " + nam.Trim() + "");
            return getDataTK(sql);
        }
        public double ThongKeDoanhThuTheoNam(string nam)
        {
            string sql = "SELECT SUM(_CTPhieuXuat.DGXuat * _CTPhieuXuat.SLXuat) FROM _CTPhieuXuat INNER JOIN PhieuXuat_ ON _CTPhieuXuat.SoPhieuX = PhieuXuat_.SoPhieuX WHERE YEAR(NgayXuat) = " + nam.Trim() + "";
            return ThongKeDoanhThu(sql);
        }
    }
}
