namespace Unova.Infrastructure.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("AspNetAuthors");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(55);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(55);
    }
}
