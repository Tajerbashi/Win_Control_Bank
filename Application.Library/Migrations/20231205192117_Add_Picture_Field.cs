using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Add_Picture_Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                schema: "SEC",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                schema: "BUS",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                schema: "BUS",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                schema: "SEC",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Picture",
                schema: "BUS",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Picture",
                schema: "BUS",
                table: "Carts");
        }
    }
}
