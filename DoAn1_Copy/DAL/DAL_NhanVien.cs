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
    public class DAL_NhanVien:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getNV()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM NhanVien", con);

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
            string sql = "Select count(*) from NhanVien where MaNV='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool themNV(DTO_NhanVien k)
        {

            string sql = "Insert into NhanVien values('" + k.MaNV.Trim() + "',N'" + k.TenNV.Trim()+ "','" + k.DiaChi.Trim() + "','" + k.SDT.Trim()+ "','" + k.Email.Trim() + "','" + k.ChucVu.Trim() + "','"+k.TaiKhoa.Trim()+"','"+k.MatKhau.Trim()+"')";

            thucthisql(sql);
            return true;
        }
        public bool suaNV(DTO_NhanVien k)
        {

            string sql = "Update NhanVien set TenNV=N'" + k.TenNV.Trim() + " ',SDT='" + k.SDT.Trim() + "',DiaChi='" + k.DiaChi.Trim() + "',Email='" + k.Email.Trim() + "',ChucVu='" + k.ChucVu.Trim() + "',TaiKhoan='"+k.TaiKhoa.Trim()+"',MatKhau='"+k.MatKhau.Trim()+"' where MaNV='" + k.MaNV.Trim() + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNV(string ma)
        {
            string sql = "Delete from NhanVien where MaNV='" + ma.Trim() + "'";
            thucthisql(sql);
            return true;
        }
    }
}
