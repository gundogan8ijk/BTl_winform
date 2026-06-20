using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.Authen;
using QuanLiNhanSu.UseCases.Authen.Register;

namespace QuanLiNhanSu.User_Control
{
    public partial class Taikhoan : UserControl
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();
        private int vt = -1;
        private int cn = 0;

        public Taikhoan()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();
        }

        private async void Taikhoan_Load(object sender, EventArgs e)
        {
            await HienThiThongtin();
            NotEnabledChucNang();
            btn_TKXoa.Enabled = false;
            btn_TKSua.Enabled = false;
        }

        private DataTable ToDataTable(List<AccountDto> list)
        {
            DataTable table = new DataTable("TaiKhoan");
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("matkhau", typeof(string));
            table.Columns.Add("quyen", typeof(string));
            foreach (var item in list)
            {
                table.Rows.Add(
                    item.Email,
                    item.MatKhau,
                    item.Quyen.ToString()
                );
            }
            return table;
        }

        private async Task HienThiThongtin()
        {
            var result = await _mediator.Send(new GetAccountsQuery());
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_TaiKhoan.DataSource = table;
            }
        }

        private void XoaDuLieu()
        {
            txt_TK_ten.Clear();
            txt_TK_matkhau.Clear();
            txt_TK_Tktentaikhoan.Clear();
        }

        public void EnabledChucNang()
        {
            txt_TK_ten.Enabled = true;
            txt_TK_matkhau.Enabled = true;
            cb_TK_Quyen.Enabled = true;
        }

        public void NotEnabledChucNang()
        {
            txt_TK_ten.Enabled = false;
            txt_TK_matkhau.Enabled = false;
            cb_TK_Quyen.Enabled = false;
        }

        private async Task ThemTK()
        {
            try
            {
                string email = txt_TK_ten.Text.Trim();
                string matkhau = txt_TK_matkhau.Text.Trim();
                double quyen = cb_TK_Quyen.SelectedIndex == 0 ? 0 : 1;

                var result = await _mediator.Send(new RegisterCommand(email, matkhau, quyen));
                if (result.IsSuccess)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            XoaDuLieu();
            await HienThiThongtin();
            NotEnabledChucNang();
        }

        private async Task SuaTK()
        {
            try
            {
                if (vt == -1) return;

                string email = txt_TK_ten.Text.Trim();
                string matkhau = txt_TK_matkhau.Text.Trim();
                double quyen = cb_TK_Quyen.SelectedIndex == 0 ? 0 : 1;

                var result = await _mediator.Send(new UpdateAccountCommand(email, matkhau, quyen));
                if (result.IsSuccess)
                {
                    MessageBox.Show("Chỉnh sửa tài khoản thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa tài khoản không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            XoaDuLieu();
            NotEnabledChucNang();
            btn_TKSua.Enabled = false;
            btn_TKXoa.Enabled = false;
        }

        private async Task XoaTaiKhoan()
        {
            try
            {
                if (vt == -1) return;

                string email = txt_TK_ten.Text.Trim();
                var result = await _mediator.Send(new DeleteAccountCommand(email));

                if (result.IsSuccess)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async void btn_TK_Luu_Click(object sender, EventArgs e)
        {
            if (cn == 1) await ThemTK();
            else if (cn == 2) await SuaTK();
        }

        private async void btn_TKtimkiem_Click(object sender, EventArgs e)
        {
            string tentk = txt_TK_Tktentaikhoan.Text.Trim();
            var result = await _mediator.Send(new GetAccountsQuery(tentk));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_TaiKhoan.DataSource = table;
            }
        }

        private void btn_TKThem_Click(object sender, EventArgs e)
        {
            EnabledChucNang();
            cn = 1;
        }

        private void btn_TKSua_Click(object sender, EventArgs e)
        {
            cn = 2;
            EnabledChucNang();
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            btn_TKSua.Enabled = true;
            btn_TKXoa.Enabled = true;
            if (vt == -1 || vt >= ds.Tables["TaiKhoan"].Rows.Count) return;

            DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
            txt_TK_ten.Text = row["email"].ToString().Trim();
            txt_TK_matkhau.Text = row["matkhau"].ToString().Trim();
            if (row["quyen"].ToString().Trim() == "0") cb_TK_Quyen.SelectedIndex = 0;
            else if (row["quyen"].ToString().Trim() == "1") cb_TK_Quyen.SelectedIndex = 1;
        }

        private void btn_TK_Huy_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            NotEnabledChucNang();
            btn_TKSua.Enabled = false;
            btn_TKXoa.Enabled = false;
        }

        private async void btn_TKXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                await XoaTaiKhoan();
                XoaDuLieu();
                NotEnabledChucNang();
                btn_TKSua.Enabled = false;
                btn_TKXoa.Enabled = false;
            }
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
