namespace Unova.Infrastructure.Configurations;

public class EnterpriseConfiguration : IEntityTypeConfiguration<Enterprise>
{
    public void Configure(EntityTypeBuilder<Enterprise> builder)
    {
        builder.ToTable("asp_Enterprises");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(2000);

        builder.Property(x => x.NIF)
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(x => x.Phone)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasOne(x => x.Address)
            .WithMany(x => x.Enterprises)
            .HasForeignKey(x => x.AddressID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

