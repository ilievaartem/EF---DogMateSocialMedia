namespace DogMateSocialMedia.BusinessLogicLayer.DTO.Request;

public class PhotoDTO
{
    public int Id { get; set; }
    public string PhotoPath { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}