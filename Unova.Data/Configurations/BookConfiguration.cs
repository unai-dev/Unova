namespace Unova.Infrastructure.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("AspNetBooks");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(55);

        builder.Property(x => x.ISBN)
            .IsRequired()
            .HasMaxLength(13);

        builder.Property(x => x.Synopsis)
            .HasMaxLength(255);

        builder.Property(x => x.PublicationAt)
            .IsRequired();

        builder.Property(x => x.Stock)
            .HasDefaultValue(1);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.AuthorID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CategoryID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
