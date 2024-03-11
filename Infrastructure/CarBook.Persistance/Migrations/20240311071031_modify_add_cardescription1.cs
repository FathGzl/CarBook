using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class modify_add_cardescription1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions");

            migrationBuilder.RenameTable(
                name: "CarDescriptions",
                newName: "CarDescription");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescription",
                newName: "IX_CarDescription_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription",
                column: "CarDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescription_Cars_CarID",
                table: "CarDescription",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescription_Cars_CarID",
                table: "CarDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription");

            migrationBuilder.RenameTable(
                name: "CarDescription",
                newName: "CarDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescription_CarID",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions",
                column: "CarDescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
