using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "216853ca-4aa8-44a3-9b5b-a4ab1b886bd2", null, "Administrator", "ADMINISTRATOR" },
                    { "74515f0b-e58e-44d4-9598-89cf89ed4ea3", null, "Supervisor", "SUPERVISOR" },
                    { "f11f57da-859a-43a1-a367-dcec54450636", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "74515f0b-e58e-44d4-9598-89cf89ed4ea3", 0, "07b4a508-197a-4ba2-9241-1694b062dd53", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECY1AVOr+4pv1PJY9fxGcaX3wJoPkkIBAgzV5rD1E2UXQJxctv8wsnjwrIiyUiPdsg==", null, false, "faab7829-1474-4946-be9a-1099726b1d2c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "216853ca-4aa8-44a3-9b5b-a4ab1b886bd2", "74515f0b-e58e-44d4-9598-89cf89ed4ea3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74515f0b-e58e-44d4-9598-89cf89ed4ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f11f57da-859a-43a1-a367-dcec54450636");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "216853ca-4aa8-44a3-9b5b-a4ab1b886bd2", "74515f0b-e58e-44d4-9598-89cf89ed4ea3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "216853ca-4aa8-44a3-9b5b-a4ab1b886bd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74515f0b-e58e-44d4-9598-89cf89ed4ea3");
        }
    }
}
