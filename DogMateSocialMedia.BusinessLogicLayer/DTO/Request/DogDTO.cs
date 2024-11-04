namespace DogMateSocialMedia.BusinessLogicLayer.DTO.Request;

public class DogDTO
{
    public int DogID { get; set; }
    public int OwnerID { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    public string ProfilePicture { get; set; }
}