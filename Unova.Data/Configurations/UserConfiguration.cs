namespace Unova.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("AspNetUsers");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CIF)
            .HasMaxLength(9)
            .IsRequired();

        builder.HasOne(x => x.Language)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.LanguageID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
