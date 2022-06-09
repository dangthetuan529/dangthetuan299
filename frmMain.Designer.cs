namespace BTL_Nhom1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTheMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoSoMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.HoSoTra = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTongTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mãThẻToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDanhSachHSMtheoTM = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mãHSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTimKiemThuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thủThưToolStripMenuItem,
            this.thẻMượnToolStripMenuItem,
            this.hồSơMượnToolStripMenuItem,
            this.hồSơTrảToolStripMenuItem,
            this.btnDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThuThu,
            this.tsSach,
            this.tsTheMuon,
            this.tsNXB});
            this.thủThưToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thủThưToolStripMenuItem.Image")));
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.thủThưToolStripMenuItem.Text = "Danh mục";
            // 
            // tsThuThu
            // 
            this.tsThuThu.Name = "tsThuThu";
            this.tsThuThu.Size = new System.Drawing.Size(195, 34);
            this.tsThuThu.Text = "Thủ thư";
            // 
            // tsSach
            // 
            this.tsSach.Name = "tsSach";
            this.tsSach.Size = new System.Drawing.Size(195, 34);
            this.tsSach.Text = "Sách";
            this.tsSach.Click += new System.EventHandler(this.tsSach_Click);
            // 
            // tsTheMuon
            // 
            this.tsTheMuon.Name = "tsTheMuon";
            this.tsTheMuon.Size = new System.Drawing.Size(195, 34);
            this.tsTheMuon.Text = "Thẻ mượn";
            this.tsTheMuon.Click += new System.EventHandler(this.tsTheMuon_Click);
            // 
            // tsNXB
            // 
            this.tsNXB.Name = "tsNXB";
            this.tsNXB.Size = new System.Drawing.Size(195, 34);
            this.tsNXB.Text = "NXB";
            // 
            // thẻMượnToolStripMenuItem
            // 
            this.thẻMượnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HoSoMuon,
            this.HoSoTra});
            this.thẻMượnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thẻMượnToolStripMenuItem.Image")));
            this.thẻMượnToolStripMenuItem.Name = "thẻMượnToolStripMenuItem";
            this.thẻMượnToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.thẻMượnToolStripMenuItem.Text = "Hồ sơ";
            // 
            // HoSoMuon
            // 
            this.HoSoMuon.Name = "HoSoMuon";
            this.HoSoMuon.Size = new System.Drawing.Size(215, 34);
            this.HoSoMuon.Text = "Hồ sơ mượn";
            this.HoSoMuon.Click += new System.EventHandler(this.HoSoMuon_Click);
            // 
            // HoSoTra
            // 
            this.HoSoTra.Name = "HoSoTra";
            this.HoSoTra.Size = new System.Drawing.Size(215, 34);
            this.HoSoTra.Text = "Hồ sơ trả";
            this.HoSoTra.Click += new System.EventHandler(this.HoSoTra_Click);
            // 
            // hồSơMượnToolStripMenuItem
            // 
            this.hồSơMượnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTongTien,
            this.mãThẻToolStripMenuItem1,
            this.tsDanhSachHSMtheoTM});
            this.hồSơMượnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hồSơMượnToolStripMenuItem.Image")));
            this.hồSơMượnToolStripMenuItem.Name = "hồSơMượnToolStripMenuItem";
            this.hồSơMượnToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.hồSơMượnToolStripMenuItem.Text = "Báo cáo";
            // 
            // tsTongTien
            // 
            this.tsTongTien.Name = "tsTongTien";
            this.tsTongTien.Size = new System.Drawing.Size(480, 34);
            this.tsTongTien.Text = "Tổng tiền thu được theo tháng quý năm";
            this.tsTongTien.Click += new System.EventHandler(this.mãHSMToolStripMenuItem_Click);
            // 
            // mãThẻToolStripMenuItem1
            // 
            this.mãThẻToolStripMenuItem1.Name = "mãThẻToolStripMenuItem1";
            this.mãThẻToolStripMenuItem1.Size = new System.Drawing.Size(480, 34);
            this.mãThẻToolStripMenuItem1.Text = "Danh sách các sách đang được mượn chưa trả";
            // 
            // tsDanhSachHSMtheoTM
            // 
            this.tsDanhSachHSMtheoTM.Name = "tsDanhSachHSMtheoTM";
            this.tsDanhSachHSMtheoTM.Size = new System.Drawing.Size(480, 34);
            this.tsDanhSachHSMtheoTM.Text = "Danh sách hồ sơ mượn theo thẻ mượn";
            this.tsDanhSachHSMtheoTM.Click += new System.EventHandler(this.tsDanhSachHSMtheoTM_Click);
            // 
            // hồSơTrảToolStripMenuItem
            // 
            this.hồSơTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mãHSTToolStripMenuItem,
            this.tsTimKiemThuThu});
            this.hồSơTrảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hồSơTrảToolStripMenuItem.Image")));
            this.hồSơTrảToolStripMenuItem.Name = "hồSơTrảToolStripMenuItem";
            this.hồSơTrảToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.hồSơTrảToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // mãHSTToolStripMenuItem
            // 
            this.mãHSTToolStripMenuItem.Name = "mãHSTToolStripMenuItem";
            this.mãHSTToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.mãHSTToolStripMenuItem.Text = "Sách";
            // 
            // tsTimKiemThuThu
            // 
            this.tsTimKiemThuThu.Name = "tsTimKiemThuThu";
            this.tsTimKiemThuThu.Size = new System.Drawing.Size(175, 34);
            this.tsTimKiemThuThu.Text = "Thủ thư";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(136, 29);
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 508);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Thư Viện ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsThuThu;
        private System.Windows.Forms.ToolStripMenuItem tsSach;
        private System.Windows.Forms.ToolStripMenuItem tsTheMuon;
        private System.Windows.Forms.ToolStripMenuItem tsNXB;
        private System.Windows.Forms.ToolStripMenuItem thẻMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoSoMuon;
        private System.Windows.Forms.ToolStripMenuItem HoSoTra;
        private System.Windows.Forms.ToolStripMenuItem hồSơMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTongTien;
        private System.Windows.Forms.ToolStripMenuItem mãThẻToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsDanhSachHSMtheoTM;
        private System.Windows.Forms.ToolStripMenuItem hồSơTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mãHSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTimKiemThuThu;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
    }
}