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
using QuanLiNhanSu.Class.TaiKhoan;

namespace QuanLiNhanSu.User_Control
{
    public partial class ChamC : UserControl
    {
        public ChamC()
        {
            InitializeComponent();
            dGVchamcong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            for (int i = 5; i < 16; i += 2)
                dGVchamcong.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            dGVchamcong.Columns[3].DefaultCellStyle.BackColor = Color.LightGreen;
            combbnam.SelectedIndex = 2;
            HienThiChamCong();
        }

        private static string cbbthang = DateTime.Now.Month.ToString();
        private static string cbbnam = DateTime.Now.Year.ToString();
        private static string manv;

        SqlDataAdapter adapter = null;
        DataSet ds = null;


        private void HienThiChamCong()
        {
           
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = $"select *from ThangCong where ThangTC={cbbthang} and NamTC={cbbnam};";
            
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
            //int[] coli = {4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //if (coli.Contains(e.ColumnIndex) && e.Value != null && e.Value.Equals(0))
            //    e.CellStyle.BackColor = Color.Red;
        }


        private void hienthitheoma(string manv)
        {
          
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = $"select *from ThangCong where MaNV= '{manv}' and ThangTC={cbbthang} and NamTC={cbbnam};";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            try
            {
                adapter.Fill(ds, "ThangCong");
                dGVchamcong.AutoGenerateColumns = false;
                dGVchamcong.DataSource = ds.Tables["ThangCong"];

                dGVchamcong.CellFormatting += new DataGridViewCellFormattingEventHandler(dGVchamcong_CellFormatting);

                database_Connect.DongKetNoi();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
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

        static int vt = -1;
        private void dGVchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            if (e.RowIndex >= 0)
            {
                var manv = dGVchamcong.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txthienthima.Text = manv;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for(int i = 4; i < 16; i++)
            {
                dGVchamcong.Columns[i].ReadOnly = false;
            }
            btnbochon.Visible = true;
            btnLuu.Visible = true;
        }
        private void reload()
        {
            for (int i = 4; i < 16; i++)
            {
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
                DataTable changes = ((DataTable)dGVchamcong.DataSource).GetChanges();
                if (changes != null)
                {
                    Database_connect database_Connect = new Database_connect();
                    database_Connect.MoKetNoi();

                    foreach (DataRow row in ds.Tables["ThangCong"].Rows)
                    {
                        for (int i = 1; i <= 12; i++)
                            row[$"Day{i}"] = (bool)dGVchamcong.Rows[row.Table.Rows.IndexOf(row)].Cells[$"day{i}"].Value ? 1 : 0;
                        row.EndEdit();
                    }

                    int kq = adapter.Update(ds.Tables["ThangCong"]);
                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn đã cập nhật lại các ngày công của tháng"+cbbthang,"", MessageBoxButtons.OK);
                        database_Connect.DongKetNoi();
                        HienThiChamCong();
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("cập nhật các ngày công thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("bạn chưa chỉnh sửa", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
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
