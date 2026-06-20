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

    public RegisterHandler(ITaiKhoanRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);

            if (await _repository.ExistsByEmailAsync(email.Value, cancellationToken))
                return Result<string>.Conflict("Email này đã được đăng ký.");

            var newAccount = CoreTaiKhoan.Create(email.Value, request.Password, QuyenNguoiDung.FromDouble(request.Quyen));
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
