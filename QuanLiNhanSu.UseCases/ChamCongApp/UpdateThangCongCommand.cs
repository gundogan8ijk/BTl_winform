using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.ChamCongAgg;

namespace QuanLiNhanSu.UseCases.ChamCongApp;

public record UpdateThangCongCommand(
    string MaNV,
    int ThangTC,
    int NamTC,
    int[] DayStatuses
) : ICommand<Result>;

public class UpdateThangCongCommandHandler : ICommandHandler<UpdateThangCongCommand, Result>
{
    private readonly IChamCongRepository _repository;

    public UpdateThangCongCommandHandler(IChamCongRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result> Handle(UpdateThangCongCommand request, CancellationToken cancellationToken)
    {
        var thangCong = await _repository.GetThangCongAsync(request.MaNV, request.ThangTC, request.NamTC, cancellationToken);
        if (thangCong == null)
        {
            return Result.NotFound("Không tìm thấy dữ liệu chấm công cho tháng và năm này.");
        }

        try
        {
            thangCong.UpdateDays(request.DayStatuses);
            await _repository.UpdateThangCongAsync(thangCong, cancellationToken);
            return Result.Success();
        }
        catch (ArgumentException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}
