using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabFamilia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesFamilia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabFamilia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabProdutos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    des_produto = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    IndAtivo = table.Column<bool>(type: "bit", nullable: false),
                    Familia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tabFamiliaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tabProdutos_TabFamilia_tabFamiliaId",
                        column: x => x.tabFamiliaId,
                        principalTable: "TabFamilia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabProdutos_tabFamiliaId",
                table: "tabProdutos",
                column: "tabFamiliaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabProdutos");

            migrationBuilder.DropTable(
                name: "TabFamilia");
        }
    }
}
