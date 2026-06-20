using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class NhanVienRepository : EfRepository<NhanVien>, INhanVienRepository
{
    private readonly AppDbContext _dbContext;

    public NhanVienRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<NhanVien?> GetByMaNVAsync(NhanVienId maNV, CancellationToken cancellationToken = default)
        => await _dbContext.NhanViens
            .FirstOrDefaultAsync(x => x.Id == maNV, cancellationToken);

    public async Task<List<NhanVien>> GetByTenNVAsync(string tenNV, CancellationToken cancellationToken = default)
        => await _dbContext.NhanViens
            .Where(x => x.TenNV.Value.Contains(tenNV))
            .ToListAsync(cancellationToken);

    public async Task<bool> ExistsByMaNVAsync(NhanVienId maNV, CancellationToken cancellationToken = default)
        => await _dbContext.NhanViens
            .AnyAsync(x => x.Id == maNV, cancellationToken);
}
