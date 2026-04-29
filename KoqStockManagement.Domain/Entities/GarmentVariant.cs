namespace KoqStockManagement.Domain.Entities;

public class GarmentVariant : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    
    public int GarmentId { get; set; }
    public Garment? Garment { get; set; }

    public int ColorId { get; set; }
    public Color? Color { get; set; }

    public int SizeId { get; set; }
    public Size? Size { get; set; }

    public string Sku { get; set; } = string.Empty;

    public DateTime? DeletedAt { get; set; }
}
