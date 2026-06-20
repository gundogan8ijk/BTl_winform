using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.ThangCongAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.Infrastructure._Config;

public class ThangCongConfig : IEntityTypeConfiguration<ThangCong>
{
    public void Configure(EntityTypeBuilder<ThangCong> builder)
    {
        builder.ToTable("ThangCong");

        builder.Ignore(x => x.Id);

        builder.HasKey(x => new { MaNV = x.MaNV, x.ThangNam });

        builder.Property(x => x.MaNV)
            .HasColumnName("MaNV")
            .HasMaxLength(NhanVienId.MaxLength)
            .HasConversion(v => v.Value, s => NhanVienId.From(s))
            .IsRequired();

        builder.Property(x => x.TenNV)
            .HasColumnName("TenNV")
            .HasMaxLength(TenNhanVien.MaxLength)
            .HasConversion(v => v.Value, s => TenNhanVien.From(s))
            .IsRequired();

        builder.OwnsOne(x => x.ThangNam, tn =>
        {
            tn.Property(t => t.Thang).HasColumnName("ThangTC").IsRequired();
            tn.Property(t => t.Nam).HasColumnName("NamTC").IsRequired();
        });

        for (int i = 1; i <= 12; i++)
            builder.Property($"Day{i}").HasColumnName($"Day{i}").IsRequired();
    }
}
