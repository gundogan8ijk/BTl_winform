using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure._Repository;

public class TaiKhoanRepository : EfRepository<TaiKhoan>, ITaiKhoanRepository
{
    public TaiKhoanRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
