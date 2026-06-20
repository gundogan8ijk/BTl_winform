using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.Core.TaiKhoanAgg;

public class TaiKhoan : EntityBase<TaiKhoan, string>, IAggregateRoot
{
    public string Email => Id;
    public string MatKhau { get; private set; }
    public QuyenNguoiDung Quyen { get; private set; }

    #pragma warning disable CS8618
    private TaiKhoan() { }
    #pragma warning restore CS8618

    public TaiKhoan(string email, string matKhau, QuyenNguoiDung quyen)
    {
        Guard.Against.NullOrWhiteSpace(email, nameof(email));
        Guard.Against.NullOrWhiteSpace(matKhau, nameof(matKhau));
        Guard.Against.Null(quyen, nameof(quyen));

        Id = EmailAddress.From(email).Value;
        MatKhau = ValueObjects.MatKhau.From(matKhau).Value;
        Quyen = quyen;
    }

    public static TaiKhoan Create(string email, string matKhau, QuyenNguoiDung quyen) =>
        new(email, matKhau, quyen);

    public void UpdatePassword(string currentPassword, string newPassword)
    {
        Guard.Against.NullOrWhiteSpace(newPassword, nameof(newPassword));
        if (MatKhau != currentPassword)
            throw new InvalidOperationException("Mật khẩu hiện tại không đúng.");
        MatKhau = ValueObjects.MatKhau.From(newPassword).Value;
    }

    public void SetPassword(string newPassword)
    {
        Guard.Against.NullOrWhiteSpace(newPassword, nameof(newPassword));
        MatKhau = ValueObjects.MatKhau.From(newPassword).Value;
    }

    public void UpdateRole(QuyenNguoiDung newQuyen)
    {
        Guard.Against.Null(newQuyen, nameof(newQuyen));
        Quyen = newQuyen;
    }
}
