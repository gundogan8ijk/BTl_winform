using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.ChamCongAgg;

public interface IChamCongRepository : IRepository<ChamCong>
{
    Task<List<ChamCong>> GetAttendanceForMonthAsync(string maNV, int month, int year, CancellationToken cancellationToken = default);
    Task<List<ChamCong>> GetAttendanceForMonthAllEmployeesAsync(int month, int year, CancellationToken cancellationToken = default);
    Task<ThangCong?> GetThangCongAsync(string maNV, int month, int year, CancellationToken cancellationToken = default);
    Task<List<ThangCong>> GetThangCongListAsync(int month, int year, CancellationToken cancellationToken = default);
    Task AddThangCongAsync(ThangCong thangCong, CancellationToken cancellationToken = default);
    Task UpdateThangCongAsync(ThangCong thangCong, CancellationToken cancellationToken = default);
}
