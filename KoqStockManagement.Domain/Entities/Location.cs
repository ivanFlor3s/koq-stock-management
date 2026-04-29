namespace KoqStockManagement.Domain.Entities;

public class Location : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Enums.LocationType Type { get; set; }
    public string? Address { get; set; }
    public DateTime? DeletedAt { get; set; }
}
