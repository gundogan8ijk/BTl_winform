using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core._ValueObjects.Enums;
using CoreTaiKhoan = QuanLiNhanSu.Core.TaiKhoanAgg.TaiKhoan;

namespace QuanLiNhanSu.UseCases.TaiKhoan.Register;

public record RegisterCommand(string Email, string Password, double Quyen) : ICommand<Result<string>>;

public class RegisterHandler : ICommandHandler<RegisterCommand, Result<string>>
{
    private readonly ITaiKhoanRepository _repository;
    private readonly IPasswordHasher _passwordHasher;

    public RegisterHandler(ITaiKhoanRepository repository, IPasswordHasher passwordHasher)
    {
        _repository = repository;
        _passwordHasher = passwordHasher;
    }

    public async ValueTask<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);

            if (await _repository.GetByIdAsync(email.Value, cancellationToken) != null)
                return Result<string>.Conflict("Email này đã được đăng ký.");

            var hashedPassword = _passwordHasher.HashPassword(request.Password);
            var newAccount = CoreTaiKhoan.Create(email.Value, hashedPassword, QuyenNguoiDung.FromDouble(request.Quyen));
            await _repository.AddAsync(newAccount, cancellationToken);

            return Result<string>.Success("Đăng ký tài khoản thành công.");
        }
        catch (ValueObjectValidationException ex)
        {
            return Result<string>.Invalid(new ValidationError(ex.Message));
        }
        catch (ArgumentException ex)
        {
            return Result<string>.Invalid(new ValidationError(ex.Message));
        }
    }
}
