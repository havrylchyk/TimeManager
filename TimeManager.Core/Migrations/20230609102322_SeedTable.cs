using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeManager.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskCategory",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("186551bf-3433-4e4e-b742-f2616c985fdd"), "Дозвілля" },
                    { new Guid("2a390f1d-bc5f-43c0-8721-128a5eb7f698"), "Спорт" },
                    { new Guid("34b9ed71-a155-442e-84eb-0c089833c98a"), "Домашні обов'язки" },
                    { new Guid("bfffda6f-3c8a-42eb-b9f6-2a4a88ba270b"), "Навчання" },
                    { new Guid("f5cb35ee-9d54-4561-9b28-809a7622c8a1"), "Робота" }
                });

            migrationBuilder.InsertData(
                table: "TaskStatus",
                columns: new[] { "Id", "StasusName" },
                values: new object[,]
                {
                    { new Guid("2cb67cd6-dcf3-4735-aa91-b9a9cbaa8b00"), "Виконано" },
                    { new Guid("794dcf3b-0cc4-4a51-96b2-01081e44530c"), "Не розпочато" },
                    { new Guid("9862c6fc-ff7d-4430-96a3-6bb6acddb61d"), "В процесі" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskCategory",
                keyColumn: "Id",
                keyValue: new Guid("186551bf-3433-4e4e-b742-f2616c985fdd"));

            migrationBuilder.DeleteData(
                table: "TaskCategory",
                keyColumn: "Id",
                keyValue: new Guid("2a390f1d-bc5f-43c0-8721-128a5eb7f698"));

            migrationBuilder.DeleteData(
                table: "TaskCategory",
                keyColumn: "Id",
                keyValue: new Guid("34b9ed71-a155-442e-84eb-0c089833c98a"));

            migrationBuilder.DeleteData(
                table: "TaskCategory",
                keyColumn: "Id",
                keyValue: new Guid("bfffda6f-3c8a-42eb-b9f6-2a4a88ba270b"));

            migrationBuilder.DeleteData(
                table: "TaskCategory",
                keyColumn: "Id",
                keyValue: new Guid("f5cb35ee-9d54-4561-9b28-809a7622c8a1"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("2cb67cd6-dcf3-4735-aa91-b9a9cbaa8b00"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("794dcf3b-0cc4-4a51-96b2-01081e44530c"));

            migrationBuilder.DeleteData(
                table: "TaskStatus",
                keyColumn: "Id",
                keyValue: new Guid("9862c6fc-ff7d-4430-96a3-6bb6acddb61d"));
        }
    }
}
