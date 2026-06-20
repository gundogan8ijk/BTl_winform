using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.NhanVien;

namespace QuanLiNhanSu
{
    public partial class Hienthidanhsach : UserControl
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();
        private int vt = -1;
        private int chucnang = 0;

        public Hienthidanhsach()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();
            this.Load += Hienthidanhsach_Load;
        }

        private async void Hienthidanhsach_Load(object sender, EventArgs e)
        {
            await HienThiThongtin();
            gb_thongtin.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private DataTable ToDataTable(List<NhanVienDto> list)
        {
            DataTable table = new DataTable("NhanSu");
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgaySinh", typeof(string));
            table.Columns.Add("GioiTinh", typeof(string));
            table.Columns.Add("SoDienThoai", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("ChucVu", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("thangVaoLam", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(
                    item.MaNV,
                    item.TenNV,
                    item.NgaySinh.ToString("dd/MM/yyyy"),
                    item.GioiTinh,
                    item.SoDienThoai,
                    item.Email,
                    item.ChucVu,
                    item.DiaChi,
                    item.ThangVaoLam
                );
            }
            return table;
        }

        private async Task HienThiThongtin()
        {
            var result = await _mediator.Send(new GetNhanVienListQuery());
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthithongtin.DataSource = table;
            }
        }

        private async Task TimKiemTheoMa(string manv)
        {
            var result = await _mediator.Send(new GetNhanVienListQuery(MaNV: manv));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthithongtin.DataSource = table;
            }
        }

        private async Task TimKiemTheoTen(string tennv)
        {
            var result = await _mediator.Send(new GetNhanVienListQuery(TenNV: tennv));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthithongtin.DataSource = table;
            }
        }

        private async Task ThemNhanVien()
        {
            try
            {
                string maNV = txt_Masv.Text.Trim();
                string tenNV = txt_Tennv.Text.Trim();
                DateTime ngaySinh = dtp_Ngaysinh.Value;
                string gioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ";
                string sdt = txt_Sdt.Text.Trim();
                string email = txt_Email.Text.Trim();
                string chucVu = cb_Chucvu.SelectedItem?.ToString() ?? "Nhân viên";
                string diaChi = txt_Diachi.Text.Trim();
                int thangVaoLam = DateTime.Now.Month;

                var result = await _mediator.Send(new CreateNhanVienCommand(
                    maNV, tenNV, ngaySinh, gioiTinh, sdt, email, chucVu, diaChi, thangVaoLam
                ));

                if (result.IsSuccess)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                gb_thongtin.Enabled = false;
                XoaForm();
            }
        }

        private async Task SuaNhanVien()
        {
            try
            {
                if (vt == -1) return;

                string maNV = txt_Masv.Text.Trim();
                string tenNV = txt_Tennv.Text.Trim();
                DateTime ngaySinh = dtp_Ngaysinh.Value;
                string gioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ";
                string sdt = txt_Sdt.Text.Trim();
                string email = txt_Email.Text.Trim();
                string chucVu = cb_Chucvu.Text.Trim();
                string diaChi = txt_Diachi.Text.Trim();

                var result = await _mediator.Send(new UpdateNhanVienCommand(
                    maNV, tenNV, ngaySinh, gioiTinh, sdt, email, chucVu, diaChi
                ));

                if (result.IsSuccess)
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa nhân viên không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                XoaForm();
                gb_thongtin.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private async Task XoaNhanVien()
        {
            try
            {
                string manv = txt_Masv.Text.Trim();
                var result = await _mediator.Send(new DeleteNhanVienCommand(manv));

                if (result.IsSuccess)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    await HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công: " + string.Join(", ", result.Errors));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XoaForm()
        {
            txt_Masv.Clear();
            txt_Tennv.Clear();
            txt_Diachi.Clear();
            txt_Sdt.Clear();
            txt_Email.Clear();
            txt_TKMa.Clear();
            txt_TKTen.Clear();
        }

        private async void btn_TImkiem_Click(object sender, EventArgs e)
        {
            string manv = txt_TKMa.Text.Trim();
            string tennv = txt_TKTen.Text.Trim();

            if (!string.IsNullOrEmpty(manv))
            {
                await TimKiemTheoMa(manv);
            }
            else if (!string.IsNullOrEmpty(tennv))
            {
                await TimKiemTheoTen(tennv);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private async void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                await XoaNhanVien();
                XoaForm();
            }
        }

        private async void btn_Luu_Click(object sender, EventArgs e)
        {
            if (chucnang == 1) await ThemNhanVien();
            else if (chucnang == 2) await SuaNhanVien();
        }

        private async void btn_Them_Click(object sender, EventArgs e)
        {
            chucnang = 1;
            gb_thongtin.Enabled = true;
            await HienThiThongtin();
            XoaForm();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            gb_thongtin.Enabled = true;
        }

        private void dgv_Hienthithongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            if (vt == -1 || vt >= ds.Tables["NhanSu"].Rows.Count) return;

            DataRow row = ds.Tables["NhanSu"].Rows[vt];
            txt_Masv.Text = row["MaNV"].ToString().Trim();
            txt_Tennv.Text = row["TenNV"].ToString().Trim();

            string[] ns = row["NgaySinh"].ToString().Trim().Split('/');
            if (ns.Length >= 3)
            {
                string ngay = ns[0];
                string thang = ns[1];
                string nam = ns[2].Split(' ')[0];
                dtp_Ngaysinh.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));
            }

            string gt = row["GioiTinh"].ToString().Trim();
            if (gt == "Nam") rdb_Nam.Checked = true;
            else if (gt == "Nữ") rdb_Nu.Checked = true;

            txt_Sdt.Text = row["SoDienThoai"].ToString().Trim();
            txt_Email.Text = row["Email"].ToString().Trim();
            cb_Chucvu.Text = row["ChucVu"].ToString().Trim();
            txt_Diachi.Text = row["DiaChi"].ToString().Trim();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            XoaForm();
            gb_thongtin.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void dgv_Hienthithongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txt_Masv_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
