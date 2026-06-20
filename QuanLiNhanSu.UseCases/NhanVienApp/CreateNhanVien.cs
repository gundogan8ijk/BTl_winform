using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

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
        if (await _repository.ExistsByMaNVAsync(request.MaNV, cancellationToken))
        {
            return Result<string>.Conflict("Mã nhân viên đã tồn tại.");
        }

        try
        {
            var nv = NhanVien.Create(
                request.MaNV,
                request.TenNV,
                request.NgaySinh,
                request.GioiTinh,
                request.SoDienThoai,
                request.Email,
                request.ChucVu,
                request.DiaChi,
                request.ThangVaoLam
            );

            await _repository.AddAsync(nv, cancellationToken);
            return Result<string>.Success(nv.MaNV);
        }
        catch (ArgumentException ex)
        {
            return Result<string>.Invalid(new ValidationError(ex.Message));
        }
    }
}
