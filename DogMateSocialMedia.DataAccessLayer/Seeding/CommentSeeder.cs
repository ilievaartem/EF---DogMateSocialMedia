using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DogMateSocialMedia.DataAccessLayer.Seeding;

public static class CommentSeeder
    {
        public static void SeedComments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    UserId = 1, 
                    CommentText = "Great photo!",
                    PhotoId = 1, 
                    CreatedAt = DateTime.UtcNow.AddDays(-15),
                    UpdatedAt = DateTime.UtcNow.AddDays(-10)
                },
                new Comment
                {
                    Id = 2,
                    UserId = 2, 
                    CommentText = "Looks amazing!",
                    PhotoId = 2, 
                    CreatedAt = DateTime.UtcNow.AddDays(-12),
                    UpdatedAt = DateTime.UtcNow.AddDays(-8)
                },
                new Comment
                {
                    Id = 3,
                    UserId = 1,
                    CommentText = "So cute!",
                    PhotoId = 2,
                    CreatedAt = DateTime.UtcNow.AddDays(-7),
                    UpdatedAt = DateTime.UtcNow.AddDays(-3)
                },
                new Comment
                {
                    Id = 4,
                    UserId = 2,
                    CommentText = "Nice shot!",
                    PhotoId = 1,
                    CreatedAt = DateTime.UtcNow.AddDays(-5),
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }