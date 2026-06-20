using System;

namespace QuanLiNhanSu.Core._ValueObjects;

public record struct MatKhau
{
    public const int MinLength = 6;
    public const int MaxLength = 100;
    public string Value { get; }

    public MatKhau(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Mật khẩu không được để trống.");

        if (value.Length < MinLength || value.Length > MaxLength)
            throw new ArgumentException($"Mật khẩu phải từ {MinLength} đến {MaxLength} ký tự.");

        Value = value;
    }

    public static MatKhau From(string value) => new(value);

    public override string ToString() => Value;
}
