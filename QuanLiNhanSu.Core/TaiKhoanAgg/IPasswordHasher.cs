namespace QuanLiNhanSu.Core.TaiKhoanAgg;

public interface IPasswordHasher
{
    string HashPassword(string password);
    bool VerifyPassword(string hashedPassword, string providedPassword);
}
