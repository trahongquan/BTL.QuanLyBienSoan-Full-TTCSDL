using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.QuanLyBienSoan
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string sql;
            this.rpv.RefreshReport();
            sql = "SELECT DISTINCT NamNghiemThu FROM TaiLieuBienSoan ORDER BY NamNghiemThu";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtNam, "NamNghiemThu");
            cbtxtNam.SelectedIndex = -1;
            this.rpv.RefreshReport();
        }

        private void cbtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaTaiLieu,TenTaiLieu,MaLoai,MaHocPhan,MaKHoa,KinhPhi,GhiChu FROM TaiLieuBienSoan WHERE NamNghiemThu = '" + cbtxtNam.Text + "'";
            DataTable dt = new DataTable();
            dt = ChucNang.TaiDuLieuVaoBang(sql);
            rpv.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rpv.LocalReport.ReportPath = @"D:\1. HOC TAP\1. LOP CNTT12\12. CO SO DU LIEU\BTL.QuanLyBienSoan\Report1.rdlc";
            rpv.LocalReport.DataSources.Add(rds);
            rpv.RefreshReport();
        }
    }
}
