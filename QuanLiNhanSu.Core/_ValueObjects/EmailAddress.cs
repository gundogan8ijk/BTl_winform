using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<string>]
public readonly partial struct EmailAddress
{
    public const int MaxLength = 150;

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Email không được để trống.");
        var trimmed = value.Trim().ToLowerInvariant();
        if (trimmed.Length > MaxLength)
            return Validation.Invalid($"Email không được vượt quá {MaxLength} ký tự.");
        try { _ = new System.Net.Mail.MailAddress(trimmed); }
        catch { return Validation.Invalid("Email không đúng định dạng."); }
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value.Trim().ToLowerInvariant();
}
