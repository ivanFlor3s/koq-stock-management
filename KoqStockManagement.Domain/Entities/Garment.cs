namespace KoqStockManagement.Domain.Entities;

public class Garment : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public DateTime? DeletedAt { get; set; }

    public ICollection<GarmentFeature> GarmentFeatures { get; set; } = new List<GarmentFeature>();
    public ICollection<GarmentVariant> Variants { get; set; } = new List<GarmentVariant>();
}
