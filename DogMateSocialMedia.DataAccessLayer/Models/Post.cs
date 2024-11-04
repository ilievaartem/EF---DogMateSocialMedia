using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Post
{
    [Key]
    public int PostID { get; set; }

    [ForeignKey("User")]
    public int UserID { get; set; }
    public User User { get; set; }

    public string Content { get; set; }

    public string MediaUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
