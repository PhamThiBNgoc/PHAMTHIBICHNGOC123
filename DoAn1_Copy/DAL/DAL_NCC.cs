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
    public class DAL_NCC:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị danh sách sản phẩm ra ngoài màn hình DTO->DAL->BUS->GUI
        public DataTable getNCC()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM NhaCC", con);

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
            string sql = "Select count(*) from NhaCC where MaNCC='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public bool themNCC(DTO_NCC ncc)
        {

            string sql = "Insert into NhaCC values('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "','" + ncc.DiaChi + "','" + ncc.SDT + "','" + ncc.Email + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNCC(DTO_NCC ncc)
        {

            string sql = "Update NhaCC set TenNCC=N'" + ncc.TenNCC + " ',SDT='" + ncc.DiaChi + "',DiaChi='" + ncc.SDT + "',Email='" + ncc.Email + "' where MaNCC='" + ncc.MaNCC + "'";

            thucthisql(sql);
 

       
            return true;
        }
        public bool xoaNCC(string ma)
        {
            string sql = "Delete from NhaCC where MaNCC='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable SearchEmployeesByName(string searchName)
        {
            // Tạo kết nối tới cơ sở dữ liệu
            // Mở kết nối
            con.Open();

            // Tạo câu truy vấn SQL
            string query = "SELECT * FROM NhaCC WHERE TenNCC LIKE @TenNCC";

            // Tạo đối tượng Command và thiết lập các thông số
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@TenNCC", "%" + searchName + "%");

            // Tạo đối tượng Adapter và DataTable để lưu trữ kết quả
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable searchResults = new DataTable();

            // Đổ dữ liệu từ Adapter vào DataTable
            adapter.Fill(searchResults);
            con.Close();
            // Trả về DataTable chứa kết quả tìm kiếm
            return searchResults;
            

        }
    }
}
