using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.UseCases.NhanVien;

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
        try
        {
            var id = NhanVienId.From(request.MaNV);
            var nv = await _repository.GetByMaNVAsync(id, cancellationToken);
            if (nv == null)
                return Result.NotFound("Không tìm thấy nhân viên.");

            await _repository.DeleteAsync(nv, cancellationToken);
            return Result.Success();
        }
        catch (ValueObjectValidationException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}
