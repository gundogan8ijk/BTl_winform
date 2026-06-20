using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

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
        var nv = await _repository.GetByMaNVAsync(request.MaNV, cancellationToken);
        if (nv == null)
        {
            return Result.NotFound("Không tìm thấy nhân viên.");
        }

        try
        {
            nv.UpdateInfo(
                request.TenNV,
                request.NgaySinh,
                request.GioiTinh,
                request.SoDienThoai,
                request.Email,
                request.ChucVu,
                request.DiaChi
            );

            await _repository.UpdateAsync(nv, cancellationToken);
            return Result.Success();
        }
        catch (ArgumentException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}
