using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class;
using QuanLiNhanSu.Class.TaiKhoan;

namespace QuanLiNhanSu
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {

            try
            {
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();
                string email = txt_Taikhoan.Text.Trim();
                string matkhau = txt_matkhau.Text.Trim();

                string query = "SELECT * FROM TaiKhoan WHERE email = @Email AND matkhau = @Matkhau";
                using (SqlCommand command = new SqlCommand(query, database_Connect.sqlCon))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Matkhau", matkhau);

                    using (SqlDataReader data = command.ExecuteReader())
                    {
                        if (data.HasRows)
                        {
                            data.Read();
                            Const.quyen_ = (float)data.GetDouble(2);
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc mật khẩu không đúng!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở đây : " + ex.Message);
            }
        }
     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dangKi = new DangKi();
            dangKi.Show();
            this.Hide();
        }

        private void txt_Taikhoan_Enter(object sender, EventArgs e)
        {
            if(txt_Taikhoan.Text == "Tên đăng nhập")
            {
                txt_Taikhoan.Text = "";
                txt_Taikhoan.ForeColor  = Color.Black;
            }
        }

        private void txt_Taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Showpass.Checked)
            {
                txt_matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }
    }
}
