using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.ThangCongAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class ThangCongRepository : EfRepository<ThangCong>, IThangCongRepository
{
    private readonly AppDbContext _dbContext;

    public ThangCongRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ThangCong?> GetThangCongAsync(NhanVienId maNV, ThangNam thangNam, CancellationToken cancellationToken = default)
        => await _dbContext.ThangCongs
            .FirstOrDefaultAsync(x => x.MaNV == maNV && x.ThangNam == thangNam, cancellationToken);

    public async Task<List<ThangCong>> GetThangCongListAsync(ThangNam thangNam, CancellationToken cancellationToken = default)
        => await _dbContext.ThangCongs
            .Where(x => x.ThangNam == thangNam)
            .ToListAsync(cancellationToken);

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
