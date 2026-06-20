using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class TaiKhoanRepository : EfRepository<TaiKhoan>, ITaiKhoanRepository
{
    private readonly AppDbContext _dbContext;

    public TaiKhoanRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TaiKhoan?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _dbContext.TaiKhoans
            .FirstOrDefaultAsync(x => x.Id == email, cancellationToken);
    }

    public async Task<bool> ExistsByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _dbContext.TaiKhoans
            .AnyAsync(x => x.Id == email, cancellationToken);
    }
}
