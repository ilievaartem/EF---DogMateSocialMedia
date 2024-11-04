using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Surname).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Age);
        builder.Property(e => e.Nickname).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Sex).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(255);
        builder.Property(e => e.Role).HasMaxLength(20).IsRequired();
        builder.Property(e => e.IsVerified).HasDefaultValue(false);
        builder.Property(e => e.CreatedAt);
        builder.Property(e => e.UpdatedAt);
        builder.ToTable(b => 
            b.HasCheckConstraint("CHK_Role", "Role IN ('Owner', 'Professional')")
        );

        // builder.HasData(
        //     new User
        //     {
        //         Id = 1,
        //         Name = "John",
        //         Surname = "Doe",
        //         Nickname = "johndoe",
        //         Age = 30,
        //         Email = "john.doe@example.com",
        //         Sex = true,
        //         Description = "Sample Description",
        //         Role = "Owner",
        //         IsVerified = false,
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow
        //     },
        //     new User
        //     {
        //         Id = 2,
        //         Name = "Jane",
        //         Surname = "Doe",
        //         Nickname = "janedoe",
        //         Age = 28,
        //         Email = "jane.doe@example.com",
        //         Sex = false,
        //         Description = "Sample Description",
        //         Role = "Professional",
        //         IsVerified = true,
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow
        //     }
        // );
    }
}