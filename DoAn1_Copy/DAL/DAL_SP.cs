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
    public class DAL_SP:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị danh sách sản phẩm ra ngoài màn hình DTO->DAL->BUS->GUI
        public DataTable getSanPham()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * from SanPham", con);

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
        public DataTable getDVT()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * from DVT", con);

                dt = new DataTable();
                da.Fill(dt);


                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable getNhaCC()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * from NhaCC", con);

                dt = new DataTable();
                da.Fill(dt);


                con.Close();
                return dt;
            }
            catch
            {
                return null;
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
            string sql = "Select count(*) from SanPham where MaSP='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool themSP(DTO_SanPham sp)
        {

            string sql = "Insert into SanPham values('" + sp.MaSP + "',N'" + sp.TenSP + "','" + sp.MaDVT + "','" + sp.MaNCC + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaSP(DTO_SanPham sp)
        {

            string sql = "Update SanPham set TenSP=N'" + sp.TenSP + " ',MaNCC='" + sp.MaNCC + "',MaDVT='" + sp.MaDVT + "' where MaSP='" + sp.MaSP + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaSP(string ma)
        {
            string sql = "Delete from SanPham where MaSP='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable SearchEmployeesByName(string searchName)
        {
            // Tạo kết nối tới cơ sở dữ liệu
            // Mở kết nối
                con.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";

                // Tạo đối tượng Command và thiết lập các thông số
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@TenSP", "%" + searchName + "%");

                // Tạo đối tượng Adapter và DataTable để lưu trữ kết quả
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable searchResults = new DataTable();

                // Đổ dữ liệu từ Adapter vào DataTable
                adapter.Fill(searchResults);

                // Trả về DataTable chứa kết quả tìm kiếm
                return searchResults;
            
        }
    }
}
