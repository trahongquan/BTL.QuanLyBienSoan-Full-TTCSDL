namespace BTL.QuanLyBienSoan
{
    partial class ThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtxtTK = new System.Windows.Forms.ComboBox();
            this.cbtxtNam = new System.Windows.Forms.ComboBox();
            this.cbtxtKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtxtTG = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtKP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgTK = new System.Windows.Forms.DataGridView();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.txtKP);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.cbtxtTG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbtxtKhoa);
            this.panel1.Controls.Add(this.cbtxtNam);
            this.panel1.Controls.Add(this.cbtxtTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 166);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 284);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn kiểu thống kê";
            // 
            // cbtxtTK
            // 
            this.cbtxtTK.FormattingEnabled = true;
            this.cbtxtTK.Items.AddRange(new object[] {
            "Theo Năm",
            "Theo Khoa",
            "Theo tác giả",
            "Tất cả"});
            this.cbtxtTK.Location = new System.Drawing.Point(122, 37);
            this.cbtxtTK.Name = "cbtxtTK";
            this.cbtxtTK.Size = new System.Drawing.Size(121, 21);
            this.cbtxtTK.TabIndex = 1;
            this.cbtxtTK.SelectedIndexChanged += new System.EventHandler(this.cbtxtTK_SelectedIndexChanged);
            // 
            // cbtxtNam
            // 
            this.cbtxtNam.FormattingEnabled = true;
            this.cbtxtNam.Location = new System.Drawing.Point(268, 37);
            this.cbtxtNam.Name = "cbtxtNam";
            this.cbtxtNam.Size = new System.Drawing.Size(121, 21);
            this.cbtxtNam.TabIndex = 2;
            this.cbtxtNam.SelectedIndexChanged += new System.EventHandler(this.cbtxtNam_SelectedIndexChanged);
            // 
            // cbtxtKhoa
            // 
            this.cbtxtKhoa.FormattingEnabled = true;
            this.cbtxtKhoa.Location = new System.Drawing.Point(268, 65);
            this.cbtxtKhoa.Name = "cbtxtKhoa";
            this.cbtxtKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbtxtKhoa.TabIndex = 3;
            this.cbtxtKhoa.SelectedIndexChanged += new System.EventHandler(this.cbtxtKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng tài liệu";
            // 
            // cbtxtTG
            // 
            this.cbtxtTG.FormattingEnabled = true;
            this.cbtxtTG.Location = new System.Drawing.Point(268, 92);
            this.cbtxtTG.Name = "cbtxtTG";
            this.cbtxtTG.Size = new System.Drawing.Size(121, 21);
            this.cbtxtTG.TabIndex = 5;
            this.cbtxtTG.SelectedIndexChanged += new System.EventHandler(this.cbtxtTG_SelectedIndexChanged);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(608, 37);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 6;
            // 
            // txtKP
            // 
            this.txtKP.Location = new System.Drawing.Point(608, 66);
            this.txtKP.Name = "txtKP";
            this.txtKP.Size = new System.Drawing.Size(100, 20);
            this.txtKP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng kinh phí";
            // 
            // dtgTK
            // 
            this.dtgTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTK.Location = new System.Drawing.Point(0, 0);
            this.dtgTK.Name = "dtgTK";
            this.dtgTK.Size = new System.Drawing.Size(1014, 284);
            this.dtgTK.TabIndex = 0;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(407, 92);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(100, 20);
            this.txtTG.TabIndex = 7;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbtxtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbtxtKhoa;
        private System.Windows.Forms.ComboBox cbtxtNam;
        private System.Windows.Forms.ComboBox cbtxtTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgTK;
        private System.Windows.Forms.TextBox txtTG;
    }
}