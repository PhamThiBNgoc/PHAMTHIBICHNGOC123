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
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap busdn = new BUS_DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot forgot = new frmForgot();
            forgot.ShowDialog();
        }

        private void btnDN_Click_1(object sender, EventArgs e)
        {
            string role;

            string TaiKhoan = txtTK.Text;
            string MatKhau = txtMK.Text;



            if (busdn.Login(TaiKhoan, MatKhau, out role))
            {
                if (role == "admin")
                {
                    frmMenu menuForm = new frmMenu(role);
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    frmMenu menuForm = new frmMenu(role);


                    menuForm.HideSomeFeatures(); // phương thức để ẩn các chức năng
                    menuForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkXemMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkXemMK.Checked)
            {
                txtMK.PasswordChar = (char)0; // Hiển thị mật khẩu
            }
            else
            {
                txtMK.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
    }
}
