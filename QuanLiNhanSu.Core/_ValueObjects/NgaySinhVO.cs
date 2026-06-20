using Vogen;

namespace QuanLiNhanSu.Core._ValueObjects;

[ValueObject<DateOnly>]
public readonly partial struct NgaySinhVO
{
    public static NgaySinhVO Today() => From(DateOnly.FromDateTime(DateTime.Today));

    private static Validation Validate(DateOnly value)
    {
        if (value == default)
            return Validation.Invalid("Ngày sinh không được để trống.");
        if (value > DateOnly.FromDateTime(DateTime.Today))
            return Validation.Invalid("Ngày sinh không được là ngày tương lai.");
        if (value.Year < 1900)
            return Validation.Invalid("Ngày sinh không hợp lệ (trước năm 1900).");
        return Validation.Ok;
    }

    public static bool operator <(NgaySinhVO left, NgaySinhVO right) => left.Value < right.Value;
    public static bool operator <=(NgaySinhVO left, NgaySinhVO right) => left.Value <= right.Value;
    public static bool operator >(NgaySinhVO left, NgaySinhVO right) => left.Value > right.Value;
    public static bool operator >=(NgaySinhVO left, NgaySinhVO right) => left.Value >= right.Value;
}
