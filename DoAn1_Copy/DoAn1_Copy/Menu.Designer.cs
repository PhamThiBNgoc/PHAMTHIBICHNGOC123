namespace DoAn1_Copy
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_NCC = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DVT = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_KH = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_PN = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPX = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_SP,
            this.Menu_NCC,
            this.Menu_DVT,
            this.Menu_KH,
            this.Menu_PN,
            this.MenuPX,
            this.Menu_NV});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // Menu_SP
            // 
            this.Menu_SP.Name = "Menu_SP";
            this.Menu_SP.Size = new System.Drawing.Size(286, 34);
            this.Menu_SP.Text = "Quản lý sản phẩm";
            this.Menu_SP.Click += new System.EventHandler(this.Menu_SP_Click);
            // 
            // Menu_NCC
            // 
            this.Menu_NCC.Name = "Menu_NCC";
            this.Menu_NCC.Size = new System.Drawing.Size(286, 34);
            this.Menu_NCC.Text = "Quản lý nhà cung cấp";
            this.Menu_NCC.Click += new System.EventHandler(this.Menu_NCC_Click);
            // 
            // Menu_DVT
            // 
            this.Menu_DVT.Name = "Menu_DVT";
            this.Menu_DVT.Size = new System.Drawing.Size(286, 34);
            this.Menu_DVT.Text = "Quản lý đơn vị tính";
            this.Menu_DVT.Click += new System.EventHandler(this.Menu_DVT_Click);
            // 
            // Menu_KH
            // 
            this.Menu_KH.Name = "Menu_KH";
            this.Menu_KH.Size = new System.Drawing.Size(286, 34);
            this.Menu_KH.Text = "Quản lý khách hàng ";
            this.Menu_KH.Click += new System.EventHandler(this.Menu_KH_Click);
            // 
            // Menu_PN
            // 
            this.Menu_PN.Name = "Menu_PN";
            this.Menu_PN.Size = new System.Drawing.Size(286, 34);
            this.Menu_PN.Text = "Quản lý phiếu nhập";
            this.Menu_PN.Click += new System.EventHandler(this.Menu_PN_Click);
            // 
            // MenuPX
            // 
            this.MenuPX.Name = "MenuPX";
            this.MenuPX.Size = new System.Drawing.Size(286, 34);
            this.MenuPX.Text = "Quản lý phiếu xuất";
            this.MenuPX.Click += new System.EventHandler(this.MenuPX_Click);
            // 
            // Menu_NV
            // 
            this.Menu_NV.Name = "Menu_NV";
            this.Menu_NV.Size = new System.Drawing.Size(286, 34);
            this.Menu_NV.Text = "Quản lý nhân viên";
            this.Menu_NV.Click += new System.EventHandler(this.Menu_NV_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DoAn1_Copy.Properties.Resources.hinh_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Resize += new System.EventHandler(this.frmMenu_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_SP;
        private System.Windows.Forms.ToolStripMenuItem Menu_NCC;
        private System.Windows.Forms.ToolStripMenuItem Menu_DVT;
        private System.Windows.Forms.ToolStripMenuItem Menu_KH;
        private System.Windows.Forms.ToolStripMenuItem Menu_PN;
        private System.Windows.Forms.ToolStripMenuItem MenuPX;
        private System.Windows.Forms.ToolStripMenuItem Menu_NV;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}