using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class LuongNhanVienRepository : EfRepository<LuongNhanVien>, ILuongNhanVienRepository
{
    private readonly AppDbContext _dbContext;

    public LuongNhanVienRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<LuongNhanVien?> GetByEmployeeMonthYearAsync(string maNV, int thang, int nam, CancellationToken cancellationToken = default)
    {
        return await _dbContext.LuongNhanViens
            .FirstOrDefaultAsync(x => x.MaNV == maNV && x.ThangNhanLuong == thang && x.Nam == nam, cancellationToken);
    }

    public async Task<List<LuongNhanVien>> GetByMonthYearAsync(int thang, int nam, CancellationToken cancellationToken = default)
    {
        return await _dbContext.LuongNhanViens
            .Where(x => x.ThangNhanLuong == thang && x.Nam == nam)
            .ToListAsync(cancellationToken);
    }
}
