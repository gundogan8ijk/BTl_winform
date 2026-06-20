using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core._ValueObjects.Enums;

namespace QuanLiNhanSu.UseCases.NhanVien;

public record UpdateNhanVienCommand(
    string MaNV,
    string TenNV,
    DateTime NgaySinh,
    string GioiTinh,
    string SoDienThoai,
    string Email,
    string ChucVu,
    string DiaChi
) : ICommand<Result>;

public class UpdateNhanVienHandler : ICommandHandler<UpdateNhanVienCommand, Result>
{
    private readonly INhanVienRepository _repository;

    public UpdateNhanVienHandler(INhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result> Handle(UpdateNhanVienCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var id = NhanVienId.From(request.MaNV);
            var nv = await _repository.GetByIdAsync(id, cancellationToken);
            if (nv == null)
                return Result.NotFound("Không tìm thấy nhân viên.");

            nv.Update(
                TenNhanVien.From(request.TenNV),
                NgaySinhVO.From(DateOnly.FromDateTime(request.NgaySinh)),
                GioiTinh.FromValue(request.GioiTinh),
                SoDienThoaiVN.From(request.SoDienThoai),
                EmailAddress.From(request.Email),
                ChucVu.From(request.ChucVu),
                DiaChi.From(request.DiaChi)
            );

            await _repository.UpdateAsync(nv, cancellationToken);
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
