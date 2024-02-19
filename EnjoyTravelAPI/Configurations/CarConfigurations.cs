using EnjoyTravelAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnjoyTravelAPI.Configurations
{
    public class CarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Make).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Model).IsRequired().HasMaxLength(50);
            builder.Property(e => e.IsAvailable).IsRequired();

            builder.HasData(
                new Car(1, "Ford", "Focus", true),
                new Car(2, "Jaguar", "XE", true),
                new Car(3, "Bentley", "Continental", false)
                );
        }
    }
}
