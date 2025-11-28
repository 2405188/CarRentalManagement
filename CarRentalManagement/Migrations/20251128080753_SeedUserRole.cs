using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0971043c-769f-48fa-bb36-129d476194c6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDQS1x85NEs5QXAFqAhMiurFHuMPzngBlacyuPts/3zQEdwPOgD4pBUBO1fX9AQbAw==", null, false, "574bbada-ff26-4ae4-8f62-fc946359d354", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3201), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3753), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3758), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4012), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4017), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4022), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4027), new DateTime(2025, 11, 28, 16, 7, 51, 446, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(1546), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2056), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2061), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2283), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2288), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2292), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2297), new DateTime(2025, 11, 28, 15, 44, 49, 817, DateTimeKind.Local).AddTicks(2299) });
        }
    }
}
