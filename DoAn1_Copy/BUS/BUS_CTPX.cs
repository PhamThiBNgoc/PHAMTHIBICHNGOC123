using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;




namespace BUS
{
    public class BUS_CTPX
    {
        DAL_CTPX dal_ctpx = new DAL_CTPX();
        public DataTable getData(string ma)
        {
            return dal_ctpx.getData(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dal_ctpx.kiemtramatrung(ma);
        }
        public bool ThemCTHDB(DTO_CTPX CTHDB)
        {
            return dal_ctpx.ThemCTHDB(CTHDB);
        }
        public bool SuaCTHDB(DTO_CTPX CTHDB)
        {
            return dal_ctpx.SuaCTHDB(CTHDB);
        }
        public bool XoaCTHDB(string ma)
        {
            return dal_ctpx.XoaCTHDB(ma);
        }
        //public DataTable TimKiem(string mahd, string masp)
        //{
        //    return dal_ctpx.TimKiem(mahd, masp);
        //}
        public double ThongKeDoanhThuTheoThang(string thang, string nam)
        {
            return dal_ctpx.ThongKeDoanhThuTheoThang(thang, nam);
        }
        public double ThongKeDoanhThuTheoNam(string nam)
        {
            return dal_ctpx.ThongKeDoanhThuTheoNam(nam);
        }
        public DataTable ThongKeHoaDonTheoThang(string thang, string nam)
        {
            return dal_ctpx.ThongKeHoaDonTheoThang(thang, nam);
        }
        public DataTable ThongKeHoaDonTheoNam(string nam)
        {
            return dal_ctpx.ThongKeHoaDonTheoNam(nam);
        }
        //public void ExportPhieuXuatToExcel(string ma, string filePath)
        //{
        //    DataTable phieuXuatData = dal_ctpx.getData(ma);

        //    using (ExcelPackage excelPackage = new ExcelPackage())
        //    {
        //        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("PhieuXuat");

        //        worksheet.Cells["A1"].Value = "Danh sách phiếu xuất";
        //        worksheet.Cells["A1"].Style.Font.Bold = true;
        //        worksheet.Cells["A1"].Style.Font.Size = 12;
        //        worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

        //        // Ghi dữ liệu vào file Excel
        //        for (int i = 0; i < phieuXuatData.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < phieuXuatData.Columns.Count; j++)
        //            {
        //                worksheet.Cells[i + 1, j + 1].Value = phieuXuatData.Rows[i][j];
        //            }
        //        }

        //        // Lưu file Excel
        //        FileInfo excelFile = new FileInfo(filePath);
        //        excelPackage.SaveAs(excelFile);
        //    }
        //}
        
        
    }
}
