using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabPessoa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ind_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabPessoa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TabLogin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_pessoa = table.Column<int>(type: "int", nullable: false),
                    ind_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabLogin", x => x.id);
                    table.ForeignKey(
                        name: "FK_TabLogin_TabPessoa_id_pessoa",
                        column: x => x.id_pessoa,
                        principalTable: "TabPessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabLogradouro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_logradouro = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ind_ativo = table.Column<bool>(type: "bit", nullable: false),
                    id_pessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabLogradouro", x => x.id);
                    table.ForeignKey(
                        name: "FK_TabLogradouro_TabPessoa_id_pessoa",
                        column: x => x.id_pessoa,
                        principalTable: "TabPessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabLogin_id_pessoa",
                table: "TabLogin",
                column: "id_pessoa");

            migrationBuilder.CreateIndex(
                name: "IX_TabLogradouro_id_pessoa",
                table: "TabLogradouro",
                column: "id_pessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabLogin");

            migrationBuilder.DropTable(
                name: "TabLogradouro");

            migrationBuilder.DropTable(
                name: "TabPessoa");
        }
    }
}
