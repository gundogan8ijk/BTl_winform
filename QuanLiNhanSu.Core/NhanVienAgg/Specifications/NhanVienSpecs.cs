namespace QuanLiNhanSu.Core.NhanVienAgg.Specifications;

public class NhanVienByIdSpec : Specification<NhanVien>
{
    public NhanVienByIdSpec(NhanVienId id) =>
        Query.AsNoTracking().Where(x => x.Id == id);
}

public class NhanVienByTenSpec : Specification<NhanVien>
{
    public NhanVienByTenSpec(string ten) =>
        Query.AsNoTracking().Where(x => x.TenNV.Value.Contains(ten));
}
