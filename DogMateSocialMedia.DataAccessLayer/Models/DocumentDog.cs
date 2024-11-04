using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class DocumentDog
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Dog")]
    public int DogId { get; set; }
    public Dog Dog { get; set; }

    public string DocumentType { get; set; }

    public string DocumentPhoto { get; set; }

    public bool VerifiedByAI { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}