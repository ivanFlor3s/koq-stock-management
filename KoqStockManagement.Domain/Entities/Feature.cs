namespace KoqStockManagement.Domain.Entities;

public class Feature : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
}
