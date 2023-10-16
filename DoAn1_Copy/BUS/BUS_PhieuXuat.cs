using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Core.ExcelPackage;
using System.IO;
using OfficeOpenXml;

namespace BUS
{
    public class BUS_PhieuXuat
    {


        // Thêm định nghĩa biến dtPX

        DAL_PhieuXuat dalpx = new DAL_PhieuXuat();


        public DataTable getData()
        {
            return dalpx.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return dalpx.kiemtramatrung(ma);
        }
        public bool ThemHD(PhieuXuat hd)
        {
            return dalpx.ThemHDB(hd);
        }
        public bool SuaHD(PhieuXuat hd)
        {
            return dalpx.SuaHDB(hd);
        }
        public bool XoaHD(string ma)
        {
            return dalpx.XoaHDB(ma);
        }
        //public DataTable TimKiem(string mahdb, string manv, string makh)
        //{
        //    return dalpx.TimKiem(mahdb, manv, makh);
        //}
        //public void Inhoadon(string ma)
        //{
        //    //Khởi động excel
        //    COMExcel.Application exApp = new COMExcel.Application();
        //    COMExcel.Workbook exBook;
        //    COMExcel.Worksheet exSheet;
        //    COMExcel.Range exRange;
        //    string sql;
        //    int hang = 0, cot = 0;
        //    DataTable tblThongtinHD, tblThongtinHang;
        //    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
        //    exSheet = exBook.Worksheets[1];
        //    DataTable tblThongtinHD, tblThongtinHang;
        //    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
        //    exSheet = exBook.Worksheets[1];



        //}
       
    }
}

