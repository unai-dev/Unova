namespace Unova.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasOne(x => x.Enterprise)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.EnterpriseID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Language)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.LanguageID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Center)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.CenterID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
