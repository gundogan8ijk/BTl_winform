using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.ChamCongAgg;

public interface IChamCongRepository : IRepository<ChamCong>
{
    Task<List<ChamCong>> GetAttendanceForMonthAsync(NhanVienId maNV, int month, int year, CancellationToken cancellationToken = default);
    Task<List<ChamCong>> GetAttendanceForMonthAllEmployeesAsync(int month, int year, CancellationToken cancellationToken = default);
}
