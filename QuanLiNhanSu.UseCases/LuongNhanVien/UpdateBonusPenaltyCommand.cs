using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.UseCases.LuongNhanVien;

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
        try
        {
            var maNV = NhanVienId.From(request.MaNV);
            var thangNam = ThangNam.Create(request.Thang, request.Nam);

            var luong = await _repository.GetByEmployeeMonthYearAsync(maNV, thangNam, cancellationToken);
            if (luong == null)
                return Result.NotFound("Không tìm thấy thông tin lương cho tháng và năm này.");

            luong.UpdateBonusAndPenalty(
                TienThuong.From((decimal)request.TienThuong),
                TienPhat.From((decimal)request.TienPhat)
            );

            await _repository.UpdateAsync(luong, cancellationToken);
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
