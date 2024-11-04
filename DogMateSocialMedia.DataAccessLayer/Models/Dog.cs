using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogMateSocialMedia.DataAccessLayer.Models;

public class Dog
{
    [Key] public int DogID { get; set; }

    [ForeignKey("User")] public int OwnerID { get; set; }
    public User Owner { get; set; }

    [Required, MaxLength(50)] public string Name { get; set; }

    [MaxLength(50)] public string Breed { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; }

    public string Description { get; set; }

    public string ProfilePicture { get; set; }
}