using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabProdutos_tabFamilia_IdFamilia",
                table: "tabProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tabProdutos",
                table: "tabProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tabFamilia",
                table: "tabFamilia");

            migrationBuilder.RenameTable(
                name: "tabProdutos",
                newName: "TabProdutos");

            migrationBuilder.RenameTable(
                name: "tabFamilia",
                newName: "TabFamilia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TabProdutos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IndAtivo",
                table: "TabProdutos",
                newName: "ind_ativo");

            migrationBuilder.RenameColumn(
                name: "IdFamilia",
                table: "TabProdutos",
                newName: "id_familia");

            migrationBuilder.RenameIndex(
                name: "IX_tabProdutos_IdFamilia",
                table: "TabProdutos",
                newName: "IX_TabProdutos_id_familia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TabFamilia",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IndAtivo",
                table: "TabFamilia",
                newName: "ind_ativo");

            migrationBuilder.RenameColumn(
                name: "DesFamilia",
                table: "TabFamilia",
                newName: "des_familia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TabProdutos",
                table: "TabProdutos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TabFamilia",
                table: "TabFamilia",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TabProdutos_TabFamilia_id_familia",
                table: "TabProdutos",
                column: "id_familia",
                principalTable: "TabFamilia",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabProdutos_TabFamilia_id_familia",
                table: "TabProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TabProdutos",
                table: "TabProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TabFamilia",
                table: "TabFamilia");

            migrationBuilder.RenameTable(
                name: "TabProdutos",
                newName: "tabProdutos");

            migrationBuilder.RenameTable(
                name: "TabFamilia",
                newName: "tabFamilia");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tabProdutos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ind_ativo",
                table: "tabProdutos",
                newName: "IndAtivo");

            migrationBuilder.RenameColumn(
                name: "id_familia",
                table: "tabProdutos",
                newName: "IdFamilia");

            migrationBuilder.RenameIndex(
                name: "IX_TabProdutos_id_familia",
                table: "tabProdutos",
                newName: "IX_tabProdutos_IdFamilia");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tabFamilia",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ind_ativo",
                table: "tabFamilia",
                newName: "IndAtivo");

            migrationBuilder.RenameColumn(
                name: "des_familia",
                table: "tabFamilia",
                newName: "DesFamilia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tabProdutos",
                table: "tabProdutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tabFamilia",
                table: "tabFamilia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tabProdutos_tabFamilia_IdFamilia",
                table: "tabProdutos",
                column: "IdFamilia",
                principalTable: "tabFamilia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
