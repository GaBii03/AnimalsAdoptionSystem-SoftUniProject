using AnimalsAdoptionSystem.Infrastructure.Data.Configuration;
using AnimalsAdoptionSystem.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimalsAdoptionSystem.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new VolunteerConfiguration());
        builder.ApplyConfiguration(new AnimalConfiguration());
        builder.ApplyConfiguration(new AnimalKindConfiguration());
        builder.ApplyConfiguration(new AnimalCharacterConfiguration());
        builder.ApplyConfiguration(new AdopterConfiguration());

        base.OnModelCreating(builder);
    }

    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<AnimalCharacter> AnimalCharacters { get; set; } = null!;
    public DbSet<AnimalKind> AnimalKinds { get; set; } = null!;
    public DbSet<Volunteer> Volunteers { get; set; } = null!;
    public DbSet<Adopter> Adopters { get; set; } = null!;
}

