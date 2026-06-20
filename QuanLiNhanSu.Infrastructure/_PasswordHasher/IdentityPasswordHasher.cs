using Microsoft.AspNetCore.Identity;
using QuanLiNhanSu.Core.TaiKhoanAgg;

namespace QuanLiNhanSu.Infrastructure._PasswordHasher;

public class IdentityPasswordHasher : IPasswordHasher
{
    private readonly PasswordHasher<string> _hasher = new();

    public string HashPassword(string password)
    {
        return _hasher.HashPassword("user", password);
    }

    public bool VerifyPassword(string hashedPassword, string providedPassword)
    {
        var result = _hasher.VerifyHashedPassword("user", hashedPassword, providedPassword);
        return result != PasswordVerificationResult.Failed;
    }
}
