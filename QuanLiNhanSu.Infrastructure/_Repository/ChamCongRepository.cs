using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.ChamCongAgg;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class ChamCongRepository : EfRepository<ChamCong>, IChamCongRepository
{
    private readonly AppDbContext _dbContext;

    public ChamCongRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ChamCong>> GetAttendanceForMonthAsync(NhanVienId maNV, int month, int year, CancellationToken cancellationToken = default)
        => await _dbContext.ChamCongs
            .Where(x => x.MaNV == maNV && x.NgayCong.Month == month && x.NgayCong.Year == year)
            .ToListAsync(cancellationToken);

    public async Task<List<ChamCong>> GetAttendanceForMonthAllEmployeesAsync(int month, int year, CancellationToken cancellationToken = default)
        => await _dbContext.ChamCongs
            .Where(x => x.NgayCong.Month == month && x.NgayCong.Year == year)
            .ToListAsync(cancellationToken);
}
