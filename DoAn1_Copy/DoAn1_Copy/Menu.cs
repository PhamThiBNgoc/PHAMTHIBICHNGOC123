using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn1_Copy
{
    public partial class frmMenu : Form
    {
       
        private string role;
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        public void HideSomeFeatures()
        {
            Menu_NV.Enabled = false;
        }

        private void Menu_SP_Click(object sender, EventArgs e)
        {
            frmSP frm = new frmSP();
            frm.ShowDialog();
        }

      

        private void Menu_NCC_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.ShowDialog();
        }

        private void Menu_DVT_Click(object sender, EventArgs e)
        {
            frmDVT frm = new frmDVT();
            frm.ShowDialog();
        }

        private void Menu_KH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void Menu_PN_Click(object sender, EventArgs e)
        {
            PhieuNhap frm = new PhieuNhap();
            frm.Show();
        }

        private void MenuPX_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            frm.ShowDialog();
        }

        private void Menu_NV_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe frm = new GUI_ThongKe();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide(); // Ẩn form hiện tại

                frmDangNhap frm = new  frmDangNhap();
                frm.Show();

            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
        }
    }
}
