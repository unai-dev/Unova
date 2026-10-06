namespace Unova.Infrastructure.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("AspNetBookings");

        builder.HasKey(x => x.ID);

        builder.Property(x => x.StartTime)
            .IsRequired();

        builder.Property(x => x.Status)
            .IsRequired();

        builder.Property(x => x.PickupDeadline)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.Bookings)
            .HasForeignKey(x => x.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Copy)
            .WithMany(x => x.Bookings)
            .HasForeignKey(x => x.CopyID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
