namespace QuanLiNhanSu.Core.NhanVienAgg;

public class NhanVien : EntityBase<NhanVien, NhanVienId>, IAggregateRoot
{
    public NhanVienId MaNV => Id;
    public TenNhanVien TenNV { get; private set; }
    public NgaySinhVO NgaySinh { get; private set; }
    public GioiTinh GioiTinh { get; private set; }
    public SoDienThoaiVN SoDienThoai { get; private set; }
    public EmailAddress Email { get; private set; }
    public ChucVu ChucVu { get; private set; }
    public DiaChi DiaChi { get; private set; }
    public int ThangVaoLam { get; private set; }

    #pragma warning disable CS8618
    private NhanVien() { }
    #pragma warning restore CS8618

    public NhanVien(
        NhanVienId maNV,
        TenNhanVien tenNV,
        NgaySinhVO ngaySinh,
        GioiTinh gioiTinh,
        SoDienThoaiVN soDienThoai,
        EmailAddress email,
        ChucVu chucVu,
        DiaChi diaChi,
        int thangVaoLam)
    {
        Guard.Against.OutOfRange(thangVaoLam, nameof(thangVaoLam), 1, 12);
        Id = maNV;
        TenNV = tenNV;
        NgaySinh = ngaySinh;
        GioiTinh = gioiTinh;
        SoDienThoai = soDienThoai;
        Email = email;
        ChucVu = chucVu;
        DiaChi = diaChi;
        ThangVaoLam = thangVaoLam;
    }

    public static NhanVien Create(
        string maNV, string tenNV, DateOnly ngaySinh, string gioiTinh,
        string soDienThoai, string email, string chucVu, string diaChi, int thangVaoLam)
    {
        return new NhanVien(
            NhanVienId.From(maNV),
            TenNhanVien.From(tenNV),
            NgaySinhVO.From(ngaySinh),
            GioiTinh.FromValue(gioiTinh),
            SoDienThoaiVN.From(soDienThoai),
            EmailAddress.From(email),
            ChucVu.From(chucVu),
            DiaChi.From(diaChi),
            thangVaoLam);
    }

    public void Update(
        TenNhanVien tenNV, NgaySinhVO ngaySinh, GioiTinh gioiTinh,
        SoDienThoaiVN soDienThoai, EmailAddress email, ChucVu chucVu, DiaChi diaChi)
    {
        TenNV = tenNV;
        NgaySinh = ngaySinh;
        GioiTinh = gioiTinh;
        SoDienThoai = soDienThoai;
        Email = email;
        ChucVu = chucVu;
        DiaChi = diaChi;
    }
}
