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
    public partial class frmNCC : Form
    {
        BUS_NCC busncc = new BUS_NCC();
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busncc.getNCC();
            dgvNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNCC.Columns[3].HeaderText = "SDT";
            dgvNCC.Columns[4].HeaderText = "Email";
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtDiaChi.Text;
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp");
                return;
            }
            DTO_NCC ncc = new DTO_NCC(ma, ten, DiaChi, sdt, Email);
            if (busncc.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp  đã tồn tại.");
            }
            else
            {
                if (busncc.themNCC(ncc))
                {
                    MessageBox.Show("Thêm thông tin nhà cung cấp  thành công.");
                    dgvNCC.DataSource = busncc.getNCC();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin nhà cung cấp không thành công.");
                }
            }
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgvNCC[0, hang].Value.ToString();
            txtTen.Text = dgvNCC[1, hang].Value.ToString();
            txtSDT.Text = dgvNCC[3, hang].Value.ToString();
            txtDiaChi.Text = dgvNCC[2, hang].Value.ToString();
            txtEmail.Text = dgvNCC[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string DiaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string Email = txtEmail.Text;
            DTO_NCC ncc = new DTO_NCC(ma, ten, DiaChi, sdt, Email);

            if (busncc.suaNCC(ncc) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvNCC.DataSource = busncc.getNCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busncc.xoaNCC(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvNCC.DataSource = busncc.getNCC();
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

        private void btnseach_Click(object sender, EventArgs e)
        {
            string searchName = txtseach.Text; // Lấy tên nhân viên cần tìm kiếm từ TextBox

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm kiếm.");
                return;
            }

            DataTable searchResults = busncc.SearchEmployeesByName(searchName);

            // Hiển thị kết quả tìm kiếm trên DataGridView
            dgvNCC.DataSource = searchResults;
        }
    }
}
