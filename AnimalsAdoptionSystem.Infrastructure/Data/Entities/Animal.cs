using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Entities
{
	public class Animal
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; } = null!;

		[Required]
		[StringLength(70)]
		public string Age { get; set; } = null!;

        [Required]
        public int AnimalKindId { get; set; }

		[ForeignKey(nameof(AnimalKindId))]
        public AnimalKind AnimalKind { get; set; } = null!;

        [Required]
        public int AnimalCharacterId { get; set; }

        [ForeignKey(nameof(AnimalCharacterId))]
        public AnimalCharacter AnimalCharacter { get; set; } = null!;

        [Required]
		[StringLength(100)]
		public string Address { get; set; } = null!;

		[Required]
		[StringLength(200)]
		public string Illness { get; set; } = null!;

		[StringLength(500)]
		public string AdditionalInfo { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int VolunteerId { get; set; }

		[ForeignKey(nameof(VolunteerId))]
		public Volunteer Volunteer { get; set; } = null!;

        public int? AdopterId { get; set; }

        [ForeignKey(nameof(AdopterId))]
        public Adopter? Adopter { get; set; } 
    }
}

