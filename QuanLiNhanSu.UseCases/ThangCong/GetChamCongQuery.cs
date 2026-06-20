using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Mediator;
using QuanLiNhanSu.Core.ThangCongAgg.ValueObjects;
using QuanLiNhanSu.Core.NhanVienAgg.ValueObjects;
using ThangCong = QuanLiNhanSu.Core.ThangCongAgg.ThangCong;
using QuanLiNhanSu.Core.ThangCongAgg;
using QuanLiNhanSu.Core.ThangCongAgg.Specifications;
namespace QuanLiNhanSu.UseCases.ThangCong;

public record GetChamCongQuery(int Thang, int Nam, string? MaNV = null) : IQuery<Result<List<ThangCongDto>>>;

public class GetChamCongQueryHandler : IQueryHandler<GetChamCongQuery, Result<List<ThangCongDto>>>
{
    private readonly IThangCongRepository _repository;

    public GetChamCongQueryHandler(IThangCongRepository repository)
    {
        _repository = repository;
    }

    public async ValueTask<Result<List<ThangCongDto>>> Handle(GetChamCongQuery request, CancellationToken cancellationToken)
    {
        var thangNam = ThangNam.Create(request.Thang, request.Nam);
        List<QuanLiNhanSu.Core.ThangCongAgg.ThangCong> list;

        if (!string.IsNullOrEmpty(request.MaNV))
        {
            var maNV = NhanVienId.From(request.MaNV);
            var single = await _repository.FirstOrDefaultAsync(new ThangCongByMaNVThangNamSpec(maNV, thangNam), cancellationToken);
            list = single == null ? [] : [single];
        }
        else
        {
            list = await _repository.ListAsync(new ThangCongByThangNamSpec(thangNam), cancellationToken);
        }

        var dtos = list.Select(x => new ThangCongDto(
            x.MaNV.Value,
            x.TenNV.Value,
            x.ThangNam.Thang,
            x.ThangNam.Nam,
            x.Day1, x.Day2, x.Day3, x.Day4,
            x.Day5, x.Day6, x.Day7, x.Day8,
            x.Day9, x.Day10, x.Day11, x.Day12
        )).ToList();

        return Result<List<ThangCongDto>>.Success(dtos);
    }
}
