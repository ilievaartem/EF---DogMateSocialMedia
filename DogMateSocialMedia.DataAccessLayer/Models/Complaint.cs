using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Complaint
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public string ComplaintText { get; set; }

    public DateTime? ReadAt { get; set; }

    [Required]
    public string Status { get; set; } = "Pending";

    public string AdminResponse { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}