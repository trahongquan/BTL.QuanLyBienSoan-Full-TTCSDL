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
    public partial class frmTroLy : Form
    {
        DataTable dtTroLy;
        public frmTroLy()
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
            btnThemTroLy.Enabled = true;
            btnXoaTroLy.Enabled = true;
            btnSuaTroLy.Enabled = true;
            btnLuuTroLy.Enabled = false;
            txtMaTroLy.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemTroLy_Click(object sender, EventArgs e)
        {
            btnSuaTroLy.Enabled = false;
            btnXoaTroLy.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuTroLy.Enabled = true;
            btnThemTroLy.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaTroLy.Enabled = true; //cho phép nhập mới
            txtMaTroLy.Focus();
        }

        private void btnSuaTroLy_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtTroLy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTroLy.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaTroLy.Text.Trim().Length == 0) || (txtTenTroLy.Text.Trim().Length == 0) || (txtTDN.Text.Trim().Length == 0)
                || (txtMK.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTroLy.Focus();
                return;
            }
            sql = "UPDATE TroLy SET TenTroLy=N'" + txtTenTroLy.Text.ToString() + "',CapBac=N'" + txtCapBac.Text.ToString() + "',HocVi=N'" + txtHocVi.Text.Trim()
                + "',TenDangNhap=N'" + txtTDN.Text.ToString() + "',MatKhau=N'" + txtMK.Text.ToString() + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaTroLy=N'" + txtMaTroLy.Text + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaTroLy_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTroLy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTroLy.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TroLy WHERE MaTroLy=N'" + txtMaTroLy.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnLuuTroLy_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaTroLy.Text.Trim().Length == 0) || (txtTenTroLy.Text.Trim().Length == 0) || (txtTDN.Text.Trim().Length == 0)
                || (txtMK.Text.Trim().Length == 0) || (txtCapBac.Text.Trim().Length == 0)
                || (txtHocVi.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTroLy.Focus();
                return;
            }

            sql = "Select MaTroLy From TroLy where MaTroLy=N'" + txtMaTroLy.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã trợ lý này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTroLy.Focus();
                return;
            }

            sql = "INSERT INTO TroLy VALUES(N'" + txtMaTroLy.Text + "',N'" + txtTenTroLy.Text + "',N'" + txtCapBac.Text + "',N'"
                + txtHocVi.Text + "',N'" + txtTDN.Text + "',N'" + txtMK.Text + "',N'" + rtxtGhiChu.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaTroLy.Enabled = true;
            btnThemTroLy.Enabled = true;
            btnSuaTroLy.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuTroLy.Enabled = false;
            txtMaTroLy.Enabled = false;
        }

        private void btnTimTroLy_Click(object sender, EventArgs e)
        {
            txtMaTroLy.Enabled = true;
            btnHuy.Enabled = true;
            string sql;
            if ((txtMaTroLy.Text == "") && (txtTenTroLy.Text == "") && (txtCapBac.Text == "") && (txtHocVi.Text == "")
                && (txtTDN.Text == "") && (txtMK.Text == "") && (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from TroLy WHERE 1=1";
            if (txtMaTroLy.Text != "")
                sql += " AND MaTroLy LIKE N'%" + txtMaTroLy.Text + "%'";
            if (txtTenTroLy.Text != "")
                sql += " AND TenTroLy LIKE N'%" + txtTenTroLy.Text + "%'";
            if (txtCapBac.Text != "")
                sql += " AND CapBac LIKE N'%" + txtCapBac.Text + "%'";
            if (txtHocVi.Text != "")
                sql += " AND HocVi LIKE N'%" + txtHocVi.Text + "%'";
            if (txtTDN.Text != "")
                sql += " AND TenDangNhap LIKE N'%" + txtTDN.Text + "%'";
            if (txtMK.Text != "")
                sql += " AND MatKhau LIKE N'%" + txtMK.Text + "%'";
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text + "%'";

            dtTroLy = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtTroLy.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtTroLy.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgTroLy.DataSource = dtTroLy;

            XoaDuLieuTextBox();
        }

        private void dtgTroLy_Click(object sender, EventArgs e)
        {
            if (btnThemTroLy.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTroLy.Focus();
                return;
            }
            if (dtTroLy.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTroLy.Text = dtgTroLy.CurrentRow.Cells["MaTroLy"].Value.ToString();
            txtTenTroLy.Text = dtgTroLy.CurrentRow.Cells["TenTroLy"].Value.ToString();
            txtCapBac.Text = dtgTroLy.CurrentRow.Cells["Capbac"].Value.ToString();
            txtHocVi.Text = dtgTroLy.CurrentRow.Cells["HocVi"].Value.ToString();
            txtTDN.Text = dtgTroLy.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txtMK.Text = dtgTroLy.CurrentRow.Cells["MatKhau"].Value.ToString();
            rtxtGhiChu.Text = dtgTroLy.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnSuaTroLy.Enabled = true;
            btnXoaTroLy.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void frmTroLy_Load(object sender, EventArgs e)
        {
            string sql;
            txtMaTroLy.Enabled = false;
            btnLuuTroLy.Enabled = false;
            btnHuy.Enabled = false;
            TaiDuLieuVaoGridView(); //Hiển thị bảng trợ lý
        }

        //Lấy dữ liệu từ sql server đưa vào datagridview
        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM TroLy";
            dtTroLy = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgTroLy.DataSource = dtTroLy; //Nguồn dữ liệu            
            dtgTroLy.Columns[0].HeaderText = "Mã trợ lý";
            dtgTroLy.Columns[1].HeaderText = "Tên trợ lý";
            dtgTroLy.Columns[2].HeaderText = "Cấp bậc";
            dtgTroLy.Columns[3].HeaderText = "Học vị";
            dtgTroLy.Columns[4].HeaderText = "Tên đăng nhập";
            dtgTroLy.Columns[5].HeaderText = "Mật khẩu";
            dtgTroLy.Columns[6].HeaderText = "Ghi chú";

            dtgTroLy.Columns[0].Width = 80;
            dtgTroLy.Columns[1].Width = 120;
            dtgTroLy.Columns[2].Width = 80;
            dtgTroLy.Columns[3].Width = 80;
            dtgTroLy.Columns[4].Width = 120;
            dtgTroLy.Columns[5].Width = 120;
            dtgTroLy.Columns[6].Width = 120;

            dtgTroLy.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgTroLy.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void XoaDuLieuTextBox()
        {
            txtMaTroLy.Text = "";
            txtTenTroLy.Text = "";
            txtCapBac.Text = "";
            txtHocVi.Text = "";
            txtTDN.Text = "";
            txtMK.Text = "";
            rtxtGhiChu.Text = "";
        }
    }
}
