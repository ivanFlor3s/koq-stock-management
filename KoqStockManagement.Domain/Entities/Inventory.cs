namespace KoqStockManagement.Domain.Entities;

public class Inventory : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    
    public int LocationId { get; set; }
    public Location? Location { get; set; }

    public int GarmentVariantId { get; set; }
    public GarmentVariant? GarmentVariant { get; set; }

    public int Quantity { get; set; }
    public int LowStockThreshold { get; set; }

    public DateTime? DeletedAt { get; set; }
}
