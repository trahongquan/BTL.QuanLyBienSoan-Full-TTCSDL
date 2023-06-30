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
    public partial class frmLoaiTaiLieu : Form
    {
        DataTable dtTaiLieu;
        public frmLoaiTaiLieu()
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
            btnThemLTL.Enabled = true;
            btnXoaLTL.Enabled = true;
            btnSuaLTL.Enabled = true;
            btnLuuLTL.Enabled = false;
            txtMaLTL.Enabled = false;
            TaiDuLieuVaoGridView();
        }

        private void btnThemLTL_Click(object sender, EventArgs e)
        {
            btnSuaLTL.Enabled = false;
            btnXoaLTL.Enabled = false;
            btnHuy.Enabled = true;
            btnLuuLTL.Enabled = true;
            btnThemLTL.Enabled = false;
            XoaDuLieuTextBox(); //Xoá trắng các textbox
            txtMaLTL.Enabled = true; //cho phép nhập mới
            txtMaLTL.Focus();
        }

        private void btnSuaLTL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (dtgLoaiTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLTL.Text == "") //nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtMaLTL.Text.Trim().Length == 0) || (txtTenLTL.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLTL.Focus();
                return;
            }
            sql = "UPDATE LoaiTaiLieu SET TenLoai=N'" + txtTenLTL.Text.ToString() + "' WHERE MaLoai=N'" + txtMaLTL.Text + "'";
            ChucNang.ChayCauLenhSQL(sql);
            TaiDuLieuVaoGridView();
            XoaDuLieuTextBox();
            btnHuy.Enabled = false;
        }

        private void btnXoaLTL_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTaiLieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLTL.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE LoaiTaiLieu WHERE MaLoai=N'" + txtMaLTL.Text + "'";
                ChucNang.ChayCauLenhSQL(sql);
                TaiDuLieuVaoGridView();
                XoaDuLieuTextBox();
            }
        }                

        //Chức năng tải dữ liệu ngay khi hiển thị form
        private void frmLoaiTaiLieu_Load(object sender, EventArgs e)
        {
            txtMaLTL.Enabled = false;
            btnLuuLTL.Enabled = false;
            btnHuy.Enabled = false;
            TaiDuLieuVaoGridView(); //Hiển thị bảng trong datagridview
        }

        private void btnLuuLTL_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if ((txtMaLTL.Text.Trim().Length == 0) || (txtTenLTL.Text.Trim().Length == 0))
            {
                MessageBox.Show("Còn ô dữ liệu chưa được nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLTL.Focus();
                return;
            }

            sql = "Select MaLoai From LoaiTaiLieu where MaLoai=N'" + txtMaLTL.Text.Trim() + "'";
            if (ChucNang.KiemTraTrung(sql))
            {
                MessageBox.Show("Mã loại tài liệu này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLTL.Focus();
                return;
            }

            sql = "INSERT INTO LoaiTaiLieu VALUES(N'" + txtMaLTL.Text + "',N'" + txtTenLTL.Text + "')";
            ChucNang.ChayCauLenhSQL(sql); //Thực hiện câu lệnh sql
            TaiDuLieuVaoGridView(); //Nạp lại DataGridView
            XoaDuLieuTextBox();
            btnXoaLTL.Enabled = true;
            btnThemLTL.Enabled = true;
            btnSuaLTL.Enabled = true;
            btnHuy.Enabled = false;
            btnLuuLTL.Enabled = false;
            txtMaLTL.Enabled = false;
        }

        //Lấy dữ liệu từ sql server đưa vào datagridview
        private void TaiDuLieuVaoGridView()
        {
            string sql;
            sql = "SELECT * FROM LoaiTaiLieu";
            dtTaiLieu = ChucNang.TaiDuLieuVaoBang(sql); //Đọc dữ liệu từ bảng
            dtgLoaiTL.DataSource = dtTaiLieu; //Nguồn dữ liệu            
            dtgLoaiTL.Columns[0].HeaderText = "Mã tài liệu";
            dtgLoaiTL.Columns[1].HeaderText = "Tên loại tài liệu";

            dtgLoaiTL.Columns[0].Width = 80;
            dtgLoaiTL.Columns[1].Width = 180;

            dtgLoaiTL.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dtgLoaiTL.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dtgLoaiTL_Click(object sender, EventArgs e)
        {
            if (btnThemLTL.Enabled == false) //Không cho lấy dữ liệu từ datagrid lên textbox
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLTL.Focus();
                return;
            }
            if (dtTaiLieu.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLTL.Text = dtgLoaiTL.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTenLTL.Text = dtgLoaiTL.CurrentRow.Cells["TenLoai"].Value.ToString();            

            btnSuaLTL.Enabled = true;
            btnXoaLTL.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void XoaDuLieuTextBox()
        {
            txtMaLTL.Text = "";
            txtTenLTL.Text = "";
        }
    }
}
