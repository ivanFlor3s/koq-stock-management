using Microsoft.EntityFrameworkCore;
using KoqStockManagement.Domain.Entities;

namespace KoqStockManagement.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<Location> Locations { get; }
    DbSet<Category> Categories { get; }
    DbSet<Feature> Features { get; }
    DbSet<Color> Colors { get; }
    DbSet<Size> Sizes { get; }
    DbSet<Garment> Garments { get; }
    DbSet<GarmentFeature> GarmentFeatures { get; }
    DbSet<GarmentVariant> GarmentVariants { get; }
    DbSet<Inventory> Inventories { get; }
    DbSet<Transfer> Transfers { get; }
    DbSet<TransferItem> TransferItems { get; }
    DbSet<Reception> Receptions { get; }
    DbSet<ReceptionItem> ReceptionItems { get; }
    DbSet<AuditLog> AuditLogs { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
