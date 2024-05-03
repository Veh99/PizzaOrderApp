using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaOrderApp.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Pizzas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Pizzas",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
