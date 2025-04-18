namespace Domain.Primitives;

public abstract class BaseEntity(Guid id) : IEquatable<BaseEntity>
{
    private Guid Id { get; init; } = id;

    protected BaseEntity() : this(new Guid()) { }
    
    public bool Equals(BaseEntity? other)
    {
        if (other is null || other.GetType() != GetType())
            return false;
        return other.Id == Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType() || obj is not BaseEntity entity)
            return false;
        return entity.Id == Id;
    }

    public override int GetHashCode() => Id.GetHashCode();
    
    public static bool operator ==(BaseEntity? first, BaseEntity? second) => first is not null && second is not null && first.Equals(second);
    
    public static bool operator !=(BaseEntity? first, BaseEntity? second) => !(first == second);
}
