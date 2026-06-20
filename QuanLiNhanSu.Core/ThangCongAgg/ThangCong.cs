using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;

namespace QuanLiNhanSu.Core.ThangCongAgg;

public class ThangCong : EntityBase<ThangCong, string>, IAggregateRoot
{
    public NhanVienId MaNV { get; private set; }
    public TenNhanVien TenNV { get; private set; }
    public ThangNam ThangNam { get; private set; }

    public int Day1 { get; private set; }
    public int Day2 { get; private set; }
    public int Day3 { get; private set; }
    public int Day4 { get; private set; }
    public int Day5 { get; private set; }
    public int Day6 { get; private set; }
    public int Day7 { get; private set; }
    public int Day8 { get; private set; }
    public int Day9 { get; private set; }
    public int Day10 { get; private set; }
    public int Day11 { get; private set; }
    public int Day12 { get; private set; }

    #pragma warning disable CS8618
    private ThangCong() { }
    #pragma warning restore CS8618

    public ThangCong(NhanVienId maNV, TenNhanVien tenNV, ThangNam thangNam)
    {
        MaNV = maNV;
        TenNV = tenNV;
        ThangNam = thangNam;
        Id = $"{maNV.Value}_{thangNam.Thang}_{thangNam.Nam}";
    }

    public static ThangCong Create(string maNV, string tenNV, int thang, int nam)
    {
        return new ThangCong(
            NhanVienId.From(maNV),
            TenNhanVien.From(tenNV),
            ThangNam.Create(thang, nam));
    }

    public void UpdateDays(int[] statuses)
    {
        if (statuses == null || statuses.Length < 12)
            throw new ArgumentException("Danh sách trạng thái ngày phải có tối thiểu 12 phần tử.");
        Day1  = statuses[0];  Day2  = statuses[1];  Day3  = statuses[2];
        Day4  = statuses[3];  Day5  = statuses[4];  Day6  = statuses[5];
        Day7  = statuses[6];  Day8  = statuses[7];  Day9  = statuses[8];
        Day10 = statuses[9];  Day11 = statuses[10]; Day12 = statuses[11];
    }
}
