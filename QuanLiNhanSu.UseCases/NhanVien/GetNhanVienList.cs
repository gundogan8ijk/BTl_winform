using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.NhanVienAgg;
using QuanLiNhanSu.Core._ValueObjects;
using CoreNhanVien = QuanLiNhanSu.Core.NhanVienAgg.NhanVien;

namespace QuanLiNhanSu.UseCases.NhanVien;

public record GetNhanVienListQuery(string? MaNV = null, string? TenNV = null) : IQuery<Result<List<NhanVienDto>>>;

public class GetNhanVienListHandler : IQueryHandler<GetNhanVienListQuery, Result<List<NhanVienDto>>>
{
    private readonly INhanVienRepository _repository;

    public GetNhanVienListHandler(INhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<List<NhanVienDto>>> Handle(GetNhanVienListQuery request, CancellationToken cancellationToken)
    {
        List<CoreNhanVien> list;

        if (!string.IsNullOrEmpty(request.MaNV))
        {
            var id = NhanVienId.From(request.MaNV);
            var single = await _repository.GetByMaNVAsync(id, cancellationToken);
            list = single == null ? [] : [single];
        }
        else if (!string.IsNullOrEmpty(request.TenNV))
        {
            list = await _repository.GetByTenNVAsync(request.TenNV, cancellationToken);
        }
        else
        {
            list = await _repository.ListAsync(cancellationToken);
        }

        var dtos = list.Select(x => new NhanVienDto(
            x.MaNV.Value,
            x.TenNV.Value,
            x.NgaySinh.Value.ToDateTime(System.TimeOnly.MinValue),
            x.GioiTinh.Value,
            x.SoDienThoai.Value,
            x.Email.Value,
            x.ChucVu.Value,
            x.DiaChi.Value,
            x.ThangVaoLam
        )).ToList();

        return Result<List<NhanVienDto>>.Success(dtos);
    }
}
