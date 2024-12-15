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

namespace QuanLiNhanSu
{
    public partial class Hienthidanhsach : UserControl
    {
        public Hienthidanhsach()
        {
            InitializeComponent();
            this.Load += Hienthidanhsach_Load;
        }

     

        SqlDataAdapter adapter = null;
        DataSet ds = null;

      

        private void Hienthidanhsach_Load(object sender, EventArgs e)
        {
            HienThiThongtin();
            gb_thongtin.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

        }

        private void HienThiThongtin()
        {
            Database_connect database_Connect   = new Database_connect();

            database_Connect.MoKetNoi();

            string sql = "select * from NhanVien";

            adapter = new SqlDataAdapter(sql,database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter); 
            ds = new DataSet();
            adapter.Fill(ds, "NhanSu");
            dgv_Hienthithongtin.DataSource = ds.Tables["NhanSu"];
        }

        private void TimKiemTheoMa(string manv)
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();

            string sql = "select * from NhanVien where MaNV = '" + manv + "'";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "TKMa");
            dgv_Hienthithongtin.DataSource = ds.Tables["TKMa"];
        }

        private void TimKiemTheoTen(string tennv)
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            string sql = "select * from NhanVien where TenNV like '%" + tennv + "%'";
            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "TKTen");
            dgv_Hienthithongtin.DataSource = ds.Tables["TKTen"];
        }

        // chuc nang
        private void ThemNhanVien()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                Database_connect database_Connect1 = new Database_connect();
                database_Connect1.MoKetNoi();

                // Kiểm tra nếu MaNV đã tồn tại trong cơ sở dữ liệu
                string maNV = txt_Masv.Text.Trim();
                string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand checkCommand = new SqlCommand(checkQuery, database_Connect1.sqlCon);
                checkCommand.Parameters.AddWithValue("@MaNV", maNV);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    // Thông báo nếu MaNV đã tồn tại
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                    return;  // Dừng hàm nếu trùng mã
                }

                // Tạo một dòng mới và điền thông tin
                DataRow row = ds.Tables["NhanSu"].NewRow();
                row["MaNV"] = maNV;
                row["TenNV"] = txt_Tennv.Text.Trim();
                row["NgaySinh"] = dtp_Ngaysinh.Value.ToString("yyyy-MM-dd");
                if (rdb_Nam.Checked) row["GioiTinh"] = "Nam";
                else if (rdb_Nu.Checked) row["GioiTinh"] = "Nữ";
                row["SoDienThoai"] = txt_Sdt.Text.Trim();
                row["Email"] = txt_Email.Text.Trim();
                row["ChucVu"] = cb_Chucvu.SelectedItem.ToString();
                row["DiaChi"] = txt_Diachi.Text.Trim();
                row["thangVaoLam"]= DateTime.Now.Month;

                // Thêm dòng mới vào DataTable
                ds.Tables["NhanSu"].Rows.Add(row);

                // Cập nhật dữ liệu vào cơ sở dữ liệu
                int kq = adapter.Update(ds.Tables["NhanSu"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    HienThiThongtin();  // Cập nhật thông tin hiển thị
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message);
            }
            finally
            {
                gb_thongtin.Enabled = false;
                XoaForm();
            }
        }

        private void SuaNhanVien()
        {
            try
            {
                if (vt == -1) return;
                Database_connect database_Connect   = new Database_connect();
                database_Connect.MoKetNoi();
                DataRow row = ds.Tables["NhanSu"].Rows[vt];
                row.BeginEdit();
                row["MaNV"] = txt_Masv.Text.Trim();
                row["TenNV"] = txt_Tennv.Text.Trim();
                row["NgaySinh"] = dtp_Ngaysinh.Value.Year + "-" + dtp_Ngaysinh.Value.Month + "-" + dtp_Ngaysinh.Value.Day;
                if (rdb_Nam.Checked) row["GioiTinh"] = "Nam";
                else if (rdb_Nu.Checked) row["GioiTinh"] = "Nữ";
                row["SoDienThoai"] = txt_Sdt.Text.Trim();
                row["Email"] = txt_Email.Text.Trim();
                row["ChucVu"] = cb_Chucvu.Text.Trim();
                row["DiaChi"] = txt_Diachi.Text.Trim();
                row.EndEdit();

                int kq = adapter.Update(ds.Tables["NhanSu"]);
                if (kq > 0)
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa nhân viên không thành công!");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Error !" + ex);

            }
            XoaForm();
            gb_thongtin.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

        }

        private void XoaNhanVien()
        {
            try
            {
                if (vt == -1) return;

                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                string manv = txt_Masv.Text;

                string query = $"DELETE FROM LuongNhanVien WHERE MaNV = '{manv}' DELETE FROM ThangCong WHERE MaNV = '{manv}' DELETE FROM ChamCong WHERE MaNV = '{manv}' DELETE FROM NhanVien WHERE MaNV = '{manv}'";

                SqlCommand sqlCmd = new SqlCommand(query, database_Connect.sqlCon);
                sqlCmd.CommandType = CommandType.Text;

                // Thực thi câu lệnh SQL
                int kq = sqlCmd.ExecuteNonQuery();

                // Kiểm tra kết quả
                if (kq > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công!", "Xóa nhân viên");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
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

        // Tim kiem
        private void btn_TImkiem_Click(object sender, EventArgs e)
        {
            string manv = txt_TKMa.Text.Trim();
            string tennv = txt_TKTen.Text.Trim();

            if (!string.IsNullOrEmpty(manv) && string.IsNullOrEmpty(tennv))
            {
                TimKiemTheoMa(manv);
            }
            else if (string.IsNullOrEmpty(manv) && !string.IsNullOrEmpty(tennv)) { 
                TimKiemTheoTen(tennv);
            }else if(!string.IsNullOrEmpty(manv) && !string.IsNullOrEmpty(tennv)){
                TimKiemTheoMa(manv);
            }else 
            {
                MessageBox.Show("Ban chua nhap thong tin !","Thong bao",MessageBoxButtons.OK);
            }
        }
        
        // Xoa nhan vien
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?","Thông báo"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) { 
                XoaNhanVien();
                XoaForm();
            }
        }

        int chucnang = 0;
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (chucnang == 1) ThemNhanVien();
            else if (chucnang == 2) SuaNhanVien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            chucnang = 1;
            gb_thongtin.Enabled = true;
            HienThiThongtin();
            XoaForm();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            gb_thongtin.Enabled = true;
        }

        // CellClick
        int vt = -1;
        private void dgv_Hienthithongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            if (vt == -1) return;

            DataRow row = ds.Tables["NhanSu"].Rows[vt];
            txt_Masv.Text = row["MaNV"].ToString().Trim();
            txt_Tennv.Text = row["TenNV"].ToString().Trim();
                string[] ns = row["Ngaysinh"].ToString().Trim().Split('/');
                string ngay = ns[0];
                string thang = ns[1];
                string nam = ns[2].Split(' ')[0]; 
                dtp_Ngaysinh.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));
            string gt = row["GioiTinh"].ToString().Trim();
            if(gt == "Nam") rdb_Nam.Checked = true;
            else if(gt == "Nữ") rdb_Nu.Checked = true;

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
