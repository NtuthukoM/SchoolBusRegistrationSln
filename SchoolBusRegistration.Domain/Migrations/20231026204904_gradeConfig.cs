using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolBusRegistration.Domain.Migrations
{
    /// <inheritdoc />
    public partial class gradeConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 26, 22, 49, 4, 562, DateTimeKind.Local).AddTicks(1308), "Grade 8" },
                    { 2, new DateTime(2023, 10, 26, 22, 49, 4, 562, DateTimeKind.Local).AddTicks(1319), "Grade 9" },
                    { 3, new DateTime(2023, 10, 26, 22, 49, 4, 562, DateTimeKind.Local).AddTicks(1320), "Grade 10" },
                    { 4, new DateTime(2023, 10, 26, 22, 49, 4, 562, DateTimeKind.Local).AddTicks(1320), "Grade 11" },
                    { 5, new DateTime(2023, 10, 26, 22, 49, 4, 562, DateTimeKind.Local).AddTicks(1321), "Grade 12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
