using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.ChamCongAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class ChamCongRepository : EfRepository<ChamCong>, IChamCongRepository
{
    private readonly AppDbContext _dbContext;

    public ChamCongRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ChamCong>> GetAttendanceForMonthAsync(string maNV, int month, int year, CancellationToken cancellationToken = default)
    {
        return await _dbContext.ChamCongs
            .Where(x => x.MaNV == maNV && x.NgayCong.Month == month && x.NgayCong.Year == year)
            .ToListAsync(cancellationToken);
    }

    public async Task<List<ChamCong>> GetAttendanceForMonthAllEmployeesAsync(int month, int year, CancellationToken cancellationToken = default)
    {
        return await _dbContext.ChamCongs
            .Where(x => x.NgayCong.Month == month && x.NgayCong.Year == year)
            .ToListAsync(cancellationToken);
    }

    public async Task<ThangCong?> GetThangCongAsync(string maNV, int month, int year, CancellationToken cancellationToken = default)
    {
        return await _dbContext.ThangCongs
            .FirstOrDefaultAsync(x => x.MaNV == maNV && x.ThangTC == month && x.NamTC == year, cancellationToken);
    }

    public async Task<List<ThangCong>> GetThangCongListAsync(int month, int year, CancellationToken cancellationToken = default)
    {
        return await _dbContext.ThangCongs
            .Where(x => x.ThangTC == month && x.NamTC == year)
            .ToListAsync(cancellationToken);
    }

    public async Task AddThangCongAsync(ThangCong thangCong, CancellationToken cancellationToken = default)
    {
        await _dbContext.ThangCongs.AddAsync(thangCong, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateThangCongAsync(ThangCong thangCong, CancellationToken cancellationToken = default)
    {
        _dbContext.ThangCongs.Update(thangCong);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
