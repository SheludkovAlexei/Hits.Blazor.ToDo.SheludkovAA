using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 10, 23, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 10, 26, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 11, 24, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 12, 12, 16, 0, 36, 910, DateTimeKind.Local).AddTicks(4308) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 6, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 10, 8, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 6, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 10, 11, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 6, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8912), new DateTime(2024, 11, 9, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2024, 10, 6, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8914), new DateTime(2024, 11, 27, 19, 18, 35, 391, DateTimeKind.Local).AddTicks(8914) });
        }
    }
}
