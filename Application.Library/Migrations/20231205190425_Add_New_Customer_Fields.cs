using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_Customer_Fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "BUS",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "BUS",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "BUS",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "BUS",
                table: "Customers");
        }
    }
}
