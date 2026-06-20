using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core.Shared;
using Ardalis.SharedKernel;
using Ardalis.GuardClauses;
using System;

namespace QuanLiNhanSu.Core.TaiKhoanAgg;

public class TaiKhoan : EntityBase<TaiKhoan, string>, IAggregateRoot
{
    public string Email => Id;
    public string MatKhau { get; private set; }
    public double Quyen { get; private set; } // 0 = Admin, 1 = User

    // Required by EF Core
    #pragma warning disable CS8618
    private TaiKhoan() { }
    #pragma warning restore CS8618

    public TaiKhoan(string email, string matKhau, double quyen)
    {
        Guard.Against.NullOrWhiteSpace(email, nameof(email), "Email không được để trống.");
        Guard.Against.NullOrWhiteSpace(matKhau, nameof(matKhau), "Mật khẩu không được để trống.");
        Guard.Against.OutOfRange(quyen, nameof(quyen), 0, 1, "Quyền phải là 0 hoặc 1.");

        Id = new Email(email).Value;
        MatKhau = new MatKhau(matKhau).Value;
        Quyen = quyen;
    }

    public static TaiKhoan Create(string email, string matKhau, double quyen)
    {
        return new TaiKhoan(email, matKhau, quyen);
    }

    public void UpdatePassword(string currentPassword, string newPassword)
    {
        Guard.Against.NullOrWhiteSpace(newPassword, nameof(newPassword), "Mật khẩu mới không được để trống.");
        if (MatKhau != currentPassword)
            throw new InvalidOperationException("Mật khẩu hiện tại không đúng.");
        
        MatKhau = new MatKhau(newPassword).Value;
    }

    public void UpdateRole(double newQuyen)
    {
        Guard.Against.OutOfRange(newQuyen, nameof(newQuyen), 0, 1, "Quyền phải là 0 hoặc 1.");
        Quyen = newQuyen;
    }
}
