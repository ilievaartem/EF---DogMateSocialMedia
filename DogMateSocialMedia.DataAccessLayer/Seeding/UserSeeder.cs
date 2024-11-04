using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Seeding;

public static class UserSeeder
{
    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Age = 30,
                Nickname = "jdoe",
                Email = "johndoe@example.com",
                Sex = false,
                Description = "Loves hiking and photography",
                Role = "Owner",
                IsVerified = true,
                CreatedAt = DateTime.Now.AddMonths(-3),
                UpdatedAt = DateTime.Now.AddMonths(-2)
            },
            new User
            {
                Id = 2,
                Name = "Jane",
                Surname = "Smith",
                Age = 25,
                Nickname = "jsmith",
                Email = "janesmith@example.com",
                Sex = true,
                Description = "Dog lover and baker",
                Role = "Professional",
                IsVerified = false,
                CreatedAt = DateTime.Now.AddMonths(-6),
                UpdatedAt = DateTime.Now.AddMonths(-1)
            }
        );
    }
}