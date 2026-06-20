namespace QuanLiNhanSu.Core._ValueObjects.Enums;

public sealed class GioiTinh : SmartEnum<GioiTinh, string>
{
    public static readonly GioiTinh Nam = new(nameof(Nam), "Nam");
    public static readonly GioiTinh Nu = new(nameof(Nu), "Nữ");

    private GioiTinh(string name, string value) : base(name, value) { }
}
