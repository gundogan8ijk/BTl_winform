using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class NhanVienRepository : EfRepository<NhanVien>, INhanVienRepository
{
    private readonly AppDbContext _dbContext;

    public NhanVienRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<NhanVien?> GetByMaNVAsync(string maNV, CancellationToken cancellationToken = default)
    {
        return await _dbContext.NhanViens
            .FirstOrDefaultAsync(x => x.Id == maNV, cancellationToken);
    }

    public async Task<List<NhanVien>> GetByTenNVAsync(string tenNV, CancellationToken cancellationToken = default)
    {
        return await _dbContext.NhanViens
            .Where(x => x.TenNV.Contains(tenNV))
            .ToListAsync(cancellationToken);
    }

    public async Task<bool> ExistsByMaNVAsync(string maNV, CancellationToken cancellationToken = default)
    {
        return await _dbContext.NhanViens
            .AnyAsync(x => x.Id == maNV, cancellationToken);
    }
}
