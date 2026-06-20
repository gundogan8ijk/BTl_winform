using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Core.ChamCongAgg;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;

namespace QuanLiNhanSu.Infrastructure.Data.Seeds;

public static class AppDbContextSeed
{
    public static async Task SeedAsync(AppDbContext context)
    {
        // Auto-create database if not exists
        await context.Database.EnsureCreatedAsync();

        // 1. Seed Accounts
        if (!await context.TaiKhoans.AnyAsync())
        {
            var admin = TaiKhoan.Create("admin@gmail.com", "admin123", 0);
            var user = TaiKhoan.Create("user@gmail.com", "user123", 1);
            
            context.TaiKhoans.AddRange(admin, user);
            await context.SaveChangesAsync();
        }

        // 2. Seed Employees
        if (!await context.NhanViens.AnyAsync())
        {
            var nv1 = NhanVien.Create("NV001", "Nguyễn Văn A", new DateTime(1990, 5, 12), "Nam", "0912345678", "nva@gmail.com", "Quản lý", "Hà Nội", 6);
            var nv2 = NhanVien.Create("NV002", "Trần Thị B", new DateTime(1995, 10, 20), "Nữ", "0987654321", "ttb@gmail.com", "Nhân viên", "Hải Phòng", 6);
            
            context.NhanViens.AddRange(nv1, nv2);
            await context.SaveChangesAsync();

            // 3. Seed Monthly Attendance Logs (ThangCong)
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            var tc1 = ThangCong.Create("NV001", "Nguyễn Văn A", currentMonth, currentYear);
            tc1.UpdateDays(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }); // present for all 12 tracked days

            var tc2 = ThangCong.Create("NV002", "Trần Thị B", currentMonth, currentYear);
            tc2.UpdateDays(new int[] { 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1 });

            context.ThangCongs.AddRange(tc1, tc2);

            // 4. Seed Salary Records (LuongNhanVien)
            var l1 = LuongNhanVien.Create("NV001", currentMonth, currentYear, 500000, 0, 1000000, 15000000);
            var l2 = LuongNhanVien.Create("NV002", currentMonth, currentYear, 200000, 50000, 500000, 8000000);

            context.LuongNhanViens.AddRange(l1, l2);

            await context.SaveChangesAsync();
        }
    }
}
