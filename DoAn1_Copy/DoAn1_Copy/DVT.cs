using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Copy
{
    public partial class frmDVT : Form
    {
        BUS_DVT busdvt = new BUS_DVT();
        public frmDVT()
        {
            InitializeComponent();
        }

        private void frmDVT_Load(object sender, EventArgs e)
        {
            dgvDVT.DataSource = busdvt.getDVT();
            dgvDVT.Columns[0].HeaderText = "Mã đơn vị tính";
            dgvDVT.Columns[1].HeaderText = "Tên đơn vị tính ";
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn vị tính");
                return;
            }
            DTO_DVT dvt = new DTO_DVT(ma,ten);
            if (busdvt.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("thông tin đơn vị tính  đã tồn tại.");
            }
            else
            {
                if (busdvt.themDVT(dvt))
                {
                    MessageBox.Show("Thêm thông tin đơn vị tính thành công.");
                    dgvDVT.DataSource = busdvt.getDVT();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin đơn vị tính không thành công.");
                }
            }
        }

        private void dgvDVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgvDVT[0, hang].Value.ToString();
            txtTen.Text = dgvDVT[1, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;

            DTO_DVT dvt = new DTO_DVT(ma,ten);

            if (busdvt.suaDVT(dvt) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvDVT.DataSource = busdvt.getDVT();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busdvt.xoaDVT(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvDVT.DataSource = busdvt.getDVT();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = string.Empty;
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
