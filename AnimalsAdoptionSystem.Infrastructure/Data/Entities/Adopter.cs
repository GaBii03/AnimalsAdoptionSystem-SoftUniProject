using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Entities
{
	public class Adopter
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;


        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}

