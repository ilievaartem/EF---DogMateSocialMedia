using System.ComponentModel.DataAnnotations;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class User
{
    [Key] 
    public int Id { get; set; }

    [Required, MaxLength(50)] 
    public string Name { get; set; }

    [Required, MaxLength(50)] 
    public string Surname { get; set; }

    public int Age { get; set; }

    [Required, MaxLength(50)] 
    public string Nickname { get; set; }

    [Required, MaxLength(100)] 
    public string Email { get; set; }

    [Required] 
    public bool Sex { get; set; }

    [MaxLength(255)] 
    public string Description { get; set; }

    [Required, MaxLength(20)] 
    public string Role { get; set; }

    public bool IsVerified { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
    public ICollection<Dog> Dogs { get; set; } = new List<Dog>();
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}
