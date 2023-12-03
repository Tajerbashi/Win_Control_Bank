using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Create_Database_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                schema: "BUS",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BankID",
                schema: "BUS",
                table: "Carts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CustomerID",
                schema: "BUS",
                table: "Carts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                schema: "BUS",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "BUS",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Banks",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blances",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    LastCash = table.Column<double>(type: "float", nullable: false),
                    Cash = table.Column<double>(type: "float", nullable: false),
                    CartID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Blances_Carts_ID",
                        column: x => x.ID,
                        principalSchema: "BUS",
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartHitories",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    CartID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartHitories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartHitories_Carts_ID",
                        column: x => x.ID,
                        principalSchema: "BUS",
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cash = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<byte>(type: "tinyint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CartTransactions",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<long>(type: "bigint", nullable: false),
                    TransactionID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartTransactions_Carts_CartID",
                        column: x => x.CartID,
                        principalSchema: "BUS",
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartTransactions_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalSchema: "BUS",
                        principalTable: "Transactions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_BankID",
                schema: "BUS",
                table: "Carts",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerID",
                schema: "BUS",
                table: "Carts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CartTransactions_CartID",
                schema: "BUS",
                table: "CartTransactions",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartTransactions_TransactionID",
                schema: "BUS",
                table: "CartTransactions",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Banks_BankID",
                schema: "BUS",
                table: "Carts",
                column: "BankID",
                principalSchema: "BUS",
                principalTable: "Banks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Customers_CustomerID",
                schema: "BUS",
                table: "Carts",
                column: "CustomerID",
                principalSchema: "BUS",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Banks_BankID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Customers_CustomerID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "Banks",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "Blances",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "CartHitories",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "CartTransactions",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "Transactions",
                schema: "BUS");

            migrationBuilder.DropIndex(
                name: "IX_Carts_BankID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CustomerID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "BankID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "BUS",
                table: "Carts");
        }
    }
}
