using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class DocumentDogConfiguration : IEntityTypeConfiguration<DocumentDog>
{
    public void Configure(EntityTypeBuilder<DocumentDog> builder)
    {
        builder.HasKey(dd => dd.Id);
        builder.Property(dd => dd.DocumentType);
        builder.Property(dd => dd.DocumentPhoto);
        builder.Property(dd => dd.VerifiedByAI);
        builder.HasOne(dd => dd.Dog).WithMany().HasForeignKey(dd => dd.DogId);
    }
}