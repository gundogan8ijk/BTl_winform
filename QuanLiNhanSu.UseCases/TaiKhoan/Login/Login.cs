using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.UseCases.TaiKhoan.Login;

public record LoginCommand(string Email, string Password) : ICommand<Result<LoginResultDto>>;

public record LoginResultDto(string Email, double Quyen, string Token);

public class LoginHandler : ICommandHandler<LoginCommand, Result<LoginResultDto>>
{
    private readonly ITaiKhoanRepository _repository;

    public LoginHandler(ITaiKhoanRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<LoginResultDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);
            var taiKhoan = await _repository.GetByEmailAsync(email.Value, cancellationToken);

            if (taiKhoan == null || taiKhoan.MatKhau != request.Password)
                return Result<LoginResultDto>.Unauthorized();

            var token = $"session-{taiKhoan.Email}-{DateTime.UtcNow.Ticks}";
            return Result<LoginResultDto>.Success(new LoginResultDto(taiKhoan.Email, (double)taiKhoan.Quyen.Value, token));
        }
        catch (ValueObjectValidationException)
        {
            return Result<LoginResultDto>.Unauthorized();
        }
    }
}
