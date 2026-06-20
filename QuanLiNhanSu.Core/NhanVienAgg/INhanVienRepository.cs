using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.Core.NhanVienAgg;

public interface INhanVienRepository : IRepository<NhanVien>
{
    Task<NhanVien?> GetByMaNVAsync(NhanVienId maNV, CancellationToken cancellationToken = default);
    Task<List<NhanVien>> GetByTenNVAsync(string tenNV, CancellationToken cancellationToken = default);
    Task<bool> ExistsByMaNVAsync(NhanVienId maNV, CancellationToken cancellationToken = default);
}
