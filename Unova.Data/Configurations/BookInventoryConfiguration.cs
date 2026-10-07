namespace Unova.Infrastructure.Configurations;

public class BookInventoryConfiguration : IEntityTypeConfiguration<BookInventory>
{
    public void Configure(EntityTypeBuilder<BookInventory> builder)
    {
        builder.ToTable("AspNetBookInventories");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Observations)
            .HasMaxLength(2000);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.BookInventories)
            .HasForeignKey(x => x.BookID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(x => x.BookInventories)
            .HasForeignKey(x => x.UserID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
