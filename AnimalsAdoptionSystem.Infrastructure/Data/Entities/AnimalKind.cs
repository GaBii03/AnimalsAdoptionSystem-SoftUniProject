using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Entities
{
	public class AnimalKind
	{
		public AnimalKind()
		{
            Animals = new List<Animal>();
		}

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<Animal> Animals { get; set; }
    }
}

