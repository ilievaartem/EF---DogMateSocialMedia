namespace DogMateSocialMedia.DataAccessLayer.Parameters;

public class PostParameters : QueryStringParameters
{
    public int? PostID { get; set; }
    public int? UserId { get; set; }
    public string MediaUrl { get; set; }
    public string Content { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}