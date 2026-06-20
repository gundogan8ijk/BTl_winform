using System;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core.Shared;
using Ardalis.SharedKernel;
using Ardalis.GuardClauses;

namespace QuanLiNhanSu.Core.NhanVienAgg;

public class NhanVien : EntityBase<NhanVien, string>, IAggregateRoot
{
    public string MaNV => Id;
    public string TenNV { get; private set; }
    public DateTime NgaySinh { get; private set; }
    public string GioiTinh { get; private set; }
    public string SoDienThoai { get; private set; }
    public string Email { get; private set; }
    public string ChucVu { get; private set; }
    public string DiaChi { get; private set; }
    public int ThangVaoLam { get; private set; }

    // Required by EF Core
    #pragma warning disable CS8618
    private NhanVien() { }
    #pragma warning restore CS8618

    public NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu, string diaChi, int thangVaoLam)
    {
        Guard.Against.NullOrWhiteSpace(maNV, nameof(maNV), "Mã nhân viên không được để trống.");
        Guard.Against.NullOrWhiteSpace(tenNV, nameof(tenNV), "Tên nhân viên không được để trống.");

        Id = maNV.Trim();
        TenNV = tenNV.Trim();
        NgaySinh = ngaySinh;
        GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? "Nam" : gioiTinh.Trim();
        SoDienThoai = new SoDienThoai(soDienThoai).Value;
        Email = new Email(email).Value;
        ChucVu = string.IsNullOrWhiteSpace(chucVu) ? "Nhân viên" : chucVu.Trim();
        DiaChi = string.IsNullOrWhiteSpace(diaChi) ? "" : diaChi.Trim();
        ThangVaoLam = thangVaoLam == 0 ? DateTime.Now.Month : thangVaoLam;
    }

    public static NhanVien Create(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu, string diaChi, int thangVaoLam)
    {
        return new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, soDienThoai, email, chucVu, diaChi, thangVaoLam);
    }

    public void UpdateInfo(string tenNV, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu, string diaChi)
    {
        Guard.Against.NullOrWhiteSpace(tenNV, nameof(tenNV), "Tên nhân viên không được để trống.");

        TenNV = tenNV.Trim();
        NgaySinh = ngaySinh;
        GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? "Nam" : gioiTinh.Trim();
        SoDienThoai = new SoDienThoai(soDienThoai).Value;
        Email = new Email(email).Value;
        ChucVu = string.IsNullOrWhiteSpace(chucVu) ? "Nhân viên" : chucVu.Trim();
        DiaChi = string.IsNullOrWhiteSpace(diaChi) ? "" : diaChi.Trim();
    }
}
