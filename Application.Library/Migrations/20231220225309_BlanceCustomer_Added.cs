using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class BlanceCustomer_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlanceCustomers",
                schema: "BUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlanceCash = table.Column<double>(type: "float", nullable: false),
                    FromCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    ToCustomerID = table.Column<long>(type: "bigint", nullable: false),
                    FromCartID = table.Column<long>(type: "bigint", nullable: false),
                    ToCartID = table.Column<long>(type: "bigint", nullable: false),
                    BlanceID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlanceCustomers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlanceCustomers_Blances_BlanceID",
                        column: x => x.BlanceID,
                        principalSchema: "BUS",
                        principalTable: "Blances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReports",
                schema: "RPT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerReports_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalSchema: "BUS",
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlanceCustomers_BlanceID",
                schema: "BUS",
                table: "BlanceCustomers",
                column: "BlanceID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReports_CustomerID",
                schema: "RPT",
                table: "CustomerReports",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlanceCustomers",
                schema: "BUS");

            migrationBuilder.DropTable(
                name: "CustomerReports",
                schema: "RPT");
        }
    }
}
