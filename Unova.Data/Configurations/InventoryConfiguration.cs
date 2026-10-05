namespace Unova.Infrastructure.Configurations;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable("asp_Inventories");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Observations)
            .HasMaxLength(2000);
    }
}
