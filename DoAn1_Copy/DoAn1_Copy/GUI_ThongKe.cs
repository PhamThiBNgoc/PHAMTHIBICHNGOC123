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
using BUS;
using DTO;
using System.Globalization;

namespace DoAn1_Copy
{
    public partial class GUI_ThongKe : Form
    {
        BUS_CTPX busctpx = new BUS_CTPX();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
           
        }
        void loaddgvHDBTheoThang(string thang, string nam)
        {


        }
        void loaddgvHDBTheoNam(string nam)
        {

        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            string thang = txtThang.Text;
            string nam = txtNamThang.Text;
            double doanhthu = busctpx.ThongKeDoanhThuTheoThang(thang, nam);
            lblTotalthang.Text = doanhthu.ToString();
            
            loaddgvHDBTheoThang(thang, nam);

        }

        private void btnThongKeNam_Click(object sender, EventArgs e)
        {
            string nam = txtNam.Text;
            double doanhthu = busctpx.ThongKeDoanhThuTheoNam(nam);
            lblTotalNam.Text = doanhthu.ToString();
            loaddgvHDBTheoNam(nam);
        }
    }
}
