using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core.TaiKhoanAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core._ValueObjects.Enums;

namespace QuanLiNhanSu.Infrastructure._Config;

public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
{
    public void Configure(EntityTypeBuilder<NhanVien> builder)
    {
        builder.ToTable("NhanVien");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("MaNV")
            .HasMaxLength(NhanVienId.MaxLength)
            .HasConversion(v => v.Value, s => NhanVienId.From(s))
            .IsRequired();

        builder.Property(x => x.TenNV)
            .HasColumnName("TenNV")
            .HasMaxLength(TenNhanVien.MaxLength)
            .HasConversion(v => v.Value, s => TenNhanVien.From(s))
            .IsRequired();

        builder.Property(x => x.NgaySinh)
            .HasColumnName("NgaySinh")
            .HasConversion(v => v.Value.ToDateTime(TimeOnly.MinValue), d => NgaySinhVO.From(DateOnly.FromDateTime(d)))
            .IsRequired();

        builder.Property(x => x.GioiTinh)
            .HasColumnName("GioiTinh")
            .HasMaxLength(10)
            .HasConversion(v => v.Value, s => GioiTinh.FromValue(s))
            .IsRequired();

        builder.Property(x => x.SoDienThoai)
            .HasColumnName("SoDienThoai")
            .HasMaxLength(20)
            .HasConversion(v => v.Value, s => SoDienThoaiVN.From(s))
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .HasMaxLength(EmailAddress.MaxLength)
            .HasConversion(v => v.Value, s => EmailAddress.From(s))
            .IsRequired();

        builder.Property(x => x.ChucVu)
            .HasColumnName("ChucVu")
            .HasMaxLength(ChucVu.MaxLength)
            .HasConversion(v => v.Value, s => ChucVu.From(s))
            .IsRequired();

        builder.Property(x => x.DiaChi)
            .HasColumnName("DiaChi")
            .HasMaxLength(DiaChi.MaxLength)
            .HasConversion(v => v.Value, s => DiaChi.From(s))
            .IsRequired();

        builder.Property(x => x.ThangVaoLam)
            .HasColumnName("thangVaoLam")
            .IsRequired();
    }
}
