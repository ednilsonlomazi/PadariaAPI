using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabFamilia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesFamilia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabFamilia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_produto = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    IndAtivo = table.Column<bool>(type: "bit", nullable: false),
                    tabFamiliaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tabProdutos_tabFamilia_tabFamiliaId",
                        column: x => x.tabFamiliaId,
                        principalTable: "tabFamilia",
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
                name: "tabFamilia");
        }
    }
}
