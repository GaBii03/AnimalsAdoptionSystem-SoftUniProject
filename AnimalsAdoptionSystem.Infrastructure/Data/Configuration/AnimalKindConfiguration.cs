using System;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
	public class AnimalKindConfiguration : IEntityTypeConfiguration<AnimalKind>
    {
        public void Configure(EntityTypeBuilder<AnimalKind> builder)
        {
            builder.HasData(CreateAnimalsKinds());
        }

        private List<AnimalKind> CreateAnimalsKinds()
        {
            List<AnimalKind> animalKinds = new List<AnimalKind>()
            {
                new AnimalKind()
                {
                    Id = 1,
                    Name = "Dog"
                },

                new AnimalKind()
                {
                    Id = 2,
                    Name = "Cat"
                },

                new AnimalKind()
                {
                    Id = 3,
                    Name = "Bunny"
                },

                new AnimalKind()
                {
                    Id = 4,
                    Name = "Sneak"
                },

                new AnimalKind()
                {
                    Id = 5,
                    Name = "Turtle"
                },

                new AnimalKind()
                {
                    Id = 6,
                    Name = "Parrot"
                },

                new AnimalKind()
                {
                    Id = 7,
                    Name = "Other (write it in the additional info field)"
                }

            };

            return animalKinds;
        }
    }
}

