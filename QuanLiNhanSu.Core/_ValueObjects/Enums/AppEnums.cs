namespace QuanLiNhanSu.Core._ValueObjects.Enums;

public sealed class TrangThaiChamCong : SmartEnum<TrangThaiChamCong, int>
{
    public static readonly TrangThaiChamCong DiLam = new("Đi làm", 1);
    public static readonly TrangThaiChamCong Nghi  = new("Nghỉ",   0);

    private TrangThaiChamCong(string name, int value) : base(name, value) { }
}

public sealed class QuyenNguoiDung : SmartEnum<QuyenNguoiDung, int>
{
    public static readonly QuyenNguoiDung Admin = new("Admin", 0);
    public static readonly QuyenNguoiDung User  = new("User",  1);

    private QuyenNguoiDung(string name, int value) : base(name, value) { }

    public static QuyenNguoiDung FromDouble(double value) =>
        value == 0 ? Admin : User;
}
