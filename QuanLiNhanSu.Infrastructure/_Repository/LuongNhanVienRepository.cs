using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class LuongNhanVienRepository : EfRepository<LuongNhanVien>, ILuongNhanVienRepository
{
    private readonly AppDbContext _dbContext;

    public LuongNhanVienRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<LuongNhanVien?> GetByEmployeeMonthYearAsync(NhanVienId maNV, ThangNam thangNam, CancellationToken cancellationToken = default)
        => await _dbContext.LuongNhanViens
            .FirstOrDefaultAsync(x => x.MaNV == maNV && x.ThangNam == thangNam, cancellationToken);

    public async Task<List<LuongNhanVien>> GetByMonthYearAsync(ThangNam thangNam, CancellationToken cancellationToken = default)
        => await _dbContext.LuongNhanViens
            .Where(x => x.ThangNam == thangNam)
            .ToListAsync(cancellationToken);
}
