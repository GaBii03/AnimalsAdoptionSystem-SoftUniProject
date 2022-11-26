using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Entities
{
	public class Volunteer
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

