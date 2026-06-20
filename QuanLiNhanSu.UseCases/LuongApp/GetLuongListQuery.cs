using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Dapper;
using Mediator;

namespace QuanLiNhanSu.UseCases.LuongApp;

public record GetLuongListQuery(int Thang, int Nam, string? MaNV = null) : IQuery<Result<List<LuongNhanVienDto>>>;

public class GetLuongListQueryHandler : IQueryHandler<GetLuongListQuery, Result<List<LuongNhanVienDto>>>
{
    private readonly IDbConnection _dbConnection;

    public GetLuongListQueryHandler(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async ValueTask<Result<List<LuongNhanVienDto>>> Handle(GetLuongListQuery request, CancellationToken cancellationToken)
    {
        string sql = "SELECT MaNV, ThangNhanLuong, Nam, Tienthuong AS TienThuong, Tienphat AS TienPhat, PhuCap, TienLuong, " +
                     "(TienLuong + PhuCap + Tienthuong - Tienphat) AS TongLuong " +
                     "FROM LuongNhanVien WHERE ThangNhanLuong = @Thang AND Nam = @Nam";
        
        var parameters = new DynamicParameters();
        parameters.Add("Thang", request.Thang);
        parameters.Add("Nam", request.Nam);

        if (!string.IsNullOrEmpty(request.MaNV))
        {
            sql += " AND MaNV = @MaNV";
            parameters.Add("MaNV", request.MaNV);
        }

        var list = await _dbConnection.QueryAsync<LuongNhanVienDto>(sql, parameters);
        return Result<List<LuongNhanVienDto>>.Success(list.ToList());
    }
}
