namespace Unova.Infrastructure.Configurations;

public class CopyConfiguration : IEntityTypeConfiguration<Copy>
{
    public void Configure(EntityTypeBuilder<Copy> builder)
    {
        builder.ToTable("AspNetCopies");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Code)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique();

        builder.HasOne(x => x.Book)
            .WithMany(x => x.Copies)
            .HasForeignKey(x => x.BookID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Location)
            .WithMany(x => x.Copies)
            .HasForeignKey(x => x.LocationID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
