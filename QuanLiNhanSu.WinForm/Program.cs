using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuanLiNhanSu.Infrastructure;
using QuanLiNhanSu.Infrastructure.Data.Context;
using QuanLiNhanSu.Infrastructure.Data.Seeds;
using Mediator;
using Serilog;

namespace QuanLiNhanSu;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        // Configure Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("logs/app-log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            Log.Information("Ứng dụng QuanLiNhanSu đang khởi chạy...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Build DI container
            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog());
            
            // Add Infrastructure & Core Services
            services.AddInfrastructureServices(configuration);
            
            // Add Mediator
            services.AddMediator();

            ServiceProvider = services.BuildServiceProvider();

            // Run database seeder
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                AppDbContextSeed.SeedAsync(context).GetAwaiter().GetResult();
            }

            Log.Information("Khởi chạy Form đăng nhập.");
            Application.Run(new DangNhap());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Ứng dụng bị dừng đột ngột!");
            MessageBox.Show("Có lỗi nghiêm trọng xảy ra: " + ex.Message);
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
