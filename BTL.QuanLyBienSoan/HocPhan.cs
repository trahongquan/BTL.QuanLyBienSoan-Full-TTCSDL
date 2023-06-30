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
    public partial class HocPhan : Form
    {
        DataTable dtHP;
        public HocPhan()
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
            btnThemHP.Enabled = true;
            btnXoaHP.Enabled = true;
            btnSuaHP.Enabled = true;
            btnLuuHP.Enabled = false;
            txtMaHP.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            btnSuaHP.Enabled = false;
            btnXoaHP.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuHP.Enabled = true;
            btnThemHP.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaHP.Enabled = true; //cho phép nhập mới
            txtMaHP.Focus();
        }

        private void btnSuaHP_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtHP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHP.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaHP.Text.Trim().Length == 0) || (txtTenHP.Text.Trim().Length == 0)
                || (txtSoTiet.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHP.Focus();
                return;
            }
            sql = "UPDATE HocPhan SET TenHocPhan=N'" + txtTenHP.Text.ToString() + "',SoTiet=N'" + txtSoTiet.Text.ToString()
                + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaHocPhan=N'" + txtMaHP.Text + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaHP_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtHP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHP.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE HocPhan WHERE MaHocPhan=N'" + txtMaHP.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnLuuHP_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaHP.Text.Trim().Length == 0) || (txtTenHP.Text.Trim().Length == 0)
                || (txtSoTiet.Text.Trim().Length == 0) || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP.Focus();
                return;
            }

            sql = "Select MaHocPhan From HocPhan where MaHocPhan=N'" + txtMaHP.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã học phần này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHP.Focus();
                return;
            }

            sql = "INSERT INTO HocPhan VALUES(N'" + txtMaHP.Text + "',N'" + txtTenHP.Text + "',N'" + txtSoTiet.Text
                + "',N'" + rtxtGhiChu.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaHP.Enabled = true;
            btnThemHP.Enabled = true;
            btnSuaHP.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuHP.Enabled = false;
            txtMaHP.Enabled = false;
        }

        private void btnTimHP_Click(object sender, EventArgs e)
        {
            txtMaHP.Enabled = true;
            btnHuy.Enabled = true;
            string sql;
            if ((txtMaHP.Text == "") && (txtTenHP.Text == "") && (txtSoTiet.Text == "")&& (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from HocPhan WHERE 1=1";
            if (txtMaHP.Text != "")
                sql += " AND MaHocPhan LIKE N'%" + txtMaHP.Text + "%'";
            if (txtTenHP.Text != "")
                sql += " AND TenHocPhan LIKE N'%" + txtTenHP.Text + "%'";
            if (txtSoTiet.Text != "")
                sql += " AND SoTiet LIKE N'%" + txtSoTiet.Text + "%'";           
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text + "%'";

            dtHP = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtHP.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtHP.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgHocPhan.DataSource = dtHP;

            XoaDuLieuTextBox();
        }

        private void HocPhan_Load(object sender, EventArgs e)
        {
            txtMaHP.Enabled = false;
            btnLuuHP.Enabled = false;
            btnHuy.Enabled = false;
            TaiDuLieuVaoGridView(); //Hiển thị bảng Khoa
        }

        private void dtgHocPhan_Click(object sender, EventArgs e)
        {
            if (btnThemHP.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP.Focus();
                return;
            }
            if (dtHP.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHP.Text = dtgHocPhan.CurrentRow.Cells["MaHocPhan"].Value.ToString();
            txtTenHP.Text = dtgHocPhan.CurrentRow.Cells["TenHocPhan"].Value.ToString();
            txtSoTiet.Text = dtgHocPhan.CurrentRow.Cells["SoTiet"].Value.ToString();
            rtxtGhiChu.Text = dtgHocPhan.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnSuaHP.Enabled = true;
            btnXoaHP.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void XoaDuLieuTextBox()
        {
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            txtSoTiet.Text = "";
            rtxtGhiChu.Text = "";
        }

        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM HocPhan";
            dtHP = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgHocPhan.DataSource = dtHP; //Nguồn dữ liệu            
            dtgHocPhan.Columns[0].HeaderText = "Mã học phần";
            dtgHocPhan.Columns[1].HeaderText = "Tên học phần";
            dtgHocPhan.Columns[2].HeaderText = "Số tiết";
            dtgHocPhan.Columns[3].HeaderText = "Ghi chú";

            dtgHocPhan.Columns[0].Width = 80;
            dtgHocPhan.Columns[1].Width = 120;
            dtgHocPhan.Columns[2].Width = 120;
            dtgHocPhan.Columns[3].Width = 120;

            dtgHocPhan.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgHocPhan.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
