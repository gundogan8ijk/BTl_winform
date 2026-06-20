using System.Text.RegularExpressions;
using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<string>]
public readonly partial struct SoDienThoaiVN
{
    private static readonly Regex _vnPhoneRegex =
        new(@"^(0[35789])\d{8}$", RegexOptions.Compiled);

    private static Validation Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Validation.Invalid("Số điện thoại không được để trống.");
        if (!_vnPhoneRegex.IsMatch(value.Trim()))
            return Validation.Invalid("Số điện thoại không hợp lệ (10 chữ số, đầu số Việt Nam: 03x/05x/07x/08x/09x).");
        return Validation.Ok;
    }

    private static string NormalizeInput(string value) => value.Trim();
}
