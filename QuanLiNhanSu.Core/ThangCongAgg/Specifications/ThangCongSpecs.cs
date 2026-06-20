using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;

namespace QuanLiNhanSu.Core.ThangCongAgg.Specifications;

public class ThangCongByThangNamSpec : Specification<ThangCong>
{
    public ThangCongByThangNamSpec(ThangNam thangNam) =>
        Query.AsNoTracking().Where(x => x.ThangNam == thangNam);
}

public class ThangCongByMaNVThangNamSpec : Specification<ThangCong>
{
    public ThangCongByMaNVThangNamSpec(NhanVienId maNV, ThangNam thangNam) =>
        Query.AsNoTracking().Where(x => x.MaNV == maNV && x.ThangNam == thangNam);
}
