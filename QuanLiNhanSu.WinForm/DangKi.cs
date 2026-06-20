using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.Authen.Register;

namespace QuanLiNhanSu
{
    public partial class DangKi : Form
    {
        private readonly IMediator _mediator;

        public DangKi()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();
        }

        private void btn_Dangki_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_emailDK.Text.Trim();
                string password = txt_pass1DK.Text.Trim();
                string confirmPassword = txt_pass2DK.Text.Trim();

                if (password != confirmPassword || password.Length < 6)
                {
                    MessageBox.Show("Mật khẩu không khớp hoặc ít hơn 6 ký tự!");
                    return;
                }

                double quyen = -1;
                if (rdb_Admin.Checked) quyen = 0;
                else if (rdb_User.Checked) quyen = 1;

                var result = _mediator.Send(new RegisterCommand(email, password, quyen)).AsTask().GetAwaiter().GetResult();

                if (result.IsSuccess)
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
                    MessageBox.Show("Đăng ký thất bại: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
