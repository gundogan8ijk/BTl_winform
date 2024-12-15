using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class.TaiKhoan;

namespace QuanLiNhanSu.User_Control
{
    public partial class Taikhoan : UserControl
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            HienThiThongtin();
            NotEnabledChucNang();
            btn_TKXoa.Enabled = false;
            btn_TKSua.Enabled = false;

        }


      

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        // Mo ket noi

        private void HienThiThongtin()
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            string sql = "select * from TaiKhoan";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon   );
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "TaiKhoan");
            dgv_TaiKhoan.DataSource = ds.Tables["TaiKhoan"];
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

        private void ThemTK()
        {
            try
            {
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                DataRow row = ds.Tables["TaiKhoan"].NewRow();
                row["email"] = txt_TK_ten.Text.Trim();
                row["matkhau"] = txt_TK_matkhau.Text.Trim();
                if (cb_TK_Quyen.SelectedIndex == 0) row["quyen"] = 0;
                else if (cb_TK_Quyen.SelectedIndex == 1) row["quyen"] = 1;


                ds.Tables["TaiKhoan"].Rows.Add(row);
                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm tai khoan thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Thêm tai khoan không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }
            XoaDuLieu();
            HienThiThongtin();
            NotEnabledChucNang();
        }


        private void SuaTK()
        {
            try
            {
                if (vt == -1) return;
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
                row.BeginEdit();
                row["email"] = txt_TK_ten.Text.Trim();
                row["matkhau"] = txt_TK_matkhau.Text.Trim();
                if (cb_TK_Quyen.SelectedIndex == 0) row["quyen"] = 0;
                else if (cb_TK_Quyen.SelectedIndex == 1) row["quyen"] = 1;
                row.EndEdit();

                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Chỉnh sửa tài khoản thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa tài khoản không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);

            }
            XoaDuLieu();
            NotEnabledChucNang() ;
            btn_TKSua.Enabled = false;
            btn_TKXoa.Enabled = false;
        }

        private void XoaTaiKhoan()
        {
            try
            {
                if (vt == -1) return;
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();
                DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
                row.Delete();

                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa tai khoan thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Xoa tai khoan không thành công!", "Xoa tai khoan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }
        }
        int cn = 0;
        private void btn_TK_Luu_Click(object sender, EventArgs e)
        {
            if (cn == 1) ThemTK();
            else if (cn == 2) SuaTK();
        }


        private void btn_TKtimkiem_Click(object sender, EventArgs e)
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            string tentk = txt_TK_Tktentaikhoan.Text.Trim();
            string sql = "select * from TaiKhoan where email like '%" + tentk + "%'";
            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "TKTen");
            dgv_TaiKhoan.DataSource = ds.Tables["TKTen"];
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

        int vt = -1;
        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            btn_TKSua.Enabled = true;
            btn_TKXoa.Enabled = true;
            if (vt == -1) return;

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
            btn_TKSua.Enabled   = false; 
            btn_TKXoa.Enabled = false;  
        }

        private void btn_TKXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa tai khoan này không ?", "Thông báo"
              , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaTaiKhoan();
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
