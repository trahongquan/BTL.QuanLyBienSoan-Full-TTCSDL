namespace BTL.QuanLyBienSoan
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
            this.MenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDMLTL = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuDMTL = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuDSTG = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuDSK = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuDSTL = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDSHP = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDMCBTG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subMenuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeThong,
            this.MenuDM,
            this.MenuGioiThieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHeThong
            // 
            this.MenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuBaoCao,
            this.subMenuThongKe,
            this.SubMenuDangXuat,
            this.SubMenuExit});
            this.MenuHeThong.Name = "MenuHeThong";
            this.MenuHeThong.Size = new System.Drawing.Size(69, 20);
            this.MenuHeThong.Text = "Hệ thống";
            // 
            // subMenuBaoCao
            // 
            this.subMenuBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("subMenuBaoCao.Image")));
            this.subMenuBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuBaoCao.Name = "subMenuBaoCao";
            this.subMenuBaoCao.Size = new System.Drawing.Size(180, 22);
            this.subMenuBaoCao.Text = "Báo cáo";
            this.subMenuBaoCao.Click += new System.EventHandler(this.subMenuBaoCao_Click);
            // 
            // SubMenuDangXuat
            // 
            this.SubMenuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuDangXuat.Image")));
            this.SubMenuDangXuat.Name = "SubMenuDangXuat";
            this.SubMenuDangXuat.Size = new System.Drawing.Size(180, 22);
            this.SubMenuDangXuat.Text = "Đăng xuất tài khoản";
            this.SubMenuDangXuat.Click += new System.EventHandler(this.SubMenuDangXuat_Click);
            // 
            // SubMenuExit
            // 
            this.SubMenuExit.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuExit.Image")));
            this.SubMenuExit.Name = "SubMenuExit";
            this.SubMenuExit.Size = new System.Drawing.Size(180, 22);
            this.SubMenuExit.Text = "Thoát";
            this.SubMenuExit.Click += new System.EventHandler(this.SubMenuExit_Click);
            // 
            // MenuDM
            // 
            this.MenuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDMLTL,
            this.SubMenuDMTL,
            this.SubMenuDSTG,
            this.SubMenuDSK,
            this.SubMenuDSTL,
            this.subMenuDSHP,
            this.subMenuDMCBTG});
            this.MenuDM.Name = "MenuDM";
            this.MenuDM.Size = new System.Drawing.Size(74, 20);
            this.MenuDM.Text = "Danh mục";
            // 
            // subMenuDMLTL
            // 
            this.subMenuDMLTL.Image = ((System.Drawing.Image)(resources.GetObject("subMenuDMLTL.Image")));
            this.subMenuDMLTL.Name = "subMenuDMLTL";
            this.subMenuDMLTL.Size = new System.Drawing.Size(243, 22);
            this.subMenuDMLTL.Text = "Danh mục loại tài liệu";
            this.subMenuDMLTL.Click += new System.EventHandler(this.subMenuDMLTL_Click);
            // 
            // SubMenuDMTL
            // 
            this.SubMenuDMTL.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuDMTL.Image")));
            this.SubMenuDMTL.Name = "SubMenuDMTL";
            this.SubMenuDMTL.Size = new System.Drawing.Size(243, 22);
            this.SubMenuDMTL.Text = "Danh mục tài liệu";
            this.SubMenuDMTL.Click += new System.EventHandler(this.SubMenuDMTL_Click);
            // 
            // SubMenuDSTG
            // 
            this.SubMenuDSTG.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuDSTG.Image")));
            this.SubMenuDSTG.Name = "SubMenuDSTG";
            this.SubMenuDSTG.Size = new System.Drawing.Size(243, 22);
            this.SubMenuDSTG.Text = "Danh sách tác giả";
            this.SubMenuDSTG.Click += new System.EventHandler(this.SubMenuDSTG_Click);
            // 
            // SubMenuDSK
            // 
            this.SubMenuDSK.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuDSK.Image")));
            this.SubMenuDSK.Name = "SubMenuDSK";
            this.SubMenuDSK.Size = new System.Drawing.Size(243, 22);
            this.SubMenuDSK.Text = "Danh sách khoa";
            this.SubMenuDSK.Click += new System.EventHandler(this.SubMenuDSK_Click);
            // 
            // SubMenuDSTL
            // 
            this.SubMenuDSTL.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuDSTL.Image")));
            this.SubMenuDSTL.Name = "SubMenuDSTL";
            this.SubMenuDSTL.Size = new System.Drawing.Size(243, 22);
            this.SubMenuDSTL.Text = "Danh sách trợ lý";
            this.SubMenuDSTL.Click += new System.EventHandler(this.SubMenuDSTL_Click);
            // 
            // subMenuDSHP
            // 
            this.subMenuDSHP.Image = ((System.Drawing.Image)(resources.GetObject("subMenuDSHP.Image")));
            this.subMenuDSHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuDSHP.Name = "subMenuDSHP";
            this.subMenuDSHP.Size = new System.Drawing.Size(243, 22);
            this.subMenuDSHP.Text = "Danh sách học phần";
            this.subMenuDSHP.Click += new System.EventHandler(this.subMenuDSHP_Click);
            // 
            // subMenuDMCBTG
            // 
            this.subMenuDMCBTG.Image = ((System.Drawing.Image)(resources.GetObject("subMenuDMCBTG.Image")));
            this.subMenuDMCBTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuDMCBTG.Name = "subMenuDMCBTG";
            this.subMenuDMCBTG.Size = new System.Drawing.Size(243, 22);
            this.subMenuDMCBTG.Text = "Danh mục chủ biên và tham gia";
            this.subMenuDMCBTG.Click += new System.EventHandler(this.subMenuDMCBTG_Click);
            // 
            // MenuGioiThieu
            // 
            this.MenuGioiThieu.Name = "MenuGioiThieu";
            this.MenuGioiThieu.Size = new System.Drawing.Size(70, 20);
            this.MenuGioiThieu.Text = "Giới thiệu";
            this.MenuGioiThieu.Click += new System.EventHandler(this.MenuGioiThieu_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // subMenuThongKe
            // 
            this.subMenuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("subMenuThongKe.Image")));
            this.subMenuThongKe.Name = "subMenuThongKe";
            this.subMenuThongKe.Size = new System.Drawing.Size(180, 22);
            this.subMenuThongKe.Text = "Thống kê";
            this.subMenuThongKe.Click += new System.EventHandler(this.subMenuThongKe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH CHÍNH";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem SubMenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuDM;
        private System.Windows.Forms.ToolStripMenuItem subMenuDMLTL;
        private System.Windows.Forms.ToolStripMenuItem SubMenuDMTL;
        private System.Windows.Forms.ToolStripMenuItem SubMenuDSTG;
        private System.Windows.Forms.ToolStripMenuItem SubMenuDSK;
        private System.Windows.Forms.ToolStripMenuItem SubMenuDSTL;
        private System.Windows.Forms.ToolStripMenuItem MenuGioiThieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem SubMenuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem subMenuDSHP;
        private System.Windows.Forms.ToolStripMenuItem subMenuDMCBTG;
        private System.Windows.Forms.ToolStripMenuItem subMenuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem subMenuThongKe;
    }
}