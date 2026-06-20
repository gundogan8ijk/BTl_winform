using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Dapper;
using Mediator;
using QuanLiNhanSu.Core.TaiKhoanAgg;

namespace QuanLiNhanSu.UseCases.Authen;

public record AccountDto(string Email, string MatKhau, double Quyen);

public record GetAccountsQuery(string? SearchEmail = null) : IQuery<Result<List<AccountDto>>>;

public record UpdateAccountCommand(string Email, string MatKhau, double Quyen) : ICommand<Result>;

public record DeleteAccountCommand(string Email) : ICommand<Result>;

public class AccountCrudHandlers : 
    IQueryHandler<GetAccountsQuery, Result<List<AccountDto>>>,
    ICommandHandler<UpdateAccountCommand, Result>,
    ICommandHandler<DeleteAccountCommand, Result>
{
    private readonly ITaiKhoanRepository _repository;
    private readonly IDbConnection _dbConnection;

    public AccountCrudHandlers(ITaiKhoanRepository repository, IDbConnection dbConnection)
    {
        _repository = repository;
        _dbConnection = dbConnection;
    }

    public async ValueTask<Result<List<AccountDto>>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
    {
        string sql = "SELECT email AS Email, matkhau AS MatKhau, Quyen FROM TaiKhoan";
        var parameters = new DynamicParameters();

        if (!string.IsNullOrEmpty(request.SearchEmail))
        {
            sql += " WHERE email LIKE @Email";
            parameters.Add("Email", $"%{request.SearchEmail}%");
        }

        var list = await _dbConnection.QueryAsync<AccountDto>(sql, parameters);
        return Result<List<AccountDto>>.Success(list.ToList());
    }

    public async ValueTask<Result> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var acc = await _repository.GetByEmailAsync(request.Email, cancellationToken);
        if (acc == null)
        {
            return Result.NotFound("Không tìm thấy tài khoản.");
        }

        acc.UpdateRole(request.Quyen);

        if (!string.IsNullOrWhiteSpace(request.MatKhau))
            acc.SetPassword(request.MatKhau);

        await _repository.UpdateAsync(acc, cancellationToken);
        return Result.Success();
    }

    public async ValueTask<Result> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        var acc = await _repository.GetByEmailAsync(request.Email, cancellationToken);
        if (acc == null)
        {
            return Result.NotFound("Không tìm thấy tài khoản.");
        }

        await _repository.DeleteAsync(acc, cancellationToken);
        return Result.Success();
    }
}
