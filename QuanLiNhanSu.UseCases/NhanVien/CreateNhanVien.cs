using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core._ValueObjects.Enums;
using CoreNhanVien = QuanLiNhanSu.Core.NhanVienAgg.NhanVien;

namespace QuanLiNhanSu.UseCases.NhanVien;

public record CreateNhanVienCommand(
    string MaNV,
    string TenNV,
    DateTime NgaySinh,
    string GioiTinh,
    string SoDienThoai,
    string Email,
    string ChucVu,
    string DiaChi,
    int ThangVaoLam
) : ICommand<Result<string>>;

public class CreateNhanVienHandler : ICommandHandler<CreateNhanVienCommand, Result<string>>
{
    private readonly INhanVienRepository _repository;

    public CreateNhanVienHandler(INhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<string>> Handle(CreateNhanVienCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var id = NhanVienId.From(request.MaNV);

            if (await _repository.ExistsByMaNVAsync(id, cancellationToken))
                return Result<string>.Conflict("Mã nhân viên đã tồn tại.");

            var nv = new CoreNhanVien(
                id,
                TenNhanVien.From(request.TenNV),
                NgaySinhVO.From(DateOnly.FromDateTime(request.NgaySinh)),
                GioiTinh.FromValue(request.GioiTinh),
                SoDienThoaiVN.From(request.SoDienThoai),
                EmailAddress.From(request.Email),
                ChucVu.From(request.ChucVu),
                DiaChi.From(request.DiaChi),
                request.ThangVaoLam
            );

            await _repository.AddAsync(nv, cancellationToken);
            return Result<string>.Success(nv.MaNV.Value);
        }
        catch (ValueObjectValidationException ex)
        {
            return Result<string>.Invalid(new ValidationError(ex.Message));
        }
        catch (ArgumentException ex)
        {
            return Result<string>.Invalid(new ValidationError(ex.Message));
        }
    }
}
