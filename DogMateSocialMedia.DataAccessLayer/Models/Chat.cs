using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Chat
{
    [Key]
    public int ChatID { get; set; }

    [ForeignKey("Sender")]
    public int SenderID { get; set; }
    public User Sender { get; set; }

    [ForeignKey("Receiver")]
    public int ReceiverID { get; set; }
    public User Receiver { get; set; }

    public string MessageText { get; set; }

    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}