using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.ChamCong;
using QuanLiNhanSu.UseCases.ThangCong;

namespace QuanLiNhanSu.User_Control
{
    public partial class ChamCong : Form
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();
        private static string cbbthang = "12";
        private static string cbbnam = "2024";
        private static string manv = "";

        public ChamCong()
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
            _ = HienThiChamCong();
        }

        private DataTable ToDataTable(List<ThangCongDto> list)
        {
            DataTable table = new DataTable("ThangCong");
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("Thang", typeof(string));
            for (int i = 1; i <= 12; i++)
            {
                table.Columns.Add($"Day{i}", typeof(int));
            }
            table.Columns.Add("TongNgayCong", typeof(int));

            foreach (var item in list)
            {
                int tong = item.Day1 + item.Day2 + item.Day3 + item.Day4 + item.Day5 + item.Day6 + item.Day7 + item.Day8 + item.Day9 + item.Day10 + item.Day11 + item.Day12;
                table.Rows.Add(
                    item.MaNV,
                    item.TenNV,
                    $"{item.ThangTC}/{item.NamTC}",
                    item.Day1,
                    item.Day2,
                    item.Day3,
                    item.Day4,
                    item.Day5,
                    item.Day6,
                    item.Day7,
                    item.Day8,
                    item.Day9,
                    item.Day10,
                    item.Day11,
                    item.Day12,
                    tong
                );
            }
            return table;
        }

        private async Task HienThiChamCong()
        {
            int t = int.Parse(cbbthang);
            int n = int.Parse(cbbnam);

            var result = await _mediator.Send(new GetChamCongQuery(t, n));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dGVchamcong.AutoGenerateColumns = false;
                dGVchamcong.DataSource = table;
            }
        }

        private void dGVchamcong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9
                || e.ColumnIndex == 11 || e.ColumnIndex == 12 || e.ColumnIndex == 13 || e.ColumnIndex == 14 || e.ColumnIndex == 15)
            {
                if (e.Value != null && e.Value.Equals(0))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void combbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbthang = combbthang.SelectedItem.ToString().Trim();
            btnxemcong.Enabled = true;
        }

        private void combbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbnam = combbnam.SelectedItem.ToString().Trim();
        }

        private async void btnxemcong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(manv)) await hienthitheoma(manv);
            else await HienThiChamCong();
        }

        private void textmanv_TextChanged(object sender, EventArgs e)
        {
            manv = textmanv.Text.Trim();
        }

        private async Task hienthitheoma(string mnv)
        {
            int t = int.Parse(cbbthang);
            int n = int.Parse(cbbnam);

            var result = await _mediator.Send(new GetChamCongQuery(t, n, mnv));
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dGVchamcong.AutoGenerateColumns = false;
                dGVchamcong.DataSource = table;
            }
        }

        private void dGVchamcong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
