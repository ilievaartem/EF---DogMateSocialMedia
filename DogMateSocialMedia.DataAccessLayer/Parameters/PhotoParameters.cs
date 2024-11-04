namespace DogMateSocialMedia.DataAccessLayer.Parameters;

public class PhotoParameters : QueryStringParameters
{
    public int? Id { get; set; }
    public string PhotoPath { get; set; }
    public int? UserId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}