using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class update_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrice_Books_BookId",
                table: "BookPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPrice_Currency_CurrenciesId",
                table: "BookPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_languageId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_languageId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                table: "Currency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPrice",
                table: "BookPrice");

            migrationBuilder.DropColumn(
                name: "languageId",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Currency",
                newName: "currencies");

            migrationBuilder.RenameTable(
                name: "BookPrice",
                newName: "BookPrices");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrice_CurrenciesId",
                table: "BookPrices",
                newName: "IX_BookPrices_CurrenciesId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrice_BookId",
                table: "BookPrices",
                newName: "IX_BookPrices_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_currencies",
                table: "currencies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPrices",
                table: "BookPrices",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Description", "tittle" },
                values: new object[,]
                {
                    { 1, "Hindi", "Hindi" },
                    { 2, "Odia", "Odia" },
                    { 3, "Telugu", "Telugu" },
                    { 4, "Urdu ", "Urdu" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_currencies_CurrenciesId",
                table: "BookPrices",
                column: "CurrenciesId",
                principalTable: "currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_currencies_CurrenciesId",
                table: "BookPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_currencies",
                table: "currencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPrices",
                table: "BookPrices");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "currencies",
                newName: "Currency");

            migrationBuilder.RenameTable(
                name: "BookPrices",
                newName: "BookPrice");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrices_CurrenciesId",
                table: "BookPrice",
                newName: "IX_BookPrice_CurrenciesId");

            migrationBuilder.RenameIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrice",
                newName: "IX_BookPrice_BookId");

            migrationBuilder.AddColumn<int>(
                name: "languageId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                table: "Currency",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPrice",
                table: "BookPrice",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_languageId",
                table: "Books",
                column: "languageId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrice_Books_BookId",
                table: "BookPrice",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrice_Currency_CurrenciesId",
                table: "BookPrice",
                column: "CurrenciesId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_languageId",
                table: "Books",
                column: "languageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
