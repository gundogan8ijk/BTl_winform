using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Result;
using Dapper;
using Mediator;

namespace QuanLiNhanSu.UseCases.ChamCongApp;

public record GetChamCongQuery(int Thang, int Nam, string? MaNV = null) : IQuery<Result<List<ThangCongDto>>>;

public class GetChamCongQueryHandler : IQueryHandler<GetChamCongQuery, Result<List<ThangCongDto>>>
{
    private readonly IDbConnection _dbConnection;

    public GetChamCongQueryHandler(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async ValueTask<Result<List<ThangCongDto>>> Handle(GetChamCongQuery request, CancellationToken cancellationToken)
    {
        string sql = "SELECT MaNV, TenNV, ThangTC, NamTC, Day1, Day2, Day3, Day4, Day5, Day6, Day7, Day8, Day9, Day10, Day11, Day12 " +
                     "FROM ThangCong WHERE ThangTC = @Thang AND NamTC = @Nam";
        
        var parameters = new DynamicParameters();
        parameters.Add("Thang", request.Thang);
        parameters.Add("Nam", request.Nam);

        if (!string.IsNullOrEmpty(request.MaNV))
        {
            sql += " AND MaNV = @MaNV";
            parameters.Add("MaNV", request.MaNV);
        }

        var list = await _dbConnection.QueryAsync<ThangCongDto>(sql, parameters);
        return Result<List<ThangCongDto>>.Success(list.ToList());
    }
}
