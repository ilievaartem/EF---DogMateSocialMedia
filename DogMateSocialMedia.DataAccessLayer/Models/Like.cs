using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Like
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("DogOwner")]
    public int DogOwner { get; set; }

    [ForeignKey("DogLiked")]
    public int DogLiked { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}