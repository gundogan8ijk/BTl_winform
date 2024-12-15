using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.Class.TaiKhoan
{
    public class Database_connect
    {
        string strCon = @"Data Source=LAPTOP-FV6UVTJE;Initial Catalog=QuanLiNhanVien;Integrated Security=True;Encrypt=False";
        public SqlConnection sqlCon = null;

        public void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        public void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}
