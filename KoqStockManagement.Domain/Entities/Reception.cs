namespace KoqStockManagement.Domain.Entities;

public class Reception : KoqStockManagement.Domain.Common.ISoftDelete
{
    public int Id { get; set; }

    public int LocationId { get; set; }
    public Location? Location { get; set; }

    public Enums.ReceptionStatus Status { get; set; }

    public int ReceivedById { get; set; }
    public User? ReceivedBy { get; set; }

    public DateTime? ReceivedAt { get; set; }
    public string? Notes { get; set; }
    public DateTime? DeletedAt { get; set; }

    public ICollection<ReceptionItem> Items { get; set; } = new List<ReceptionItem>();
}
