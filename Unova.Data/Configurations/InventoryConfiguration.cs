namespace Unova.Infrastructure.Configurations;

public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.ToTable("asp_Inventories");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Observations)
            .HasMaxLength(2000);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.Inventories)
            .HasForeignKey(x => x.BookID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(x => x.Inventories)
            .HasForeignKey(x => x.UserID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
