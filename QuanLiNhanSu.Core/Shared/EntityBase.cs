namespace QuanLiNhanSu.Core.Shared;

public abstract class EntityBase<T, TId>
{
    public TId Id { get; protected set; } = default!;
}
