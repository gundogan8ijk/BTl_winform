namespace QuanLiNhanSu.UseCases.LuongNhanVien;

public record LuongNhanVienDto(
    string MaNV,
    int ThangNhanLuong,
    int Nam,
    double TienThuong,
    double TienPhat,
    double PhuCap,
    double TienLuong,
    double TongLuong
);
