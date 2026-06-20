using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.TaiKhoanAgg;

namespace QuanLiNhanSu.Infrastructure._Config;

public class TaiKhoanConfig : IEntityTypeConfiguration<TaiKhoan>
{
    public void Configure(EntityTypeBuilder<TaiKhoan> builder)
    {
        builder.ToTable("TaiKhoan");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("email")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.MatKhau)
            .HasColumnName("matkhau")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Quyen)
            .HasColumnName("Quyen")
            .IsRequired();
    }
}
