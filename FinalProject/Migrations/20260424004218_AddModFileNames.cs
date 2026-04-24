    using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddModFileNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompleteMod",
                table: "Mods",
                newName: "FileName");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "oru_rework.txt");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "oru_cleanse_fix.txt");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "xenobia_endlag.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Mods",
                newName: "CompleteMod");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompleteMod",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompleteMod",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Mods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompleteMod",
                value: "Yes");
        }
    }
}
