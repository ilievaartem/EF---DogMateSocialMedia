﻿// <auto-generated />
using System;
using DogMateSocialMedia.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DogMateSocialMedia.DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241102233513_SeedDataMigration")]
    partial class SeedDataMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Chat", b =>
                {
                    b.Property<int>("ChatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChatID"));

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ChatID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentText = "Great photo!",
                            CreatedAt = new DateTime(2024, 10, 18, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4324),
                            PhotoId = 1,
                            UpdatedAt = new DateTime(2024, 10, 23, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4325),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CommentText = "Looks amazing!",
                            CreatedAt = new DateTime(2024, 10, 21, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4330),
                            PhotoId = 2,
                            UpdatedAt = new DateTime(2024, 10, 25, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4331),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CommentText = "So cute!",
                            CreatedAt = new DateTime(2024, 10, 26, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4336),
                            PhotoId = 2,
                            UpdatedAt = new DateTime(2024, 10, 30, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4337),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CommentText = "Nice shot!",
                            CreatedAt = new DateTime(2024, 10, 28, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4341),
                            PhotoId = 1,
                            UpdatedAt = new DateTime(2024, 11, 2, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4342),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Complaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminResponse")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ComplaintText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ReadAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.DocumentDog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DocumentPhoto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("VerifiedByAI")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.ToTable("DocumentDogs");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Dog", b =>
                {
                    b.Property<int>("DogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DogID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("DogID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogID = 1,
                            Age = 3,
                            Breed = "Golden Retriever",
                            Description = "A friendly and playful dog.",
                            Gender = "Male",
                            Name = "Buddy",
                            OwnerID = 1,
                            ProfilePicture = "https://example.com/images/buddy.jpg"
                        },
                        new
                        {
                            DogID = 2,
                            Age = 4,
                            Breed = "Labrador Retriever",
                            Description = "Very affectionate and loves to swim.",
                            Gender = "Female",
                            Name = "Luna",
                            OwnerID = 2,
                            ProfilePicture = "https://example.com/images/luna.jpg"
                        },
                        new
                        {
                            DogID = 3,
                            Age = 5,
                            Breed = "German Shepherd",
                            Description = "Loyal and protective.",
                            Gender = "Male",
                            Name = "Max",
                            OwnerID = 1,
                            ProfilePicture = "https://example.com/images/max.jpg"
                        },
                        new
                        {
                            DogID = 4,
                            Age = 3,
                            Breed = "Poodle",
                            Description = "Very intelligent and easy to train.",
                            Gender = "Male",
                            Name = "Charlie",
                            OwnerID = 2,
                            ProfilePicture = "https://example.com/images/charlie.jpg"
                        });
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DogLiked")
                        .HasColumnType("int");

                    b.Property<int>("DogOwner")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DogLiked");

                    b.HasIndex("DogOwner");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4273),
                            PhotoPath = "https://example.com/john_photo.jpg",
                            UpdatedAt = new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4275),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4282),
                            PhotoPath = "https://example.com/jane_photo.jpg",
                            UpdatedAt = new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4284),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PostID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostID = 1,
                            Content = "Enjoying a day at the park!",
                            CreatedAt = new DateTime(2024, 10, 23, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4222),
                            MediaUrl = "https://example.com/media/post1.jpg",
                            UpdatedAt = new DateTime(2024, 10, 28, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4226),
                            UserID = 1
                        },
                        new
                        {
                            PostID = 2,
                            Content = "Check out my new trick!",
                            CreatedAt = new DateTime(2024, 10, 25, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4228),
                            MediaUrl = "https://example.com/media/post2.mp4",
                            UpdatedAt = new DateTime(2024, 10, 30, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4229),
                            UserID = 2
                        },
                        new
                        {
                            PostID = 3,
                            Content = "Such a beautiful day!",
                            CreatedAt = new DateTime(2024, 10, 27, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4231),
                            MediaUrl = "https://example.com/media/post3.jpg",
                            UpdatedAt = new DateTime(2024, 11, 1, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4232),
                            UserID = 1
                        },
                        new
                        {
                            PostID = 4,
                            Content = "Just got groomed!",
                            CreatedAt = new DateTime(2024, 10, 31, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4234),
                            MediaUrl = "https://example.com/media/post5.jpg",
                            UpdatedAt = new DateTime(2024, 11, 2, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4234),
                            UserID = 2
                        });
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Sex")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users", t =>
                        {
                            t.HasCheckConstraint("CHK_Role", "Role IN ('Owner', 'Professional')");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 30,
                            CreatedAt = new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3981),
                            Description = "Loves hiking and photography",
                            Email = "johndoe@example.com",
                            IsVerified = true,
                            Name = "John",
                            Nickname = "jdoe",
                            Role = "Owner",
                            Sex = false,
                            Surname = "Doe",
                            UpdatedAt = new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3989)
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            CreatedAt = new DateTime(2024, 5, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3998),
                            Description = "Dog lover and baker",
                            Email = "janesmith@example.com",
                            IsVerified = false,
                            Name = "Jane",
                            Nickname = "jsmith",
                            Role = "Professional",
                            Sex = true,
                            Surname = "Smith",
                            UpdatedAt = new DateTime(2024, 10, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4000)
                        });
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Chat", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Comment", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Complaint", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "User")
                        .WithMany("Complaints")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.DocumentDog", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.Dog", "Dog")
                        .WithMany()
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Dog", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "Owner")
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Like", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogLiked")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogOwner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Photo", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.Post", b =>
                {
                    b.HasOne("DogMateSocialMedia.DataAccessLayer.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DogMateSocialMedia.DataAccessLayer.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Complaints");

                    b.Navigation("Dogs");

                    b.Navigation("Photos");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
