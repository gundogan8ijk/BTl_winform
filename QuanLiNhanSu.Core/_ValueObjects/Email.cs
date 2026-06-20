using System;
using System.Net.Mail;

namespace QuanLiNhanSu.Core._ValueObjects;

public record struct Email
{
    public const int MaxLength = 150;
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email không được để trống.");

        value = value.Trim().ToLowerInvariant();

        if (value.Length > MaxLength)
            throw new ArgumentException($"Email không được dài quá {MaxLength} ký tự.");

        try
        {
            var mailAddress = new MailAddress(value);
        }
        catch
        {
            throw new ArgumentException("Email không đúng định dạng.");
        }

        Value = value;
    }

    public static Email From(string value) => new(value);

    public override string ToString() => Value;
}
