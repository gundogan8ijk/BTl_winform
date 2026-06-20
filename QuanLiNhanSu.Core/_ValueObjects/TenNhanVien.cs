using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<string>]
public readonly partial struct TenNhanVien
{
    public const int MaxLength = 150;

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Họ tên nhân viên không được để trống.");
        if (value.Trim().Length > MaxLength)
            return Validation.Invalid($"Họ tên không được vượt quá {MaxLength} ký tự.");
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value.Trim();
}
