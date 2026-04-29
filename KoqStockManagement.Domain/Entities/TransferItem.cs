namespace KoqStockManagement.Domain.Entities;

public class TransferItem
{
    public int Id { get; set; }

    public int TransferId { get; set; }
    public Transfer? Transfer { get; set; }

    public int GarmentVariantId { get; set; }
    public GarmentVariant? GarmentVariant { get; set; }

    public int Quantity { get; set; }
}
