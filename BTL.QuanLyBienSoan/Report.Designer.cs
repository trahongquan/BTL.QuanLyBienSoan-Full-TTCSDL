namespace BTL.QuanLyBienSoan
{
    partial class Report
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
            this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtxtNam = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBaoCaoChiTiet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpv
            // 
            this.rpv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv.LocalReport.ReportEmbeddedResource = "BTL.QuanLyBienSoan.Report1.rdlc";
            this.rpv.Location = new System.Drawing.Point(0, 0);
            this.rpv.Name = "rpv";
            this.rpv.ServerReport.BearerToken = null;
            this.rpv.Size = new System.Drawing.Size(800, 350);
            this.rpv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoCaoChiTiet);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbtxtNam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(479, 31);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn năm báo cáo";
            // 
            // cbtxtNam
            // 
            this.cbtxtNam.FormattingEnabled = true;
            this.cbtxtNam.Location = new System.Drawing.Point(331, 31);
            this.cbtxtNam.Name = "cbtxtNam";
            this.cbtxtNam.Size = new System.Drawing.Size(121, 21);
            this.cbtxtNam.TabIndex = 0;
            this.cbtxtNam.SelectedIndexChanged += new System.EventHandler(this.cbtxt_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rpv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnBaoCaoChiTiet
            // 
            this.btnBaoCaoChiTiet.Location = new System.Drawing.Point(582, 31);
            this.btnBaoCaoChiTiet.Name = "btnBaoCaoChiTiet";
            this.btnBaoCaoChiTiet.Size = new System.Drawing.Size(96, 23);
            this.btnBaoCaoChiTiet.TabIndex = 3;
            this.btnBaoCaoChiTiet.Text = "Báo cáo chi tiết";
            this.btnBaoCaoChiTiet.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtxtNam;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnBaoCaoChiTiet;
    }
}