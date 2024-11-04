using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
        
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public string CommentText { get; set; }

    public int? PhotoId { get; set; }
        
    [ForeignKey("PhotoId")]
    public Photo Photo { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}