using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.Core.LuongNhanVienAgg;

public interface ILuongNhanVienRepository : IRepository<LuongNhanVien>
{
    Task<LuongNhanVien?> GetByEmployeeMonthYearAsync(NhanVienId maNV, ThangNam thangNam, CancellationToken cancellationToken = default);
    Task<List<LuongNhanVien>> GetByMonthYearAsync(ThangNam thangNam, CancellationToken cancellationToken = default);
}
