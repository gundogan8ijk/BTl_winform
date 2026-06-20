using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;

namespace QuanLiNhanSu.UseCases.Authen.Register;

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
        if (await _repository.ExistsByEmailAsync(request.Email, cancellationToken))
        {
            return Result<string>.Conflict("Email này đã được đăng ký.");
        }

        var newAccount = TaiKhoan.Create(request.Email, request.Password, request.Quyen);
        await _repository.AddAsync(newAccount, cancellationToken);

        return Result<string>.Success("Đăng ký tài khoản thành công.");
    }
}
