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
    public partial class frmTaiLieu : Form
    {
        DataTable dtTL;
        public frmTaiLieu()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
            btnThemTL.Enabled = true;
            btnXoaTL.Enabled = true;
            btnSuaTL.Enabled = true;
            btnLuuTL.Enabled = false;
            txtMaTL.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            btnSuaTL.Enabled = false;
            btnXoaTL.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuTL.Enabled = true;
            btnThemTL.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaTL.Enabled = true; //cho phép nhập mới
            txtMaTL.Focus();
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTL.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaTL.Text.Trim().Length == 0) || (txtTenTL.Text.Trim().Length == 0) || (cbtxtMaLoai.Text.Trim().Length == 0)
                || (cbtxtMaHP.Text.Trim().Length == 0) || (cbtxtMaKhoa.Text.Trim().Length == 0) || (cbtxtMaTroLy.Text.Trim().Length == 0)
                || (txtNamNT.Text.Trim().Length == 0) || (txtKinhPhi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTL.Focus();
                return;
            }
            sql = "UPDATE TaiLieuBienSoan SET TenTaiLieu=N'" + txtTenTL.Text.ToString() + "',MaLoai=N'" + txtMaLoai.Text.ToString() 
                + "',MaHocPhan=N'" + txtMaHP.Text.ToString() + "',MaKhoa=N'" + cbtxtMaKhoa.Text.ToString()
                + "',MaTroLy=N'" + txtMaTroLy.Text.ToString() + "',NamNghiemThu=N'" + txtNamNT.Text.Trim()
                + "',KinhPhi=N'" + txtKinhPhi.Text.Trim() + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaTaiLieu=N'" + txtMaTL.Text.ToString().Trim() + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTL.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TaiLieuBienSoan WHERE MaTaiLieu=N'" + txtMaTL.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaTL.Text.Trim().Length == 0) || (txtTenTL.Text.Trim().Length == 0) || (cbtxtMaLoai.Text.Trim().Length == 0)
                || (cbtxtMaHP.Text.Trim().Length == 0) || (cbtxtMaKhoa.Text.Trim().Length == 0) || (cbtxtMaTroLy.Text.Trim().Length == 0)
                || (txtNamNT.Text.Trim().Length == 0) || (txtKinhPhi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTL.Focus();
                return;
            }

            sql = "Select MaTaiLieu From TaiLieuBienSoan where MaTaiLieu=N'" + txtMaTL.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã tài liệu này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTL.Focus();
                return;
            }

            sql = "INSERT INTO TaiLieuBienSoan VALUES(N'" + txtMaTL.Text.ToString().Trim() + "',N'" + txtTenTL.Text + "',N'" + txtMaLoai.Text 
                + "',N'" + txtMaHP.Text + "',N'" + cbtxtMaKhoa.Text + "',N'" + txtMaTroLy.Text + "',N'" + txtNamNT.Text
                + "',N'" + txtKinhPhi.Text + "',N'" + rtxtGhiChu.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaTL.Enabled = true;
            btnThemTL.Enabled = true;
            btnSuaTL.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuTL.Enabled = false;
            txtMaTL.Enabled = false;
        }

        private void btnTimTL_Click(object sender, EventArgs e)
        {
            txtMaTL.Enabled = true;
            txtMaLoai.Enabled = true;
            cbtxtMaLoai.Enabled = false;
            txtMaHP.Enabled = true;
            cbtxtMaHP.Enabled = false;
            txtMaTroLy.Enabled = true;
            cbtxtMaTroLy.Enabled = false;
            btnHuy.Enabled = true;
            string sql;
            if ((txtMaTL.Text == "") && (txtTenTL.Text == "") && (cbtxtMaLoai.Text == "") && (cbtxtMaHP.Text == "")
                && (cbtxtMaKhoa.Text == "") && (cbtxtMaTroLy.Text == "")
                && (txtNamNT.Text == "") && (txtKinhPhi.Text == "") && (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from TaiLieuBienSoan WHERE 1=1";
            if (txtMaTL.Text != "")
                sql += " AND MaTaiLieu LIKE N'%" + txtMaTL.Text.Trim() + "%'";
            if (txtTenTL.Text != "")
                sql += " AND TenTaiLieu LIKE N'%" + txtTenTL.Text.Trim() + "%'";
            if (txtMaLoai.Text != "")
                sql += " AND MaLoai LIKE N'%" + txtMaLoai.Text.Trim() + "%'";
            if (txtMaHP.Text != "")
                sql += " AND MaHocPhan LIKE N'%" + txtMaHP.Text.Trim() + "%'";
            if (cbtxtMaKhoa.Text != "")
                sql += " AND MaKhoa LIKE N'%" + cbtxtMaKhoa.Text.Trim() + "%'";
            if (txtMaTroLy.Text != "")
                sql += " AND MaTroLy LIKE N'%" + txtMaTroLy.Text.Trim() + "%'";
            if (txtNamNT.Text != "")
                sql += " AND NamNghiemThu LIKE N'%" + txtNamNT.Text.Trim() + "%'";
            if (txtKinhPhi.Text != "")
                sql += " AND KinhPhi LIKE N'%" + txtKinhPhi.Text.Trim() + "%'";
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text.Trim() + "%'";

            dtTL = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtTL.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtTL.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgTaiLieu.DataSource = dtTL;

            XoaDuLieuTextBox();
        }

        private void frmTaiLieu_Load(object sender, EventArgs e)
        {
            string sql;
            txtMaTL.Enabled = false;
            btnLuuTL.Enabled = false;
            btnHuy.Enabled = false;
            sql = "SELECT * FROM LoaiTaiLieu";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtMaLoai, "MaLoai", "TenLoai");
            cbtxtMaLoai.SelectedIndex = -1;
            sql = "SELECT * FROM HocPhan";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtMaHP, "MaHocPhan", "TenHocPhan");
            cbtxtMaHP.SelectedIndex = -1;
            sql = "SELECT MaKhoa FROM Khoa";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtMaKhoa, "MaKhoa");
            cbtxtMaKhoa.SelectedIndex = -1;
            sql = "SELECT * FROM TroLy";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtMaTroLy, "MaTroLy", "TenTroLy");
            cbtxtMaTroLy.SelectedIndex = -1;

            txtMaLoai.Enabled = false;
            txtMaHP.Enabled = false;
            txtMaTroLy.Enabled = false;
            TaiDuLieuVaoGridView(); //Hiển thị bảng tài liệu
        }

        private void dtgTaiLieu_Click(object sender, EventArgs e)
        {
            if (btnThemTL.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTL.Focus();
                return;
            }
            if (dtTL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTL.Text = dtgTaiLieu.CurrentRow.Cells["MaTaiLieu"].Value.ToString();
            txtTenTL.Text = dtgTaiLieu.CurrentRow.Cells["TenTaiLieu"].Value.ToString();
            txtMaLoai.Text = dtgTaiLieu.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtMaHP.Text = dtgTaiLieu.CurrentRow.Cells["MaHocPhan"].Value.ToString();
            cbtxtMaKhoa.Text = dtgTaiLieu.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtMaTroLy.Text = dtgTaiLieu.CurrentRow.Cells["MaTroLy"].Value.ToString();
            txtNamNT.Text = dtgTaiLieu.CurrentRow.Cells["NamNghiemThu"].Value.ToString();
            txtKinhPhi.Text = dtgTaiLieu.CurrentRow.Cells["KinhPhi"].Value.ToString();
            rtxtGhiChu.Text = dtgTaiLieu.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnSuaTL.Enabled = true;
            btnXoaTL.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM TaiLieuBienSoan";
            dtTL = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgTaiLieu.DataSource = dtTL; //Nguồn dữ liệu            
            dtgTaiLieu.Columns[0].HeaderText = "Mã tài liệu";
            dtgTaiLieu.Columns[1].HeaderText = "Tên tài liệu";
            dtgTaiLieu.Columns[2].HeaderText = "Loại tài liệu";
            dtgTaiLieu.Columns[3].HeaderText = "Học phần";
            dtgTaiLieu.Columns[4].HeaderText = "Mã khoa";
            dtgTaiLieu.Columns[5].HeaderText = "Trợ lý phụ trách";
            dtgTaiLieu.Columns[6].HeaderText = "Năm nghiệm thu";
            dtgTaiLieu.Columns[7].HeaderText = "Kinh phí";
            dtgTaiLieu.Columns[8].HeaderText = "Ghi chú";

            dtgTaiLieu.Columns[0].Width = 80;
            dtgTaiLieu.Columns[1].Width = 150;
            dtgTaiLieu.Columns[2].Width = 120;
            dtgTaiLieu.Columns[3].Width = 120;
            dtgTaiLieu.Columns[4].Width = 80;
            dtgTaiLieu.Columns[5].Width = 120;
            dtgTaiLieu.Columns[6].Width = 80;
            dtgTaiLieu.Columns[7].Width = 80;
            dtgTaiLieu.Columns[8].Width = 120;

            dtgTaiLieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgTaiLieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void XoaDuLieuTextBox()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            cbtxtMaLoai.Text = "";
            cbtxtMaHP.Text = "";
            cbtxtMaKhoa.Text = "";
            cbtxtMaTroLy.Text = "";
            txtNamNT.Text = "";
            txtKinhPhi.Text = "";
            rtxtGhiChu.Text = "";
            txtMaLoai.Text = "";
            txtMaHP.Text = "";
            txtMaTroLy.Text = "";
        }

        private void cbtxtMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaLoai FROM LoaiTaiLieu WHERE TenLoai=N'" + cbtxtMaLoai.Text + "'";
            txtMaLoai.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void cbtxtMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHocPhan FROM HocPhan WHERE TenHocPhan=N'" + cbtxtMaHP.Text + "'";
            txtMaHP.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void cbtxtMaTroLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaTroLy FROM TroLy WHERE TenTroLy=N'" + cbtxtMaTroLy.Text + "'";
            txtMaTroLy.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT TenLoai FROM LoaiTaiLieu WHERE MaLoai=N'" + txtMaLoai.Text + "'";
            cbtxtMaLoai.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void txtMaHP_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT TenHocPhan FROM HocPhan WHERE MaHocPhan=N'" + txtMaHP.Text + "'";
            cbtxtMaHP.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void txtMaTroLy_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT TenTroLy FROM TroLy WHERE MaTroLy=N'" + txtMaTroLy.Text + "'";
            cbtxtMaTroLy.Text = ChucNang.LayDuLieuTuSQL(sql);
        }
    }
}
