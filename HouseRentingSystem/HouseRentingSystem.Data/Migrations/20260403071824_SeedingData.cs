using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HouseRentingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentID",
                table: "Houses");

            migrationBuilder.RenameColumn(
                name: "AgentID",
                table: "Houses",
                newName: "AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_AgentID",
                table: "Houses",
                newName: "IX_Houses_AgentId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AgentId", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "IsDeleted", "LastUpdatedOn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8d21ec7b-02c3-4bcc-814a-4ab544c0d8ef"), 0, new Guid("98368384-9b86-41ff-a670-b19ab1575cb3"), "d0053384-49bf-4c3b-9e1d-ffb0dc08fd06", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "gosho@gmail.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "GOSHO@GMAIL.COM", "GOSHO@GMAIL.COM", "AQAAAAIAAYagAAAAEBqYIxe0xbvF1ODDP7S3Tk4YOBweuuntjsXCQ78Ga7Shmp0F1Yd0akcVLeWAyy7d7w==", "+3599999999", false, null, false, "gosho@gmail.com" },
                    { new Guid("b626221c-e7f0-4199-996b-aad91bfeaab5"), 0, null, "daebd3f4-59d0-449a-b15a-1fd32f338691", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "dancho@gmail.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "DANCHO@GMAIL.COM", "DANCHO@GMAIL.COM", "AQAAAAIAAYagAAAAEFRY5aRUrrapQxDVjN9ZQ4YBOVC7+RCk1UH6YWeoKhi6YfcyG47euXpKYdpHE7EbMA==", "+3598888888", false, null, false, "dancho@gmail.com" },
                    { new Guid("ed87af79-41ec-4561-9ce0-9495b5c4db5b"), 0, new Guid("fe77418f-6257-417b-a43f-5424ce10b2f8"), "1eec17a1-6ad4-4e7e-afe7-00db019d2671", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "pesho@gmail.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "PESHO@GMAIL.COM", "PESHO@GMAIL.COM", "AQAAAAIAAYagAAAAEAo8tI+wgvH4jInOg+ZCmKZpWjAY4s6VbnTh8NSfttD15Ng0JC2qgF1yZtRJegSXKQ==", "+3597777777", false, null, false, "pesho@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "LastUpdatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("127755ae-176a-463d-aabe-33a6501a365b"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Single" },
                    { new Guid("1edf5fd7-7901-43d0-bc29-420eedabdf36"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cottage" },
                    { new Guid("b57562fc-0556-43ff-b8d4-e7521023ff05"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duplex" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "CreatedOn", "IsDeleted", "LastUpdatedOn", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("98368384-9b86-41ff-a670-b19ab1575cb3"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+359999999999", new Guid("8d21ec7b-02c3-4bcc-814a-4ab544c0d8ef") },
                    { new Guid("fe77418f-6257-417b-a43f-5424ce10b2f8"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+359888888888", new Guid("ed87af79-41ec-4561-9ce0-9495b5c4db5b") }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "LastUpdatedOn", "PricePerMonth", "RenterId", "Title" },
                values: new object[,]
                {
                    { new Guid("690d7645-17e1-4fc8-84e3-57f2037e1307"), "Mladost 3, Sofia", new Guid("98368384-9b86-41ff-a670-b19ab1575cb3"), new Guid("b57562fc-0556-43ff-b8d4-e7521023ff05"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qko", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKpvCqGI4-FgKWCPAxdF_RW3t7fvfoJksAww&s", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9400.00m, null, "House 3" },
                    { new Guid("84e01585-7a09-45fd-8ae7-b520faac6340"), "123 Main Street, Cityville", new Guid("fe77418f-6257-417b-a43f-5424ce10b2f8"), new Guid("1edf5fd7-7901-43d0-bc29-420eedabdf36"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy apartment located in the heart of the city. Close to shops and public transportation.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGS-nS14Fm9zhEQegRDRIkYUlhivdaJDNUeg&s", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.00m, null, "Cozy Apartment in the City Center" },
                    { new Guid("ffdfd546-d7fc-4739-b7a2-40e779b1f676"), "123 Apple Street, Cityville", new Guid("fe77418f-6257-417b-a43f-5424ce10b2f8"), new Guid("127755ae-176a-463d-aabe-33a6501a365b"), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Close to shops and public transportation.", "https://t4.ftcdn.net/jpg/00/00/64/91/360_F_649185_MwxGCma1gdvNStLmi1pGLnEg7QrJkC.jpg", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3400.00m, null, "House Example" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b626221c-e7f0-4199-996b-aad91bfeaab5"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("690d7645-17e1-4fc8-84e3-57f2037e1307"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("84e01585-7a09-45fd-8ae7-b520faac6340"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("ffdfd546-d7fc-4739-b7a2-40e779b1f676"));

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: new Guid("98368384-9b86-41ff-a670-b19ab1575cb3"));

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: new Guid("fe77418f-6257-417b-a43f-5424ce10b2f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("127755ae-176a-463d-aabe-33a6501a365b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1edf5fd7-7901-43d0-bc29-420eedabdf36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b57562fc-0556-43ff-b8d4-e7521023ff05"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d21ec7b-02c3-4bcc-814a-4ab544c0d8ef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed87af79-41ec-4561-9ce0-9495b5c4db5b"));

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "Houses",
                newName: "AgentID");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_AgentId",
                table: "Houses",
                newName: "IX_Houses_AgentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentID",
                table: "Houses",
                column: "AgentID",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
