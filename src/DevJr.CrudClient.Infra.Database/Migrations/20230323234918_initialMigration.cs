using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevJr.CrudClient.Infra.Database.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(nullable: false),
                    DtNascimento = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 200, nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
