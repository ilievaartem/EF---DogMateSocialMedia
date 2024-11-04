namespace DogMateSocialMedia.BusinessLogicLayer.DTO.Request;

public class PostDTO
{
    public int PostID { get; set; }
    public int UserID { get; set; }
    public string Content { get; set; }
    public string MediaUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}