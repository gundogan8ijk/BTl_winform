using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=DESKTOP-LGN3VIN;Initial Catalog=QuanLiNhanVien;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void btn_Dangki_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_emailDK.Text.Trim();

                if (!IsValidGmail(email))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.");
                    return;
                }
                string password = txt_pass1DK.Text.Trim();
                if (txt_pass1DK.Text.Trim() != txt_pass2DK.Text.Trim() && password.Length <= 6)
                {
                    MessageBox.Show("Password khac nhau || Mat khau it nhat 6 ki tu");
                    return;
                }
                if (IsEmailExists(email))
                {
                    MessageBox.Show("Email này đã được đăng ký. Vui lòng chọn email khác.");
                    return;
                }
                int quyen = -1;
                if (rdb_Admin.Checked) quyen = 0;
                else if (rdb_User.Checked) quyen = 1;
                MoKetNoi();

                string sql = "INSERT INTO Taikhoan (Email, matkhau, Quyen) VALUES (@Email, @Password, @Quyen)";

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password.Trim());
                cmd.Parameters.AddWithValue("@Quyen", quyen);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    txt_emailDK.Clear();
                    txt_pass1DK.Clear();
                    txt_pass2DK.Clear();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }


                    
        }
        private bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Taikhoan WHERE Email = @Email";
                MoKetNoi();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();  // Trả về số lượng bản ghi tìm thấy
                    return count > 0;  // Nếu lớn hơn 0, có nghĩa là email đã tồn tại
                }
        }
        private bool IsValidGmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private void lb_quaylai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangNhap = new DangNhap(); 
            dangNhap.Show();
            this.Hide();
        }

        private void txt_emailDK_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
