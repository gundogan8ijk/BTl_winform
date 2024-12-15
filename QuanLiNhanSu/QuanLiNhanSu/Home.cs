using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class;
using QuanLiNhanSu.User_Control;
namespace QuanLiNhanSu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            float quyen = Const.quyen_;

            if (quyen > 0) { 
                btn_Luong.Enabled = false;
                btn_Taikhoan.Enabled = false;
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Hiển thị User Control hienthidanhsach
            Hienthidanhsach danhSach = new Hienthidanhsach();
            danhSach.Dock = DockStyle.Fill;

            // Kiểm tra nếu User Control chưa được thêm
            if (!this.Controls.Contains(danhSach))
            {
                this.Controls.Add(danhSach);
            }

            danhSach.BringToFront(); 
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Tạo và thêm User Control mới
            ChamC chamC = new ChamC();  
            chamC.Dock = DockStyle.Fill;
            this.Controls.Add(chamC);   
            chamC.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.Dock = DockStyle.Fill;
            this.Controls.Add(luong);
            luong.BringToFront();
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có đăng xuất không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap(); 
                dangNhap.Show();
                this.Hide();
            }
        }
        
        private void hienthidanhsach1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {
            Taikhoan taikhoan = new Taikhoan(); 
            taikhoan.Dock = DockStyle.Fill;
            this.Controls.Add (taikhoan);
            taikhoan.BringToFront();
        }

        // Xuat file excel
    

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            Xuatds xuatds = new Xuatds();   
            xuatds.Dock = DockStyle.Fill;   
            this.Controls.Add(xuatds);
            xuatds.BringToFront();
        }

        //private void xuấtDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DataTable dataTable = new DataTable();

        //    dataTable.Columns.Add("MaNV");
        //    dataTable.Columns.Add("TenNV");
        //    dataTable.Columns.Add("NgaySinh");
        //    dataTable.Columns.Add("GioiTinh");
        //    dataTable.Columns.Add("SoDienThoai");
        //    dataTable.Columns.Add("Email");
        //    dataTable.Columns.Add("ChucVu");
        //    dataTable.Columns.Add("DiaChi");


        //    foreach (DataGridView dtgvRows in dg.Rows)
        //    {
        //        DataRow dataRow =dataTable.NewRow();

        //        dataRow[0] = dtgvRows.Cells[0].Value;
        //        dataRow[1] = dtgvRows.Cells[1].Value;
        //        dataRow[2] = dtgvRows.Cells[2].Value;
        //        dataRow[3] = dtgvRows.Cells[3].Value;
        //        dataRow[4] = dtgvRows.Cells[4].Value;
        //        dataRow[5] = dtgvRows.Cells[5].Value;
        //        dataRow[6] = dtgvRows.Cells[6].Value;
        //        dataRow[7] = dtgvRows.Cells[7].Value;


        //        dataTable.Rows.Add(dataRow);
        //    }

        //    ExportFile(dataTable,"Danh sach","DANH SÁCH NHÂN VIÊN");

        //}

        //public void ExportFile(DataTable dataTable, string sheetName, string title)
        //{
        //    //Tạo các đối tượng Excel

        //    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

        //    Microsoft.Office.Interop.Excel.Workbooks oBooks;

        //    Microsoft.Office.Interop.Excel.Sheets oSheets;

        //    Microsoft.Office.Interop.Excel.Workbook oBook;

        //    Microsoft.Office.Interop.Excel.Worksheet oSheet;

        //    //Tạo mới một Excel WorkBook 

        //    oExcel.Visible = true;

        //    oExcel.DisplayAlerts = false;

        //    oExcel.Application.SheetsInNewWorkbook = 1;

        //    oBooks = oExcel.Workbooks;

        //    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

        //    oSheets = oBook.Worksheets;

        //    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

        //    oSheet.Name = sheetName;


        //    // Tạo phần Tiêu đề
        //    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

        //    head.MergeCells = true;

        //    head.Value2 = title;

        //    head.Font.Bold = true;

        //    head.Font.Name = "Times New Roman";

        //    head.Font.Size = "20";

        //    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo tiêu đề cột 

        //    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

        //    cl1.Value2 = "Mã nhân viên";

        //    cl1.ColumnWidth = 12;

        //    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

        //    cl2.Value2 = "Họ tên";

        //    cl2.ColumnWidth = 25.0;

        //    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

        //    cl3.Value2 = "Ngày sinh";
        //    cl3.ColumnWidth = 15.0;

        //    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

        //    cl4.Value2 = "Giới tính";

        //    cl4.ColumnWidth = 10.5;

        //    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

        //    cl5.Value2 = "Số điện thoại";

        //    cl5.ColumnWidth = 13.0;

        //    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

        //    cl6.Value2 = "Email";

        //    cl6.ColumnWidth = 15.5;

        //    Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

        //    cl7.Value2 = "Chức vụ";

        //    cl7.ColumnWidth = 13.5;


        //    Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

        //    cl7.Value2 = "Địa chỉ";

        //    cl7.ColumnWidth = 20.5;

        //    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

        //    rowHead.Font.Bold = true;

        //    // Kẻ viền

        //    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Thiết lập màu nền

        //    rowHead.Interior.ColorIndex = 6;

        //    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo mảng theo datatable

        //    object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

        //    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

        //    for (int row = 0; row < dataTable.Rows.Count; row++)
        //    {
        //        DataRow dataRow = dataTable.Rows[row];

        //        for (int col = 0; col < dataTable.Columns.Count; col++)
        //        {
        //            arr[row, col] = dataRow[col];
        //        }
        //    }

        //    //Thiết lập vùng điền dữ liệu

        //    int rowStart = 4;

        //    int columnStart = 1;

        //    int rowEnd = rowStart + dataTable.Rows.Count - 2;

        //    int columnEnd = dataTable.Columns.Count;

        //    // Ô bắt đầu điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

        //    // Ô kết thúc điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

        //    // Lấy về vùng điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

        //    //Điền dữ liệu vào vùng đã thiết lập

        //    range.Value2 = arr;

        //    // Kẻ viền

        //    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Căn giữa cột mã nhân viên

        //    //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

        //    //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

        //    //Căn giữa cả bảng 
        //    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //}


    }
}
