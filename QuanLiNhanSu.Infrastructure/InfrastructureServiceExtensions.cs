using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.SqlClient;
using System.Data;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Core.ChamCongAgg;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Infrastructure.Data.Context;
using QuanLiNhanSu.Infrastructure.Data.Models;
using QuanLiNhanSu.Infrastructure._Repository;
using System;

namespace QuanLiNhanSu.Infrastructure;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration config)
    {
        string? connectionString = config.GetConnectionString("DefaultConnection") 
                                  ?? @"Data Source=LAPTOP-FV6UVTJE;Initial Catalog=QuanLiNhanVien;Integrated Security=True;Encrypt=False";

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        // Register Dapper IDbConnection
        services.AddScoped<IDbConnection>(_ => new SqlConnection(connectionString));

        // Register Identity
        services.AddIdentityCore<ApplicationUser>(opt =>
        {
            opt.Password.RequireDigit = false;
            opt.Password.RequiredLength = 6;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequireLowercase = false;
            opt.User.RequireUniqueEmail = true;
        })
        .AddRoles<ApplicationRole>()
        .AddEntityFrameworkStores<AppDbContext>()
        .AddTokenProvider<EmailTokenProvider<ApplicationUser>>(TokenOptions.DefaultEmailProvider);

        // Register repositories
        services.AddScoped<INhanVienRepository, NhanVienRepository>();
        services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
        services.AddScoped<IChamCongRepository, ChamCongRepository>();
        services.AddScoped<ILuongNhanVienRepository, LuongNhanVienRepository>();

        return services;
    }
}
