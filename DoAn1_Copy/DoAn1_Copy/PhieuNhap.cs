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
using BUS;
using DTO;
using System.Globalization;

namespace DoAn1_Copy
{
    public partial class PhieuNhap : Form
    {
        BUS_PhieuNhap buspn = new BUS_PhieuNhap();
        BUS_CTPN busctpn = new BUS_CTPN();

        BUS_NCC bus_ncc = new BUS_NCC();
        BUS_SP bus_sp = new BUS_SP();
        BUS_NhanVien busnv = new BUS_NhanVien();
        public PhieuNhap()
        {
            InitializeComponent();
        }
        void loadcbbNCC()
        {
            CboNCC.DataSource = bus_ncc.getNCC();
            CboNCC.DisplayMember = "TenNCC";
            CboNCC.ValueMember = "MaNCC";
        }
        void loadcbbNV()
        {
            cboNV.DataSource = busnv.getNV();
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "MaNV";
        }
        void loadcbbSP()
        {
            cboSP.DataSource = bus_sp.getSanPham();
            cboSP.DisplayMember = "TenSP";
            cboSP.ValueMember = "MaSP";
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loadcbbNCC();
            loadcbbSP();
            loadcbbNV();
            DataTable dt = buspn.getData();
            dgvPN.DataSource = dt;
            bingding();
            TinhTongTien();
            dgvCTPN.SelectionChanged += dgvCTPN_SelectionChanged;
            
            
        }
       
        private void bingding()
        {
            txtSoPhieuN.DataBindings.Clear();
            txtSoPhieuN.DataBindings.Add("text", dgvPN.DataSource, "SoPhieuN");
            dateTimePickerNgayN.DataBindings.Clear();
            dateTimePickerNgayN.DataBindings.Add("text", dgvPN.DataSource, "NgayNhap");
            CboNCC.DataBindings.Clear();
            CboNCC.DataBindings.Add("text", dgvPN.DataSource, "MaNCC");
            cboNV.DataBindings.Clear();
            cboNV.DataBindings.Add("text", dgvPN.DataSource, "MaNV");

        }
        private void bingding1()
        {

            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("text", dgvCTPN.DataSource, "STT");
            cboSP.DataBindings.Clear();
            cboSP.DataBindings.Add("text", dgvCTPN.DataSource, "MaSP");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("text", dgvCTPN.DataSource, "SLNhap");
            txtDG.DataBindings.Clear();
            txtDG.DataBindings.Add("text", dgvCTPN.DataSource, "DGNhap");

        }
        private void lammoict()
        {
            txtSoPhieuN.Text = "";
            txtSTT.Text = "";
            cboSP.Text = "";
            txtSL.Text = "";
            txtDG.Text = "";
        }
        private void lammoi()
        {
            txtSoPhieuN.Text = "";
            cboNV.Text = "";
            CboNCC.Text = "";
            dateTimePickerNgayN.Text = "";
        }

