using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mediator;
using QuanLiNhanSu.UseCases.NhanVienApp;

namespace QuanLiNhanSu
{
    public partial class Xuatds : UserControl
    {
        private readonly IMediator _mediator;
        private DataSet ds = new DataSet();

        public Xuatds()
        {
            InitializeComponent();
            _mediator = Program.ServiceProvider.GetRequiredService<IMediator>();
        }

        private void Xuatds_Load(object sender, EventArgs e)
        {
            Hienthidanhsach();
        }

        private DataTable ToDataTable(List<NhanVienDto> list)
        {
            DataTable table = new DataTable("NhanSu");
            table.Columns.Add("MaNV", typeof(string));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgaySinh", typeof(string));
            table.Columns.Add("GioiTinh", typeof(string));
            table.Columns.Add("SoDienThoai", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("ChucVu", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("thangVaoLam", typeof(int));

            foreach (var item in list)
            {
                table.Rows.Add(
                    item.MaNV,
                    item.TenNV,
                    item.NgaySinh.ToString("dd/MM/yyyy"),
                    item.GioiTinh,
                    item.SoDienThoai,
                    item.Email,
                    item.ChucVu,
                    item.DiaChi,
                    item.ThangVaoLam
                );
            }
            return table;
        }

        public void Hienthidanhsach()
        {
            var result = _mediator.Send(new GetNhanVienListQuery()).AsTask().GetAwaiter().GetResult();
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthi.DataSource = table;
            }
        }

        private void btn_Xuatds_Click(object sender, EventArgs e)
        {
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

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn thư mục để lưu file Excel";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                string fileName = "DanhSachNhanVien.xlsx";
                string filePath = Path.Combine(folderPath, fileName);
                txt_FilePath.Text = filePath;

                ExportFile(dataTable, "Danh sach", "DANH SÁCH NHÂN VIÊN", filePath);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.Visible = false;
            oExcel.DisplayAlerts = false;

            Microsoft.Office.Interop.Excel.Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Sheets[1];
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            string[] headers = { "Mã nhân viên", "Họ tên", "Ngày sinh", "Giới tính", "Số điện thoại", "Email", "Chức vụ", "Địa chỉ" };
            for (int i = 0; i < headers.Length; i++)
            {
                Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(((char)('A' + i)).ToString() + "3", ((char)('A' + i)).ToString() + "3");
                cl.Value2 = headers[i];
                cl.ColumnWidth = 15.0;
            }

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataTable.Rows[row][col];
                }
            }

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range("A4", "H" + (dataTable.Rows.Count + 3).ToString());
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oBook.SaveAs(filePath);
            oBook.Close();
            oExcel.Quit();
        }

        private void dgv_Hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
