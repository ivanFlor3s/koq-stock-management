using System.Reflection;
using Microsoft.EntityFrameworkCore;
using KoqStockManagement.Application.Common.Interfaces;
using KoqStockManagement.Domain.Entities;
using KoqStockManagement.Domain.Common;
using System.Linq.Expressions;

namespace KoqStockManagement.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Location> Locations => Set<Location>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Feature> Features => Set<Feature>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Size> Sizes => Set<Size>();
    public DbSet<Garment> Garments => Set<Garment>();
    public DbSet<GarmentFeature> GarmentFeatures => Set<GarmentFeature>();
    public DbSet<GarmentVariant> GarmentVariants => Set<GarmentVariant>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<Transfer> Transfers => Set<Transfer>();
    public DbSet<TransferItem> TransferItems => Set<TransferItem>();
    public DbSet<Reception> Receptions => Set<Reception>();
    public DbSet<ReceptionItem> ReceptionItems => Set<ReceptionItem>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
            {
                var parameter = Expression.Parameter(entityType.ClrType, "e");
                var property = Expression.Property(parameter, nameof(ISoftDelete.DeletedAt));
                var nullConstant = Expression.Constant(null, typeof(DateTime?));
                var body = Expression.Equal(property, nullConstant);
                var lambda = Expression.Lambda(body, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);
            }
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<ISoftDelete>())
        {
            if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.DeletedAt = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
