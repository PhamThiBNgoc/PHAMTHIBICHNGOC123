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
    public class DAL_DVT:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị danh sách sản phẩm ra ngoài màn hình DTO->DAL->BUS->GUI
        public DataTable getDVT()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM DVT", con);

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
            string sql = "Select count(*) from DVT where MaDVT='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool themDVT(DTO_DVT dvt)
        {

            string sql = "Insert into DVT values('" + dvt.MaDVT + "',N'" + dvt.TenDVT + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaDVT(DTO_DVT dvt)
        {

            string sql = "Update DVT set TenDVT=N'" + dvt.TenDVT + " ' where MaDVT='" + dvt.MaDVT + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaDVT(string ma)
        {
            string sql = "Delete from DVT where MaDVT='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
