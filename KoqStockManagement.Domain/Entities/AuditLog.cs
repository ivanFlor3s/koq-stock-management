namespace KoqStockManagement.Domain.Entities;

public class AuditLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }

    public string Action { get; set; } = string.Empty;
    public string AuditableType { get; set; } = string.Empty;
    public int AuditableId { get; set; }

    public string? OldValues { get; set; }
    public string? NewValues { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
