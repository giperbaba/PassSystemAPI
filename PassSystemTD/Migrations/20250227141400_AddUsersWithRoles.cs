using Microsoft.EntityFrameworkCore.Migrations;
using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;

#nullable disable

namespace PassSystemTD.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersWithRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                var userId = Guid.NewGuid();

                migrationBuilder.InsertData(
                    table: "Users",
                    columns: new[] { "Id", "Name", "Email", "Password", "Gender" },
                    values: new object[] { userId, $"User{i}", $"user{i}@example.com", BCrypt.Net.BCrypt.HashPassword($"string{i}"), (int)(i % 2 == 0 ? Gender.Male : Gender.Female)});
                migrationBuilder.InsertData(
                    table: "Role",
                    columns: new[] { "Id", "IsAdmin", "IsStudent", "IsTeacher", "IsDean" },
                    values: new object[] { userId, i % 100 == 0, i % 3 == 0, i % 5 == 0, i % 7 == 0 });
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Users");
            migrationBuilder.DropTable(name: "Role");
        }
    }
}