using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.LuongNhanVienAgg;

public interface ILuongNhanVienRepository : IRepository<LuongNhanVien>
{
    Task<LuongNhanVien?> GetByEmployeeMonthYearAsync(string maNV, int thang, int nam, CancellationToken cancellationToken = default);
    Task<List<LuongNhanVien>> GetByMonthYearAsync(int thang, int nam, CancellationToken cancellationToken = default);
}
