using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(3570), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(3587), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(3592), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(3593), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4099), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4101), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4104), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4106), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4347), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4352), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4355), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4356), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4360), new DateTime(2025, 11, 28, 12, 6, 9, 101, DateTimeKind.Local).AddTicks(4361), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");
        }
    }
}
