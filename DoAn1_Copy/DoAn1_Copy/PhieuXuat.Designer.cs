namespace DoAn1_Copy
{
    partial class frmPhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.dateTimePickerNgayX = new System.Windows.Forms.DateTimePicker();
            this.dgvPX = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhieuX = new System.Windows.Forms.TextBox();
            this.lblSoPhieuX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlammoict = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnCTXoa = new System.Windows.Forms.Button();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.dgvCTPX = new System.Windows.Forms.DataGridView();
            this.btnCTSua = new System.Windows.Forms.Button();
            this.btnCTThem = new System.Windows.Forms.Button();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.lblNgayXuat);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayX);
            this.groupBox1.Controls.Add(this.dgvPX);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboKH);
            this.groupBox1.Controls.Add(this.lblKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoPhieuX);
            this.groupBox1.Controls.Add(this.lblSoPhieuX);
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Xuất";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(547, 203);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 35);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(397, 203);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(88, 37);
            this.btnLammoi.TabIndex = 12;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(16, 98);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(83, 20);
            this.lblNgayXuat.TabIndex = 11;
            this.lblNgayXuat.Text = "Ngày Xuất";
            // 
            // dateTimePickerNgayX
            // 
            this.dateTimePickerNgayX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayX.Location = new System.Drawing.Point(138, 95);
            this.dateTimePickerNgayX.Name = "dateTimePickerNgayX";
            this.dateTimePickerNgayX.Size = new System.Drawing.Size(261, 26);
            this.dateTimePickerNgayX.TabIndex = 10;
            // 
            // dgvPX
            // 
            this.dgvPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPX.Location = new System.Drawing.Point(14, 282);
            this.dgvPX.Name = "dgvPX";
            this.dgvPX.RowHeadersWidth = 62;
            this.dgvPX.RowTemplate.Height = 28;
            this.dgvPX.Size = new System.Drawing.Size(608, 153);
            this.dgvPX.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(267, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(123, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(138, 152);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(261, 28);
            this.cboKH.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(16, 155);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(97, 20);
            this.lblKhachHang.TabIndex = 4;
            this.lblKhachHang.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // txtSoPhieuX
            // 
            this.txtSoPhieuX.Location = new System.Drawing.Point(138, 36);
            this.txtSoPhieuX.Name = "txtSoPhieuX";
            this.txtSoPhieuX.Size = new System.Drawing.Size(261, 26);
            this.txtSoPhieuX.TabIndex = 1;
            this.txtSoPhieuX.TextChanged += new System.EventHandler(this.txtSoPhieuX_TextChanged);
            // 
            // lblSoPhieuX
            // 
            this.lblSoPhieuX.AutoSize = true;
            this.lblSoPhieuX.Location = new System.Drawing.Point(10, 36);
            this.lblSoPhieuX.Name = "lblSoPhieuX";
            this.lblSoPhieuX.Size = new System.Drawing.Size(111, 20);
            this.lblSoPhieuX.TabIndex = 0;
            this.lblSoPhieuX.Text = "Số Phiếu Xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản lý phiếu xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlammoict);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.btnCTXoa);
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.cboSP);
            this.groupBox2.Controls.Add(this.txtSTT);
            this.groupBox2.Controls.Add(this.dgvCTPX);
            this.groupBox2.Controls.Add(this.btnCTSua);
            this.groupBox2.Controls.Add(this.btnCTThem);
            this.groupBox2.Controls.Add(this.lblDG);
            this.groupBox2.Controls.Add(this.lblSL);
            this.groupBox2.Controls.Add(this.lblSP);
            this.groupBox2.Controls.Add(this.lblSTT);
            this.groupBox2.Location = new System.Drawing.Point(650, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 466);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu xuất";
            // 
            // btnlammoict
            // 
            this.btnlammoict.Location = new System.Drawing.Point(681, 232);
            this.btnlammoict.Name = "btnlammoict";
            this.btnlammoict.Size = new System.Drawing.Size(88, 37);
            this.btnlammoict.TabIndex = 14;
            this.btnlammoict.Text = "Làm mới";
            this.btnlammoict.UseVisualStyleBackColor = true;
            this.btnlammoict.Click += new System.EventHandler(this.btnlammoict_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(462, 234);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 37);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "Xuất Excel";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(302, 194);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(270, 26);
            this.txtTongTien.TabIndex = 13;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(185, 194);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(79, 20);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // btnCTXoa
            // 
            this.btnCTXoa.Location = new System.Drawing.Point(302, 236);
            this.btnCTXoa.Name = "btnCTXoa";
            this.btnCTXoa.Size = new System.Drawing.Size(75, 40);
            this.btnCTXoa.TabIndex = 11;
            this.btnCTXoa.Text = "XoáCT";
            this.btnCTXoa.UseVisualStyleBackColor = true;
            this.btnCTXoa.Click += new System.EventHandler(this.btnCTXoa_Click);
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(302, 155);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(270, 26);
            this.txtDG.TabIndex = 10;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(302, 123);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(270, 26);
            this.txtSL.TabIndex = 9;
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(302, 82);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(270, 28);
            this.cboSP.TabIndex = 8;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(302, 38);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(270, 26);
            this.txtSTT.TabIndex = 7;
            // 
            // dgvCTPX
            // 
            this.dgvCTPX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPX.Location = new System.Drawing.Point(6, 282);
            this.dgvCTPX.Name = "dgvCTPX";
            this.dgvCTPX.RowHeadersWidth = 62;
            this.dgvCTPX.RowTemplate.Height = 28;
            this.dgvCTPX.Size = new System.Drawing.Size(763, 148);
            this.dgvCTPX.TabIndex = 6;
            this.dgvCTPX.DataSourceChanged += new System.EventHandler(this.dgvCTPX_DataSourceChanged);
            this.dgvCTPX.SelectionChanged += new System.EventHandler(this.dgvCTPX_SelectionChanged);
            // 
            // btnCTSua
            // 
            this.btnCTSua.Location = new System.Drawing.Point(168, 232);
            this.btnCTSua.Name = "btnCTSua";
            this.btnCTSua.Size = new System.Drawing.Size(81, 40);
            this.btnCTSua.TabIndex = 5;
            this.btnCTSua.Text = "SửaCT";
            this.btnCTSua.UseVisualStyleBackColor = true;
            this.btnCTSua.Click += new System.EventHandler(this.btnCTSua_Click);
            // 
            // btnCTThem
            // 
            this.btnCTThem.Location = new System.Drawing.Point(6, 232);
            this.btnCTThem.Name = "btnCTThem";
            this.btnCTThem.Size = new System.Drawing.Size(97, 40);
            this.btnCTThem.TabIndex = 4;
            this.btnCTThem.Text = "ThêmCT";
            this.btnCTThem.UseVisualStyleBackColor = true;
            this.btnCTThem.Click += new System.EventHandler(this.btnCTThem_Click);
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Location = new System.Drawing.Point(185, 158);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(64, 20);
            this.lblDG.TabIndex = 3;
            this.lblDG.Text = "Đơn giá";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(181, 123);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(78, 20);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số Lượng";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(181, 82);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(83, 20);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "Sản Phẩm";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(181, 44);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(38, 20);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "STT";
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1450, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuXuat";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayX;
        private System.Windows.Forms.DataGridView dgvPX;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoPhieuX;
        private System.Windows.Forms.Label lblSoPhieuX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.DataGridView dgvCTPX;
        private System.Windows.Forms.Button btnCTSua;
        private System.Windows.Forms.Button btnCTThem;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Button btnCTXoa;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnlammoict;
    }
}