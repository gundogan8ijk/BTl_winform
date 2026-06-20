using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<string>]
public readonly partial struct ChucVu
{
    public const int MaxLength = 100;

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Chức vụ không được để trống.");
        if (value.Trim().Length > MaxLength)
            return Validation.Invalid($"Chức vụ không được vượt quá {MaxLength} ký tự.");
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value.Trim();
}
