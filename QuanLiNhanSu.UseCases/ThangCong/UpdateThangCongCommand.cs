using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.ThangCongAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;

namespace QuanLiNhanSu.UseCases.ThangCong;

public record UpdateThangCongCommand(
    string MaNV,
    int ThangTC,
    int NamTC,
    int[] DayStatuses
) : ICommand<Result>;

public class UpdateThangCongCommandHandler : ICommandHandler<UpdateThangCongCommand, Result>
{
    private readonly IThangCongRepository _repository;

    public UpdateThangCongCommandHandler(IThangCongRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result> Handle(UpdateThangCongCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var maNV = NhanVienId.From(request.MaNV);
            var thangNam = ThangNam.Create(request.ThangTC, request.NamTC);

            var tcId = $"{maNV.Value}_{thangNam.Thang}_{thangNam.Nam}";
            var thangCong = await _repository.GetByIdAsync(tcId, cancellationToken);
            if (thangCong == null)
                return Result.NotFound("Không tìm thấy dữ liệu chấm công cho tháng và năm này.");

            thangCong.UpdateDays(request.DayStatuses);
            await _repository.UpdateAsync(thangCong, cancellationToken);
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
