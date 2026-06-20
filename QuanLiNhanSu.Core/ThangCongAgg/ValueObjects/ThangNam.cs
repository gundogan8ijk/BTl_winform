namespace QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;

/// <summary>Owned value object lưu tháng và năm, map bằng EF OwnsOne</summary>
public sealed record ThangNam
{
    public int Thang { get; }
    public int Nam { get; }

    private ThangNam() { } // EF Core

    private ThangNam(int thang, int nam)
    {
        Thang = thang;
        Nam = nam;
    }

    public static ThangNam Create(int thang, int nam)
    {
        if (thang < 1 || thang > 12)
            throw new ArgumentException("Tháng phải từ 1 đến 12.", nameof(thang));
        if (nam < 2000)
            throw new ArgumentException("Năm phải từ 2000 trở lên.", nameof(nam));
        return new ThangNam(thang, nam);
    }

    public static ThangNam Current() =>
        Create(DateTime.Now.Month, DateTime.Now.Year);

    public override string ToString() => $"Tháng {Thang}/{Nam}";
}
