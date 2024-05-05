using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabProdutos_tabFamilia_tabFamiliaId",
                table: "tabProdutos");

            migrationBuilder.RenameColumn(
                name: "tabFamiliaId",
                table: "tabProdutos",
                newName: "IdFamilia");

            migrationBuilder.RenameIndex(
                name: "IX_tabProdutos_tabFamiliaId",
                table: "tabProdutos",
                newName: "IX_tabProdutos_IdFamilia");

            migrationBuilder.AddForeignKey(
                name: "FK_tabProdutos_tabFamilia_IdFamilia",
                table: "tabProdutos",
                column: "IdFamilia",
                principalTable: "tabFamilia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabProdutos_tabFamilia_IdFamilia",
                table: "tabProdutos");

            migrationBuilder.RenameColumn(
                name: "IdFamilia",
                table: "tabProdutos",
                newName: "tabFamiliaId");

            migrationBuilder.RenameIndex(
                name: "IX_tabProdutos_IdFamilia",
                table: "tabProdutos",
                newName: "IX_tabProdutos_tabFamiliaId");

            migrationBuilder.AddForeignKey(
                name: "FK_tabProdutos_tabFamilia_tabFamiliaId",
                table: "tabProdutos",
                column: "tabFamiliaId",
                principalTable: "tabFamilia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
