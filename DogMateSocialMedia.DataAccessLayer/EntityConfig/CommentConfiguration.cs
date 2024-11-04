using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.CommentText).IsRequired();
        builder.Property(e => e.CreatedAt);
        builder.Property(e => e.UpdatedAt);
        
        // builder.HasData(
        //     new Comment
        //     {
        //         Id = 1,
        //         UserId = 2,
        //         CommentText = "cool",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow
        //     },
        //     new Comment
        //     {
        //         Id = 2,
        //         UserId = 1,
        //         CommentText = "not bad",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow
        //     }
        // );
    }
}