namespace DoAn1_Copy
{
    partial class frmSP
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
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxcn = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaDVT = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboMaDVT = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.groupBoxtt = new System.Windows.Forms.GroupBox();
            this.txtseach = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.groupBoxcn.SuspendLayout();
            this.groupBoxtt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(17, 290);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 62;
            this.dgvDSSP.RowTemplate.Height = 28;
            this.dgvDSSP.Size = new System.Drawing.Size(1028, 150);
            this.dgvDSSP.TabIndex = 16;
            this.dgvDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý sản phẩm ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 32;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(173, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(329, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(487, 32);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 34);
            this.btnLamMoi.TabIndex = 36;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(668, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBoxcn
            // 
            this.groupBoxcn.Controls.Add(this.btnseach);
            this.groupBoxcn.Controls.Add(this.txtseach);
            this.groupBoxcn.Controls.Add(this.btnThoat);
            this.groupBoxcn.Controls.Add(this.btnLamMoi);
            this.groupBoxcn.Controls.Add(this.btnXoa);
            this.groupBoxcn.Controls.Add(this.btnSua);
            this.groupBoxcn.Controls.Add(this.btnThem);
            this.groupBoxcn.Controls.Add(this.label6);
            this.groupBoxcn.Location = new System.Drawing.Point(17, 204);
            this.groupBoxcn.Name = "groupBoxcn";
            this.groupBoxcn.Size = new System.Drawing.Size(1028, 80);
            this.groupBoxcn.TabIndex = 27;
            this.groupBoxcn.TabStop = false;
            this.groupBoxcn.Text = "Chức năng";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(27, 34);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(109, 20);
            this.lblMaSP.TabIndex = 27;
            this.lblMaSP.Text = "Mã Sản Phẩm";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(22, 102);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(114, 20);
            this.lblTenSP.TabIndex = 28;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // lblMaDVT
            // 
            this.lblMaDVT.AutoSize = true;
            this.lblMaDVT.Location = new System.Drawing.Point(402, 31);
            this.lblMaDVT.Name = "lblMaDVT";
            this.lblMaDVT.Size = new System.Drawing.Size(117, 20);
            this.lblMaDVT.TabIndex = 29;
            this.lblMaDVT.Text = "Mã Đơn Vị Tính";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(380, 99);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(139, 20);
            this.lblNCC.TabIndex = 30;
            this.lblNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(142, 28);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(212, 26);
            this.txtMaSP.TabIndex = 31;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(142, 96);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(212, 26);
            this.txtTenSP.TabIndex = 32;
            // 
            // cboMaDVT
            // 
            this.cboMaDVT.FormattingEnabled = true;
            this.cboMaDVT.Location = new System.Drawing.Point(525, 28);
            this.cboMaDVT.Name = "cboMaDVT";
            this.cboMaDVT.Size = new System.Drawing.Size(223, 28);
            this.cboMaDVT.TabIndex = 33;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(525, 96);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(223, 28);
            this.cboMaNCC.TabIndex = 34;
            // 
            // groupBoxtt
            // 
            this.groupBoxtt.Controls.Add(this.cboMaNCC);
            this.groupBoxtt.Controls.Add(this.cboMaDVT);
            this.groupBoxtt.Controls.Add(this.txtTenSP);
            this.groupBoxtt.Controls.Add(this.txtMaSP);
            this.groupBoxtt.Controls.Add(this.lblNCC);
            this.groupBoxtt.Controls.Add(this.lblMaDVT);
            this.groupBoxtt.Controls.Add(this.lblTenSP);
            this.groupBoxtt.Controls.Add(this.lblMaSP);
            this.groupBoxtt.Location = new System.Drawing.Point(17, 46);
            this.groupBoxtt.Name = "groupBoxtt";
            this.groupBoxtt.Size = new System.Drawing.Size(1028, 152);
            this.groupBoxtt.TabIndex = 28;
            this.groupBoxtt.TabStop = false;
            this.groupBoxtt.Text = "thông tin";
            // 
            // txtseach
            // 
            this.txtseach.Location = new System.Drawing.Point(782, 35);
            this.txtseach.Name = "txtseach";
            this.txtseach.Size = new System.Drawing.Size(145, 26);
            this.txtseach.TabIndex = 38;
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(933, 33);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(89, 33);
            this.btnseach.TabIndex = 39;
            this.btnseach.Text = "seach";
            this.btnseach.UseVisualStyleBackColor = true;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // frmSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.groupBoxtt);
            this.Controls.Add(this.groupBoxcn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSSP);
            this.Name = "frmSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.groupBoxcn.ResumeLayout(false);
            this.groupBoxcn.PerformLayout();
            this.groupBoxtt.ResumeLayout(false);
            this.groupBoxtt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBoxcn;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaDVT;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboMaDVT;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.GroupBox groupBoxtt;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.TextBox txtseach;
    }
}