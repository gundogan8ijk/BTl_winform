using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.LuongNhanVienAgg;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core._ValueObjects;
using QuanLiNhanSu.Core.LuongNhanVienAgg.Specifications;
using CoreLuong = QuanLiNhanSu.Core.LuongNhanVienAgg.LuongNhanVien;

namespace QuanLiNhanSu.UseCases.LuongNhanVien;

public record GetLuongListQuery(int Thang, int Nam, string? MaNV = null) : IQuery<Result<List<LuongNhanVienDto>>>;

public class GetLuongListQueryHandler : IQueryHandler<GetLuongListQuery, Result<List<LuongNhanVienDto>>>
{
    private readonly ILuongNhanVienRepository _repository;

    public GetLuongListQueryHandler(ILuongNhanVienRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<List<LuongNhanVienDto>>> Handle(GetLuongListQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var thangNam = ThangNam.Create(request.Thang, request.Nam);
            List<CoreLuong> list;

            if (!string.IsNullOrEmpty(request.MaNV))
            {
                var maNV = NhanVienId.From(request.MaNV);
                var single = await _repository.FirstOrDefaultAsync(new LuongByMaNVThangNamSpec(maNV, thangNam), cancellationToken);
                list = single == null ? [] : [single];
            }
            else
            {
                list = await _repository.ListAsync(new LuongByThangNamSpec(thangNam), cancellationToken);
            }

            var dtos = list.Select(x => new LuongNhanVienDto(
                x.MaNV.Value,
                x.ThangNam.Thang,
                x.ThangNam.Nam,
                (double)x.TienThuong.Value,
                (double)x.TienPhat.Value,
                (double)x.PhuCap.Value,
                (double)x.TienLuong.Value,
                (double)x.CalculateTotalSalary()
            )).ToList();

            return Result<List<LuongNhanVienDto>>.Success(dtos);
        }
        catch (ArgumentException ex)
        {
            return Result<List<LuongNhanVienDto>>.Invalid(new ValidationError(ex.Message));
        }
    }
}
