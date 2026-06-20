using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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

        private async void Xuatds_Load(object sender, EventArgs e)
        {
            await Hienthidanhsach();
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
            table.Columns.Add("ThangVaoLam", typeof(int));

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

        public async Task Hienthidanhsach()
        {
            var result = await _mediator.Send(new GetNhanVienListQuery());
            if (result.IsSuccess)
            {
                ds = new DataSet();
                var table = ToDataTable(result.Value);
                ds.Tables.Add(table);
                dgv_Hienthi.DataSource = table;
            }
        }

        private async void btn_Xuatds_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Xuatds.Enabled = false;

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
                        for (int i = 0; i < 8; i++)
                            dataRow[i] = row.Cells[i].Value?.ToString();
                        dataTable.Rows.Add(dataRow);
                    }
                }

                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Chọn thư mục để lưu file Excel";
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = Path.Combine(folderDialog.SelectedPath, "DanhSachNhanVien.xlsx");
                        txt_FilePath.Text = filePath;
                        ExportFile(dataTable, "Danh sach", "DANH SÁCH NHÂN VIÊN", filePath);

                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                        catch
                        {
                            MessageBox.Show("Đã xuất file thành công!\nĐường dẫn: " + filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message);
            }
            finally
            {
                btn_Xuatds.Enabled = true;
            }
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = null;
            Microsoft.Office.Interop.Excel.Workbook oBook = null;
            Microsoft.Office.Interop.Excel.Worksheet oSheet = null;

            try
            {
                oExcel = new Microsoft.Office.Interop.Excel.Application();
                oExcel.Visible = false;
                oExcel.DisplayAlerts = false;

                oBook = oExcel.Workbooks.Add(Type.Missing);
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Sheets[1];
                oSheet.Name = sheetName;

                // Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Times New Roman";
                head.Font.Size = 20;
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                Marshal.ReleaseComObject(head);

                // Header cột
                string[] headers = { "Mã nhân viên", "Họ tên", "Ngày sinh", "Giới tính", "Số điện thoại", "Email", "Chức vụ", "Địa chỉ" };
                for (int i = 0; i < headers.Length; i++)
                {
                    string col = ((char)('A' + i)).ToString();
                    Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(col + "3", col + "3");
                    cl.Value2 = headers[i];
                    cl.Font.Bold = true;
                    cl.ColumnWidth = 15.0;
                    Marshal.ReleaseComObject(cl);
                }

                // Dữ liệu
                if (dataTable.Rows.Count > 0)
                {
                    object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                            arr[row, col] = dataTable.Rows[row][col];

                    string endCell = "H" + (dataTable.Rows.Count + 3);
                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range("A4", endCell);
                    range.Value2 = arr;
                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    Marshal.ReleaseComObject(range);
                }

                oBook.SaveAs(filePath);
            }
            finally
            {
                if (oBook != null) { oBook.Close(false); Marshal.ReleaseComObject(oBook); }
                if (oSheet != null) { Marshal.ReleaseComObject(oSheet); }
                if (oExcel != null) { oExcel.Quit(); Marshal.ReleaseComObject(oExcel); }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void dgv_Hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
