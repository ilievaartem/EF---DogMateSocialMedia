using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Seeding;

public static class PhotoSeeder
{
    public static void SeedPhotos(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Photo>().HasData(
            new Photo
            {
                Id = 1,
                UserId = 1,
                PhotoPath = "https://example.com/john_photo.jpg",
                CreatedAt = DateTime.Now.AddMonths(-3),
                UpdatedAt = DateTime.Now.AddMonths(-2)
            },
            new Photo
            {
                Id = 2,
                UserId = 2,
                PhotoPath = "https://example.com/jane_photo.jpg",
                CreatedAt = DateTime.Now.AddMonths(-3),
                UpdatedAt = DateTime.Now.AddMonths(-2)
            }
        );
    }
}