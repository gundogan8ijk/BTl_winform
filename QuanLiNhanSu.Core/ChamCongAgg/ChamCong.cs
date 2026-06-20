namespace QuanLiNhanSu.Core.ChamCongAgg;

public class ChamCong : EntityBase<ChamCong, string>, IAggregateRoot
{
    public NhanVienId MaNV { get; private set; }
    public TenNhanVien TenNV { get; private set; }
    public DateOnly NgayCong { get; private set; }
    public TrangThaiChamCong TrangThai { get; private set; }

    #pragma warning disable CS8618
    private ChamCong() { }
    #pragma warning restore CS8618

    public ChamCong(NhanVienId maNV, TenNhanVien tenNV, DateOnly ngayCong, TrangThaiChamCong trangThai)
    {
        MaNV = maNV;
        TenNV = tenNV;
        NgayCong = ngayCong;
        TrangThai = trangThai;
        Id = $"{maNV.Value}_{ngayCong:yyyyMMdd}";
    }

    public static ChamCong Create(string maNV, string tenNV, DateOnly ngayCong, int trangThai)
    {
        return new ChamCong(
            NhanVienId.From(maNV),
            TenNhanVien.From(tenNV),
            ngayCong,
            TrangThaiChamCong.FromValue(trangThai));
    }

    public void UpdateTrangThai(TrangThaiChamCong trangThai) => TrangThai = trangThai;
}
