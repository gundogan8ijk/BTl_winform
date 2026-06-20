using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.UseCases.TaiKhoan;

public record GetAccountQuery(string Email) : IQuery<Result<AccountDto>>;
public record AccountDto(string Email, double Quyen, string MatKhau = "••••••");

// Alias để WinForm UC Taikhoan.cs tương thích
public record GetAccountsQuery() : IQuery<Result<List<AccountDto>>>;

public record UpdateAccountCommand(string Email, string MatKhau, double Quyen) : ICommand<Result>;
public record DeleteAccountCommand(string Email) : ICommand<Result>;

// ────────── GetAccount ──────────
public class GetAccountQueryHandler : IQueryHandler<GetAccountQuery, Result<AccountDto>>
{
    private readonly ITaiKhoanRepository _repository;

    public GetAccountQueryHandler(ITaiKhoanRepository repository) => _repository = repository;

    public async ValueTask<Result<AccountDto>> Handle(GetAccountQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);
            var acc = await _repository.GetByEmailAsync(email.Value, cancellationToken);
            if (acc == null) return Result<AccountDto>.NotFound("Không tìm thấy tài khoản.");
            return Result<AccountDto>.Success(new AccountDto(acc.Email, acc.Quyen));
        }
        catch (ValueObjectValidationException ex)
        {
            return Result<AccountDto>.Invalid(new ValidationError(ex.Message));
        }
    }
}

// ────────── UpdateAccount ──────────
public class UpdateAccountHandler : ICommandHandler<UpdateAccountCommand, Result>
{
    private readonly ITaiKhoanRepository _repository;

    public UpdateAccountHandler(ITaiKhoanRepository repository) => _repository = repository;

    public async ValueTask<Result> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);
            var acc = await _repository.GetByEmailAsync(email.Value, cancellationToken);
            if (acc == null) return Result.NotFound("Không tìm thấy tài khoản.");

            acc.UpdateRole(request.Quyen);

            if (!string.IsNullOrWhiteSpace(request.MatKhau))
                acc.SetPassword(request.MatKhau);

            await _repository.UpdateAsync(acc, cancellationToken);
            return Result.Success();
        }
        catch (ValueObjectValidationException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
        catch (ArgumentException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}

// ────────── DeleteAccount ──────────
public class DeleteAccountHandler : ICommandHandler<DeleteAccountCommand, Result>
{
    private readonly ITaiKhoanRepository _repository;

    public DeleteAccountHandler(ITaiKhoanRepository repository) => _repository = repository;

    public async ValueTask<Result> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var email = EmailAddress.From(request.Email);
            var acc = await _repository.GetByEmailAsync(email.Value, cancellationToken);
            if (acc == null) return Result.NotFound("Không tìm thấy tài khoản.");

            await _repository.DeleteAsync(acc, cancellationToken);
            return Result.Success();
        }
        catch (ValueObjectValidationException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}
// ────────── GetAccountsList ──────────
public class GetAccountsQueryHandler : IQueryHandler<GetAccountsQuery, Result<List<AccountDto>>>
{
    private readonly ITaiKhoanRepository _repository;

    public GetAccountsQueryHandler(ITaiKhoanRepository repository) => _repository = repository;

    public async ValueTask<Result<List<AccountDto>>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
    {
        var list = await _repository.GetAllAsync(cancellationToken);
        var dtos = list.Select(x => new AccountDto(x.Email, x.Quyen)).ToList();
        return Result<List<AccountDto>>.Success(dtos);
    }
}
