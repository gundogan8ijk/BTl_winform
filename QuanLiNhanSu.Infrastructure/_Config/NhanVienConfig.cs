using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.NhanVienAgg;

namespace QuanLiNhanSu.Infrastructure._Config;

public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
{
    public void Configure(EntityTypeBuilder<NhanVien> builder)
    {
        builder.ToTable("NhanVien");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("MaNV")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.TenNV)
            .HasColumnName("TenNV")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.NgaySinh)
            .HasColumnName("NgaySinh")
            .IsRequired();

        builder.Property(x => x.GioiTinh)
            .HasColumnName("GioiTinh")
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(x => x.SoDienThoai)
            .HasColumnName("SoDienThoai")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.ChucVu)
            .HasColumnName("ChucVu")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.DiaChi)
            .HasColumnName("DiaChi")
            .HasMaxLength(250)
            .IsRequired();

        builder.Property(x => x.ThangVaoLam)
            .HasColumnName("thangVaoLam")
            .IsRequired();
    }
}
