using System;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
	public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasData(new Volunteer()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                UserId = "44045ba2-328d-4834-a312-acf4111bec70"
            });
        }
    }
}

