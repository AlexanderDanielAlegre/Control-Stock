using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sofas.Domain.Migrations
{
    public partial class persona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_instrumentos",
                table: "instrumentos");

            migrationBuilder.RenameTable(
                name: "instrumentos",
                newName: "Instrumentos");

            migrationBuilder.AlterColumn<string>(
                name: "Consumibles",
                table: "Instrumentos",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrumentos",
                table: "Instrumentos",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrumentos",
                table: "Instrumentos");

            migrationBuilder.RenameTable(
                name: "Instrumentos",
                newName: "instrumentos");

            migrationBuilder.AlterColumn<string>(
                name: "Consumibles",
                table: "instrumentos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_instrumentos",
                table: "instrumentos",
                column: "id");
        }
    }
}
