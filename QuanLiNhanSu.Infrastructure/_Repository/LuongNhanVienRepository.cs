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
    public LuongNhanVienRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
