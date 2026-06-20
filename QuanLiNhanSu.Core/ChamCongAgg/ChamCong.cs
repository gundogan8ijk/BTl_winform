using System;
using QuanLiNhanSu.Core.Shared;
using Ardalis.SharedKernel;

namespace QuanLiNhanSu.Core.ChamCongAgg;

public class ChamCong : EntityBase<ChamCong, string>, IAggregateRoot
{
    public string MaNV { get; private set; }
    public string TenNV { get; private set; }
    public DateTime NgayCong { get; private set; }
    public int TrangThai { get; private set; } // 1: đi làm, 0: nghỉ

    // Required by EF Core
    #pragma warning disable CS8618
    private ChamCong() { }
    #pragma warning restore CS8618

    public ChamCong(string maNV, string tenNV, DateTime ngayCong, int trangThai)
    {
        MaNV = maNV;
        TenNV = tenNV;
        NgayCong = ngayCong.Date;
        TrangThai = trangThai;
        Id = $"{maNV}_{NgayCong:yyyyMMdd}";
    }

    public static ChamCong Create(string maNV, string tenNV, DateTime ngayCong, int trangThai)
    {
        return new ChamCong(maNV, tenNV, ngayCong, trangThai);
    }

    public void UpdateStatus(int status)
    {
        TrangThai = status;
    }
}
