using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.SharedKernel;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;

namespace QuanLiNhanSu.Core.ThangCongAgg;

public interface IThangCongRepository : IRepository<ThangCong>
{
    Task<ThangCong?> GetThangCongAsync(NhanVienId maNV, ThangNam thangNam, CancellationToken cancellationToken = default);
    Task<List<ThangCong>> GetThangCongListAsync(ThangNam thangNam, CancellationToken cancellationToken = default);
}
