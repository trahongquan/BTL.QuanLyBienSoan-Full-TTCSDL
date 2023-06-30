namespace BTL.QuanLyBienSoan
{
    partial class frmLoaiTaiLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiTaiLieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenLTL = new System.Windows.Forms.TextBox();
            this.txtMaLTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgLoaiTL = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuuLTL = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemLTL = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaLTL = new System.Windows.Forms.Button();
            this.btnXoaLTL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiTL)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenLTL);
            this.panel1.Controls.Add(this.txtMaLTL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 0;
            // 
            // txtTenLTL
            // 
            this.txtTenLTL.Location = new System.Drawing.Point(158, 88);
            this.txtTenLTL.Name = "txtTenLTL";
            this.txtTenLTL.Size = new System.Drawing.Size(139, 20);
            this.txtTenLTL.TabIndex = 31;
            // 
            // txtMaLTL
            // 
            this.txtMaLTL.Location = new System.Drawing.Point(158, 60);
            this.txtMaLTL.Name = "txtMaLTL";
            this.txtMaLTL.Size = new System.Drawing.Size(139, 20);
            this.txtMaLTL.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên  loại tài liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã loại tài liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "DANH MỤC LOẠI TÀI LIỆU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgLoaiTL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 311);
            this.panel2.TabIndex = 1;
            // 
            // dtgLoaiTL
            // 
            this.dtgLoaiTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoaiTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLoaiTL.Location = new System.Drawing.Point(0, 0);
            this.dtgLoaiTL.Name = "dtgLoaiTL";
            this.dtgLoaiTL.Size = new System.Drawing.Size(800, 311);
            this.dtgLoaiTL.TabIndex = 0;
            this.dtgLoaiTL.Click += new System.EventHandler(this.dtgLoaiTL_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuuLTL);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.btnThemLTL);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnSuaLTL);
            this.panel3.Controls.Add(this.btnXoaLTL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 63);
            this.panel3.TabIndex = 2;
            // 
            // btnLuuLTL
            // 
            this.btnLuuLTL.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuLTL.Image")));
            this.btnLuuLTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuLTL.Location = new System.Drawing.Point(404, 20);
            this.btnLuuLTL.Name = "btnLuuLTL";
            this.btnLuuLTL.Size = new System.Drawing.Size(119, 23);
            this.btnLuuLTL.TabIndex = 11;
            this.btnLuuLTL.Text = "Lưu loại tài liệu";
            this.btnLuuLTL.UseVisualStyleBackColor = true;
            this.btnLuuLTL.Click += new System.EventHandler(this.btnLuuLTL_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(658, 20);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(119, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThemLTL
            // 
            this.btnThemLTL.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLTL.Image")));
            this.btnThemLTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLTL.Location = new System.Drawing.Point(23, 20);
            this.btnThemLTL.Name = "btnThemLTL";
            this.btnThemLTL.Size = new System.Drawing.Size(119, 23);
            this.btnThemLTL.TabIndex = 10;
            this.btnThemLTL.Text = "Thêm loại tài liệu";
            this.btnThemLTL.UseVisualStyleBackColor = true;
            this.btnThemLTL.Click += new System.EventHandler(this.btnThemLTL_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(531, 20);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaLTL
            // 
            this.btnSuaLTL.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLTL.Image")));
            this.btnSuaLTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLTL.Location = new System.Drawing.Point(150, 20);
            this.btnSuaLTL.Name = "btnSuaLTL";
            this.btnSuaLTL.Size = new System.Drawing.Size(119, 23);
            this.btnSuaLTL.TabIndex = 9;
            this.btnSuaLTL.Text = "Sửa loại tài liệu";
            this.btnSuaLTL.UseVisualStyleBackColor = true;
            this.btnSuaLTL.Click += new System.EventHandler(this.btnSuaLTL_Click);
            // 
            // btnXoaLTL
            // 
            this.btnXoaLTL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLTL.Image")));
            this.btnXoaLTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLTL.Location = new System.Drawing.Point(277, 20);
            this.btnXoaLTL.Name = "btnXoaLTL";
            this.btnXoaLTL.Size = new System.Drawing.Size(119, 23);
            this.btnXoaLTL.TabIndex = 8;
            this.btnXoaLTL.Text = "Xóa loại tài liệu";
            this.btnXoaLTL.UseVisualStyleBackColor = true;
            this.btnXoaLTL.Click += new System.EventHandler(this.btnXoaLTL_Click);
            // 
            // frmLoaiTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoaiTaiLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI TÀI LIỆU";
            this.Load += new System.EventHandler(this.frmLoaiTaiLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiTL)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenLTL;
        private System.Windows.Forms.TextBox txtMaLTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLoaiTL;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemLTL;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSuaLTL;
        private System.Windows.Forms.Button btnXoaLTL;
        private System.Windows.Forms.Button btnLuuLTL;
    }
}