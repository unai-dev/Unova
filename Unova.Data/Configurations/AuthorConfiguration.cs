namespace Unova.Infrastructure.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("AspNetAuthors");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Code)
            .HasMaxLength(55)
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique();

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(55);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(55);

        builder.HasData(
            new Author { ID = 1, Code = "111", FirstName = "Unai", LastName = "Villar", CreatedAt = DateTime.MinValue },
            new Author { ID = 2, Code = "222", FirstName = "Beni", LastName = "Villar", CreatedAt = DateTime.MinValue },
            new Author { ID = 3, Code = "333", FirstName = "Candi", LastName = "Cabello", CreatedAt = DateTime.MinValue }
        );
    }
}
