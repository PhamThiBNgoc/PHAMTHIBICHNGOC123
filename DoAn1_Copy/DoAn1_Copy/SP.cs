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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DoAn1_Copy
{
    public partial class frmSP : Form
    {
        BUS_SP bussp = new BUS_SP();
        public frmSP()
        {
            InitializeComponent();
        }

        private void frmSP_Load(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = bussp.getSanPham();
            dgvDSSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDSSP.Columns[1].HeaderText = "Tên ";
            dgvDSSP.Columns[2].HeaderText = "mã dvt ";
            dgvDSSP.Columns[3].HeaderText = "mã ncc ";

       



            //đổ dữ liệu vào combobox
            cboMaNCC.DataSource = bussp.getNhaCC();
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
            cboMaDVT.DataSource = bussp.getDVT();
            cboMaDVT.DisplayMember = "TenDVT";
            cboMaDVT.ValueMember = "MaDVT";
        }
      

      
        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSP.Text = dgvDSSP[0, hang].Value.ToString();
            txtTenSP.Text = dgvDSSP[1, hang].Value.ToString();
            cboMaNCC.Text = dgvDSSP[2, hang].Value.ToString();
            cboMaDVT.Text = dgvDSSP[3, hang].Value.ToString();
        }


        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboMaDVT.Text = "";
            cboMaNCC.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            string maNCC = cboMaNCC.SelectedValue.ToString();
            string maDVT = cboMaDVT.SelectedValue.ToString();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            DTO_SanPham sp = new DTO_SanPham(ma, ten, maDVT, maNCC);

            if (bussp.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.");
                return;
            }

            if (bussp.themSP(sp))
            {
                MessageBox.Show("Thêm sản phẩm thành công.");
                dgvDSSP.DataSource = bussp.getSanPham();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            string maDVT = cboMaDVT.SelectedValue.ToString();
            string maNCC = cboMaNCC.SelectedValue.ToString();

            DTO_SanPham sv = new DTO_SanPham(ma, ten, maDVT, maNCC);

            if (bussp.suaSP(sv) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvDSSP.DataSource = bussp.getSanPham();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (bussp.xoaSP(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvDSSP.DataSource = bussp.getSanPham();
                }
            }
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

            DataTable searchResults = bussp.SearchEmployeesByName(searchName);

            // Hiển thị kết quả tìm kiếm trên DataGridView
            dgvDSSP.DataSource = searchResults;
        }
    }
}
