namespace BTL.QuanLyBienSoan
{
    partial class HocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocPhan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimHP = new System.Windows.Forms.Button();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgHocPhan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuuHP = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemHP = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaHP = new System.Windows.Forms.Button();
            this.btnXoaHP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocPhan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimHP);
            this.panel1.Controls.Add(this.rtxtGhiChu);
            this.panel1.Controls.Add(this.txtSoTiet);
            this.panel1.Controls.Add(this.txtTenHP);
            this.panel1.Controls.Add(this.txtMaHP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnTimHP
            // 
            this.btnTimHP.Image = ((System.Drawing.Image)(resources.GetObject("btnTimHP.Image")));
            this.btnTimHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimHP.Location = new System.Drawing.Point(205, 140);
            this.btnTimHP.Name = "btnTimHP";
            this.btnTimHP.Size = new System.Drawing.Size(138, 23);
            this.btnTimHP.TabIndex = 60;
            this.btnTimHP.Text = "Tìm kiếm Học phần";
            this.btnTimHP.UseVisualStyleBackColor = true;
            this.btnTimHP.Click += new System.EventHandler(this.btnTimHP_Click);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(513, 60);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(168, 96);
            this.rtxtGhiChu.TabIndex = 59;
            this.rtxtGhiChu.Text = "";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(205, 114);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(100, 20);
            this.txtSoTiet.TabIndex = 58;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(205, 88);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(210, 20);
            this.txtTenHP.TabIndex = 55;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(205, 60);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(100, 20);
            this.txtMaHP.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Số tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tên học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(277, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "DANH SÁCH HỌC PHẦN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgHocPhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 270);
            this.panel2.TabIndex = 1;
            // 
            // dtgHocPhan
            // 
            this.dtgHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHocPhan.Location = new System.Drawing.Point(0, 0);
            this.dtgHocPhan.Name = "dtgHocPhan";
            this.dtgHocPhan.Size = new System.Drawing.Size(800, 270);
            this.dtgHocPhan.TabIndex = 0;
            this.dtgHocPhan.Click += new System.EventHandler(this.dtgHocPhan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuuHP);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.btnThemHP);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnSuaHP);
            this.panel3.Controls.Add(this.btnXoaHP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 64);
            this.panel3.TabIndex = 2;
            // 
            // btnLuuHP
            // 
            this.btnLuuHP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHP.Image")));
            this.btnLuuHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHP.Location = new System.Drawing.Point(421, 21);
            this.btnLuuHP.Name = "btnLuuHP";
            this.btnLuuHP.Size = new System.Drawing.Size(116, 23);
            this.btnLuuHP.TabIndex = 22;
            this.btnLuuHP.Text = "Lưu Học phần";
            this.btnLuuHP.UseVisualStyleBackColor = true;
            this.btnLuuHP.Click += new System.EventHandler(this.btnLuuHP_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(666, 21);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 23);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThemHP
            // 
            this.btnThemHP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHP.Image")));
            this.btnThemHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHP.Location = new System.Drawing.Point(29, 21);
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(121, 23);
            this.btnThemHP.TabIndex = 21;
            this.btnThemHP.Text = "Thêm Học phần";
            this.btnThemHP.UseVisualStyleBackColor = true;
            this.btnThemHP.Click += new System.EventHandler(this.btnThemHP_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(549, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 23);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaHP
            // 
            this.btnSuaHP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHP.Image")));
            this.btnSuaHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHP.Location = new System.Drawing.Point(162, 21);
            this.btnSuaHP.Name = "btnSuaHP";
            this.btnSuaHP.Size = new System.Drawing.Size(119, 23);
            this.btnSuaHP.TabIndex = 20;
            this.btnSuaHP.Text = "Sửa Học Phần";
            this.btnSuaHP.UseVisualStyleBackColor = true;
            this.btnSuaHP.Click += new System.EventHandler(this.btnSuaHP_Click);
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHP.Image")));
            this.btnXoaHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHP.Location = new System.Drawing.Point(293, 21);
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.Size = new System.Drawing.Size(116, 23);
            this.btnXoaHP.TabIndex = 19;
            this.btnXoaHP.Text = "Xóa Học phần";
            this.btnXoaHP.UseVisualStyleBackColor = true;
            this.btnXoaHP.Click += new System.EventHandler(this.btnXoaHP_Click);
            // 
            // HocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HocPhan";
            this.Load += new System.EventHandler(this.HocPhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocPhan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuHP;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemHP;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSuaHP;
        private System.Windows.Forms.Button btnXoaHP;
        private System.Windows.Forms.Button btnTimHP;
        private System.Windows.Forms.DataGridView dtgHocPhan;
    }
}