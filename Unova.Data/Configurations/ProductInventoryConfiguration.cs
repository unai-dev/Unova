namespace Unova.Infrastructure.Configurations;

public class ProductInventoryConfiguration : IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> builder)
    {
        builder.ToTable("AspNetProductInventories");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Observations)
            .HasMaxLength(2000);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.ProductInventories)
            .HasForeignKey(x => x.ProductID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(x => x.ProductInventories)
            .HasForeignKey(x => x.UserID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
