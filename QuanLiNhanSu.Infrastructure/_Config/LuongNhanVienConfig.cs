using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Core.LuongNhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.Infrastructure._Config;

public class LuongNhanVienConfig : IEntityTypeConfiguration<LuongNhanVien>
{
    public void Configure(EntityTypeBuilder<LuongNhanVien> builder)
    {
        builder.ToTable("LuongNhanVien");

        builder.Ignore(x => x.Id);

        builder.HasKey(x => new { MaNV = x.MaNV, x.ThangNam });

        builder.Property(x => x.MaNV)
            .HasColumnName("MaNV")
            .HasMaxLength(NhanVienId.MaxLength)
            .HasConversion(v => v.Value, s => NhanVienId.From(s))
            .IsRequired();

        builder.OwnsOne(x => x.ThangNam, tn =>
        {
            tn.Property(t => t.Thang).HasColumnName("ThangNhanLuong").IsRequired();
            tn.Property(t => t.Nam).HasColumnName("Nam").IsRequired();
        });

        builder.Property(x => x.TienThuong)
            .HasColumnName("Tienthuong")
            .HasConversion(v => v.Value, d => TienThuong.From(d))
            .IsRequired();

        builder.Property(x => x.TienPhat)
            .HasColumnName("Tienphat")
            .HasConversion(v => v.Value, d => TienPhat.From(d))
            .IsRequired();

        builder.Property(x => x.PhuCap)
            .HasColumnName("PhuCap")
            .HasConversion(v => v.Value, d => PhuCap.From(d))
            .IsRequired();

        builder.Property(x => x.TienLuong)
            .HasColumnName("TienLuong")
            .HasConversion(v => v.Value, d => MucLuong.From(d))
            .IsRequired();
    }
}
