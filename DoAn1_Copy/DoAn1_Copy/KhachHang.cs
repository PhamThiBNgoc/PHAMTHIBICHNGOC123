using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using DTO;
using System.Windows.Forms;

namespace DoAn1_Copy
{
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = buskh.getKH();
            dgvKH.Columns[0].HeaderText = "Mã khách hàng ";
            dgvKH.Columns[1].HeaderText = "Tên khách hàng ";
            dgvKH.Columns[3].HeaderText = "Số điện thoại";
            dgvKH.Columns[2].HeaderText = "Địa chỉ";
            dgvKH.Columns[4].HeaderText = "Email";
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            int sdt = int.Parse(txtSDT.Text);
            string DiaChi = txtDiaChi.Text;
            string Email = txtDiaChi.Text;
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng .");
                return;
            }
            DTO_KhachHang k = new DTO_KhachHang(ma, ten, DiaChi, sdt, Email);
            if (buskh.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã khách hàng   đã tồn tại.");
            }
            else
            {
                if (buskh.themKH(k))
                {
                    MessageBox.Show("Thêm thông tin khách hàng  thành công.");
                    dgvKH.DataSource = buskh.getKH();
                }
                else
                {
                    MessageBox.Show("Thêm thông khách hàng không thành công.");
                }
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgvKH[0, hang].Value.ToString();
            txtTen.Text = dgvKH[1, hang].Value.ToString();
            txtSDT.Text = dgvKH[3, hang].Value.ToString();
            txtDiaChi.Text = dgvKH[2, hang].Value.ToString();
            txtEmail.Text = dgvKH[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string DiaChi = txtDiaChi.Text;
            int sdt = int.Parse(txtSDT.Text);
            string Email = txtEmail.Text;
            DTO_KhachHang k = new DTO_KhachHang(ma, ten, DiaChi, sdt, Email);

            if (buskh.suaKH(k) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvKH.DataSource = buskh.getKH();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buskh.xoaKH(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvKH.DataSource = buskh.getKH();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtMa.Text = "";
            txtTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
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
    }
}
