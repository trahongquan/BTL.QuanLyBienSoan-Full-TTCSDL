namespace BTL.QuanLyBienSoan
{
    partial class ReportDetail
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
            this.txtTG = new System.Windows.Forms.TextBox();
            this.cbtxtTG = new System.Windows.Forms.ComboBox();
            this.cbtxtKhoa = new System.Windows.Forms.ComboBox();
            this.cbtxtNam = new System.Windows.Forms.ComboBox();
            this.cbtxtTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.cbtxtTG);
            this.panel1.Controls.Add(this.cbtxtKhoa);
            this.panel1.Controls.Add(this.cbtxtNam);
            this.panel1.Controls.Add(this.cbtxtTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 329);
            this.panel2.TabIndex = 1;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(448, 81);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(100, 20);
            this.txtTG.TabIndex = 13;
            // 
            // cbtxtTG
            // 
            this.cbtxtTG.FormattingEnabled = true;
            this.cbtxtTG.Location = new System.Drawing.Point(309, 81);
            this.cbtxtTG.Name = "cbtxtTG";
            this.cbtxtTG.Size = new System.Drawing.Size(121, 21);
            this.cbtxtTG.TabIndex = 12;
            // 
            // cbtxtKhoa
            // 
            this.cbtxtKhoa.FormattingEnabled = true;
            this.cbtxtKhoa.Location = new System.Drawing.Point(309, 54);
            this.cbtxtKhoa.Name = "cbtxtKhoa";
            this.cbtxtKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbtxtKhoa.TabIndex = 11;
            // 
            // cbtxtNam
            // 
            this.cbtxtNam.FormattingEnabled = true;
            this.cbtxtNam.Location = new System.Drawing.Point(309, 26);
            this.cbtxtNam.Name = "cbtxtNam";
            this.cbtxtNam.Size = new System.Drawing.Size(121, 21);
            this.cbtxtNam.TabIndex = 10;
            // 
            // cbtxtTK
            // 
            this.cbtxtTK.FormattingEnabled = true;
            this.cbtxtTK.Items.AddRange(new object[] {
            "Theo Năm",
            "Theo Khoa",
            "Theo tác giả",
            "Tất cả"});
            this.cbtxtTK.Location = new System.Drawing.Point(163, 26);
            this.cbtxtTK.Name = "cbtxtTK";
            this.cbtxtTK.Size = new System.Drawing.Size(121, 21);
            this.cbtxtTK.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn kiểu báo cáo";
            // 
            // ReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportDetail";
            this.Text = "ReportDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.ComboBox cbtxtTG;
        private System.Windows.Forms.ComboBox cbtxtKhoa;
        private System.Windows.Forms.ComboBox cbtxtNam;
        private System.Windows.Forms.ComboBox cbtxtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}