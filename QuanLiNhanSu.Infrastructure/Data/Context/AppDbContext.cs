using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.ChamCongAgg;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Infrastructure.Data.Models;
using System.Reflection;

namespace QuanLiNhanSu.Infrastructure.Data.Context;

public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<NhanVien> NhanViens => Set<NhanVien>();
    public DbSet<ChamCong> ChamCongs => Set<ChamCong>();
    public DbSet<ThangCong> ThangCongs => Set<ThangCong>();
    public DbSet<LuongNhanVien> LuongNhanViens => Set<LuongNhanVien>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
