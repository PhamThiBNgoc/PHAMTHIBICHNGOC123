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
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvCV.DataSource = busnv.getNV();
            dgvCV.Columns[0].HeaderText = "Mã  ";
            dgvCV.Columns[1].HeaderText = "Tên  ";
            dgvCV.Columns[2].HeaderText = "Địa chỉ";
            dgvCV.Columns[3].HeaderText = "Số điện thoại";
            
            dgvCV.Columns[4].HeaderText = "Email";
            //dgvCV.Columns[5].HeaderText = "Chức Vụ";
            //dgvCV.Columns[6].HeaderText = "Tài Khoản";
            //dgvCV.Columns[7].HeaderText = "Mật khẩu";
         
            
        }
        private void SetDataGridViewWidth()
        {
            int visibleColumnCount = 0;

            foreach (DataGridViewColumn column in dgvCV.Columns)
            {
                column.Width = 80; // Thiết lập độ rộng mặc định là 200 cho tất cả các cột

                if (column.Visible)
                {
                    visibleColumnCount++;
                }
            }

            int totalColumnWidth = 80 * visibleColumnCount; // Tính toán tổng độ rộng mới dựa trên độ rộng mặc định và số cột hiển thị

            dgvCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Tắt chế độ tự động điều chỉnh độ rộng cột
            dgvCV.Width = totalColumnWidth; // Thiết lập lại độ rộng của DataGridView dựa trên tổng độ rộng mới

            // Ghi đè độ rộng của từng cột để đảm bảo rằng độ rộng của tất cả các cột đều là 200
            foreach (DataGridViewColumn column in dgvCV.Columns)
            {
                column.Width = 80;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string DiaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            string ChucVu = txtChucVu.Text;
            string taiKhoan = txtTK.Text;
            string MatKhau = txtMK.Text;
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên .");
                return;
            }
            DTO_NhanVien k = new DTO_NhanVien(ma, ten, DiaChi, sdt, Email, ChucVu, taiKhoan, MatKhau);
            if (busnv.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
            }
            else
            {
                if (busnv.themNV(k))
                {
                    MessageBox.Show("Thêm thông tin nhân viên  thành công.");
                    dgvCV.DataSource = busnv.getNV();
                }
                else
                {
                    MessageBox.Show("Thêm thông nhân viên không thành công.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string DiaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            string ChucVu = txtChucVu.Text;
            string taiKhoan = txtTK.Text;
            string MatKhau = txtMK.Text;
            DTO_NhanVien k = new DTO_NhanVien(ma, ten, DiaChi, sdt, Email, ChucVu,taiKhoan,MatKhau);

            if (busnv.suaNV(k) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvCV.DataSource = busnv.getNV();
            }
        }

        private void dgvCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgvCV[0, hang].Value.ToString();
            txtTen.Text = dgvCV[1, hang].Value.ToString();
            txtDiaChi.Text = dgvCV[2, hang].Value.ToString();
            txtSDT.Text = dgvCV[3, hang].Value.ToString();
            
            txtEmail.Text = dgvCV[4, hang].Value.ToString();
            txtChucVu.Text = dgvCV[5, hang].Value.ToString();
            txtTK.Text = dgvCV[6, hang].Value.ToString();
            txtMK.Text = dgvCV[7, hang].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtMa.Text = "";
            txtTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtChucVu.Text = "";
            txtTK.Text = "";
            txtMK.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide(); // Ẩn form hiện tại

                frmMenu formMenu = new frmMenu();
                formMenu.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busnv.xoaNV(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvCV.DataSource = busnv.getNV();
                }
            }
        }
    }
    
}
