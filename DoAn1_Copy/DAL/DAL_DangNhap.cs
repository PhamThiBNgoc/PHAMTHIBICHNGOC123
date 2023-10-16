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
    public class DAL_DangNhap:DBConnect
    {
        public bool CheckLogin(string TaiKhoan, string MatKhau, out string role)
        {

            role = null;
            try
            {
                // Kết nối đến cơ sở dữ liệu

                // Mở kết nối
                con.Open();

                // Tạo câu truy vấn
                SqlCommand cmd = new SqlCommand("SELECT ChucVu FROM NhanVien WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau", con);
                cmd.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                // Thực thi câu truy vấn và đọc dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    role = reader.GetString(0);
                    return true;

                }
                

            }
            catch (Exception ) { throw; }
            finally { con.Close(); }
            return false;
        }
        public bool isadmin(string taikhoan, string matkhau)
        {
            string role;
            DAL_DangNhap daldn = new DAL_DangNhap();

            if (daldn.CheckLogin(taikhoan, matkhau, out role))
            {
                return role == "admin";
            }
            return false;
        }


    }
}
