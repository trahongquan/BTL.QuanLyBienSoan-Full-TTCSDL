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
    public partial class frmKhoa : Form
    {
        DataTable dtKhoa;
        public frmKhoa()
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
            btnThemKhoa.Enabled = true;
            btnXoaKhoa.Enabled = true;
            btnSuaKhoa.Enabled = true;
            btnLuuKhoa.Enabled = false;
            txtMaKhoa.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            btnSuaKhoa.Enabled = false;
            btnXoaKhoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuKhoa.Enabled = true;
            btnThemKhoa.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaKhoa.Enabled = true; //cho phép nhập mới
            txtMaKhoa.Focus();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhoa.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaKhoa.Text.Trim().Length == 0) || (txtTenKhoa.Text.Trim().Length == 0)
                || (txtCNK.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhoa.Focus();
                return;
            }
            sql = "UPDATE Khoa SET TenKhoa=N'" + txtTenKhoa.Text.ToString() + "',ChuNhiemKhoa=N'" + txtCNK.Text.ToString()
                + "',CapBac=N'" + txtCapBac.Text.ToString() + "',HocVi=N'" + txtHocVi.Text.Trim() + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaKhoa=N'" + txtMaKhoa.Text + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhoa.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Khoa WHERE MaKhoa=N'" + txtMaKhoa.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnTimKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = true;
            btnHuy.Enabled = true;
            string sql;
            if ((txtMaKhoa.Text == "") && (txtTenKhoa.Text == "") && (txtCNK.Text == "") && (txtCapBac.Text == "")
                && (txtHocVi.Text == "") && (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from Khoa WHERE 1=1";
            if (txtMaKhoa.Text != "")
                sql += " AND MaKhoa LIKE N'%" + txtMaKhoa.Text + "%'";
            if (txtTenKhoa.Text != "")
                sql += " AND TenKhoa LIKE N'%" + txtTenKhoa.Text + "%'";
            if (txtCNK.Text != "")
                sql += " AND ChuNhiemKhoa LIKE N'%" + txtCNK.Text + "%'";
            if (txtCapBac.Text != "")
                sql += " AND CapBac LIKE N'%" + txtCapBac.Text + "%'";
            if (txtHocVi.Text != "")
                sql += " AND HocVi LIKE N'%" + txtHocVi.Text + "%'";
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text + "%'";            

            dtKhoa = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtKhoa.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtKhoa.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgKhoa.DataSource = dtKhoa;

            XoaDuLieuTextBox();
        }

        private void dtgKhoa_Click(object sender, EventArgs e)
        {
            if (btnThemKhoa.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhoa.Focus();
                return;
            }
            if (dtKhoa.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhoa.Text = dtgKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = dtgKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
            txtCNK.Text = dtgKhoa.CurrentRow.Cells["ChuNhiemKhoa"].Value.ToString();
            txtCapBac.Text = dtgKhoa.CurrentRow.Cells["Capbac"].Value.ToString();
            txtHocVi.Text = dtgKhoa.CurrentRow.Cells["HocVi"].Value.ToString();
            rtxtGhiChu.Text = dtgKhoa.CurrentRow.Cells["GhiChu"].Value.ToString();            

            btnSuaKhoa.Enabled = true;
            btnXoaKhoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = false;
            btnLuuKhoa.Enabled = false;
            btnHuy.Enabled = false;
            TaiDuLieuVaoGridView(); //Hiển thị bảng Khoa
        }



        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaKhoa.Text.Trim().Length == 0) || (txtTenKhoa.Text.Trim().Length == 0)
                || (txtCNK.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhoa.Focus();
                return;
            }

            sql = "Select MaKhoa From Khoa where MaKhoa=N'" + txtMaKhoa.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã khoa này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return;
            }

            sql = "INSERT INTO Khoa VALUES(N'" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "',N'" + txtCNK.Text + "',N'"
                + txtCapBac.Text + "',N'" + txtHocVi.Text + "',N'" + rtxtGhiChu.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaKhoa.Enabled = true;
            btnThemKhoa.Enabled = true;
            btnSuaKhoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuKhoa.Enabled = false;
            txtMaKhoa.Enabled = false;
        }

        private void XoaDuLieuTextBox()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtCNK.Text = "";
            txtCapBac.Text = "";
            txtHocVi.Text = "";
            rtxtGhiChu.Text = "";
        }

        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM Khoa";
            dtKhoa = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgKhoa.DataSource = dtKhoa; //Nguồn dữ liệu            
            dtgKhoa.Columns[0].HeaderText = "Mã khoa";
            dtgKhoa.Columns[1].HeaderText = "Tên khoa";
            dtgKhoa.Columns[2].HeaderText = "Chủ nhiệm khoa";
            dtgKhoa.Columns[3].HeaderText = "Cấp bậc";
            dtgKhoa.Columns[4].HeaderText = "Học vị";
            dtgKhoa.Columns[5].HeaderText = "Ghi chú";

            dtgKhoa.Columns[0].Width = 80;
            dtgKhoa.Columns[1].Width = 120;
            dtgKhoa.Columns[2].Width = 120;
            dtgKhoa.Columns[3].Width = 80;
            dtgKhoa.Columns[4].Width = 80;
            dtgKhoa.Columns[5].Width = 120;

            dtgKhoa.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgKhoa.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
