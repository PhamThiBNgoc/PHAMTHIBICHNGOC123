using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

using OfficeOpenXml.Style;
using BUS;
using DTO;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Core.ExcelPackage;



namespace DoAn1_Copy
{
    public partial class frmPhieuXuat : Form
    {
        BUS_PhieuXuat buspx = new BUS_PhieuXuat();
        BUS_CTPX busctpx = new BUS_CTPX();

        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_SP bus_sp = new BUS_SP();
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        void loaddgvCTPX(string ma)
        {
            dgvCTPX.DataSource = busctpx.getData(ma);
            dgvCTPX.Columns[0].HeaderText = "Mã hoá đơn";
            dgvCTPX.Columns[1].HeaderText = "STT";
            dgvCTPX.Columns[2].HeaderText = "Mã Sản Phẩm";
            dgvCTPX.Columns[3].HeaderText = "Số Lượng ";
            dgvCTPX.Columns[4].HeaderText = "Đơn Giá";
        }

        void loadcbbKH()
        {
            cboKH.DataSource = bus_kh.getKH();
            cboKH.DisplayMember = "TenKH";
            cboKH.ValueMember = "MaKH";
        }
        void loadcbbSP()
        {
            cboSP.DataSource = bus_sp.getSanPham();
            cboSP.DisplayMember = "TenSP";
            cboSP.ValueMember = "MaSP";
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            //dgvPX.DataSource = buspx.getData();
            //dgvPX.Columns[0].HeaderText = "Mã hoá đơn";
            //dgvPX.Columns[2].HeaderText = "Ngày bán";
            //dgvPX.Columns[3].HeaderText = "Mã khách hàng";
           
            loadcbbKH();
            loadcbbSP();
            System.Data.DataTable  dt = new System.Data.DataTable();
            dt = buspx.getData();
            dgvPX.DataSource = dt;
            bingding();
            TinhTongTien();
            dgvCTPX.SelectionChanged += dgvCTPX_SelectionChanged;






        }



        private void bingding()
        {
            txtSoPhieuX.DataBindings.Clear();
            txtSoPhieuX.DataBindings.Add("text", dgvPX.DataSource, "SoPhieuX");
            dateTimePickerNgayX.DataBindings.Clear();
            dateTimePickerNgayX.DataBindings.Add("text", dgvPX.DataSource, "NgayXuat");
            cboKH.DataBindings.Clear();
            cboKH.DataBindings.Add("text", dgvPX.DataSource, "MaKH");

        }
        private void bingding1()
        {

            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("text", dgvCTPX.DataSource, "STT");
            cboSP.DataBindings.Clear();
            cboSP.DataBindings.Add("text", dgvCTPX.DataSource, "MaSP");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("text", dgvCTPX.DataSource, "SLXuat");
            txtDG.DataBindings.Clear();
            txtDG.DataBindings.Add("text", dgvCTPX.DataSource, "DGXuat");

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoPhieuX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable  dt = new System.Data.DataTable();
                dt = busctpx.getData(txtSoPhieuX.Text.Trim());
                dgvCTPX.DataSource = dt;
                bingding1();
            }
            catch
            {
                dgvCTPX.DataSource = null;
            }

        }

