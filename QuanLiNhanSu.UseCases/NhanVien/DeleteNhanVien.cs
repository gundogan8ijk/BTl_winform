using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core.ThangCongAgg;
using QuanLiNhanSu.Core.ThangCongAgg.Specifications;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Core.LuongNhanVienAgg.Specifications;
using QuanLiNhanSu.Core._ValueObjects;

namespace QuanLiNhanSu.UseCases.NhanVien;

public record DeleteNhanVienCommand(string MaNV) : ICommand<Result>;

public class DeleteNhanVienHandler : ICommandHandler<DeleteNhanVienCommand, Result>
{
    private readonly INhanVienRepository _nhanVienRepository;
    private readonly IThangCongRepository _thangCongRepository;
    private readonly ILuongNhanVienRepository _luongRepository;

    public DeleteNhanVienHandler(
        INhanVienRepository nhanVienRepository,
        IThangCongRepository thangCongRepository,
        ILuongNhanVienRepository luongRepository)
    {
        _nhanVienRepository = nhanVienRepository;
        _thangCongRepository = thangCongRepository;
        _luongRepository = luongRepository;
    }

    public async ValueTask<Result> Handle(DeleteNhanVienCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var id = NhanVienId.From(request.MaNV);
            var nv = await _nhanVienRepository.GetByIdAsync(id, cancellationToken);
            if (nv == null)
                return Result.NotFound("Không tìm thấy nhân viên.");

            // Clean up related ThangCong records
            var thangCongSpecs = new ThangCongByMaNVSpec(id);
            var thangCongList = await _thangCongRepository.ListAsync(thangCongSpecs, cancellationToken);
            if (thangCongList.Any())
            {
                await _thangCongRepository.DeleteRangeAsync(thangCongList, cancellationToken);
            }

            // Clean up related LuongNhanVien records
            var luongSpecs = new LuongByMaNVSpec(id);
            var luongList = await _luongRepository.ListAsync(luongSpecs, cancellationToken);
            if (luongList.Any())
            {
                await _luongRepository.DeleteRangeAsync(luongList, cancellationToken);
            }

            // Delete the employee
            await _nhanVienRepository.DeleteAsync(nv, cancellationToken);
            return Result.Success();
        }
        catch (ValueObjectValidationException ex)
        {
            return Result.Invalid(new ValidationError(ex.Message));
        }
    }
}
