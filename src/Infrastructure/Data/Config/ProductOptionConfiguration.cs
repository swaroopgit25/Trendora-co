using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trendora.ApplicationCore.Entities;

namespace Trendora.Infrastructure.Data.Config;

public class ProductOptionConfiguration : IEntityTypeConfiguration<ProductOption>
{
    public void Configure(EntityTypeBuilder<ProductOption> builder)
    {
        builder.ToTable("ProductOptions");

        builder.Property(p => p.Id)
            .UseHiLo("product_options_hilo")
            .IsRequired();

        builder.Property(p => p.Type)
            .IsRequired();

        builder.Property(p => p.Value)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DisplayName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.AdditionalPrice)
            .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0);

        builder.HasOne(p => p.CatalogItem)
            .WithMany(c => c.Options)
            .HasForeignKey(p => p.CatalogItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

