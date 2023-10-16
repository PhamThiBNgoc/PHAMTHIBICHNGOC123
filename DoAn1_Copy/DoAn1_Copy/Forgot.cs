using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace DoAn1_Copy
{
    public partial class frmForgot : Form
    {
        BUS_Forgot bus_forgot = new BUS_Forgot();
        public frmForgot()
        {
            InitializeComponent();
            label3.Text = string.Empty;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            if (bus_forgot.CheckEmail(Email))
            {
                string password = bus_forgot.GetPassword(Email);
                label3.Text = "Mật khẩu của bạn là: " + password;
            }
            else
            {
                MessageBox.Show("Email không đúng!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
        }
    }
}
