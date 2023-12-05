using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_BUS_Fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cash",
                schema: "BUS",
                table: "CartHistories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "BUS",
                table: "CartHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FromCartKey",
                schema: "BUS",
                table: "CartHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsCashable",
                schema: "BUS",
                table: "CartHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                schema: "BUS",
                table: "CartHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "BUS",
                table: "CartHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ToCartKey",
                schema: "BUS",
                table: "CartHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<byte>(
                name: "TransactionType",
                schema: "BUS",
                table: "CartHistories",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cash",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "FromCartKey",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "IsCashable",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "Message",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "ToCartKey",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                schema: "BUS",
                table: "CartHistories");
        }
    }
}
