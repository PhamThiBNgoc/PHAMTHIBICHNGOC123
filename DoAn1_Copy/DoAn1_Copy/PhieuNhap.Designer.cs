namespace DoAn1_Copy
{
    partial class PhieuNhap
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnCTXoa = new System.Windows.Forms.Button();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.btnCTSua = new System.Windows.Forms.Button();
            this.btnCTThem = new System.Windows.Forms.Button();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dateTimePickerNgayN = new System.Windows.Forms.DateTimePicker();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhieuN = new System.Windows.Forms.TextBox();
            this.lblSoPhieuN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboNCC = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnlammoict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(140, 194);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(270, 26);
            this.txtTongTien.TabIndex = 13;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(23, 194);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(79, 20);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // btnCTXoa
            // 
            this.btnCTXoa.Location = new System.Drawing.Point(246, 233);
            this.btnCTXoa.Name = "btnCTXoa";
            this.btnCTXoa.Size = new System.Drawing.Size(75, 40);
            this.btnCTXoa.TabIndex = 11;
            this.btnCTXoa.Text = "XoáCT";
            this.btnCTXoa.UseVisualStyleBackColor = true;
            this.btnCTXoa.Click += new System.EventHandler(this.btnCTXoa_Click_1);
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(140, 155);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(270, 26);
            this.txtDG.TabIndex = 10;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(140, 123);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(270, 26);
            this.txtSL.TabIndex = 9;
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(140, 82);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(270, 28);
            this.cboSP.TabIndex = 8;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(140, 38);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(270, 26);
            this.txtSTT.TabIndex = 7;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(23, 287);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 62;
            this.dgvCTPN.RowTemplate.Height = 28;
            this.dgvCTPN.Size = new System.Drawing.Size(786, 222);
            this.dgvCTPN.TabIndex = 6;
            this.dgvCTPN.DataSourceChanged += new System.EventHandler(this.dgvCTPN_DataSourceChanged);
            this.dgvCTPN.SelectionChanged += new System.EventHandler(this.dgvCTPN_SelectionChanged);
            // 
            // btnCTSua
            // 
            this.btnCTSua.Location = new System.Drawing.Point(140, 233);
            this.btnCTSua.Name = "btnCTSua";
            this.btnCTSua.Size = new System.Drawing.Size(81, 40);
            this.btnCTSua.TabIndex = 5;
            this.btnCTSua.Text = "SửaCT";
            this.btnCTSua.UseVisualStyleBackColor = true;
            this.btnCTSua.Click += new System.EventHandler(this.btnCTSua_Click_1);
            // 
            // btnCTThem
            // 
            this.btnCTThem.Location = new System.Drawing.Point(23, 233);
            this.btnCTThem.Name = "btnCTThem";
            this.btnCTThem.Size = new System.Drawing.Size(97, 40);
            this.btnCTThem.TabIndex = 4;
            this.btnCTThem.Text = "ThêmCT";
            this.btnCTThem.UseVisualStyleBackColor = true;
            this.btnCTThem.Click += new System.EventHandler(this.btnCTThem_Click_1);
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Location = new System.Drawing.Point(23, 158);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(64, 20);
            this.lblDG.TabIndex = 3;
            this.lblDG.Text = "Đơn giá";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(19, 123);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(78, 20);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số Lượng";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(19, 82);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(83, 20);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "Sản Phẩm";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(19, 44);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(38, 20);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "STT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(624, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản lý phiếu nhập";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(16, 82);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(87, 20);
            this.lblNgayNhap.TabIndex = 11;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // dateTimePickerNgayN
            // 
            this.dateTimePickerNgayN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayN.Location = new System.Drawing.Point(138, 80);
            this.dateTimePickerNgayN.Name = "dateTimePickerNgayN";
            this.dateTimePickerNgayN.Size = new System.Drawing.Size(261, 26);
            this.dateTimePickerNgayN.TabIndex = 10;
            // 
            // dgvPN
            // 
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Location = new System.Drawing.Point(20, 279);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.RowHeadersWidth = 62;
            this.dgvPN.RowTemplate.Height = 28;
            this.dgvPN.Size = new System.Drawing.Size(692, 222);
            this.dgvPN.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(324, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(172, 236);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 236);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(142, 123);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(257, 28);
            this.cboNV.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(16, 123);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(83, 20);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // txtSoPhieuN
            // 
            this.txtSoPhieuN.Location = new System.Drawing.Point(138, 36);
            this.txtSoPhieuN.Name = "txtSoPhieuN";
            this.txtSoPhieuN.Size = new System.Drawing.Size(261, 26);
            this.txtSoPhieuN.TabIndex = 1;
            this.txtSoPhieuN.TextChanged += new System.EventHandler(this.txtSoPhieuN_TextChanged);
            // 
            // lblSoPhieuN
            // 
            this.lblSoPhieuN.AutoSize = true;
            this.lblSoPhieuN.Location = new System.Drawing.Point(10, 36);
            this.lblSoPhieuN.Name = "lblSoPhieuN";
            this.lblSoPhieuN.Size = new System.Drawing.Size(115, 20);
            this.lblSoPhieuN.TabIndex = 0;
            this.lblSoPhieuN.Text = "Số Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlammoict);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.Controls.Add(this.btnCTXoa);
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.cboSP);
            this.groupBox2.Controls.Add(this.txtSTT);
            this.groupBox2.Controls.Add(this.dgvCTPN);
            this.groupBox2.Controls.Add(this.btnCTSua);
            this.groupBox2.Controls.Add(this.btnCTThem);
            this.groupBox2.Controls.Add(this.lblDG);
            this.groupBox2.Controls.Add(this.lblSL);
            this.groupBox2.Controls.Add(this.lblSP);
            this.groupBox2.Controls.Add(this.lblSTT);
            this.groupBox2.Location = new System.Drawing.Point(749, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 525);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.CboNCC);
            this.groupBox1.Controls.Add(this.lblNCC);
            this.groupBox1.Controls.Add(this.lblNgayNhap);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayN);
            this.groupBox1.Controls.Add(this.dgvPN);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNV);
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoPhieuN);
            this.groupBox1.Controls.Add(this.lblSoPhieuN);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 525);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // CboNCC
            // 
            this.CboNCC.FormattingEnabled = true;
            this.CboNCC.Location = new System.Drawing.Point(142, 161);
            this.CboNCC.Name = "CboNCC";
            this.CboNCC.Size = new System.Drawing.Size(257, 28);
            this.CboNCC.TabIndex = 13;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(18, 161);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(107, 20);
            this.lblNCC.TabIndex = 12;
            this.lblNCC.Text = "Nhà cung cấp";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(637, 237);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 35);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(476, 237);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(88, 37);
            this.btnLammoi.TabIndex = 14;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnlammoict
            // 
            this.btnlammoict.Location = new System.Drawing.Point(371, 235);
            this.btnlammoict.Name = "btnlammoict";
            this.btnlammoict.Size = new System.Drawing.Size(88, 37);
            this.btnlammoict.TabIndex = 15;
            this.btnlammoict.Text = "Làm mới";
            this.btnlammoict.UseVisualStyleBackColor = true;
            this.btnlammoict.Click += new System.EventHandler(this.btnlammoict_Click);
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1601, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnCTXoa;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Button btnCTSua;
        private System.Windows.Forms.Button btnCTThem;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayN;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoPhieuN;
        private System.Windows.Forms.Label lblSoPhieuN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnlammoict;
    }
}