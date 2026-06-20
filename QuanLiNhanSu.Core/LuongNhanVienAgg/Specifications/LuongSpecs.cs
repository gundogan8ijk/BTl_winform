namespace QuanLiNhanSu.Core.LuongNhanVienAgg.Specifications;

public class LuongByThangNamSpec : Specification<LuongNhanVien>
{
    public LuongByThangNamSpec(ThangNam thangNam) =>
        Query.AsNoTracking().Where(x => x.ThangNam == thangNam);
}

public class LuongByMaNVThangNamSpec : Specification<LuongNhanVien>
{
    public LuongByMaNVThangNamSpec(NhanVienId maNV, ThangNam thangNam) =>
        Query.AsNoTracking().Where(x => x.MaNV == maNV && x.ThangNam == thangNam);
}
