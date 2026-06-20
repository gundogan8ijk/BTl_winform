using System;
using System.Text.RegularExpressions;

namespace QuanLiNhanSu.Core._ValueObjects;

public record struct SoDienThoai
{
    public string Value { get; }

    public SoDienThoai(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Số điện thoại không được để trống.");

        value = value.Trim();

        // Standard Vietnamese phone number match (10 digits)
        if (!Regex.IsMatch(value, @"^(0[3|5|7|8|9])[0-9]{8}$"))
            throw new ArgumentException("Số điện thoại không hợp lệ (phải gồm 10 chữ số và bắt đầu bằng đầu số Việt Nam).");

        Value = value;
    }

    public static SoDienThoai From(string value) => new(value);

    public override string ToString() => Value;
}