        private void txtSoPhieuN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoPhieuN.Text))
            {
                DataTable dt = busctpn.getData(txtSoPhieuN.Text.Trim());
                dgvCTPN.DataSource = dt;
                bingding1();
            }
            else
            {
                dgvCTPN.DataSource = null;
            }
        }

        private void dgvCTPN_DataSourceChanged(object sender, EventArgs e)
        {
            bingding1();
        }


        private void dgvCTPN_SelectionChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell cellSLN = row.Cells["SLNhap"];
                    DataGridViewCell cellDGN = row.Cells["DGNhap"];

                    if (cellSLN.Value != null && cellDGN.Value != null)
                    {
                        int sl = Convert.ToInt32(cellSLN.Value);
                        int dg = Convert.ToInt32(cellDGN.Value);
                        decimal amount = sl * dg;
                        totalAmount += amount;
                    }
                }
            }

            txtTongTien.Text = totalAmount.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string SoPhieuN = txtSoPhieuN.Text;
            DateTime NgayNhap = dateTimePickerNgayN.Value;

            string MaNCC = CboNCC.SelectedValue.ToString();
            string MaNV = cboNV.SelectedValue.ToString();

            if (string.IsNullOrEmpty(SoPhieuN))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu nhập.");
                return;
            }

            DTO_PhieuNhap k = new DTO_PhieuNhap(SoPhieuN, NgayNhap, MaNCC, MaNV);

            if (buspn.ThemPN(k))
            {
                MessageBox.Show("Thêm thông tin phiếu nhập thành công.");
                dgvPN.DataSource = buspn.getData();
            }
            else
            {
                MessageBox.Show("Thêm thông tin phiếu nhập không thành công.");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string SoPhieuN = txtSoPhieuN.Text;
            DateTime NgayNhap = DateTime.Parse(dateTimePickerNgayN.Value.ToShortDateString());

            string MaNCC = CboNCC.Text;
            string MaNV = cboNV.Text;
            DTO_PhieuNhap k = new DTO_PhieuNhap(SoPhieuN, NgayNhap, MaNCC, MaNV);

            if (buspn.SuaPN(k) == true)
            {
                MessageBox.Show("Sua thanh cong");
                dgvPN.DataSource = buspn.getData();
            }
         
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string ma = txtSoPhieuN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (buspn.XoaPN(ma) == true)
                {
                    MessageBox.Show("Xoá thành công ");
                    dgvPN.DataSource = buspn.getData();
                }
            }
           
        }

        private void btnCTThem_Click_1(object sender, EventArgs e)
        {
            string SoPhieuN = txtSoPhieuN.Text;
            int STT = int.Parse(txtSTT.Text);
            string maSP = cboSP.SelectedValue.ToString();
            int SLNhap = int.Parse(txtSL.Text);
            int DGNhap = int.Parse(txtDG.Text);

            if (string.IsNullOrEmpty(SoPhieuN))//kiểm tra các giá trị nhập vào
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi tiết phiếu nhập.");
                return;
            }

            DTO_CTPN k = new DTO_CTPN(SoPhieuN, STT, maSP, SLNhap, DGNhap);

            if (busctpn.ThemCTHDN(k))
            {
                MessageBox.Show("Thêm thông tin chi tiết phiếu nhập thành công.");
                dgvCTPN.DataSource = busctpn.getData(SoPhieuN);
            }
            else
            {
                MessageBox.Show("Thêm thông tin chi tiết phiếu nhập không thành công.");
            }

        }

        private void btnCTSua_Click_1(object sender, EventArgs e)
        {
            string SoPhieuN = txtSoPhieuN.Text;
            int STT = int.Parse(txtSTT.Text);
            string maSP = cboSP.SelectedValue.ToString();
            int SLNhap = int.Parse(txtSL.Text);
            int DGNhap = int.Parse(txtDG.Text);

            DTO_CTPN k = new DTO_CTPN(SoPhieuN, STT, maSP, SLNhap, DGNhap);

            if (busctpn.SuaCTHDN(k))
            {
                MessageBox.Show("Sửa thông tin chi tiết phiếu nhập thành công.");
                DataTable dt = busctpn.getData(txtSoPhieuN.Text);
                if (dt != null)
                {
                    dgvCTPN.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin chi tiết phiếu nhập không thành công.");
            }
        }

        private void btnCTXoa_Click_1(object sender, EventArgs e)
        {
            int STT = int.Parse(txtSTT.Text);
            string SoPhieuN = txtSoPhieuN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                DTO_CTPN k = new DTO_CTPN();
                if (busctpn.XoaCTHDN(STT.ToString()))
                {
                    MessageBox.Show("Xoá thông tin chi tiết phiếu nhập thành công.");
                    dgvCTPN.DataSource = busctpn.getData(txtSoPhieuN.Text);
                }
                else
                {
                    MessageBox.Show("Xoá thông tin chi tiết phiếu nhập không thành công.");
                }
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {

            txtSoPhieuN.Text = "";
            CboNCC.Text = "";
            CboNCC.Text = "";
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
    }
}
