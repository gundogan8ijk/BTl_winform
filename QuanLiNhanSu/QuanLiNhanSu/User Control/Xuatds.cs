using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class.TaiKhoan;

namespace QuanLiNhanSu
{
    public partial class Xuatds : UserControl
    {
        public Xuatds()
        {
            InitializeComponent();
        }

        private void Xuatds_Load(object sender, EventArgs e)
        {
            Hienthidanhsach();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public void Hienthidanhsach()
        {
           Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();    

            string sql = "select * from NhanVien";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "NhanSu");
            dgv_Hienthi.DataSource = ds.Tables["NhanSu"];
        }

        private void btn_Xuatds_Click(object sender, EventArgs e)
        {
            // Tạo DataTable và điền dữ liệu từ DataGridView
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("MaNV");
            dataTable.Columns.Add("TenNV");
            dataTable.Columns.Add("NgaySinh");
            dataTable.Columns.Add("GioiTinh");
            dataTable.Columns.Add("SoDienThoai");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("ChucVu");
            dataTable.Columns.Add("DiaChi");

            foreach (DataGridViewRow row in dgv_Hienthi.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = row.Cells[0].Value?.ToString();
                    dataRow[1] = row.Cells[1].Value?.ToString();
                    dataRow[2] = row.Cells[2].Value?.ToString();
                    dataRow[3] = row.Cells[3].Value?.ToString();
                    dataRow[4] = row.Cells[4].Value?.ToString();
                    dataRow[5] = row.Cells[5].Value?.ToString();
                    dataRow[6] = row.Cells[6].Value?.ToString();
                    dataRow[7] = row.Cells[7].Value?.ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }
            // Mở FolderBrowserDialog để chọn thư mục
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục để lưu file Excel";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục đã chọn
                string folderPath = folderBrowserDialog.SelectedPath;

                // Lấy tên file cần lưu (có thể thêm tên file mặc định hoặc yêu cầu người dùng nhập)
                string fileName = "DanhSachNhanVien.xlsx";  // Tên file mặc định

                // Kết hợp đường dẫn thư mục và tên file
                string filePath = Path.Combine(folderPath, fileName);

                // Gán đường dẫn vào TextBox
                txt_FilePath.Text = filePath;

                // Xuất dữ liệu ra Excel tại đường dẫn đã chọn
                ExportFile(dataTable, "Danh sach", "DANH SÁCH NHÂN VIÊN", filePath);
                System.Diagnostics.Process.Start(filePath);
            }
        }


        public void ExportFile(DataTable dataTable, string sheetName, string title, string filePath)
        {
            // Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.Visible = false;  // Ẩn Excel khi lưu file
            oExcel.DisplayAlerts = false;

            Microsoft.Office.Interop.Excel.Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Sheets[1];
            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            string[] headers = { "Mã nhân viên", "Họ tên", "Ngày sinh", "Giới tính", "Số điện thoại", "Email", "Chức vụ", "Địa chỉ" };
            for (int i = 0; i < headers.Length; i++)
            {
                Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(((char)('A' + i)).ToString() + "3", ((char)('A' + i)).ToString() + "3");
                cl.Value2 = headers[i];
                cl.ColumnWidth = 15.0;
            }

            // Tạo mảng dữ liệu để xuất vào Excel
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataTable.Rows[row][col];
                }
            }

            // Điền dữ liệu vào Excel
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range("A4", "H" + (dataTable.Rows.Count + 3).ToString());
            range.Value2 = arr;

            // Kẻ viền và căn giữa dữ liệu
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Lưu file Excel tại đường dẫn đã chọn
            oBook.SaveAs(filePath);
            oBook.Close();
            oExcel.Quit();
        }

        private void dgv_Hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
