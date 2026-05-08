using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSecurityStampToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d21ec7b-02c3-4bcc-814a-4ab544c0d8ef"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEL+uHWj/rCSmM+ZUa5mcjQj2ItLXQH6MdQjjp9MM78tl9m29GHtTJwQqXP8A/vLJWQ==", "adb0a92f-b369-49ec-8a23-0393419a72f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b626221c-e7f0-4199-996b-aad91bfeaab5"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEJ87ROXq+dR6kGi/NEiX2zTmQ75GX/ju9p6yVC1ptIjAYQjGA+U4oY2G0qWLrkEptQ==", "0ea86036-cbd3-49cb-a2f0-434fd53267be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed87af79-41ec-4561-9ce0-9495b5c4db5b"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEG9hkI8EsexgRu2bqFnhYFS2cSR355m/WZOPLpLf9ZSxZzLFd/uRtXMCUpytcGreFA==", "53b5d705-d41f-4a9a-8f22-10c4a67b160b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d21ec7b-02c3-4bcc-814a-4ab544c0d8ef"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEBqYIxe0xbvF1ODDP7S3Tk4YOBweuuntjsXCQ78Ga7Shmp0F1Yd0akcVLeWAyy7d7w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b626221c-e7f0-4199-996b-aad91bfeaab5"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEFRY5aRUrrapQxDVjN9ZQ4YBOVC7+RCk1UH6YWeoKhi6YfcyG47euXpKYdpHE7EbMA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed87af79-41ec-4561-9ce0-9495b5c4db5b"),
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAEAo8tI+wgvH4jInOg+ZCmKZpWjAY4s6VbnTh8NSfttD15Ng0JC2qgF1yZtRJegSXKQ==", null });
        }
    }
}
