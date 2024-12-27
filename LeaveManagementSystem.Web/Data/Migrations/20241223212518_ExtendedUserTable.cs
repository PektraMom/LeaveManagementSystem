using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74515f0b-e58e-44d4-9598-89cf89ed4ea3",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4caa5888-d065-43a7-901f-37681fb48a3e", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEMSXTilujimH28oQa+NU90BWofWSu/GeV1A8EmbWCoSzcZJ9qJAcdPhHKRtEZKIIuw==", "6863a363-56b1-485f-8b08-459cd2cc4db6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74515f0b-e58e-44d4-9598-89cf89ed4ea3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b4a508-197a-4ba2-9241-1694b062dd53", "AQAAAAIAAYagAAAAECY1AVOr+4pv1PJY9fxGcaX3wJoPkkIBAgzV5rD1E2UXQJxctv8wsnjwrIiyUiPdsg==", "faab7829-1474-4946-be9a-1099726b1d2c" });
        }
    }
}
