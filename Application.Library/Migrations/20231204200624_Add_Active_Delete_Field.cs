using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Add_Active_Delete_Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "UserRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "UserRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "UserRoleGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "UserRoleGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "LOG",
                table: "UserLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "LOG",
                table: "UserLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "RPT",
                table: "TransferReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "RPT",
                table: "TransferReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "RPT",
                table: "TransactionReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "RPT",
                table: "TransactionReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "LOG",
                table: "TransactionLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "LOG",
                table: "TransactionLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "GroupUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "GroupUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "SEC",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "SEC",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "CartTransactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "CartTransactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "RPT",
                table: "CartReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "RPT",
                table: "CartReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "LOG",
                table: "CartLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "LOG",
                table: "CartLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "CartHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "CartHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "Blances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "Blances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "LOG",
                table: "BlanceLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "LOG",
                table: "BlanceLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "BUS",
                table: "Banks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "BUS",
                table: "Banks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "RPT",
                table: "BankReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "RPT",
                table: "BankReports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "UserRoleGroups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "UserRoleGroups");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "LOG",
                table: "UserLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "LOG",
                table: "UserLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "RPT",
                table: "TransferReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "RPT",
                table: "TransferReports");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "RPT",
                table: "TransactionReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "RPT",
                table: "TransactionReports");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "LOG",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "LOG",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "GroupUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "GroupUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "SEC",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "SEC",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "CartTransactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "CartTransactions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "RPT",
                table: "CartReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "RPT",
                table: "CartReports");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "LOG",
                table: "CartLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "LOG",
                table: "CartLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "CartHistories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "Blances");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "Blances");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "LOG",
                table: "BlanceLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "LOG",
                table: "BlanceLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "BUS",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "BUS",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "RPT",
                table: "BankReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "RPT",
                table: "BankReports");
        }
    }
}
