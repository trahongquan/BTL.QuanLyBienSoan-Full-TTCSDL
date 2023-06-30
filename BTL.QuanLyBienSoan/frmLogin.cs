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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtTenDangNhap.Text == "admin") && (txtMatKhau.Text == "1"))
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else if ((txtTenDangNhap.Text == "TL001") && (txtMatKhau.Text == "1"))
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
                frmMain.DisableDSTL();
            }
            else if ((txtTenDangNhap.Text == "TL002") && (txtMatKhau.Text == "2"))
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
                frmMain.DisableDSTL();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = "";
                txtTenDangNhap.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Thoát
            this.Close();
        }
    }
}
