using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.LuongNhanVienAgg;

namespace QuanLiNhanSu.Infrastructure._Config;

public class LuongNhanVienConfig : IEntityTypeConfiguration<LuongNhanVien>
{
    public void Configure(EntityTypeBuilder<LuongNhanVien> builder)
    {
        builder.ToTable("LuongNhanVien");

        builder.Ignore(x => x.Id);

        builder.HasKey(x => new { x.MaNV, x.ThangNhanLuong, x.Nam });

        builder.Property(x => x.MaNV)
            .HasColumnName("MaNV")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.ThangNhanLuong)
            .HasColumnName("ThangNhanLuong")
            .IsRequired();

        builder.Property(x => x.Nam)
            .HasColumnName("Nam")
            .IsRequired();

        builder.Property(x => x.TienThuong)
            .HasColumnName("Tienthuong")
            .IsRequired();

        builder.Property(x => x.TienPhat)
            .HasColumnName("Tienphat")
            .IsRequired();

        builder.Property(x => x.PhuCap)
            .HasColumnName("PhuCap")
            .IsRequired();

        builder.Property(x => x.TienLuong)
            .HasColumnName("TienLuong")
            .IsRequired();
    }
}
