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
    public partial class TaiLieu_TacGia : Form
    {
        DataTable dtTLTG;
        public TaiLieu_TacGia()
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
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            cbtxtTG.Enabled = false;
            cbtxtTL.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            cbtxtTG.Enabled = true; //cho phép nhập mới
            cbtxtTL.Enabled = true;
            cbtxtTG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtTLTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((cbtxtTG.Text == "") || (cbtxtTL.Text == "")) //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((cbtxtTG.Text.Trim().Length == 0) || (cbtxtTL.Text.Trim().Length == 0) || (cbtxtNV.Text.Trim() == "")
                || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtGhiChu.Focus();
                return;
            }
            sql = "UPDATE TacGia_TaiLieu SET MaTaiLieu=N'" + txtTL.Text.ToString().Trim()
                + "',NhiemVu=N'" + cbtxtNV.Text.Trim() + "',GhiChu=N'" + rtxtGhiChu.Text.Trim()
                + "' WHERE MaTacGia=N'" + txtTG.Text.ToString().Trim() + "' AND MaTaiLieu=N'" + txtTL.Text.ToString().Trim() + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTLTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbtxtTG.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TacGia_TaiLieu WHERE MaTacGia=N'" + txtTG.Text + "' AND MaTaiLieu=N'" + txtTL.Text.ToString().Trim() + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((cbtxtTG.Text.Trim().Length == 0) || (cbtxtTL.Text.Trim().Length == 0) || (cbtxtNV.Text == "")
                || (rtxtGhiChu.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtxtTG.Focus();
                return;
            }

            sql = "Select MaTaiLieu, NhiemVu From TacGia_TaiLieu where MaTaiLieu=N'" + txtTL.Text.Trim() 
                + "' AND NhiemVu = N'Chủ biên'"; 
            if (ChucNang.KiemTraTrung(sql))
            {
               MessageBox.Show("Tài liệu này đã có chủ biên, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtTL.Focus();
                return;
            }

            sql = "INSERT INTO TacGia_TaiLieu VALUES('" + txtTG.Text.ToString().Trim() + "','" + txtTL.Text.ToString().Trim()
                + "',N'" + cbtxtNV.Text.Trim() + "',N'" + rtxtGhiChu.Text.Trim() + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            cbtxtTG.Enabled = false;
            cbtxtTL .Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            cbtxtTG.Enabled = true;
            cbtxtTL.Enabled = true;
            txtTL.Enabled = false;
            txtTG.Enabled = false;
            btnHuy.Enabled = true;
            string sql;
            if ((cbtxtTG.Text == "") && (cbtxtTL.Text == "") && (cbtxtNV.Text == "")
                && (rtxtGhiChu.Text == ""))
            {
                TaiDuLieuVaoGridView();
                return;
            }
            sql = "SELECT * from TacGia_TaiLieu WHERE 1=1";
            if (cbtxtTG.Text != "")
                sql += " AND MaTacGia LIKE N'%" + txtTG.Text + "%'";
            if (cbtxtTL.Text != "")
                sql += " AND MaTaiLieu LIKE N'%" + txtTL.Text + "%'";
            if (cbtxtNV.Text != "")
                sql += " AND NhiemVu LIKE N'%" + cbtxtNV.Text + "%'";
            if (rtxtGhiChu.Text != "")
                sql += " AND GhiChu LIKE N'%" + rtxtGhiChu.Text + "%'";

            dtTLTG = ChucNang.TaiDuLieuVaoBang(sql);
            if (dtTLTG.Rows.Count == 0)
                MessageBox.Show("Không có dữ liệu thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dtTLTG.Rows.Count + "  dữ liệu thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgTLTG.DataSource = dtTLTG;

            XoaDuLieuTextBox();
        }

        private void TaiLieu_TacGia_Load(object sender, EventArgs e)
        {
            string sql;
            cbtxtTG.Enabled = false;
            cbtxtTL.Enabled = false;
            txtTL.Enabled = false;
            txtTG.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            sql = "SELECT * FROM TacGia";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtTG, "MaTacGia", "TenTacGia");
            cbtxtTG.SelectedIndex = -1;
            sql = "SELECT * FROM TaiLieuBiensoan";
            ChucNang.DuaDuLieuVaoComboBox(sql, cbtxtTL, "MaTaiLieu", "TenTaiLieu");
            cbtxtTL.SelectedIndex = -1;
            TaiDuLieuVaoGridView(); //Hiển thị bảng 
        }

        private void dtgTLTG_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtxtTG.Focus();
                return;
            }
            if (dtTLTG.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtTG.Text = dtgTLTG.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtTL.Text = dtgTLTG.CurrentRow.Cells["MaTaiLieu"].Value.ToString();
            cbtxtNV.Text = dtgTLTG.CurrentRow.Cells["NhiemVu"].Value.ToString();
            rtxtGhiChu.Text = dtgTLTG.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        //Lấy dữ liệu từ sql server đưa vào datagridview
        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM TacGia_TaiLieu";
            dtTLTG = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgTLTG.DataSource = dtTLTG; //Nguồn dữ liệu            
            dtgTLTG.Columns[0].HeaderText = "Mã tác giả";
            dtgTLTG.Columns[1].HeaderText = "Mã tài liệu";
            dtgTLTG.Columns[2].HeaderText = "Nhiệm vụ";
            dtgTLTG.Columns[3].HeaderText = "Ghi chú";

            dtgTLTG.Columns[0].Width = 120;
            dtgTLTG.Columns[1].Width = 120;
            dtgTLTG.Columns[2].Width = 120;
            dtgTLTG.Columns[3].Width = 120;

            dtgTLTG.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgTLTG.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void XoaDuLieuTextBox()
        {
            cbtxtTG.Text = "";
            cbtxtTL.Text = "";
            cbtxtNV.Text = "";
            rtxtGhiChu.Text = "";
            txtTG.Text = "";
            txtTL.Text = "";
        }

        private void cbtxtTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaTacGia FROM TacGia WHERE TenTacGia=N'" + cbtxtTG.Text + "'";
            txtTG.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void cbtxtTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaTaiLieu FROM TaiLieuBienSoan WHERE TenTaiLieu=N'" + cbtxtTL.Text + "'";
            txtTL.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void txtTG_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT TenTacGia FROM TacGia WHERE MaTacGia=N'" + txtTG.Text + "'";
            cbtxtTG.Text = ChucNang.LayDuLieuTuSQL(sql);
        }

        private void txtTL_TextChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT TenTaiLieu FROM TaiLieuBienSoan WHERE MaTaiLieu=N'" + txtTL.Text + "'";
            cbtxtTL.Text = ChucNang.LayDuLieuTuSQL(sql);
        }
    }
}
