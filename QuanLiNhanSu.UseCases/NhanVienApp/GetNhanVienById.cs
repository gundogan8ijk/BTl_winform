using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

public record GetNhanVienByIdQuery(string MaNV) : IQuery<Result<NhanVienDto>>;

public class GetNhanVienByIdHandler : IQueryHandler<GetNhanVienByIdQuery, Result<NhanVienDto>>
{
    private readonly INhanVienRepository _repository;

    public GetNhanVienByIdHandler(INhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<NhanVienDto>> Handle(GetNhanVienByIdQuery request, CancellationToken cancellationToken)
    {
        var nv = await _repository.GetByMaNVAsync(request.MaNV, cancellationToken);
        if (nv == null)
        {
            return Result<NhanVienDto>.NotFound("Không tìm thấy nhân viên.");
        }

        var dto = new NhanVienDto(
            nv.MaNV,
            nv.TenNV,
            nv.NgaySinh,
            nv.GioiTinh,
            nv.SoDienThoai,
            nv.Email,
            nv.ChucVu,
            nv.DiaChi,
            nv.ThangVaoLam
        );

        return Result<NhanVienDto>.Success(dto);
    }
}
