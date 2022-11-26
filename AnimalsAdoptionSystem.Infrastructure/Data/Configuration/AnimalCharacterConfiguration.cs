using System;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
	public class AnimalCharacterConfiguration : IEntityTypeConfiguration<AnimalCharacter>
    {
        public void Configure(EntityTypeBuilder<AnimalCharacter> builder)
        {
            builder.HasData(CreateAnimalsKinds());
        }

        private List<AnimalCharacter> CreateAnimalsKinds()
        {
            List<AnimalCharacter> animalCharacter = new List<AnimalCharacter>()
            {
                new AnimalCharacter()
                {
                    Id = 1,
                    Name = "Agressive"
                },

                new AnimalCharacter()
                {
                    Id = 2,
                    Name = "Calm"
                },

                new AnimalCharacter()
                {
                    Id = 3,
                    Name = "Other(describe it in the additional info field)"
                }
            };

            return animalCharacter;
        }
    }

}

