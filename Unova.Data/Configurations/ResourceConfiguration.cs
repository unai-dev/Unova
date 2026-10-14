namespace Unova.Infrastructure.Configurations;

public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
{
    public void Configure(EntityTypeBuilder<Resource> builder)
    {
        builder.ToTable("AspNetResources");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Code)
            .HasMaxLength(55)
            .IsRequired();

        builder.Property(x => x.Text)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(2000);

        builder.HasOne(x => x.Language)
            .WithMany(x => x.Resources)
            .HasForeignKey(x => x.LanguageID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
