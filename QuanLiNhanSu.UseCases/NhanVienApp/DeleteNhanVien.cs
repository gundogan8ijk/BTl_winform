using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

public record DeleteNhanVienCommand(string MaNV) : ICommand<Result>;

public class DeleteNhanVienHandler : ICommandHandler<DeleteNhanVienCommand, Result>
{
    private readonly INhanVienRepository _repository;

    public DeleteNhanVienHandler(INhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result> Handle(DeleteNhanVienCommand request, CancellationToken cancellationToken)
    {
        var nv = await _repository.GetByMaNVAsync(request.MaNV, cancellationToken);
        if (nv == null)
        {
            return Result.NotFound("Không tìm thấy nhân viên.");
        }

        await _repository.DeleteAsync(nv, cancellationToken);
        return Result.Success();
    }
}
