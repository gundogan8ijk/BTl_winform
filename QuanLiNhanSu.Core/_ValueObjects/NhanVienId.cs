using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<string>]
public readonly partial struct NhanVienId
{
    public const int MaxLength = 50;

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Mã nhân viên không được để trống.");
        if (value.Trim().Length > MaxLength)
            return Validation.Invalid($"Mã nhân viên không được vượt quá {MaxLength} ký tự.");
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value.Trim().ToUpperInvariant();
}
