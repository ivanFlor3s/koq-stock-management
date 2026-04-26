using System.Reflection;
using Microsoft.EntityFrameworkCore;
using KoqStockManagement.Application.Common.Interfaces;
using KoqStockManagement.Domain.Entities;

namespace KoqStockManagement.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Store> Stores => Set<Store>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
