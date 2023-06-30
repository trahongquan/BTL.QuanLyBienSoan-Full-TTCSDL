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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void SubMenuExit_Click(object sender, EventArgs e)
        {
            ChucNang.NgatKetNoi(); //Đóng kết nối
            Application.Exit(); //Thoát
            frmLogin.ActiveForm.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChucNang.KetNoi();
        }

        private void MenuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm quản lý biên soạn 1.0!"
                + Environment.NewLine + "Các chức năng chính: "
                + Environment.NewLine + "1. Quản lý danh mục tài liệu"
                + Environment.NewLine + "2. Quản lý danh sách tác giả"
                + Environment.NewLine + "3. Quản lý danh sách khoa chuyên ngành thực hiện biên soạn"
                + Environment.NewLine + "4. Quản lý thông tin trợ lý phụ trách"
                + Environment.NewLine + "5. Thống kê biên soạn", "Chào mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void subMenuDMLTL_Click(object sender, EventArgs e)
        {
            frmLoaiTaiLieu frmLoaiTaiLieu = new frmLoaiTaiLieu();
            frmLoaiTaiLieu.ShowDialog();
        }

        private void SubMenuDMTL_Click(object sender, EventArgs e)
        {
            frmTaiLieu frmTaiLieu = new frmTaiLieu();
            frmTaiLieu.ShowDialog();
        }

        private void SubMenuDSTG_Click(object sender, EventArgs e)
        {
            frmTacGia frmTacGia = new frmTacGia();
            frmTacGia.ShowDialog();
        }

        private void SubMenuDSK_Click(object sender, EventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.ShowDialog();
        }

        private void SubMenuDSTL_Click(object sender, EventArgs e)
        {
            frmTroLy frmTroLy = new frmTroLy();
            frmTroLy.ShowDialog();
        }

        public void SubMenuDangXuat_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        public void DisableDSTL()
        {
            SubMenuDSTL.Enabled = false;
        }

        private void subMenuDSHP_Click(object sender, EventArgs e)
        {
            HocPhan hocPhan = new HocPhan();
            hocPhan.ShowDialog();
        }

        private void subMenuDMCBTG_Click(object sender, EventArgs e)
        {
            TaiLieu_TacGia taiLieu_tacgia = new TaiLieu_TacGia();
            taiLieu_tacgia.ShowDialog();
        }

        private void subMenuBaoCao_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void subMenuThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
        }
    }
}
