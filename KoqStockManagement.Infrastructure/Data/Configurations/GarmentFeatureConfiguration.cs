using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KoqStockManagement.Domain.Entities;

namespace KoqStockManagement.Infrastructure.Data.Configurations;

public class GarmentFeatureConfiguration : IEntityTypeConfiguration<GarmentFeature>
{
    public void Configure(EntityTypeBuilder<GarmentFeature> builder)
    {
        builder.HasKey(gf => new { gf.GarmentId, gf.FeatureId });
    }
}
