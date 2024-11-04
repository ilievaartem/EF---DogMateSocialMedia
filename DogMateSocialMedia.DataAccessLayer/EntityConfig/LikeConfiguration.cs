using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class LikeConfiguration : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasKey(l => l.Id);
        builder.HasOne<Dog>().WithMany().HasForeignKey(l => l.DogOwner);
        builder.HasOne<Dog>().WithMany().HasForeignKey(l => l.DogLiked);
    }
}
