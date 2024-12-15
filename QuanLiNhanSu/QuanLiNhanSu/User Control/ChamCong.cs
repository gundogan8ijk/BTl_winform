using QuanLiNhanSu.Class.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiNhanSu.User_Control
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
           
            dGVchamcong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dGVchamcong.Columns[5].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[7].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[9].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[11].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[13].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[15].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[3].DefaultCellStyle.BackColor = Color.LightGreen;
            combbnam.SelectedIndex = 2;
            HienThiChamCong();

        }

        static string cbbthang = "12";
        static string cbbnam = "2024";
        static string manv;

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void HienThiChamCong()
        {
            string dauthang = cbbnam + "-"+cbbthang+"-01";
            int daysInMonth = DateTime.DaysInMonth(int.Parse(cbbnam), int.Parse(cbbthang));
            string cuoithang = cbbnam + "-" + cbbthang + "-" + daysInMonth.ToString("D2");

            DateTime date = DateTime.ParseExact(dauthang, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = "\r\nSELECT \r\n    c.MaNV,\r\n    c.TenNV,\r\n    '"+dauthang+"' AS Thang,    -- Tháng\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 1 THEN c.TrangThai ELSE 0 END) AS Day1,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 2 THEN c.TrangThai ELSE 0 END) AS Day2,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 3 THEN c.TrangThai ELSE 0 END) AS Day3,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 4 THEN c.TrangThai ELSE 0 END) AS Day4,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 5 THEN c.TrangThai ELSE 0 END) AS Day5,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 6 THEN c.TrangThai ELSE 0 END) AS Day6,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 7 THEN c.TrangThai ELSE 0 END) AS Day7,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 8 THEN c.TrangThai ELSE 0 END) AS Day8,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 9 THEN c.TrangThai ELSE 0 END) AS Day9,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 10 THEN c.TrangThai ELSE 0 END) AS Day10,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 11 THEN c.TrangThai ELSE 0 END) AS Day11,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 12 THEN c.TrangThai ELSE 0 END) AS Day12,\r\n    SUM(CASE WHEN c.TrangThai = 1 THEN 1 ELSE 0 END) AS TongNgayCong\r\nFROM ChamCong c\r\nWHERE c.NgayCong BETWEEN '"+dauthang+"' AND '"+cuoithang+"'\r\nGROUP BY c.MaNV, c.TenNV;\r\n\r\n";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ThangCong");
            dGVchamcong.AutoGenerateColumns = false;
            dGVchamcong.DataSource = ds.Tables["ThangCong"];

            dGVchamcong.CellFormatting += new DataGridViewCellFormattingEventHandler(dGVchamcong_CellFormatting);

            database_Connect.DongKetNoi();
        }

        private void dGVchamcong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10 || e.ColumnIndex == 5 || e.ColumnIndex == 6||e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9
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
             cbbthang=combbthang.SelectedItem.ToString().Trim();
            btnxemcong.Enabled = true;
        }

        private void combbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
             cbbnam=combbnam.SelectedItem.ToString().Trim();
        }

        private void btnxemcong_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(manv) && !string.IsNullOrWhiteSpace(manv))) hienthitheoma(manv);
            else HienThiChamCong();
        }

        private void textmanv_TextChanged(object sender, EventArgs e)
        {
            manv=textmanv.Text.Trim();
        }

        private void hienthitheoma(string manv)
        {
            string dauthang = cbbnam + "-" + cbbthang + "-01";
            int daysInMonth = DateTime.DaysInMonth(int.Parse(cbbnam), int.Parse(cbbthang));
            string cuoithang = cbbnam + "-" + cbbthang + "-" + daysInMonth.ToString("D2");

            DateTime date = DateTime.ParseExact(dauthang, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = "\r\nSELECT \r\n    c.MaNV,\r\n    c.TenNV,\r\n    '" + dauthang + "' AS Thang,    -- Tháng\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 1 THEN c.TrangThai ELSE 0 END) AS Day1,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 2 THEN c.TrangThai ELSE 0 END) AS Day2,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 3 THEN c.TrangThai ELSE 0 END) AS Day3,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 4 THEN c.TrangThai ELSE 0 END) AS Day4,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 5 THEN c.TrangThai ELSE 0 END) AS Day5,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 6 THEN c.TrangThai ELSE 0 END) AS Day6,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 7 THEN c.TrangThai ELSE 0 END) AS Day7,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 8 THEN c.TrangThai ELSE 0 END) AS Day8,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 9 THEN c.TrangThai ELSE 0 END) AS Day9,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 10 THEN c.TrangThai ELSE 0 END) AS Day10,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 11 THEN c.TrangThai ELSE 0 END) AS Day11,\r\n    MAX(CASE WHEN DAY(c.NgayCong) = 12 THEN c.TrangThai ELSE 0 END) AS Day12,\r\n    SUM(CASE WHEN c.TrangThai = 1 THEN 1 ELSE 0 END) AS TongNgayCong\r\nFROM ChamCong c\r\nWHERE c.NgayCong BETWEEN '" + dauthang + "' AND '" + cuoithang + "'\r\n AND c.MaNV = '"+manv+"' \r\nGROUP BY c.MaNV, c.TenNV;\r\n\r\n";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "ThangCong");
            dGVchamcong.AutoGenerateColumns = false;
            dGVchamcong.DataSource = ds.Tables["ThangCong"];

            dGVchamcong.CellFormatting += new DataGridViewCellFormattingEventHandler(dGVchamcong_CellFormatting);

            database_Connect.DongKetNoi();
        }

        private void dGVchamcong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
