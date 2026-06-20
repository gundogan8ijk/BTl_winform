using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.ChamCongAgg;

namespace QuanLiNhanSu.Infrastructure._Config;

public class ThangCongConfig : IEntityTypeConfiguration<ThangCong>
{
    public void Configure(EntityTypeBuilder<ThangCong> builder)
    {
        builder.ToTable("ThangCong");

        builder.Ignore(x => x.Id);

        builder.HasKey(x => new { x.MaNV, x.ThangTC, x.NamTC });

        builder.Property(x => x.MaNV)
            .HasColumnName("MaNV")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.TenNV)
            .HasColumnName("TenNV")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.ThangTC)
            .HasColumnName("ThangTC")
            .IsRequired();

        builder.Property(x => x.NamTC)
            .HasColumnName("NamTC")
            .IsRequired();

        // Map Day1 to Day12 properties
        for (int i = 1; i <= 12; i++)
        {
            builder.Property($"Day{i}")
                .HasColumnName($"Day{i}")
                .IsRequired();
        }
    }
}
