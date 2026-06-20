using QuanLiNhanSu.Core.Shared;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.LuongNhanVienAgg;

public class LuongNhanVien : EntityBase<LuongNhanVien, string>, IAggregateRoot
{
    public string MaNV { get; private set; }
    public int ThangNhanLuong { get; private set; }
    public int Nam { get; private set; }
    public double TienThuong { get; private set; }
    public double TienPhat { get; private set; }
    public double PhuCap { get; private set; }
    public double TienLuong { get; private set; }

    // Required by EF Core
    #pragma warning disable CS8618
    private LuongNhanVien() { }
    #pragma warning restore CS8618

    public LuongNhanVien(string maNV, int thangNhanLuong, int nam, double tienThuong, double tienPhat, double phuCap, double tienLuong)
    {
        MaNV = maNV;
        ThangNhanLuong = thangNhanLuong;
        Nam = nam;
        TienThuong = tienThuong;
        TienPhat = tienPhat;
        PhuCap = phuCap;
        TienLuong = tienLuong;
        Id = $"{maNV}_{thangNhanLuong}_{nam}";
    }

    public static LuongNhanVien Create(string maNV, int thangNhanLuong, int nam, double tienThuong, double tienPhat, double phuCap, double tienLuong)
    {
        return new LuongNhanVien(maNV, thangNhanLuong, nam, tienThuong, tienPhat, phuCap, tienLuong);
    }

    public void UpdateBonusAndPenalty(double tienThuong, double tienPhat)
    {
        TienThuong = tienThuong;
        TienPhat = tienPhat;
    }

    public void UpdateSalary(double basicSalary, double phuCap)
    {
        TienLuong = basicSalary;
        PhuCap = phuCap;
    }

    public double CalculateTotalSalary()
    {
        return TienLuong + PhuCap + TienThuong - TienPhat;
    }
}