        private void dgvCTPX_DataSourceChanged(object sender, EventArgs e)
        {
            bingding1();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string SoPhieuX = txtSoPhieuX.Text;
            DateTime NgayXuat = DateTime.Parse(dateTimePickerNgayX.Value.ToShortDateString());

            string MaKH = cboKH.Text;
            if (string.IsNullOrEmpty(SoPhieuX))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu xuất .");
                return;
            }
            PhieuXuat k = new PhieuXuat(SoPhieuX, NgayXuat, MaKH);
            if (buspx.kiemtramatrung(SoPhieuX) == 1)
            {
                MessageBox.Show("Mã phiếu xuất  đã tồn tại.");
            }
            else
            {
                if (buspx.ThemHD(k))
                {
                    MessageBox.Show("Thêm thông tin phiếu xuất  thành công.");
                    dgvPX.DataSource = buspx.getData();
                }
                else
                {
                    MessageBox.Show("Thêm thông phiếu xuất  không thành công.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string SoPhieuX = txtSoPhieuX.Text;
            DateTime NgayXuat = DateTime.Parse(dateTimePickerNgayX.Value.ToShortDateString());

            string MaKH = cboKH.Text;
            PhieuXuat k = new PhieuXuat(SoPhieuX, NgayXuat, MaKH);

            if (buspx.SuaHD(k) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvPX.DataSource = buspx.getData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtSoPhieuX.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buspx.XoaHD(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvPX.DataSource = buspx.getData();
                }
            }
        }

        private void btnCTThem_Click(object sender, EventArgs e)
        {

            string SoPhieuX = txtSoPhieuX.Text;
            int STT = int.Parse(txtSTT.Text);
            string maSP = cboSP.Text;
            int SLXuat = int.Parse(txtSL.Text);
            int DGXuat = int.Parse(txtDG.Text);
            if (string.IsNullOrEmpty(SoPhieuX))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu xuất .");
                return;
            }
            DTO_CTPX k = new DTO_CTPX(SoPhieuX, STT, maSP, SLXuat, DGXuat);
            if (busctpx.kiemtramatrung(STT.ToString()) == 1)
            {
                MessageBox.Show("Mã phiếu xuất hoặc stt đã tồn tại.");
            }
            else
            {
                if (busctpx.ThemCTHDB(k))
                {
                    MessageBox.Show("Thêm thông tin chi tiết thành công.");
                    dgvCTPX.DataSource = busctpx.getData(SoPhieuX);
                }
                else
                {
                    MessageBox.Show("Thêm thông tin chi tiết không thành công.");
                }
            }
        }

        private void btnCTSua_Click(object sender, EventArgs e)
        {
            string SoPhieuX = txtSoPhieuX.Text;
            int STT = int.Parse(txtSTT.Text);
            string maSP = cboSP.Text;
            int SLXuat = int.Parse(txtSL.Text);
            int DGXuat = int.Parse(txtDG.Text);
            DTO_CTPX k = new DTO_CTPX(SoPhieuX, STT, maSP, SLXuat, DGXuat);

            if (busctpx.SuaCTHDB(k) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvCTPX.DataSource = busctpx.getData(SoPhieuX);
            }
        }

        private void btnCTXoa_Click(object sender, EventArgs e)
        {

            int STT = int.Parse(txtSTT.Text);
            string SoPhieuX = txtSoPhieuX.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                DTO_CTPX k = new DTO_CTPX();
                if (busctpx.XoaCTHDB(STT.ToString()))
                {
                    MessageBox.Show("Xoá thành công");
                    dgvCTPX.DataSource = busctpx.getData(txtSoPhieuX.Text);
                }
            }

        }

        private void dgvCTPX_SelectionChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCTPX.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell cellSLXuat = row.Cells["SLXuat"];
                    DataGridViewCell cellDGXuat = row.Cells["DGXuat"];

