using System;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

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
