using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Seeding;

public static class DogSeeder
{
    public static void SeedDogs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dog>().HasData(
            new Dog
            {
                DogID = 1,
                OwnerID = 1, 
                Name = "Buddy",
                Breed = "Golden Retriever",
                Age = 3,
                Gender = "Male",
                Description = "A friendly and playful dog.",
                ProfilePicture = "https://example.com/images/buddy.jpg"
            },
            new Dog
            {
                DogID = 2,
                OwnerID = 2,
                Name = "Luna",
                Breed = "Labrador Retriever",
                Age = 4,
                Gender = "Female",
                Description = "Very affectionate and loves to swim.",
                ProfilePicture = "https://example.com/images/luna.jpg"
            },
            new Dog
            {
                DogID = 3,
                OwnerID = 1,
                Name = "Max",
                Breed = "German Shepherd",
                Age = 5,
                Gender = "Male",
                Description = "Loyal and protective.",
                ProfilePicture = "https://example.com/images/max.jpg"
            },
            new Dog
            {
                DogID = 4,
                OwnerID = 2,
                Name = "Charlie",
                Breed = "Poodle",
                Age = 3,
                Gender = "Male",
                Description = "Very intelligent and easy to train.",
                ProfilePicture = "https://example.com/images/charlie.jpg"
            }
        );
    }
}