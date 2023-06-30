using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL.QuanLyBienSoan
{
    internal class ChucNang
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static void KetNoi()
        {
            string source = "server = HPK01\\MAYCHU;" + "uid = tk1; pwd = 2;" + "database = QuanLyBienSoan";
            Conn = new SqlConnection(source);   //Khởi tạo đối tượng            
            Conn.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (Conn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối đến SQL server thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Không thể kết nối với SQL server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void NgatKetNoi()
        {
            try 
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();       //Đóng kết nối
                    Conn.Dispose();     //Giải phóng tài nguyên
                    Conn = null;
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }
        //Lấy dữ liệu vào bảng
        public static DataTable TaiDuLieuVaoBang(string sql)
        {

            SqlDataAdapter dapt = new SqlDataAdapter(sql, Conn); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dapt.Fill(table);
            return table;
        }

        //Hàm kiểm tra mã có trùng nhau ko
        public static bool KiemTraTrung(string sql)
        {
            SqlDataAdapter dapt = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            dapt.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }        

        //Hàm thực hiện câu lệnh SQL
        public static void ChayCauLenhSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Conn; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        //Lấy dữ liệu từ câu lệnh SQL đổ vào ComboBox
        public static void DuaDuLieuVaoComboBox(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter dapt = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            dapt.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị            
        }

        //Lấy dữ liệu từ câu lệnh SQL đổ vào ComboBox và đổi tên mã
        public static void DuaDuLieuVaoComboBox(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dapt = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            dapt.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Đưa ra các giá trị trong combobox
            cbo.DisplayMember = ten; //Thay thế các giá trị bằng tên "ten"
        }

        //Lấy dữ liệu từ câu lệnh SQL
        public static string LayDuLieuTuSQL(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader(); 
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            //MessageBox.Show(ma);
            reader.Close();
            return ma;
        }
    }
}
