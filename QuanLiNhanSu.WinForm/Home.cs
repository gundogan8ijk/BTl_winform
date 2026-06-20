using System;
using System.Windows.Forms;
using QuanLiNhanSu.Class;
using QuanLiNhanSu.User_Control;

namespace QuanLiNhanSu
{
    public partial class Home : Form
    {
        private UserControl _currentPanel = null;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowPanel(UserControl control)
        {
            _currentPanel?.Dispose();
            _currentPanel = control;
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            float quyen = Const.quyen_;
            if (quyen > 0)
            {
                btn_Luong.Enabled = false;
                btn_Taikhoan.Enabled = false;
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            ShowPanel(new Hienthidanhsach());
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ShowPanel(new ChamC());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel(new Luong());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có đăng xuất không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {
            ShowPanel(new Taikhoan());
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            ShowPanel(new Xuatds());
        }

        private void hienthidanhsach1_Load(object sender, EventArgs e)
        {
        }
    }
}
