using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;

namespace QuanLiNhanSu.UseCases.Authen.Login;

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
        var taiKhoan = await _repository.GetByEmailAsync(request.Email, cancellationToken);
        if (taiKhoan == null || taiKhoan.MatKhau != request.Password)
        {
            return Result<LoginResultDto>.Unauthorized();
        }

        var token = $"session-{taiKhoan.Email}-{DateTime.UtcNow.Ticks}";
        return Result<LoginResultDto>.Success(new LoginResultDto(taiKhoan.Email, taiKhoan.Quyen, token));
    }
}
