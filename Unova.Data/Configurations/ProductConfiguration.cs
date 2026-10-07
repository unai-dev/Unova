namespace Unova.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("AspNetProducts");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(2000);

        builder.Property(x => x.EAN)
            .HasMaxLength(13)
            .IsRequired();

        builder.Property(x => x.Price)
            .HasPrecision(15, 2)
            .IsRequired();

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
