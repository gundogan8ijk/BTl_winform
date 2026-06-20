using Vogen;

namespace QuanLiNhanSu.Core.TaiKhoanAgg.ValueObjects;

[ValueObject<string>]
public readonly partial struct MatKhau
{
    public const int MinLength = 6;
    public const int MaxLength = 100;

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Mật khẩu không được để trống.");
        if (value.Length < MinLength || value.Length > MaxLength)
            return Validation.Invalid($"Mật khẩu phải từ {MinLength} đến {MaxLength} ký tự.");
        return Validation.Ok;
    }
}
