using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Photo
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string PhotoPath { get; set; }
    
    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}