using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogMateSocialMedia.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "Description", "Email", "IsVerified", "Name", "Nickname", "Role", "Sex", "Surname", "UpdatedAt" },
                values: new object[] { 1, 30, new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3981), "Loves hiking and photography", "johndoe@example.com", true, "John", "jdoe", "Owner", false, "Doe", new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "Description", "Email", "Name", "Nickname", "Role", "Sex", "Surname", "UpdatedAt" },
                values: new object[] { 2, 25, new DateTime(2024, 5, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(3998), "Dog lover and baker", "janesmith@example.com", "Jane", "jsmith", "Professional", true, "Smith", new DateTime(2024, 10, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogID", "Age", "Breed", "Description", "Gender", "Name", "OwnerID", "ProfilePicture" },
                values: new object[,]
                {
                    { 1, 3, "Golden Retriever", "A friendly and playful dog.", "Male", "Buddy", 1, "https://example.com/images/buddy.jpg" },
                    { 2, 4, "Labrador Retriever", "Very affectionate and loves to swim.", "Female", "Luna", 2, "https://example.com/images/luna.jpg" },
                    { 3, 5, "German Shepherd", "Loyal and protective.", "Male", "Max", 1, "https://example.com/images/max.jpg" },
                    { 4, 3, "Poodle", "Very intelligent and easy to train.", "Male", "Charlie", 2, "https://example.com/images/charlie.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "PhotoPath", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4273), "https://example.com/john_photo.jpg", new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4275), 1 },
                    { 2, new DateTime(2024, 8, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4282), "https://example.com/jane_photo.jpg", new DateTime(2024, 9, 3, 1, 35, 12, 984, DateTimeKind.Local).AddTicks(4284), 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostID", "Content", "CreatedAt", "MediaUrl", "UpdatedAt", "UserID" },
                values: new object[,]
                {
                    { 1, "Enjoying a day at the park!", new DateTime(2024, 10, 23, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4222), "https://example.com/media/post1.jpg", new DateTime(2024, 10, 28, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4226), 1 },
                    { 2, "Check out my new trick!", new DateTime(2024, 10, 25, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4228), "https://example.com/media/post2.mp4", new DateTime(2024, 10, 30, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4229), 2 },
                    { 3, "Such a beautiful day!", new DateTime(2024, 10, 27, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4231), "https://example.com/media/post3.jpg", new DateTime(2024, 11, 1, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4232), 1 },
                    { 4, "Just got groomed!", new DateTime(2024, 10, 31, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4234), "https://example.com/media/post5.jpg", new DateTime(2024, 11, 2, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4234), 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedAt", "PhotoId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Great photo!", new DateTime(2024, 10, 18, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4324), 1, new DateTime(2024, 10, 23, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4325), 1 },
                    { 2, "Looks amazing!", new DateTime(2024, 10, 21, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4330), 2, new DateTime(2024, 10, 25, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4331), 2 },
                    { 3, "So cute!", new DateTime(2024, 10, 26, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4336), 2, new DateTime(2024, 10, 30, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4337), 1 },
                    { 4, "Nice shot!", new DateTime(2024, 10, 28, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4341), 1, new DateTime(2024, 11, 2, 23, 35, 12, 984, DateTimeKind.Utc).AddTicks(4342), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
