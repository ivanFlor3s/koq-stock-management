namespace KoqStockManagement.Domain.Entities;

public class GarmentFeature
{
    public int GarmentId { get; set; }
    public Garment? Garment { get; set; }
    
    public int FeatureId { get; set; }
    public Feature? Feature { get; set; }
}
