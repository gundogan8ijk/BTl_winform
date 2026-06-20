using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Dapper;
using Mediator;

namespace QuanLiNhanSu.UseCases.NhanVienApp;

public record GetNhanVienListQuery(string? MaNV = null, string? TenNV = null) : IQuery<Result<List<NhanVienDto>>>;

public class GetNhanVienListHandler : IQueryHandler<GetNhanVienListQuery, Result<List<NhanVienDto>>>
{
    private readonly IDbConnection _dbConnection;

    public GetNhanVienListHandler(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async ValueTask<Result<List<NhanVienDto>>> Handle(GetNhanVienListQuery request, CancellationToken cancellationToken)
    {
        string sql = "SELECT MaNV, TenNV, NgaySinh, GioiTinh, SoDienThoai, Email, ChucVu, DiaChi, thangVaoLam AS ThangVaoLam FROM NhanVien";
        var parameters = new DynamicParameters();

        if (!string.IsNullOrEmpty(request.MaNV))
        {
            sql += " WHERE MaNV = @MaNV";
            parameters.Add("MaNV", request.MaNV);
        }
        else if (!string.IsNullOrEmpty(request.TenNV))
        {
            sql += " WHERE TenNV LIKE @TenNV";
            parameters.Add("TenNV", $"%{request.TenNV}%");
        }

        var list = await _dbConnection.QueryAsync<NhanVienDto>(sql, parameters);
        return Result<List<NhanVienDto>>.Success(list.ToList());
    }
}
