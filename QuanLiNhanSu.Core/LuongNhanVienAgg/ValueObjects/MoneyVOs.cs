using Vogen;

namespace QuanLiNhanSu.Core.LuongNhanVienAgg.ValueObjects;

[ValueObject<decimal>]
public readonly partial struct MucLuong
{
    private static Validation Validate(decimal value) =>
        value < 0 ? Validation.Invalid("Mức lương phải >= 0.") : Validation.Ok;

    public static MucLuong Zero => From(0m);
}

[ValueObject<decimal>]
public readonly partial struct TienThuong
{
    private static Validation Validate(decimal value) =>
        value < 0 ? Validation.Invalid("Tiền thưởng phải >= 0.") : Validation.Ok;

    public static TienThuong Zero => From(0m);
}

[ValueObject<decimal>]
public readonly partial struct TienPhat
{
    private static Validation Validate(decimal value) =>
        value < 0 ? Validation.Invalid("Tiền phạt phải >= 0.") : Validation.Ok;

    public static TienPhat Zero => From(0m);
}

[ValueObject<decimal>]
public readonly partial struct PhuCap
{
    private static Validation Validate(decimal value) =>
        value < 0 ? Validation.Invalid("Phụ cấp phải >= 0.") : Validation.Ok;

    public static PhuCap Zero => From(0m);
}
