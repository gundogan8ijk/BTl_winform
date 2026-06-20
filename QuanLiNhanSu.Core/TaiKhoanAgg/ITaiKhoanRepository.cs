using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.TaiKhoanAgg;

public interface ITaiKhoanRepository : IRepository<TaiKhoan>
{
    Task<TaiKhoan?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<bool> ExistsByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<List<TaiKhoan>> GetAllAsync(CancellationToken cancellationToken = default);
}
