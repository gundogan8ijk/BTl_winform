using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.ChamCongAgg;

namespace QuanLiNhanSu.Infrastructure._Config;

public class ChamCongConfig : IEntityTypeConfiguration<ChamCong>
{
    public void Configure(EntityTypeBuilder<ChamCong> builder)
    {
        builder.ToTable("ChamCong");

        // Ignore the memory-only Id property
        builder.Ignore(x => x.Id);

        // Configure the composite key matching the original database schema
        builder.HasKey(x => new { x.MaNV, x.NgayCong });

        builder.Property(x => x.MaNV)
            .HasColumnName("MaNV")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.TenNV)
            .HasColumnName("TenNV")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.NgayCong)
            .HasColumnName("NgayCong")
            .IsRequired();

        builder.Property(x => x.TrangThai)
            .HasColumnName("TrangThai")
            .IsRequired();
    }
}
