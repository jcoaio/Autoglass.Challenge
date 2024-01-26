using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Autoglass.Challenge.Infra.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Situacao = table.Column<int>(type: "INTEGER", maxLength: 10, nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataValidade = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IdFornecedor = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Descricao" },
                values: new object[] { 1, "12.983.451/0001-01", "Fornecedor_01" });

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Descricao" },
                values: new object[] { 2, "12.983.452/0001-01", "Fornecedor_02" });

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Descricao" },
                values: new object[] { 3, "12.983.453/0001-01", "Fornecedor_03" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataFabricacao", "DataValidade", "Descricao", "IdFornecedor", "Situacao" },
                values: new object[] { 1, new DateTime(2023, 1, 29, 15, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Vidro", 1, 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataFabricacao", "DataValidade", "Descricao", "IdFornecedor", "Situacao" },
                values: new object[] { 2, new DateTime(2022, 11, 18, 9, 55, 18, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Retrovisor", 1, 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataFabricacao", "DataValidade", "Descricao", "IdFornecedor", "Situacao" },
                values: new object[] { 3, new DateTime(2019, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified), "Pelicula", 2, 1 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataFabricacao", "DataValidade", "Descricao", "IdFornecedor", "Situacao" },
                values: new object[] { 4, new DateTime(2022, 12, 13, 12, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), "Lanterna", 3, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_DataFabricacao",
                table: "Produto",
                column: "DataFabricacao");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdFornecedor",
                table: "Produto",
                column: "IdFornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
