using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.NhanVienAgg;

public interface INhanVienRepository : IRepository<NhanVien>
{
    Task<NhanVien?> GetByMaNVAsync(string maNV, CancellationToken cancellationToken = default);
    Task<List<NhanVien>> GetByTenNVAsync(string tenNV, CancellationToken cancellationToken = default);
    Task<bool> ExistsByMaNVAsync(string maNV, CancellationToken cancellationToken = default);
}
