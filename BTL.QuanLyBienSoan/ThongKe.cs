using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL.QuanLyBienSoan
{
    public partial class ThongKe : Form
    {
        DataTable dtTK;
        string sql;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void cbtxtTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbtxtTK.Text == "Theo Năm")
            {
                cbtxtNam.Enabled = true; 
                cbtxtKhoa.Enabled = false; cbtxtKhoa.Text = "";
                cbtxtTG.Enabled = false; cbtxtTG.Text = "";
                txtTG.Enabled = false; txtTG.Text = "";
                sql = "SELECT DISTINCT NamNghiemThu FROM TaiLieuBienSoan ORDER BY NamNghiemThu";
                
                //Sửa lỗi khi fill combobox 2 vẫn đang fill combobox 1
                //Detach event
                cbtxtNam.SelectedIndexChanged -= cbtxtNam_SelectedIndexChanged;
                ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtNam, "NamNghiemThu");
                //Attach event again
                cbtxtNam.SelectedIndexChanged += cbtxtNam_SelectedIndexChanged;
                                
                cbtxtNam.SelectedIndex = -1;
            }                
            else if (cbtxtTK.Text == "Theo Khoa")
            {
                cbtxtNam.Enabled = false; cbtxtNam.Text = "";
                cbtxtKhoa.Enabled = true;
                cbtxtTG.Enabled = false; cbtxtTG.Text = "";
                txtTG.Enabled = false; txtTG.Text = "";
                sql = "SELECT MaKhoa FROM Khoa";
                ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtKhoa, "MaKhoa");
                cbtxtKhoa.SelectedIndex = -1;
            }
            else if (cbtxtTK.Text == "Theo tác giả")
            {
                cbtxtNam.Enabled = false; cbtxtNam.Text = "";
                cbtxtKhoa.Enabled = false; cbtxtKhoa.Text = "";
                cbtxtTG.Enabled = true;
                txtTG.Enabled = true;
                sql = "SELECT TenTacGia FROM TacGia";
                ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtTG, "TenTacGia");
                cbtxtTG.SelectedIndex = -1;                
            }
            else if (cbtxtTK.Text == "Tất cả")
            {
                cbtxtNam.Enabled = false; cbtxtNam.Text = "";
                cbtxtKhoa.Enabled = false; cbtxtKhoa.Text = "";
                cbtxtTG.Enabled = false; cbtxtTG.Text = "";
                txtTG.Enabled = false; txtTG.Text = "";
                
                txtKP.Text = KinhPhiTheoTatCa().ToString("N0");
                txtSL.Text = dtgTK.RowCount.ToString();
            }

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbtxtTK.SelectedIndex = -1;
            cbtxtNam.SelectedIndex = -1;
            cbtxtKhoa.SelectedIndex = -1;
            cbtxtTG.SelectedIndex = -1;
            TaiDuLieuVaoGridView();
        }

        private void cbtxtNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKP.Text = KinhPhiTheoNam().ToString("N0");
            txtSL.Text = dtgTK.RowCount.ToString();
        }

        private void cbtxtKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKP.Text = KinhPhiTheoKhoa().ToString("N0");
            txtSL.Text = dtgTK.RowCount.ToString();
        }

        private void cbtxtTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT MaTacGia FROM TacGia WHERE TenTacGia=N'" + cbtxtTG.Text + "'";
            txtTG.Text = ChucNang.LayDuLieuTuSQL(sql);
            txtKP.Text = KinhPhiTheoTacGia().ToString("N0");
            txtSL.Text = dtgTK.RowCount.ToString();
        }

        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT TL.MaTaiLieu, TenTaiLieu, TenLoai, TenTacGia, NhiemVu, TK.MaKhoa, NamNghiemThu, KinhPhi" 
                + " FROM TaiLieuBienSoan AS TL, LoaiTaiLieu AS LTL, TacGia AS TG, TacGia_TaiLieu AS TGTL, Khoa AS TK" 
                + " WHERE TL.MaTaiLieu = TGTL.MaTaiLieu AND TG.MaTacGia = TGTL.MaTacGia"
                + " AND LTL.MaLoai = TL.MaLoai AND TL.MaKhoa = TK.MaKhoa AND TG.MaKhoa = TK.MaKhoa"
                + " AND NhiemVu = N'Chủ biên'"
                + " ORDER BY TL.MaTaiLieu";
            dtTK = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgTK.DataSource = dtTK; //Nguồn dữ liệu            
            dtgTK.Columns[0].HeaderText = "Mã tài liệu";
            dtgTK.Columns[1].HeaderText = "Tên tài liệu";
            dtgTK.Columns[2].HeaderText = "Loại tài liệu";
            dtgTK.Columns[3].HeaderText = "Tên tác giả";
            dtgTK.Columns[4].HeaderText = "Nhiệm vụ";
            dtgTK.Columns[5].HeaderText = "Mã khoa";
            dtgTK.Columns[6].HeaderText = "Năm nghiệm thu";
            dtgTK.Columns[7].HeaderText = "Kinh phí";

            dtgTK.Columns[0].Width = 80;
            dtgTK.Columns[1].Width = 150;
            dtgTK.Columns[2].Width = 120;
            dtgTK.Columns[3].Width = 120;
            dtgTK.Columns[4].Width = 120;
            dtgTK.Columns[5].Width = 80;
            dtgTK.Columns[6].Width = 80;
            dtgTK.Columns[7].Width = 100;

            dtgTK.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgTK.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void XoaDuLieuTextBox()
        {
            cbtxtTK.Text = "";
            cbtxtNam.Text = "";
            cbtxtKhoa.Text = "";
            cbtxtTG.Text = "";
            txtSL.Text = "";
            txtKP.Text = "";
        }

        private int KinhPhiTheoNam()
        {
            int kp = 0;
            string sql;
            sql = "SELECT TL.MaTaiLieu, TenTaiLieu, TenLoai, TenTacGia, NhiemVu, TK.MaKhoa, NamNghiemThu, KinhPhi"
                + " FROM TaiLieuBienSoan AS TL, LoaiTaiLieu AS LTL, TacGia AS TG, TacGia_TaiLieu AS TGTL, Khoa AS TK"
                + " WHERE TL.MaTaiLieu = TGTL.MaTaiLieu AND TG.MaTacGia = TGTL.MaTacGia"
                + " AND LTL.MaLoai = TL.MaLoai AND TL.MaKhoa = TK.MaKhoa AND TG.MaKhoa = TK.MaKhoa"
                + " AND NhiemVu = N'Chủ biên' AND NamNghiemThu = N'" + cbtxtNam.Text + "'";
                //+ " ORDER BY TL.MaTaiLieu";
            //sql = "SELECT KinhPhi from TaiLieuBienSoan WHERE NamNghiemThu = " + cbtxtNam.Text;
            dtTK = ChucNang.TaiDuLieuVaoBang(sql);
            dtgTK.DataSource = dtTK;
            for (int i = 0; i < dtgTK.Rows.Count; i++)
                kp = kp + int.Parse(dtgTK.Rows[i].Cells[7].Value.ToString());
            return kp;
        }

        private int KinhPhiTheoKhoa()
        {
            int kp = 0;
            string sql;
            sql = "SELECT TL.MaTaiLieu, TenTaiLieu, TenLoai, TenTacGia, NhiemVu, TK.MaKhoa, NamNghiemThu, KinhPhi"
                + " FROM TaiLieuBienSoan AS TL, LoaiTaiLieu AS LTL, TacGia AS TG, TacGia_TaiLieu AS TGTL, Khoa AS TK"
                + " WHERE TL.MaTaiLieu = TGTL.MaTaiLieu AND TG.MaTacGia = TGTL.MaTacGia"
                + " AND LTL.MaLoai = TL.MaLoai AND TL.MaKhoa = TK.MaKhoa AND TG.MaKhoa = TK.MaKhoa"
                + " AND NhiemVu = N'Chủ biên' AND TL.MaKhoa = '" + cbtxtKhoa.Text + "'"
                + " ORDER BY TL.MaTaiLieu";
            //sql = "SELECT KinhPhi from TaiLieuBienSoan WHERE MaKhoa = '" + cbtxtKhoa.Text + "'";
            dtTK = ChucNang.TaiDuLieuVaoBang(sql);
            dtgTK.DataSource = dtTK;
            for (int i = 0; i < dtgTK.Rows.Count; i++)
                kp = kp + int.Parse(dtgTK.Rows[i].Cells[7].Value.ToString());
            return kp;
        }

        private int KinhPhiTheoTacGia()
        { 
            int kp = 0;
            string sql;
            sql = "SELECT TL.MaTaiLieu, TenTaiLieu, TenLoai, TenTacGia, NhiemVu, TK.MaKhoa, NamNghiemThu, KinhPhi"
                + " FROM TaiLieuBienSoan AS TL, LoaiTaiLieu AS LTL, TacGia AS TG, TacGia_TaiLieu AS TGTL, Khoa AS TK"
                + " WHERE TGTL.MaTacGia = TG.MaTacGia AND LTL.MaLoai = TL.MaLoai"
                + " AND TL.MaTaiLieu = TGTL.MaTaiLieu AND TG.MaKhoa = TK.MaKhoa"
                + " AND TGTL.MaTacGia = '" + txtTG.Text + "'"
                + " ORDER BY TL.MaTaiLieu";
            //sql = "SELECT KinhPhi from TaiLieuBienSoan WHERE MaKhoa = '" + cbtxtKhoa.Text + "'";
            dtTK = ChucNang.TaiDuLieuVaoBang(sql);
            dtgTK.DataSource = dtTK;
            for (int i = 0; i < dtgTK.Rows.Count; i++)
                kp = kp + int.Parse(dtgTK.Rows[i].Cells[7].Value.ToString());
            return kp;
        }

        private int KinhPhiTheoTatCa()
        {
            int kp = 0;
            string sql;
            sql = "SELECT TL.MaTaiLieu, TenTaiLieu, TenLoai, TenTacGia, NhiemVu, TK.MaKhoa, NamNghiemThu, KinhPhi"
                + " FROM TaiLieuBienSoan AS TL, LoaiTaiLieu AS LTL, TacGia AS TG, TacGia_TaiLieu AS TGTL, Khoa AS TK"
                + " WHERE TL.MaTaiLieu = TGTL.MaTaiLieu AND TG.MaTacGia = TGTL.MaTacGia"
                + " AND LTL.MaLoai = TL.MaLoai AND TL.MaKhoa = TK.MaKhoa AND TG.MaKhoa = TK.MaKhoa"
                + " AND NhiemVu = N'Chủ biên'"
                + " ORDER BY TL.MaTaiLieu";
            //sql = "SELECT KinhPhi from TaiLieuBienSoan WHERE NamNghiemThu = " + cbtxtNam.Text;
            dtTK = ChucNang.TaiDuLieuVaoBang(sql);
            dtgTK.DataSource = dtTK;
            for (int i = 0; i < dtgTK.Rows.Count; i++)
                kp = kp + int.Parse(dtgTK.Rows[i].Cells[7].Value.ToString());
            return kp;
        }
    }
}
