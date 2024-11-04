using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Seeding;

public static class PostSeeder
{
    public static void SeedPosts(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasData(
            new Post
            {
                PostID = 1,
                UserID = 1, 
                Content = "Enjoying a day at the park!",
                MediaUrl = "https://example.com/media/post1.jpg",
                CreatedAt = DateTime.UtcNow.AddDays(-10),
                UpdatedAt = DateTime.UtcNow.AddDays(-5)
            },
            new Post
            {
                PostID = 2,
                UserID = 2, 
                Content = "Check out my new trick!",
                MediaUrl = "https://example.com/media/post2.mp4",
                CreatedAt = DateTime.UtcNow.AddDays(-8),
                UpdatedAt = DateTime.UtcNow.AddDays(-3)
            },
            new Post
            {
                PostID = 3,
                UserID = 1,
                Content = "Such a beautiful day!",
                MediaUrl = "https://example.com/media/post3.jpg",
                CreatedAt = DateTime.UtcNow.AddDays(-6),
                UpdatedAt = DateTime.UtcNow.AddDays(-1)
            },
            new Post
            {
                PostID = 4,
                UserID = 2,
                Content = "Just got groomed!",
                MediaUrl = "https://example.com/media/post5.jpg",
                CreatedAt = DateTime.UtcNow.AddDays(-2),
                UpdatedAt = DateTime.UtcNow
            }
        );
    }
}