                    if (cellSLXuat.Value != null && cellDGXuat.Value != null)
                    {
                        int sl = Convert.ToInt32(cellSLXuat.Value);
                        int dg = Convert.ToInt32(cellDGXuat.Value);
                        decimal amount = sl * dg;
                        totalAmount += amount;
                    }
                }
            }

            txtTongTien.Text = totalAmount.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string SoPhieuX = txtSoPhieuX.Text;
            string MaSP = cboSP.Text;
            int SLXuat = Convert.ToInt32(txtSL.Text);
            int DGXuat = Convert.ToInt32(txtDG.Text);
            int STT  = int.Parse(txtSTT.Text);

            // Tạo DataTable để chứa dữ liệu báo cáo
            System.Data.DataTable reportData = new System.Data.DataTable();
            reportData.Columns.Add("SoPhieux", typeof(string));
            reportData.Columns.Add("STT", typeof(int));
            reportData.Columns.Add("MaSP", typeof(string));
            reportData.Columns.Add("SLXuat", typeof(int));
            reportData.Columns.Add("DGXuat", typeof(int));
            

            // Thêm dữ liệu từ phiếu xuất vào DataTable
            DataRow row = reportData.NewRow();
            row["SoPhieuX"] = SoPhieuX;
            row["STT"] = STT;
            row["MaSP"] = MaSP;
            row["SLXuat"] = SLXuat;
            row["DGXuat"] = DGXuat;
            reportData.Rows.Add(row);

            // Tạo tệp Excel
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
            {
                OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");

                // Đặt tiêu đề cho các cột
                for (int i = 0; i < reportData.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = reportData.Columns[i].ColumnName;
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // Điền dữ liệu từ DataTable vào tệp Excel
                for (int i = 0; i < reportData.Rows.Count; i++)
                {
                    for (int j = 0; j < reportData.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = reportData.Rows[i][j];
                    }
                }

                // Tùy chỉnh định dạng cho các cột
                worksheet.Cells[1, 1, reportData.Rows.Count + 1, reportData.Columns.Count].AutoFitColumns();
                worksheet.Cells[1, 1, 1, reportData.Columns.Count].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[1, 1, 1, reportData.Columns.Count].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                // Lưu tệp Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    
                    excelPackage.SaveAs(excelFile);
                    MessageBox.Show("Báo cáo đã được xuất thành công!");
                }
            }
        }

       
        //private void ExportToExcel(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        // Hiển thị hộp thoại lưu tệp
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.Filter = "Excel Files|*.xlsx";
        //        saveFileDialog.Title = "C:\\Users\\ADMIN\\Documents\\Zalo Received Files";
        //        saveFileDialog.FileName = "Do_An1.xlsx";
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string filePath = saveFileDialog.FileName;
        //            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        //            // Tạo một đối tượng ExcelPackage mới
        //            using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
        //            {
        //                // Tạo một Sheet mới trong tệp Excel
        //                OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
        //                // Thiết lập tiêu đề cho các cột
        //                worksheet.Cells[1, 1].Value = "SoPhieuX";
        //                worksheet.Cells[1, 2].Value = "STT";
        //                worksheet.Cells[1, 3].Value = "MaSP";
        //                worksheet.Cells[1, 4].Value = "Đơn giá";
        //                worksheet.Cells[1, 5].Value = "Số lượng";

        //                // Thiết lập định dạng và auto-fit cho các cột
        //                for (int i = 1; i <= 4; i++)
        //                {
        //                    worksheet.Column(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                    worksheet.Column(i).AutoFit();
        //                }

        //                // Đổ dữ liệu từ DataGridView vào Sheet Excel
        //                if (dataGridView.Rows.Count > 0)
        //                {
        //                    for (int i = 0; i < dataGridView.Rows.Count; i++)
        //                    {
        //                        worksheet.Cells[i + 2, 1].Value = dataGridView.Rows[i].Cells["SoPhieuX"].Value?.ToString();
        //                        worksheet.Cells[i + 2, 2].Value = dataGridView.Rows[i].Cells["STT"].Value?.ToString();
        //                        worksheet.Cells[i + 2, 3].Value = dataGridView.Rows[i].Cells["MaSP"].Value?.ToString();
        //                        worksheet.Cells[i + 2, 4].Value = dataGridView.Rows[i].Cells["SLXuat"].Value?.ToString();
        //                        worksheet.Cells[i + 2, 5].Value = dataGridView.Rows[i].Cells["DGXuat"].Value?.ToString();
        //                    }
        //                }

        //                // Lưu tệp Excel
        //                FileInfo excelFile = new FileInfo(filePath);
        //                excelPackage.SaveAs(excelFile);
        //            }

        //            MessageBox.Show("Xuất dữ liệu thành công!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Microsoft Excel | *.xlsx";
        //    saveFileDialog.Title = "Lưu danh sách phiếu xuất";
        //    saveFileDialog.ShowDialog();

        //    if (saveFileDialog.FileName != "")
        //    {
        //        try
        //        {
        //            ExportToExcel(saveFileDialog.FileName);
        //            MessageBox.Show("Kết xuất thành công!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Thông báo lỗi");
        //        }
        //    }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtSoPhieuX.Text = "";
            cboKH.Text = "";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide(); // Ẩn form hiện tại

                frmMenu formMenu = new frmMenu();
                formMenu.Show();
            }
        }

        private void btnlammoict_Click(object sender, EventArgs e)
        {
            txtSTT.Text = "";
            txtSL.Text = "";
            txtDG.Text = "";
            cboSP.Text = "";
            txtTongTien.Text = "";
        }


        //private void ExportToExcel(string filePath)
        //{
        //    // Khởi tạo ứng dụng Excel
        //    Application excelApp = new Application();
        //    excelApp.Visible = false;

        //    // Tạo workbook mới
        //    Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

        //    // Tạo worksheet mới
        //    Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

        //    // Đặt tiêu đề cho các cột
        //    worksheet.Cells[1, 1] = "Mã hoá đơn";
        //    worksheet.Cells[1, 2] = "STT";
        //    worksheet.Cells[1, 3] = "Mã Sản Phẩm";
        //    worksheet.Cells[1, 4] = "Số Lượng";
        //    worksheet.Cells[1, 5] = "Đơn Giá";

        //    // Đổ dữ liệu từ DataGridView vào Excel
        //    for (int i = 0; i < dgvCTPX.Rows.Count - 1; i++)
        //    {
        //        for (int j = 0; j < dgvCTPX.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dgvCTPX.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }

        //    // Định dạng các ô trong Excel
        //    Range headerRange = worksheet.Range["A1", "E1"];
        //    headerRange.Font.Bold = true;
        //    headerRange.Interior.Color = System.Drawing.Color.Yellow;
        //    headerRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

        //    Range dataRange = worksheet.Range["A1", $"E{dgvCTPX.Rows.Count}"];
        //    dataRange.Columns.AutoFit();

        //    // Lưu workbook
        //    workbook.SaveAs(filePath);

        //    // Đóng workbook và ứng dụng Excel
        //    workbook.Close();
        //    excelApp.Quit();

        //    // Giải phóng tài nguyên COM
        //    Marshal.ReleaseComObject(worksheet);
        //    Marshal.ReleaseComObject(workbook);
        //    Marshal.ReleaseComObject(excelApp);

        //    // Hiển thị thông tin đã lưu thành công
        //    MessageBox.Show($"Dữ liệu đã được xuất thành công vào tệp {filePath}!");
        //}


    }
}
// nor baro khong tim thay 
