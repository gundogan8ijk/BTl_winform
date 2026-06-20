using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.LuongNhanVienAgg;

namespace QuanLiNhanSu.UseCases.LuongApp;

public record UpdateBonusPenaltyCommand(
    string MaNV,
    int Thang,
    int Nam,
    double TienThuong,
    double TienPhat
) : ICommand<Result>;

public class UpdateBonusPenaltyCommandHandler : ICommandHandler<UpdateBonusPenaltyCommand, Result>
{
    private readonly ILuongNhanVienRepository _repository;

    public UpdateBonusPenaltyCommandHandler(ILuongNhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result> Handle(UpdateBonusPenaltyCommand request, CancellationToken cancellationToken)
    {
        var luong = await _repository.GetByEmployeeMonthYearAsync(request.MaNV, request.Thang, request.Nam, cancellationToken);
        if (luong == null)
        {
            return Result.NotFound("Không tìm thấy thông tin lương cho tháng và năm này.");
        }

        luong.UpdateBonusAndPenalty(request.TienThuong, request.TienPhat);
        await _repository.UpdateAsync(luong, cancellationToken);

        return Result.Success();
    }
}
