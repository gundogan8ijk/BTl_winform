using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.ChamCongApp;

namespace QuanLiNhanSu.User_Control
{
    public partial class ChamC : UserControl
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();
        private static string cbbthang = DateTime.Now.Month.ToString();
        private static string cbbnam = DateTime.Now.Year.ToString();
        private static string manv = "";
        private int vt = -1;

        public ChamC()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();

            dGVchamcong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            for (int i = 5; i < 16; i += 2)
            {
                if (dGVchamcong.Columns.Count > i)
                    dGVchamcong.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            if (dGVchamcong.Columns.Count > 3)
                dGVchamcong.Columns[3].DefaultCellStyle.BackColor = Color.LightGreen;
            
            combbnam.SelectedIndex = 2;
            HienThiChamCong();
        }

        private DataTable ToDataTable(List<ThangCongDto> list)
        {
            DataTable table = new DataTable("ThangCong");
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("ThangTC", typeof(int));
            table.Columns.Add("NamTC", typeof(int));
            for (int i = 1; i <= 12; i++)
            {
                table.Columns.Add($"Day{i}", typeof(bool));
            }

            foreach (var item in list)
            {
                table.Rows.Add(
                    item.MaNV,
                    item.TenNV,
                    item.ThangTC,
                    item.NamTC,
                    item.Day1 == 1,
                    item.Day2 == 1,
                    item.Day3 == 1,
                    item.Day4 == 1,
                    item.Day5 == 1,
                    item.Day6 == 1,
                    item.Day7 == 1,
                    item.Day8 == 1,
                    item.Day9 == 1,
                    item.Day10 == 1,
                    item.Day11 == 1,
                    item.Day12 == 1
                );
            }
            return table;
        }

        private void HienThiChamCong()
        {
            int t = int.Parse(cbbthang);
            int n = int.Parse(cbbnam);
            var result = _mediator.Send(new GetChamCongQuery(t, n)).AsTask().GetAwaiter().GetResult();
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dGVchamcong.AutoGenerateColumns = false;
                dGVchamcong.DataSource = table;
            }
        }

        private void hienthitheoma(string mnv)
        {
            int t = int.Parse(cbbthang);
            int n = int.Parse(cbbnam);
            var result = _mediator.Send(new GetChamCongQuery(t, n, mnv)).AsTask().GetAwaiter().GetResult();
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dGVchamcong.AutoGenerateColumns = false;
                dGVchamcong.DataSource = table;
            }
        }

        private void combbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbnam = combbnam.SelectedItem.ToString().Trim();
        }

        private void combbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbthang = combbthang.SelectedItem.ToString().Trim();
            btnxemcong.Enabled = true;
        }

        private void textmanv_TextChanged_1(object sender, EventArgs e)
        {
            btnTim.Enabled = true;
            manv = textmanv.Text.Trim();
        }

        private void btnxemcong_Click(object sender, EventArgs e)
        {
            HienThiChamCong();
            textmanv.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            hienthitheoma(manv);
            textmanv.Clear();
            btnTim.Enabled = false;
        }

        private void dGVchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1 || vt >= dGVchamcong.Rows.Count) return;

            var val = dGVchamcong.Rows[vt].Cells[0].Value;
            if (val != null)
            {
                txthienthima.Text = val.ToString().Trim();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 4; i < 16; i++)
            {
                if (dGVchamcong.Columns.Count > i)
                    dGVchamcong.Columns[i].ReadOnly = false;
            }
            btnbochon.Visible = true;
            btnLuu.Visible = true;
        }

        private void reload()
        {
            for (int i = 4; i < 16; i++)
            {
                if (dGVchamcong.Columns.Count > i)
                    dGVchamcong.Columns[i].ReadOnly = true;
            }
            btnbochon.Visible = false;
            btnLuu.Visible = false;
            txthienthima.Clear();
            textmanv.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (vt == -1) return;

                int t = int.Parse(cbbthang);
                int n = int.Parse(cbbnam);

                // Save changes for all modified rows
                foreach (DataGridViewRow gridRow in dGVchamcong.Rows)
                {
                    if (gridRow.IsNewRow) continue;

                    string rowMaNV = gridRow.Cells[0].Value.ToString().Trim();
                    int[] days = new int[12];
                    
                    for (int i = 0; i < 12; i++)
                    {
                        var cellVal = gridRow.Cells[i + 4].Value;
                        bool checkedState = false;
                        if (cellVal != null)
                        {
                            if (cellVal is bool b) checkedState = b;
                            else if (cellVal is int cellInt) checkedState = cellInt == 1;
                        }
                        days[i] = checkedState ? 1 : 0;
                    }

                    var result = _mediator.Send(new UpdateThangCongCommand(rowMaNV, t, n, days)).AsTask().GetAwaiter().GetResult();
                    if (!result.IsSuccess)
                    {
                        MessageBox.Show("Cập nhật ngày công thất bại cho NV: " + rowMaNV);
                        return;
                    }
                }

                MessageBox.Show("Bạn đã cập nhật lại các ngày công của tháng " + cbbthang, "", MessageBoxButtons.OK);
                HienThiChamCong();
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex.Message);
            }
        }

        private void btnbochon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textmanv.Text))
                hienthitheoma(manv);
            else HienThiChamCong();

            btnbochon.Visible = false;
        }
    }
}
