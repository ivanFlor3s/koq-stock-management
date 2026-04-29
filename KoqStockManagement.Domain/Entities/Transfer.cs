namespace KoqStockManagement.Domain.Entities;

public class Transfer : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }

    public int SourceLocationId { get; set; }
    public Location? SourceLocation { get; set; }

    public int DestinationLocationId { get; set; }
    public Location? DestinationLocation { get; set; }

    public Enums.TransferStatus Status { get; set; }

    public int CreatedById { get; set; }
    public User? CreatedBy { get; set; }

    public DateTime? ShippedAt { get; set; }
    public DateTime? ReceivedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public ICollection<TransferItem> Items { get; set; } = new List<TransferItem>();
}
