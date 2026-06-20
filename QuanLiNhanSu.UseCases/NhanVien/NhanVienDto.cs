using System;

namespace QuanLiNhanSu.UseCases.NhanVien;

/// <summary>DTO trả về WinForm — dùng kiểu nguyên thủy để UI dễ bind</summary>
public record NhanVienDto(
    string MaNV,
    string TenNV,
    DateTime NgaySinh,
    string GioiTinh,
    string SoDienThoai,
    string Email,
    string ChucVu,
    string DiaChi,
    int ThangVaoLam
);
