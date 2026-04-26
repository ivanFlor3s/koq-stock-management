using Microsoft.EntityFrameworkCore;
using KoqStockManagement.Domain.Entities;

namespace KoqStockManagement.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Store> Stores { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
