using System;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasData(CreateAnimal());
        }

        private List<Animal> CreateAnimal()
        {
            var animals = new List<Animal>()
            {
                new Animal()
                {
                    Id = 1,
                    Name = "Katy",
                    Address = "North London, UK (near the border)",
                    Age = "2 years and 2 months",
                    ImageUrl = "https://images.hindustantimes.com/rf/image_size_630x354/HT/p2/2019/08/08/Pictures/_6bda0940-b9ad-11e9-98cb-e738ad509720.jpg",
                    AnimalKindId = 2,
                    AnimalCharacterId = 2,
                    Illness = "none",
                    AdditionalInfo = "She has hygienic habits, likes to sleep and loves kids!",
                    VolunteerId = 1,
                },

                new Animal()
                {
                    Id = 2,
                    Name = "Barry",
                    Address = "Plovdiv ,Bulgaria",
                    Age = "3 years",
                    ImageUrl = "https://cdn.britannica.com/49/161649-050-3F458ECF/Bernese-mountain-dog-grass.jpg",
                    AnimalKindId = 1,
                    AnimalCharacterId = 2,
                    Illness = "Kidney problems (takes pills to maintain good health)",
                    AdditionalInfo = "He has hygienic habits, loves kids, very energetic, love long walks!",
                    VolunteerId = 1,
                },

                new Animal()
                {
                    Id = 3,
                    Name = "Tessy",
                    Address = "Varna, Bulgaria",
                    Age = "1 year and 6 months",
                    ImageUrl = "https://media.istockphoto.com/id/157423855/photo/white-rabbit-for-sale-easter-bunny-in-a-cage.jpg?s=612x612&w=0&k=20&c=v7mOWtCqY-Xu_0rqLfMMgAE1uII3djHIRnQ7BP0vQ0Q=",
                    AnimalKindId = 3,
                    AnimalCharacterId = 2,
                    Illness = "none",
                    AdditionalInfo = "Loves kids, comes with a big rabbit cage!",
                    VolunteerId = 1,
                }

            };

            return animals;

        }
    }
}

