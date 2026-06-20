using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.LuongApp;

namespace QuanLiNhanSu
{
    public partial class Luong : UserControl
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();
        private int vt = -1;
        private int thangluong = DateTime.Now.Month;
        private int namluong = DateTime.Now.Year;
        private string manv = "";
        private string timtheoma = "";
        private int tienthuong = 0;
        private int tienphat = 0;

        public Luong()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();

            int thanghientai = DateTime.Now.Month;
            cbbthangluong.SelectedIndex = thanghientai - 1;
            int namhientai = DateTime.Now.Year;
            cbbnamluong.SelectedIndex = namhientai - 2023;
            
            this.dgv_Hienthiluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthiluong_CellClick);
            
            for (int i = 0; i < 11; i += 2)
            {
                if (dgv_Hienthiluong.Columns.Count > i)
                    dgv_Hienthiluong.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            if (dgv_Hienthiluong.Columns.Contains("colTienLuong"))
            {
                dgv_Hienthiluong.Columns["colTienLuong"].DefaultCellStyle.BackColor = Color.LightYellow;
                dgv_Hienthiluong.Columns["colTienLuong"].DefaultCellStyle.Format = "N0";
            }
            if (dgv_Hienthiluong.Columns.Contains("coltienthuong"))
                dgv_Hienthiluong.Columns["coltienthuong"].DefaultCellStyle.Format = "N0";
            if (dgv_Hienthiluong.Columns.Contains("coltienphat"))
                dgv_Hienthiluong.Columns["coltienphat"].DefaultCellStyle.Format = "N0";
            if (dgv_Hienthiluong.Columns.Contains("PhuCap"))
                dgv_Hienthiluong.Columns["PhuCap"].DefaultCellStyle.Format = "N0";
            if (dgv_Hienthiluong.Columns.Contains("Column2"))
                dgv_Hienthiluong.Columns["Column2"].DefaultCellStyle.Format = "N0";

            _ = HienThiLuong();
        }

        private DataTable ToDataTable(List<LuongNhanVienDto> list)
        {
            DataTable table = new DataTable("LuongNhanVien");
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("ThangNhanLuong", typeof(int));
            table.Columns.Add("Nam", typeof(int));
            table.Columns.Add("Tienthuong", typeof(double));
            table.Columns.Add("Tienphat", typeof(double));
            table.Columns.Add("PhuCap", typeof(double));
            table.Columns.Add("TienLuong", typeof(double));
            table.Columns.Add("TongLuong", typeof(double));

            foreach (var item in list)
            {
                table.Rows.Add(
                    item.MaNV,
                    item.ThangNhanLuong,
                    item.Nam,
                    item.TienThuong,
                    item.TienPhat,
                    item.PhuCap,
                    item.TienLuong,
                    item.TongLuong
                );
            }
            return table;
        }

        private async Task HienThiLuong()
        {
            var result = await _mediator.Send(new GetLuongListQuery(thangluong, namluong));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthiluong.DataSource = table;
            }
        }

        private void dgv_Hienthiluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1 || vt >= ds.Tables["LuongNhanVien"].Rows.Count) return;

            DataRow row = ds.Tables["LuongNhanVien"].Rows[vt];
            txtMnv.Text = row["MaNV"].ToString().Trim();
            txtTienluong.Text = row["TienLuong"].ToString().Trim();
            txt_Tienthuong.Text = row["Tienthuong"].ToString().Trim();
            txt_Tienphat.Text = row["Tienphat"].ToString().Trim();
        }

        private void XoaForm()
        {
            txtTimMa.Clear();
            txtMnv.Clear();
            txt_Tienthuong.Clear();
            txt_Tienphat.Clear();
            txtTienluong.Clear();
        }

        private void AnTxt()
        {
            txt_Tienphat.ReadOnly = true;
            txt_Tienthuong.ReadOnly = true;
            btnLuu.Enabled = true;
        }

        private async void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            await HienThiLuong();
            XoaForm();
            AnTxt();
        }

        private void txt_Mnv_TextChanged(object sender, EventArgs e)
        {
            manv = txtMnv.Text.Trim();
        }

        private void txt_Luongcoban_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void cbbthangluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            thangluong = Convert.ToInt32(cbbthangluong.SelectedItem);
        }

        private void cbbnamluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            namluong = Convert.ToInt32(cbbnamluong.SelectedItem);
        }

        private void txt_Tienthuong_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            if (string.IsNullOrEmpty(txt_Tienthuong.Text))
            {
                tienthuong = 0;
            }
            else tienthuong = Convert.ToInt32(txt_Tienthuong.Text);
        }

        private void txt_Tienphat_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            if (string.IsNullOrEmpty(txt_Tienphat.Text))
            {
                tienphat = 0;
            }
            else  tienphat = Convert.ToInt32(txt_Tienphat.Text);
        }

        private void txt_Tienthuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Tienphat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_Tienthuong.ReadOnly = false;
            txt_Tienphat.ReadOnly = false;
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMnv.Text))
                {
                    if (vt == -1) return;

                    string mnv = txtMnv.Text.Trim();
                    var result = await _mediator.Send(new UpdateBonusPenaltyCommand(
                        mnv, thangluong, namluong, tienthuong, tienphat
                    ));

                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Bạn chỉnh sửa thông tin thành công!\n tiền thưởng: " + tienthuong + "\t tiền phạt: " + tienphat, "tháng: " + thangluong + "\tnăm: " + namluong, MessageBoxButtons.OK);
                        XoaForm();
                        AnTxt();
                        await HienThiLuong();
                    }
                    else
                    {
                        MessageBox.Show("chỉnh sửa tiền thưởng/phạt thất bại: " + string.Join(", ", result.Errors));
                    }
                }
                else
                {
                    MessageBox.Show("bạn chưa nhập mã nhân viên", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
        }

        private void txtMnv_TextChanged(object sender, EventArgs e)
        {
            manv = txtMnv.Text;
        }

        private async Task hienthitheoma(string timtheoma)
        {
            try
            {
                var result = await _mediator.Send(new GetLuongListQuery(thangluong, namluong, timtheoma));
                if (result.IsSuccess)
                {
                    ds = new DataSet();
                    var table = ToDataTable(result.Value);
                    ds.Tables.Add(table);
                    dgv_Hienthiluong.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            btnTimma.Enabled = true;
            timtheoma = txtTimMa.Text;
        }

        private async void btnTimma_Click(object sender, EventArgs e)
        {
            await hienthitheoma(timtheoma);
            XoaForm();
            AnTxt();
            btnTimma.Enabled = false;
        }

        private void txtTienluong_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
