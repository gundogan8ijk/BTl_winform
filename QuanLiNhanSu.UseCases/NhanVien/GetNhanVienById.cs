using System;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.Specifications;

namespace QuanLiNhanSu.UseCases.NhanVien;

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
        var id = NhanVienId.From(request.MaNV);
        var nv = await _repository.FirstOrDefaultAsync(new NhanVienByIdSpec(id), cancellationToken);
        if (nv == null)
            return Result<NhanVienDto>.NotFound("Không tìm thấy nhân viên.");

        var dto = new NhanVienDto(
            nv.MaNV.Value,
            nv.TenNV.Value,
            nv.NgaySinh.Value.ToDateTime(TimeOnly.MinValue),
            nv.GioiTinh.Value,
            nv.SoDienThoai.Value,
            nv.Email.Value,
            nv.ChucVu.Value,
            nv.DiaChi.Value,
            nv.ThangVaoLam
        );

        return Result<NhanVienDto>.Success(dto);
    }
}
