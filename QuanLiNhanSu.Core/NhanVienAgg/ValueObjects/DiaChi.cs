using Vogen;

namespace QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;

[ValueObject<string>]
public readonly partial struct DiaChi
{
    public const int MaxLength = 250;

    private static Validation Validate(string value)
    {
        if (value != null && value.Trim().Length > MaxLength)
            return Validation.Invalid($"Địa chỉ không được vượt quá {MaxLength} ký tự.");
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value?.Trim() ?? string.Empty;
}
