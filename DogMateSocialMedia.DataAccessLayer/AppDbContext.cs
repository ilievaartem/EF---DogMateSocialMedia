using DogMateSocialMedia.DataAccessLayer.EntityConfig;
using DogMateSocialMedia.DataAccessLayer.Models;
using DogMateSocialMedia.DataAccessLayer.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DogMateSocialMedia.DataAccessLayer;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Complaint> Complaints { get; set; }
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<DocumentDog> DocumentDogs { get; set; }
    public DbSet<Like> Likes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new PhotoConfiguration());
        modelBuilder.ApplyConfiguration(new ComplaintConfiguration());
        modelBuilder.ApplyConfiguration(new DogConfiguration());
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new ChatConfiguration());
        modelBuilder.ApplyConfiguration(new DocumentDogConfiguration());
        modelBuilder.ApplyConfiguration(new LikeConfiguration());
        
        UserSeeder.SeedUsers(modelBuilder);
        PostSeeder.SeedPosts(modelBuilder);
        PhotoSeeder.SeedPhotos(modelBuilder);
        CommentSeeder.SeedComments(modelBuilder);
        DogSeeder.SeedDogs(modelBuilder);
    }
}