namespace KoqStockManagement.Domain.Entities;

public class Color : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? HexCode { get; set; }
    public DateTime? DeletedAt { get; set; }
}
