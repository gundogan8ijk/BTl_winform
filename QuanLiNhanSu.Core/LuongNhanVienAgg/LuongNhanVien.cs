namespace QuanLiNhanSu.Core.LuongNhanVienAgg;

public class LuongNhanVien : EntityBase<LuongNhanVien, string>, IAggregateRoot
{
    public NhanVienId MaNV { get; private set; }
    public ThangNam ThangNam { get; private set; }
    public MucLuong TienLuong { get; private set; }
    public TienThuong TienThuong { get; private set; }
    public TienPhat TienPhat { get; private set; }
    public PhuCap PhuCap { get; private set; }

    #pragma warning disable CS8618
    private LuongNhanVien() { }
    #pragma warning restore CS8618

    public LuongNhanVien(
        NhanVienId maNV, ThangNam thangNam,
        TienThuong tienThuong, TienPhat tienPhat, PhuCap phuCap, MucLuong tienLuong)
    {
        MaNV = maNV;
        ThangNam = thangNam;
        TienThuong = tienThuong;
        TienPhat = tienPhat;
        PhuCap = phuCap;
        TienLuong = tienLuong;
        Id = $"{maNV.Value}_{thangNam.Thang}_{thangNam.Nam}";
    }

    public static LuongNhanVien Create(
        string maNV, int thang, int nam,
        double tienThuong, double tienPhat, double phuCap, double tienLuong)
    {
        return new LuongNhanVien(
            NhanVienId.From(maNV),
            ThangNam.Create(thang, nam),
            TienThuong.From((decimal)tienThuong),
            TienPhat.From((decimal)tienPhat),
            PhuCap.From((decimal)phuCap),
            MucLuong.From((decimal)tienLuong));
    }

    public decimal CalculateTotalSalary() =>
        TienLuong.Value + PhuCap.Value + TienThuong.Value - TienPhat.Value;

    public void UpdateBonusAndPenalty(TienThuong thuong, TienPhat phat)
    {
        TienThuong = thuong;
        TienPhat = phat;
    }

    public void UpdateSalary(MucLuong luong, PhuCap phuCap)
    {
        TienLuong = luong;
        PhuCap = phuCap;
    }
}
