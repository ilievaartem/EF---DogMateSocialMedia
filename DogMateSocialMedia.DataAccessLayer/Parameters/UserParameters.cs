namespace DogMateSocialMedia.DataAccessLayer.Parameters;

public class UserParameters : QueryStringParameters
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int? Age { get; set; }
    public string Nickname { get; set; }
    public string Email { get; set; }
    public bool? Sex { get; set; }
    public string Description { get; set; }
    public string Role { get; set; }
    public bool? IsVerified { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}