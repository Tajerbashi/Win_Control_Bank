using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_Tables_Configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                schema: "LOG",
                table: "UserLogs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TransactionID",
                schema: "RPT",
                table: "TransactionReports",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TransactionID",
                schema: "LOG",
                table: "TransactionLogs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CartID",
                schema: "RPT",
                table: "CartReports",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CartID",
                schema: "LOG",
                table: "CartLogs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BlanceID",
                schema: "LOG",
                table: "BlanceLogs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BankID",
                schema: "RPT",
                table: "BankReports",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_UserID",
                schema: "LOG",
                table: "UserLogs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionReports_TransactionID",
                schema: "RPT",
                table: "TransactionReports",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransactionID",
                schema: "LOG",
                table: "TransactionLogs",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_CartReports_CartID",
                schema: "RPT",
                table: "CartReports",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartLogs_CartID",
                schema: "LOG",
                table: "CartLogs",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_BlanceLogs_BlanceID",
                schema: "LOG",
                table: "BlanceLogs",
                column: "BlanceID");

            migrationBuilder.CreateIndex(
                name: "IX_BankReports_BankID",
                schema: "RPT",
                table: "BankReports",
                column: "BankID");

            migrationBuilder.AddForeignKey(
                name: "FK_BankReports_Banks_BankID",
                schema: "RPT",
                table: "BankReports",
                column: "BankID",
                principalSchema: "BUS",
                principalTable: "Banks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlanceLogs_Blances_BlanceID",
                schema: "LOG",
                table: "BlanceLogs",
                column: "BlanceID",
                principalSchema: "BUS",
                principalTable: "Blances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLogs_Carts_CartID",
                schema: "LOG",
                table: "CartLogs",
                column: "CartID",
                principalSchema: "BUS",
                principalTable: "Carts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartReports_Carts_CartID",
                schema: "RPT",
                table: "CartReports",
                column: "CartID",
                principalSchema: "BUS",
                principalTable: "Carts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLogs_Transactions_TransactionID",
                schema: "LOG",
                table: "TransactionLogs",
                column: "TransactionID",
                principalSchema: "BUS",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionReports_Transactions_TransactionID",
                schema: "RPT",
                table: "TransactionReports",
                column: "TransactionID",
                principalSchema: "BUS",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogs_Users_UserID",
                schema: "LOG",
                table: "UserLogs",
                column: "UserID",
                principalSchema: "SEC",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankReports_Banks_BankID",
                schema: "RPT",
                table: "BankReports");

            migrationBuilder.DropForeignKey(
                name: "FK_BlanceLogs_Blances_BlanceID",
                schema: "LOG",
                table: "BlanceLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLogs_Carts_CartID",
                schema: "LOG",
                table: "CartLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CartReports_Carts_CartID",
                schema: "RPT",
                table: "CartReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLogs_Transactions_TransactionID",
                schema: "LOG",
                table: "TransactionLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionReports_Transactions_TransactionID",
                schema: "RPT",
                table: "TransactionReports");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogs_Users_UserID",
                schema: "LOG",
                table: "UserLogs");

            migrationBuilder.DropIndex(
                name: "IX_UserLogs_UserID",
                schema: "LOG",
                table: "UserLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionReports_TransactionID",
                schema: "RPT",
                table: "TransactionReports");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransactionID",
                schema: "LOG",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_CartReports_CartID",
                schema: "RPT",
                table: "CartReports");

            migrationBuilder.DropIndex(
                name: "IX_CartLogs_CartID",
                schema: "LOG",
                table: "CartLogs");

            migrationBuilder.DropIndex(
                name: "IX_BlanceLogs_BlanceID",
                schema: "LOG",
                table: "BlanceLogs");

            migrationBuilder.DropIndex(
                name: "IX_BankReports_BankID",
                schema: "RPT",
                table: "BankReports");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "LOG",
                table: "UserLogs");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                schema: "RPT",
                table: "TransactionReports");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                schema: "LOG",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "CartID",
                schema: "RPT",
                table: "CartReports");

            migrationBuilder.DropColumn(
                name: "CartID",
                schema: "LOG",
                table: "CartLogs");

            migrationBuilder.DropColumn(
                name: "BlanceID",
                schema: "LOG",
                table: "BlanceLogs");

            migrationBuilder.DropColumn(
                name: "BankID",
                schema: "RPT",
                table: "BankReports");
        }
    }
}
