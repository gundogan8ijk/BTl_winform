using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.Authen.Login;
using QuanLiNhanSu.Class;

namespace QuanLiNhanSu
{
    public partial class DangNhap : Form
    {
        private readonly IMediator _mediator;

        public DangNhap()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_Taikhoan.Text.Trim();
                string matkhau = txt_matkhau.Text.Trim();

                var result = _mediator.Send(new LoginCommand(email, matkhau)).AsTask().GetAwaiter().GetResult();

                if (result.IsSuccess)
                {
                    Const.quyen_ = (float)result.Value.Quyen;
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
            if (txt_Taikhoan.Text == "Tên đăng nhập")
            {
                txt_Taikhoan.Text = "";
                txt_Taikhoan.ForeColor = Color.Black;
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
