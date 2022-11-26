using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalsAdoptionSystem.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "44045ba2-328d-4834-a312-acf4111bec70",
                UserName = "volunteer@mail.com",
                NormalizedUserName = "VOLUNTEER@MEIL.COM",
                Email = "volunteer@mail.com",
                NormalizedEmail = "VOLUNTEER@MEIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Volunteer123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "c5e41c6f-17dd-47b1-97b0-d6b827b7abc9",
                UserName = "adopter@mail.com",
                NormalizedUserName = "ADOPTER@MAIL.COM",
                Email = "adopter@mail.com",
                NormalizedEmail = "ADOPTER@MAIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Adopter123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "f7672546-1a47-4f61-881c-b670468c3d8a",
                UserName = "guest1@mail.com",
                NormalizedUserName = "GUEST1@MAIL.COM",
                Email = "guest1@mail.com",
                NormalizedEmail = "GUEST1@MAIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Guest1123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "9c4b0823-34b6-4f64-b97d-33c2a8bb5991",
                UserName = "guest2@mail.com",
                NormalizedUserName = "GUEST2@MAIL.COM",
                Email = "guest2@mail.com",
                NormalizedEmail = "GUEST2@MAIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Guest2123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "a7a58c04-5a08-4fd1-b0bb-fdd3cb736470",
                UserName = "guest3@mail.com",
                NormalizedUserName = "GUEST3@MAIL.COM",
                Email = "guest3@mail.com",
                NormalizedEmail = "GUEST3@MAIL.COM"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "Guest3123");
            users.Add(user);

            return users;
        }

    }
}

