namespace Unova.Infrastructure.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("AspNetCategories");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(55);

        builder.HasIndex(x => x.Name)
            .IsUnique();


        builder.HasData(
                new Category { ID = 1, Name = "Vida", CreatedAt = DateTime.MinValue },
                new Category { ID = 2, Name = "Amor", CreatedAt = DateTime.MinValue },
                new Category { ID = 3, Name = "Terror", CreatedAt = DateTime.MinValue }
        );
    }
}
