namespace KoqStockManagement.Domain.Entities;

public class ReceptionItem
{
    public int Id { get; set; }

    public int ReceptionId { get; set; }
    public Reception? Reception { get; set; }

    public int GarmentVariantId { get; set; }
    public GarmentVariant? GarmentVariant { get; set; }

    public int Quantity { get; set; }
}
