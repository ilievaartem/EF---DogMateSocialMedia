using DogMateSocialMedia.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogMateSocialMedia.DataAccessLayer.EntityConfig;

public class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder.HasKey(c => c.ChatID);
        builder.Property(c => c.MessageText);
        builder.HasOne(c => c.Sender).WithMany().HasForeignKey(c => c.SenderID);
        builder.HasOne(c => c.Receiver).WithMany().HasForeignKey(c => c.ReceiverID);
    }
}