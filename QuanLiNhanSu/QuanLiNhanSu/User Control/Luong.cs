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

namespace QuanLiNhanSu
{
    public partial class Luong : UserControl
    {
        public Luong()
        {
            InitializeComponent();
            int thanghientai = DateTime.Now.Month;
            cbbthangluong.SelectedIndex = thanghientai - 1;
            int namhientai = DateTime.Now.Year;
            cbbnamluong.SelectedIndex = namhientai - 2023;
            this.dgv_Hienthiluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthiluong_CellClick);
            for(int i=0;i<11;i+=2)
            {
                dgv_Hienthiluong.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            dgv_Hienthiluong.Columns["colTienLuong"].DefaultCellStyle.BackColor = Color.LightYellow;

            dgv_Hienthiluong.Columns["colTienLuong"].DefaultCellStyle.Format = "N0";
            dgv_Hienthiluong.Columns["coltienthuong"].DefaultCellStyle.Format = "N0";
            dgv_Hienthiluong.Columns["coltienphat"].DefaultCellStyle.Format = "N0";
            dgv_Hienthiluong.Columns["PhuCap"].DefaultCellStyle.Format = "N0";
            dgv_Hienthiluong.Columns["Column2"].DefaultCellStyle.Format = "N0";
            HienThiLuong();
        }

 
        private static int thangluong = DateTime.Now.Month;
        private static int namluong = DateTime.Now.Year;
        private static string manv;
        private static string timtheoma;
        private static int tienthuong;
        private static int tienphat;


        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void HienThiLuong()
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = $"SELECT * FROM LuongNhanVien WHERE ThangNhanLuong = {thangluong} AND Nam = {namluong};";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "LuongNhanVien");
            dgv_Hienthiluong.DataSource = ds.Tables["LuongNhanVien"];

            database_Connect.DongKetNoi();
        }

        static int vt = -1;
        private void dgv_Hienthiluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            
            if (e.RowIndex >= 0)
            {
                var maNV = dgv_Hienthiluong.Rows[e.RowIndex].Cells["colManv"].Value.ToString().Trim();
                var tienLuong = dgv_Hienthiluong.Rows[e.RowIndex].Cells["colTienLuong"].Value.ToString().Trim();
                var tienphat = dgv_Hienthiluong.Rows[e.RowIndex].Cells["coltienphat"].Value.ToString().Trim();
                var tienthuong = dgv_Hienthiluong.Rows[e.RowIndex].Cells["coltienthuong"].Value.ToString().Trim();

                txt_Tienphat.Text = tienphat;
                txt_Tienthuong.Text= tienthuong;
                txtMnv.Text = maNV;
                txtTienluong.Text = tienLuong;
            }
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
        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            HienThiLuong();
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
                tienthuong= 0;
            }
            else tienthuong = Convert.ToInt32(txt_Tienthuong.Text);
        }

        private void txt_Tienphat_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled=true;
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

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
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

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_Tienthuong.ReadOnly = false;
            txt_Tienphat.ReadOnly=false;
        }

        string strCon = @"Data Source=LAPTOP-FV6UVTJE;Initial Catalog=QuanLiNhanVien;Integrated Security=True;Encrypt=False";
        public SqlConnection sqlCon = null;

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ((!string.IsNullOrEmpty(txtMnv.Text) && !string.IsNullOrWhiteSpace(txtMnv.Text)))
                {
                    if (vt == -1) return;
                    Database_connect database_Connect = new Database_connect();
                    database_Connect.MoKetNoi();

                    DataRow row = ds.Tables["LuongNhanVien"].Rows[vt];
                    row["Tienthuong"] = tienthuong;
                    row["Tienphat"] = tienphat;
                    row.EndEdit();
                    int kq = adapter.Update(ds.Tables["LuongNhanVien"]);

                    if (kq > 0)
                    {
                        MessageBox.Show("Bạn chỉnh sửa thông tin thành công!\n tiền thưởng:" + tienthuong + "\t tiền phạt:"+tienphat,"tháng:"+thangluong+"\tnăm:"+namluong, MessageBoxButtons.OK);
                        database_Connect.DongKetNoi();
                        XoaForm();
                        AnTxt();
                        HienThiLuong();
                    }
                    else
                    {
                        MessageBox.Show("chỉnh sửa tiền thưởng/phạt thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("bạn chưa nhập mã nhân viên", "", MessageBoxButtons.OK);
                }
            } catch(Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message);
            }
        }

        private void txtMnv_TextChanged(object sender, EventArgs e)
        {
            manv = txtMnv.Text;
        }

        private void hienthitheoma(string timtheoma)
        {
            try
            {
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                string sql = $"SELECT * FROM LuongNhanVien WHERE MaNV='{timtheoma}' AND ThangNhanLuong = {thangluong} AND Nam = {namluong};";

                adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "LuongNhanVien");
                dgv_Hienthiluong.DataSource = ds.Tables["LuongNhanVien"];

                database_Connect.DongKetNoi();
            }
            catch (Exception ex) {
                MessageBox.Show("lỗi: "+ex);
            }
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            btnTimma.Enabled = true;
            timtheoma = txtTimMa.Text;
        }


        private void btnTimma_Click(object sender, EventArgs e)
        {
            hienthitheoma(timtheoma);
            XoaForm();
            AnTxt();
            btnTimma.Enabled = false;
        }

        private void txtTienluong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
