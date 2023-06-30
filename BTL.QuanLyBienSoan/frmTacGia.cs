using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.QuanLyBienSoan
{
    public partial class frmTacGia : Form
    {
        DataTable dtTG;
        public frmTacGia()
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
            btnThemTG.Enabled = true;
            btnXoaTG.Enabled = true;
            btnSuaTG.Enabled = true;
            btnLuuTG.Enabled = false;
            txtMaTG.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            btnSuaTG.Enabled = false;
            btnXoaTG.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuTG.Enabled = true;
            btnThemTG.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaTG.Enabled = true; //cho phép nhập mới
            txtMaTG.Focus();
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTG.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaTG.Text.Trim().Length == 0) || (txtTenTG.Text.Trim().Length == 0) || (cbtxtMaKhoa.Text.Trim().Length == 0)
                || (txtChucVu.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTG.Focus();
                return;
            }
            sql = "UPDATE TacGia SET TenTacGia=N'" + txtTenTG.Text.ToString() + "',ChucVu=N'" + txtChucVu.Text.ToString() + "',MaKhoa=N'" + cbtxtMaKhoa.Text.ToString()
                + "',CapBac=N'" + txtCapBac.Text.ToString() + "',HocVi=N'" + txtHocVi.Text.Trim() + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaTacGia=N'" + txtMaTG.Text.ToString() + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTG.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TacGia WHERE MaTacGia=N'" + txtMaTG.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnTimTG_Click(object sender, EventArgs e)
        {
            txtMaTG.Enabled = true;
            btnHuy.Enabled = true;
            string sql;
            if ((txtMaTG.Text == "") && (txtTenTG.Text == "") && (txtChucVu.Text == "") && (txtCapBac.Text == "")
                && (txtHocVi.Text == "") && (cbtxtMaKhoa.Text == "") && (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from TacGia WHERE 1=1";
            if (txtMaTG.Text != "")
                sql += " AND MaTacGia LIKE N'%" + txtMaTG.Text + "%'";
            if (txtTenTG.Text != "")
                sql += " AND TenTacGia LIKE N'%" + txtTenTG.Text + "%'";
            if (txtChucVu.Text != "")
                sql += " AND ChucVu LIKE N'%" + txtChucVu.Text + "%'";
            if (txtCapBac.Text != "")
                sql += " AND CapBac LIKE N'%" + txtCapBac.Text + "%'";
            if (txtHocVi.Text != "")
                sql += " AND HocVi LIKE N'%" + txtHocVi.Text + "%'";
            if (cbtxtMaKhoa.Text != "")
                sql += " AND MaKhoa LIKE N'%" + cbtxtMaKhoa.Text + "%'";
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text + "%'";

            dtTG = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtTG.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtTG.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgTacGia.DataSource = dtTG;

            XoaDuLieuTextBox();
        }

        private void dtgTacGia_Click(object sender, EventArgs e)
        {
            if (btnThemTG.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTG.Focus();
                return;
            }
            if (dtTG.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTG.Text = dtgTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtTenTG.Text = dtgTacGia.CurrentRow.Cells["TenTacGia"].Value.ToString();
            txtCapBac.Text = dtgTacGia.CurrentRow.Cells["Capbac"].Value.ToString();
            txtChucVu.Text = dtgTacGia.CurrentRow.Cells["ChucVu"].Value.ToString();
            txtHocVi.Text = dtgTacGia.CurrentRow.Cells["HocVi"].Value.ToString();
            cbtxtMaKhoa.Text = dtgTacGia.CurrentRow.Cells["MaKhoa"].Value.ToString();
            rtxtGhiChu.Text = dtgTacGia.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnSuaTG.Enabled = true;
            btnXoaTG.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            string sql;
            txtMaTG.Enabled = false;
            btnLuuTG.Enabled = false;
            btnHuy.Enabled = false;            
            sql = "SELECT MaKhoa FROM Khoa";
            ChucNang.DuaDuLieuVaoComboBox(sql,cbtxtMaKhoa,"MaKhoa");
            cbtxtMaKhoa.SelectedIndex = -1;
            TaiDuLieuVaoGridView(); //Hiển thị bảng tác giả
        }


        private void btnLuuTG_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaTG.Text.Trim().Length == 0) || (txtTenTG.Text.Trim().Length == 0) || (cbtxtMaKhoa.Text.Trim().Length == 0)
                || (txtChucVu.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTG.Focus();
                return;
            }

            sql = "Select MaTacGia From TacGia where MaTacGia=N'" + txtMaTG.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã tác giả này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTG.Focus();
                return;
            }

            sql = "INSERT INTO TacGia VALUES(N'" + txtMaTG.Text + "',N'" + txtTenTG.Text + "',N'" + txtCapBac.Text + "',N'"
                + txtChucVu.Text + "',N'" + txtHocVi.Text + "',N'" + cbtxtMaKhoa.Text + "',N'" + rtxtGhiChu.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaTG.Enabled = true;
            btnThemTG.Enabled = true;
            btnSuaTG.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuTG.Enabled = false;
            txtMaTG.Enabled = false;
        }

        //Lấy dữ liệu từ sql server đưa vào datagridview
        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM TacGia";
            dtTG = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgTacGia.DataSource = dtTG; //Nguồn dữ liệu            
            dtgTacGia.Columns[0].HeaderText = "Mã tác giả";
            dtgTacGia.Columns[1].HeaderText = "Tên tác giả";
            dtgTacGia.Columns[2].HeaderText = "Cấp bậc";
            dtgTacGia.Columns[3].HeaderText = "Chức vụ";
            dtgTacGia.Columns[4].HeaderText = "Học vị";
            dtgTacGia.Columns[5].HeaderText = "Mã khoa";
            dtgTacGia.Columns[6].HeaderText = "Ghi chú";

            dtgTacGia.Columns[0].Width = 80;
            dtgTacGia.Columns[1].Width = 120;
            dtgTacGia.Columns[2].Width = 80;
            dtgTacGia.Columns[3].Width = 80;
            dtgTacGia.Columns[4].Width = 80;
            dtgTacGia.Columns[5].Width = 80;
            dtgTacGia.Columns[6].Width = 120;

            dtgTacGia.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgTacGia.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void XoaDuLieuTextBox()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtCapBac.Text = "";
            txtChucVu.Text = "";
            txtHocVi.Text = "";
            cbtxtMaKhoa.Text = "";
            rtxtGhiChu.Text = "";
        }
    }
}
