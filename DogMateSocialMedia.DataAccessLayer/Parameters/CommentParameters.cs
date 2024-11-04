namespace DogMateSocialMedia.DataAccessLayer.Parameters;

public class CommentParameters : QueryStringParameters
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public int? PhotoId { get; set; }
    public string CommentText { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}