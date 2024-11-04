using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class DogConfiguration : IEntityTypeConfiguration<Dog>
{
    public void Configure(EntityTypeBuilder<Dog> builder)
    {
        builder.HasKey(d => d.DogID);
        builder.Property(d => d.Name).HasMaxLength(50).IsRequired();
        builder.Property(d => d.Breed).HasMaxLength(50);
        builder.Property(d => d.Gender).IsRequired();
        builder.Property(d => d.ProfilePicture).HasMaxLength(255);
        builder.HasOne(d => d.Owner).WithMany(u => u.Dogs).HasForeignKey(d => d.OwnerID).OnDelete(DeleteBehavior.Cascade);
    }
}