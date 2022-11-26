using System;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
	public class AdopterConfiguration : IEntityTypeConfiguration<Adopter>
    {
        public void Configure(EntityTypeBuilder<Adopter> builder)
        {
            builder.HasData(new Adopter()
            {
                Id = 1,
                PhoneNumber = "+359777777777",
                UserId = "c5e41c6f-17dd-47b1-97b0-d6b827b7abc9"
            });
        }
    }
}

